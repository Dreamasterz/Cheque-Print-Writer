namespace Cheque_Print_Writer
{
    partial class DBSetup
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dbname = new System.Windows.Forms.ComboBox();
            this.dbpassword = new System.Windows.Forms.TextBox();
            this.dbusername = new System.Windows.Forms.TextBox();
            this.dbserver = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dbport = new System.Windows.Forms.TextBox();
            this.chkpersistent = new System.Windows.Forms.CheckBox();
            this.chksslmode = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name:";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(24, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Activate Online Mode";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DB Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "User Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 248);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 11);
            this.progressBar1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Progress (0%) : Validating";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dbname
            // 
            this.dbname.FormattingEnabled = true;
            this.dbname.Location = new System.Drawing.Point(90, 120);
            this.dbname.Name = "dbname";
            this.dbname.Size = new System.Drawing.Size(129, 21);
            this.dbname.TabIndex = 11;
            this.dbname.Text = "mydb";
            // 
            // dbpassword
            // 
            this.dbpassword.Location = new System.Drawing.Point(90, 69);
            this.dbpassword.Name = "dbpassword";
            this.dbpassword.Size = new System.Drawing.Size(129, 20);
            this.dbpassword.TabIndex = 6;
            this.dbpassword.UseSystemPasswordChar = true;
            // 
            // dbusername
            // 
            this.dbusername.Location = new System.Drawing.Point(90, 43);
            this.dbusername.Name = "dbusername";
            this.dbusername.Size = new System.Drawing.Size(129, 20);
            this.dbusername.TabIndex = 5;
            this.dbusername.Text = "root";
            // 
            // dbserver
            // 
            this.dbserver.Location = new System.Drawing.Point(90, 17);
            this.dbserver.Name = "dbserver";
            this.dbserver.Size = new System.Drawing.Size(129, 20);
            this.dbserver.TabIndex = 3;
            this.dbserver.Text = "localhost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Port:";
            // 
            // dbport
            // 
            this.dbport.Location = new System.Drawing.Point(90, 94);
            this.dbport.Name = "dbport";
            this.dbport.Size = new System.Drawing.Size(129, 20);
            this.dbport.TabIndex = 17;
            // 
            // chkpersistent
            // 
            this.chkpersistent.AutoSize = true;
            this.chkpersistent.Location = new System.Drawing.Point(90, 147);
            this.chkpersistent.Name = "chkpersistent";
            this.chkpersistent.Size = new System.Drawing.Size(128, 17);
            this.chkpersistent.TabIndex = 19;
            this.chkpersistent.Text = "PersistenSecurity Info";
            this.chkpersistent.UseVisualStyleBackColor = true;
            // 
            // chksslmode
            // 
            this.chksslmode.AutoSize = true;
            this.chksslmode.Location = new System.Drawing.Point(90, 164);
            this.chksslmode.Name = "chksslmode";
            this.chksslmode.Size = new System.Drawing.Size(76, 17);
            this.chksslmode.TabIndex = 20;
            this.chksslmode.Text = "SSL Mode";
            this.chksslmode.UseVisualStyleBackColor = true;
            // 
            // DBSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 310);
            this.Controls.Add(this.chksslmode);
            this.Controls.Add(this.chkpersistent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dbport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dbname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dbpassword);
            this.Controls.Add(this.dbusername);
            this.Controls.Add(this.dbserver);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DBSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DBSetup";
            this.Load += new System.EventHandler(this.DBSetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox dbserver;
        private System.Windows.Forms.TextBox dbusername;
        private System.Windows.Forms.TextBox dbpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dbname;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dbport;
        private System.Windows.Forms.CheckBox chkpersistent;
        private System.Windows.Forms.CheckBox chksslmode;
    }
}