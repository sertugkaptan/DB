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
    public partial class InsScreen : Form
    {
        public InsScreen()
        {
            InitializeComponent();
        }

        public void getForm(Form frm)
        {
            panel2.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frm);
            frm.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            UpdateScreen ais = new UpdateScreen();
            getForm(ais);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen ms = new MainScreen();
            ms.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CourseTaught ct = new CourseTaught();
            getForm(ct);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTakingScreen ats = new AddTakingScreen();
            getForm(ats);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CourseInfoScreen cis = new CourseInfoScreen();
            getForm(cis);
        }
    }
}
