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
    public partial class CourseInfoScreen : Form
    {
        public CourseInfoScreen()
        {
            InitializeComponent();
            populate();
            fillCombo("course",comboBox2, "code");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void populate()
        {
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT t.std_id AS Student_ID, c.name AS Course_Name, c.code AS Course_Code, s.name AS student_Name FROM taking t, course c ,student s  WHERE t.crs_code = c.code  AND s.std_id = t.std_id AND t.crs_code = @crs_code", db.getConnection());
            adapter.SelectCommand.Parameters.Add("@crs_code", MySqlDbType.VarChar).Value = comboBox2.Text;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            populate();
        }

        public Boolean checkCourse()
        {
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `teaching` WHERE `crs_code` = @usn", db.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = comboBox2.Text;
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
            String crs_code = comboBox2.Text;
   

            if (crs_code.Equals(""))
                return true;
            else
                return false;

        }
        public void fillCombo(String table,ComboBox cb,String str)
        {
            try
            {
                DB db = new DB();
                String selectQuery = "SELECT * FROM " + table;
                db.openConnection();
                MySqlCommand command = new MySqlCommand(selectQuery, db.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cb.Items.Add(reader.GetString(str));
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

        
    }
}
