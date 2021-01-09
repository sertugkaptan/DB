using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLogin s_screen = new StudentLogin();
            s_screen.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsLogin ins_login = new InsLogin();
            ins_login.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerScreen rs = new registerScreen();
            rs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CoordinatorLogin login_screen = new CoordinatorLogin();
            login_screen.Show();
        }
    }
}
