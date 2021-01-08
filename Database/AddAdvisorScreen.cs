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
    public partial class AddAdvisorScreen : Form
    {
        public AddAdvisorScreen()
        {
            InitializeComponent();
            populate();
            fillCombo("instructor",comboBox1,"ins_id");
            fillCombo("student",comboBox2, "std_id");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void populate()
        {
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM advisor a ",db.getConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if(checkEmptyFields())
            {
                MessageBox.Show("Please fill all of the empty boxes", "Empty Fields", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            int ins_id = int.Parse(comboBox1.Text);
            int std_id = int.Parse(comboBox2.Text);
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `advisor`(`ins_id`, `std_id`) VALUES(@ins_id,@std_id)", db.getConnection());
            cmd.Parameters.Add("@ins_id", MySqlDbType.Int32).Value = ins_id;
            cmd.Parameters.Add("@std_id", MySqlDbType.Int32).Value = std_id;

            db.openConnection();

            if (!checkEmptyFields())
            {
                if(checkStd())
                {
                    MessageBox.Show("Student already has an advisor", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Advisor successfully Assigned!", "Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public Boolean checkStd()
        {
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `advisor` WHERE `std_id` = @usn", db.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.Int32).Value = int.Parse(comboBox2.Text);
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
        public Boolean checkData(TextBox box,String table_name,String clmn)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM "+ table_name + " WHERE "+ clmn +" = "+ int.Parse(box.Text), db.getConnection());

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
            String ins_id = comboBox1.Text;
            String std_id = comboBox2.Text;
   

            if (ins_id.Equals("") || std_id.Equals(""))
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
