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
    public partial class StudentScreen : Form
    {
        public StudentScreen()
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
        private void button1_Click(object sender, EventArgs e)
        {
            StudentDetailsScreen STD = new StudentDetailsScreen();
            getForm(STD);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CourseScreen STD = new CourseScreen();
            getForm(STD);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ParticipantsScreen STD = new ParticipantsScreen();
            getForm(STD);
        }
    }
}
