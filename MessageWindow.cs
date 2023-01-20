using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chemaths
{
    public partial class MessageWindow : Form
    {
        public MessageWindow(string result, string answer)
        {
            InitializeComponent();
            tool_tip.Active = Interface.active_tool_tips; 

            result_label.Text = result;//виведення результату відповіді
            if(answer == "right")//якщо відповідь корситувача правильна
            {
                answer_label.Visible = false;//приховання тексту правильної відповіді
            }
            else //якщо відповідь корситувача неправильна
            {
                //виведення правильної відповіді
                answer_label.Text = "Правильна відповідь: " + answer;
            }
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.Close();//закриття форми
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
