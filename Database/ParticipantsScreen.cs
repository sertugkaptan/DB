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
    public partial class ParticipantsScreen : Form
    {
        public ParticipantsScreen()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void participants()
        {
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM taking WHERE crs_code ='" + comboBox1.Text + "'", db.getConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            db.closeConnection();

        }

        private void ParticipantsScreen_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            string selectQuery = "SELECT *FROM taking WHERE std_id = '" + StudentLogin.username + "' ";
            db.openConnection();
            MySqlCommand command = new MySqlCommand(selectQuery, db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["crs_code"].ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            participants();
        }
    }
}
