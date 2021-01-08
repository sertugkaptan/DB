using MySql.Data.MySqlClient;
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
    public partial class registerScreen : Form
    {
        public registerScreen()
        {
            InitializeComponent();
            password_box.UseSystemPasswordChar = true;
            confirmation_box.UseSystemPasswordChar = true;
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `user`(`sch_id`, `Password`, `Email`, `First_Name`, `Last_Name`) VALUES (@usn, @pass, @email, @fn, @ln)", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = usern_box.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password_box.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email_box.Text;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = first_name_box.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = last_name_box.Text;
        

            db.openConnection();
            if (!checkEmptyFields())
            {
                if (confirmPassword())
                {
                    if(!checkEmail())
                    {
                        if (checkUsername())
                        {
                            MessageBox.Show("Username already exist Please try a different Username", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Account successfully created!","Account", MessageBoxButtons.OK,MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("Unexpected Error has occured","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email already exist Please try a different email", "Duplicate Email", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords are not matching, Please check again","Confirm Password",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all of the empty boxes","Empty Fields",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
           
            db.closeConnection();
                    
        }
        public Boolean checkUsername()
        {
            DB db = new DB();
            String username = usern_box.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `sch_id` = @usn", db.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean checkEmail()
        {
            DB db = new DB();
            String email = email_box.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `Email` = @email", db.getConnection());
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean confirmPassword()
        {
            if (password_box.Text != confirmation_box.Text)
                return false;
            else
                return true;
        }

        public Boolean checkEmptyFields()
        {
            String username = usern_box.Text;
            String password = password_box.Text;
            String email = email_box.Text;
            String fn = first_name_box.Text;
            String ln = last_name_box.Text;

            if (username.Equals("") || password.Equals("") || email.Equals("") || fn.Equals("") || ln.Equals(""))
                return true;
            else
                return false;
                    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CoordinatorLogin login_screen = new CoordinatorLogin();
            login_screen.Show();
        }

    }
}
