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
    public partial class CourseTaught : Form
    {
        public CourseTaught()
        {
            InitializeComponent();
            ins_id_box.Text = User.usn;
            fillCombo("instructor", name_box, "name");
            fillCombo("instructor", surname_box, "surname");
            fillCombo("instructor", usn_box, "username");
            fillCombo("instructor", pass_box, "password");
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void populate()
        {
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM instructor WHERE ins_id = @ins_id ",db.getConnection());
            adapter.SelectCommand.Parameters.Add("@ins_id", MySqlDbType.VarChar).Value = User.usn;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public Boolean checkUsername()
        {
            DB db = new DB();
            String username = usn_box.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `instructor` WHERE `username` = @usn", db.getConnection());
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

        public Boolean checkEmptyFields()
        {
            String username = usn_box.Text;
            String pass = pass_box.Text;
   

            if(username.Equals("") || pass.Equals(""))
                return true;
            else
                return false;

        }
        public void fillCombo(String table, TextBox tb,String column)
        {
            try
            {
                DB db = new DB();
                string selectQuery = "SELECT * FROM instructor WHERE ins_id = @ins_id";
                db.openConnection();
                MySqlCommand command = new MySqlCommand(selectQuery, db.getConnection());
                command.Parameters.Add("@ins_id", MySqlDbType.VarChar).Value = ins_id_box.Text;
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tb.Text = reader.GetString(column);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields())
            {
                MessageBox.Show("Please fill all of the empty boxes", "Empty Fields", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("UPDATE `instructor` SET `password` = @pass ,`username` = @usn WHERE ins_id = @ins_id", db.getConnection());
            cmd.Parameters.Add("@usn", MySqlDbType.VarChar).Value = usn_box.Text;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass_box.Text;
            cmd.Parameters.Add("@ins_id", MySqlDbType.VarChar).Value = ins_id_box.Text;

            db.openConnection();

            if (!checkEmptyFields())
            {
                if (checkUsername())
                {
                    MessageBox.Show("Username already exist please change it", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    if (cmd.ExecuteNonQuery() ==  1)
                    {
                        MessageBox.Show("Personal details succesfully updated!!!", "Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Unexpected Error has occured", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all of the empty boxes", "Empty Fields", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            populate();
            db.closeConnection();
        }
    }
}
