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
    public partial class AddCorseScreen : Form
    {
        public AddCorseScreen()
        {
            InitializeComponent();
            populate();
            fillCombo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void populate()
        {
            DB db = new DB();
            db.openConnection();
            String code = code_box.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM course c ", db.getConnection());
            adapter.SelectCommand.Parameters.Add("@code", MySqlDbType.VarChar).Value = code;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void add_btn_Click_1(object sender, EventArgs e)
        {
            
        }
        public Boolean checkCode()
        {
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `course` WHERE `code` = @usn", db.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = code_box.Text;
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
        public Boolean checkData(TextBox box, String table_name, String clmn)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM " + table_name + " WHERE " + clmn + " = " + int.Parse(box.Text), db.getConnection());

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
            String name = name_box.Text;
            String code = code_box.Text;
            String dept = dept_box.Text;


            if (name.Equals("") || code.Equals("") || dept.Equals(""))
                return true;
            else
                return false;

        }
        public void fillCombo()
        {
            try
            {
                DB db = new DB();
                string selectQuery = "SELECT * FROM department";
                db.openConnection();
                MySqlCommand command = new MySqlCommand(selectQuery, db.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dept_box.Items.Add(reader.GetString("name"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void del_but_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM `course` WHERE `code` = @crs_code", db.getConnection());
            cmd.Parameters.Add("@crs_code", MySqlDbType.VarChar).Value = code_box.Text;

            if (!checkEmptyFields())
            {
                if (MessageBox.Show("Are you sure you want to delete", "Account", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Instructor successfully deleted!!", "Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields())
            {
                MessageBox.Show("Please fill all of the empty boxes", "Empty Fields", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            String name = name_box.Text;
            String code = code_box.Text;
            String dept = dept_box.Text;
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `course`(`name`, `code`,  `dept`) VALUES(@name,@code,@dept)", db.getConnection());
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@code", MySqlDbType.VarChar).Value = code;
            cmd.Parameters.Add("@dept", MySqlDbType.VarChar).Value = dept;

            db.openConnection();

            if (!checkEmptyFields())
            {
                if (checkCode())
                {
                    MessageBox.Show("Course code already exist please change course code", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Course successfully Added!", "Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
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