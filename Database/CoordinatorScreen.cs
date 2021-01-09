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
    public partial class CoordinatorScreen : Form
    {
        public CoordinatorScreen()
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
            AddInstructorScreen ais = new AddInstructorScreen();
            getForm(ais);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudentScreen ais = new AddStudentScreen();
            getForm(ais);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCourseScreen ais = new AddCourseScreen();
            getForm(ais);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddAdvisorScreen ais = new AddAdvisorScreen();
            getForm(ais);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddTeachingScreen ais = new AddTeachingScreen();
            getForm(ais);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen ms = new MainScreen();
            ms.Show();
        }
    }
}
