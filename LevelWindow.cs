using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json.Linq;
using System.IO;

namespace chemaths
{
    public partial class LevelWindow : Form
    {
        int index, countR = 0;
        XmlDocument doc = new XmlDocument();
        XmlNodeList tasks, tasksR;
        XmlNode[] taskArray, taskArrayR;
        public int N_Results1;
        public int N_Results2;
        public string userName;
        string result_choice;

        public void Start()//заповнення масиву рівнянь та масиву результатів
        {
            doc.Load("Levels.xml");
            tasks = doc.SelectNodes($"/root/level[@number='{(int)register_w.level_choice.Value}']/task");
            tasksR = doc.SelectNodes($"/root/level[@number='results{(int)register_w.level_choice.Value}']/task");
            taskArray = tasks.OfType<XmlNode>().ToArray();
            taskArrayR = tasksR.OfType<XmlNode>().ToArray();
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            help_panel.Visible = true;//відображення допоміжних підказок
            //вимкнення відповіді елементів на дії користувача
            input_box.Enabled = output_box.Enabled = help_btn.Enabled = back_btn.Enabled = check_btn.Enabled = false;
        }

        RegisterWindow register_w;

        public LevelWindow(RegisterWindow tmp, string tmp_s)//початок тесту, тасування масиву рівнянь, виведення першого рівняння
        {
            InitializeComponent();
            tool_tip.Active = Program.active_tool_tips;
            register_w = tmp;
            result_choice = tmp_s;

            Start();
            Fisher_Yates(taskArray, taskArrayR);
            output_box.Text = "";
            index = 1;
            output_box.Text = taskArray[0].InnerText;
        }

        private void help_close_btn_Click(object sender, EventArgs e)
        {
            help_panel.Visible = false;//закриття допоміжних підказок
            //увімкнення відповіді елементів на дії користувача
            input_box.Enabled = output_box.Enabled = help_btn.Enabled = back_btn.Enabled = check_btn.Enabled = true;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new RegisterWindow(), sender);//перехід до попереднього вікна
        }

        private void LevelWindow_Load(object sender, EventArgs e)
        {
            label_end.Visible = false;
        }

        private void check_btn_Click_1(object sender, EventArgs e) // перевірка відповіді користувача
        {
            try
            {
                if (index <= taskArray.Length) // якщо тест ще не пройдено
                {
                    if (input_box.Text == "123456")
                    {
                        throw new Exception("empty_mistake");
                    }
                    if (!input_box.Text.All(Char.IsNumber))
                    {
                        throw new Exception("character_mistake");
                    }

                    if (input_box.Text == taskArrayR[index - 1].InnerText) // якщо відповідь правильна
                    {
                        countR++;
                        if (result_choice == "yes")
                        {
                            MessageWindow message = new MessageWindow("Відповідь правильна!", "right");
                            message.ShowDialog(); // показ діалогу, що користувач відповів правильно
                        }
                        output_box.Text = ""; // очищення текстових полів
                        input_box.Text = "";
                    }
                    else // якщо неправильна
                    {
                        if (result_choice == "yes")
                        {
                            MessageWindow message = new MessageWindow("Відповідь неправильна!", taskArrayR[index - 1].InnerText);
                            message.ShowDialog(); // показ діалогу, що користувач відповів правильно
                        }
                        output_box.Text = "";
                        input_box.Text = "";
                    }
                    if (index != taskArray.Length) // якщо не дійшли до кінця
                    {
                        output_box.Text = taskArray[index].InnerText; // виводимо хім. рівняння, що необхідно урівняти
                    }
                    else
                    {
                        output_box.Visible = input_box.Visible = label10.Visible = false;
                        label_end.Visible = true;
                    }
                    index++;
                }
                else
                {
                    N_Results2 = countR;
                    JObject file1 = JObject.Parse(File.ReadAllText("Results.json")); // парсинг файлу з результатами до тесту
                    JObject file2 = new JObject();
                    file2[userName] = countR; // "ім'я": результат
                    file1.Merge(file2, new JsonMergeSettings // злиття об'єктів json 
                    {
                        MergeArrayHandling = MergeArrayHandling.Union
                    });
                    File.WriteAllText(@"Results.json", file1.ToString()); // перезапис файлу з новим результатом
                    GameWindow tmp = new GameWindow(); // повернення до початковго меню
                    tmp.Show();
                    tmp.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
                    this.Hide();
                }

                if (string.IsNullOrWhiteSpace(input_box.Text))
                {
                    input_box.Text = "123456";//виведення допоміжної підказки
                    input_box.Font = new Font(input_box.Font, FontStyle.Italic);//встановлення курсиву
                    input_box.ForeColor = Color.DimGray;//зміна кольору
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "empty_mistake")
                {
                    MistakeWindow mistake_w = new MistakeWindow("Поле відповіді містить лише допоміжну підказку!");
                    mistake_w.ShowDialog();
                }
                if (ex.Message == "character_mistake")
                {
                    MistakeWindow mistake_w = new MistakeWindow("Поле відповіді має містити лише цифри!");
                    mistake_w.ShowDialog();
                }
            }
        }

        private void input_box_Click(object sender, EventArgs e)
        {
            //якщо користувач не вводив нічого в поле та вміст поля дорівнює допоміжній підказці
            if (input_box.Text == "123456")
            {
                input_box.Text = null;//очищення поля
                input_box.Font = new Font(input_box.Font, FontStyle.Regular);//зняття курсиву
                input_box.ForeColor = Color.FromArgb(31, 34, 53);//зміна кольору
            }
        }

        private void input_box_Leave(object sender, EventArgs e)
        {
            //якщо поле порожнє
            if (string.IsNullOrWhiteSpace(input_box.Text))
            {
                input_box.Text = "123456";//виведення допоміжної підказки
                input_box.Font = new Font(input_box.Font, FontStyle.Italic);//встановлення курсиву
                input_box.ForeColor = Color.DimGray;//зміна кольору
            }
        }

        public void Fisher_Yates(XmlNode[] taskArray, XmlNode[] taskArrayR) // алгоритм тасування Фішера-Йетса
        {
            Random rnd = new Random(); 
            for (int i = taskArray.Length - 1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);
                XmlNode temp1 = taskArray[j];
                XmlNode temp2 = taskArrayR[j];
                taskArray[j] = taskArray[i]; taskArrayR[j] = taskArrayR[i];
                taskArray[i] = temp1; taskArrayR[i] = temp2;
            }
        }
        public void OPEN_MENU_POINT(Form point_form, object sender)//функція відкриття форми
        {
            point_form.Show();
            //задання границь попереднього вікна
            point_form.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void close_btn_Click(object sender, EventArgs e)//закриття програми
        {
            Application.Exit();
        }

        private void active_panel_MouseDown(object sender, MouseEventArgs e)
        {
            //функція перетягування безрамкового вікна за допоміжну активну панель
            active_panel.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
    }
}
