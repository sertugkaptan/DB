using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Database 
{
    public partial class InstructorLogin : Form
    {
        public InstructorLogin()
        {
            
            InitializeComponent();
            password_box.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                password_box.UseSystemPasswordChar = true;
            }
            else
            {
               password_box.UseSystemPasswordChar = false;
            }
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            String username = username_box.Text;
            String password = password_box.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `instructor` WHERE `ins_id` = @usn AND `password` = @pass", db.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            db.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                this.Hide();
                InstructorScreen ins_screen = new InstructorScreen();
                ins_screen.Show();
            }
            db.closeConnection();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerScreen register_form = new registerScreen();
            register_form.Show();
        }

        private void main_menu_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen ms = new MainScreen();
            ms.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
