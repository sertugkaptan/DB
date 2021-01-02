
namespace Database
{
    partial class registerScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.perm_box = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.confirmation_box = new System.Windows.Forms.TextBox();
            this.username_box = new System.Windows.Forms.Label();
            this.usern_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.last_name_box = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.email_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.first_name_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.perm_box);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.confirmation_box);
            this.panel1.Controls.Add(this.username_box);
            this.panel1.Controls.Add(this.usern_box);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.last_name_box);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.email_box);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.password_box);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.first_name_box);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(78, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 505);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(50, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Permission";
            // 
            // perm_box
            // 
            this.perm_box.FormattingEnabled = true;
            this.perm_box.Location = new System.Drawing.Point(52, 212);
            this.perm_box.Name = "perm_box";
            this.perm_box.Size = new System.Drawing.Size(355, 21);
            this.perm_box.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(107, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(50, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Confirm Password";
            // 
            // confirmation_box
            // 
            this.confirmation_box.Location = new System.Drawing.Point(53, 312);
            this.confirmation_box.Name = "confirmation_box";
            this.confirmation_box.Size = new System.Drawing.Size(354, 20);
            this.confirmation_box.TabIndex = 13;
            // 
            // username_box
            // 
            this.username_box.AutoSize = true;
            this.username_box.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username_box.ForeColor = System.Drawing.SystemColors.Control;
            this.username_box.Location = new System.Drawing.Point(49, 140);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(80, 20);
            this.username_box.TabIndex = 12;
            this.username_box.Text = "Username";
            // 
            // usern_box
            // 
            this.usern_box.Location = new System.Drawing.Point(53, 163);
            this.usern_box.Name = "usern_box";
            this.usern_box.Size = new System.Drawing.Size(354, 20);
            this.usern_box.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(237, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Last Name";
            // 
            // last_name_box
            // 
            this.last_name_box.Location = new System.Drawing.Point(241, 107);
            this.last_name_box.Name = "last_name_box";
            this.last_name_box.Size = new System.Drawing.Size(166, 20);
            this.last_name_box.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(127)))), ((int)(((byte)(80)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(82, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(289, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Login Screen";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(49, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-mail";
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(53, 362);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(354, 20);
            this.email_box.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(48, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(52, 262);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(354, 20);
            this.password_box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(49, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // first_name_box
            // 
            this.first_name_box.Location = new System.Drawing.Point(53, 107);
            this.first_name_box.Name = "first_name_box";
            this.first_name_box.Size = new System.Drawing.Size(178, 20);
            this.first_name_box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(120, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Your Account";
            // 
            // registerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(642, 569);
            this.Controls.Add(this.panel1);
            this.Name = "registerScreen";
            this.Text = "Register Screen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox first_name_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox last_name_box;
        private System.Windows.Forms.Label username_box;
        private System.Windows.Forms.TextBox usern_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox confirmation_box;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox perm_box;
        private System.Windows.Forms.Label label7;
    }
}