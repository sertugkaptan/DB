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
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void populate()
        {
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT crs_code AS Course_Codes_That_Are_Assigned FROM teaching WHERE ins_id = @ins_id ",db.getConnection());
            adapter.SelectCommand.Parameters.Add("@ins_id", MySqlDbType.VarChar).Value = User.usn;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
