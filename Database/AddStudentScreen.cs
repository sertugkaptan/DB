﻿using System;
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
    public partial class AddStudentScreen : Form
    {
        public AddStudentScreen()
        {
            InitializeComponent();
            populate();
            fillCombo("department", dept_box, "name");
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void populate()
        {
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM student",db.getConnection());

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
            String name = name_box.Text;
            String surname = surname_box.Text;
            String country_id = country_id_box.Text;
            int ins_id = int.Parse(std_id_box.Text);
            String usn = usn_box.Text;
            String pass = pass_box.Text;
            String dept = dept_box.Text;
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `student`(`std_id`, `password`, `dept`, `username`, `name`, `surname`,`country_id`) VALUES (@std_id, @pass, @dept, @usn, @name, @surn, @country_id)", db.getConnection());
            cmd.Parameters.Add("@usn", MySqlDbType.VarChar).Value = usn;
            cmd.Parameters.Add("@std_id", MySqlDbType.Int32).Value = ins_id;
            cmd.Parameters.Add("@country_id", MySqlDbType.VarChar).Value = country_id;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@surn", MySqlDbType.VarChar).Value = surname;
            cmd.Parameters.Add("@dept", MySqlDbType.VarChar).Value = dept;

            db.openConnection();

            if (!checkEmptyFields())
            {
                if(checkCountry())
                {
                    MessageBox.Show("Citizen ID already registered!!");
                }
                else
                {
                    if(checkData(std_id_box, "student", "std_id"))
                    {
                        MessageBox.Show("Instructor ID already registered!!");
                    }
                    else
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Account successfully created!", "Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Unexpected Error has occured", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all of the empty boxes", "Empty Fields", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            populate();
            db.closeConnection();

        }
        public Boolean checkCountry()
        {
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `instructor` WHERE `country_id` = @usn", db.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = country_id_box.Text;
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
        public Boolean checkUsername()
        {
            DB db = new DB();
            String username = usn_box.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` WHERE `std_id` = @usn", db.getConnection());
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
            String name = name_box.Text;
            String surname = surname_box.Text;
            String country_id = country_id_box.Text;
            String ins_id = std_id_box.Text;
            String usn = usn_box.Text;
            String pass = pass_box.Text;

            if (usn.Equals("") || pass.Equals("") || country_id.Equals("") || name.Equals("") || surname.Equals("") || ins_id.Equals(""))
                return true;
            else
                return false;

        }
        public void fillCombo(String table, ComboBox cb, String str)
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

        private void del_btn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `student` WHERE `std_id` = @std_id ", db.getConnection());
            cmd.Parameters.Add("@std_id", MySqlDbType.VarChar).Value = std_id_box.Text;
            
            if (!checkEmptyFields())
            {
                if (MessageBox.Show("Are you sure you want to delete", "Account", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Student successfully assigned to lecture!!", "Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
