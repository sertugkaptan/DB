using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class StudentDetailsScreen : Form
    {
        
        public StudentDetailsScreen()
        {
            InitializeComponent();
            fillCombo("student", textBox7, "username");
            fillCombo("student", textBox6, "password");
            populate();
            
        }

        private void StudentDetailsScreen_Load(object sender, EventArgs e)
        {

            DB db = new DB();
            db.openConnection();
            string query = "SELECT* FROM `student` WHERE `std_id` = '" + User.usn + "'";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            MySqlDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                textBox1.Text = dr["std_id"].ToString();
                textBox2.Text = dr["name"].ToString();
                textBox3.Text = dr["surname"].ToString();
                textBox4.Text = dr["dept"].ToString();
                textBox5.Text = dr["country_id"].ToString();
                textBox6.Text = dr["password"].ToString();
                textBox7.Text = dr["username"].ToString();
            }
            db.closeConnection();
            populate();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            string query = "UPDATE student  SET username= '" + textBox7.Text + "', password= '" + textBox6.Text + "' WHERE std_id = '" + textBox1.Text + "'";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            if (!checkEmptyFields())
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Personal details succesfully updated!!!", "Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Unexpected Error has occured", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please fill all of the empty boxes", "Empty Fields", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            db.closeConnection();
            populate();
        }
        public void populate()
        {
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM student WHERE std_id = @std_id", db.getConnection());
            adapter.SelectCommand.Parameters.Add("@std_id", MySqlDbType.VarChar).Value = textBox1.Text;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void fillCombo(String table, TextBox tb, String column)
        {
            try
            {
                DB db = new DB();
                string selectQuery = "SELECT * FROM student WHERE std_id = @std_id";
                db.openConnection();
                MySqlCommand command = new MySqlCommand(selectQuery, db.getConnection());
                command.Parameters.Add("@std_id", MySqlDbType.VarChar).Value = textBox1.Text;
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
        public Boolean checkEmptyFields()
        {
            String username = textBox7.Text;
            String pass = textBox6.Text;


            if (username.Equals("") || pass.Equals(""))
                return true;
            else
                return false;

        }
        public Boolean checkUsername()
        {
            DB db = new DB();
            String username = textBox7.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` WHERE `username` = @usn", db.getConnection());
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
