using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chemaths
{
    public abstract class Interface : Form
    {
        public abstract void OPEN_MENU_POINT(Form point_form, object sender);
        public abstract void close_btn_Click(object sender, EventArgs e);
        public abstract void active_panel_MouseDown(object sender, MouseEventArgs e);
    }
}
