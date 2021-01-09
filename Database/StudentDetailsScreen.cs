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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            string query = "UPDATE student  SET Name = '" + textBox2.Text + "' , Surname = '" + textBox3.Text + "', country_id= '" + textBox5.Text + "', password= '" + textBox6.Text + "' WHERE std_id = '" + textBox1.Text + "'";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());


            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Updated");
                }
                else
                {
                    MessageBox.Show("Data No Updated");
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            db.closeConnection();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
