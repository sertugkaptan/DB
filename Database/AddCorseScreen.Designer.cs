
namespace Database
{
    partial class AddCorseScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_btn = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dept_box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.code_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.del_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(224, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 403);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // add_btn
            // 
            this.add_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.add_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.add_btn.Location = new System.Drawing.Point(44, 367);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(119, 23);
            this.add_btn.TabIndex = 8;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // dept_box
            // 
            this.dept_box.FormattingEnabled = true;
            this.dept_box.Location = new System.Drawing.Point(21, 152);
            this.dept_box.Name = "dept_box";
            this.dept_box.Size = new System.Drawing.Size(176, 21);
            this.dept_box.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(21, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Department Name";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(21, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Course Code";
            // 
            // code_box
            // 
            this.code_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.code_box.Location = new System.Drawing.Point(21, 100);
            this.code_box.Name = "code_box";
            this.code_box.Size = new System.Drawing.Size(178, 22);
            this.code_box.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(21, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Course Name";
            // 
            // name_box
            // 
            this.name_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.name_box.Location = new System.Drawing.Point(19, 51);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(178, 22);
            this.name_box.TabIndex = 17;
            // 
            // del_but
            // 
            this.del_but.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.del_but.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.del_but.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.del_but.Location = new System.Drawing.Point(44, 396);
            this.del_but.Name = "del_but";
            this.del_but.Size = new System.Drawing.Size(119, 23);
            this.del_but.TabIndex = 24;
            this.del_but.Text = "Delete";
            this.del_but.UseVisualStyleBackColor = true;
            this.del_but.Click += new System.EventHandler(this.del_but_Click);
            // 
            // AddCorseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.del_but);
            this.Controls.Add(this.dept_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.code_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "AddCorseScreen";
            this.Text = "AddInstructorScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.ComboBox dept_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox code_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Button del_but;
    }
}