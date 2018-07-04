namespace Cheque_Print_Writer
{
    partial class Form1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payeeCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payeeLower = new System.Windows.Forms.ToolStripMenuItem();
            this.payeeCapital = new System.Windows.Forms.ToolStripMenuItem();
            this.payeeCustomize = new System.Windows.Forms.ToolStripMenuItem();
            this.wordAmountCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amountLower = new System.Windows.Forms.ToolStripMenuItem();
            this.amountCapital = new System.Windows.Forms.ToolStripMenuItem();
            this.amountCamille = new System.Windows.Forms.ToolStripMenuItem();
            this.dBSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OnlineMode = new System.Windows.Forms.ToolStripMenuItem();
            this.serverSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OfflineMode = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Cheque_Print_Writer.DataSet1();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cheque_Print_Writer.cheque.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1041, 271);
            this.reportViewer1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MetroBank",
            "MetroBank(Personal)"});
            this.comboBox1.Location = new System.Drawing.Point(92, 326);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "MetroBank";
            this.comboBox1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Output Format:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Amount";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.signInToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payeeCharactersToolStripMenuItem,
            this.wordAmountCharactersToolStripMenuItem,
            this.dBSetupToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // payeeCharactersToolStripMenuItem
            // 
            this.payeeCharactersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payeeLower,
            this.payeeCapital,
            this.payeeCustomize});
            this.payeeCharactersToolStripMenuItem.Name = "payeeCharactersToolStripMenuItem";
            this.payeeCharactersToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.payeeCharactersToolStripMenuItem.Text = "Payee Characters";
            // 
            // payeeLower
            // 
            this.payeeLower.CheckOnClick = true;
            this.payeeLower.Name = "payeeLower";
            this.payeeLower.Size = new System.Drawing.Size(134, 22);
            this.payeeLower.Text = "Lower Case";
            this.payeeLower.Click += new System.EventHandler(this.payeeCharactersClick);
            // 
            // payeeCapital
            // 
            this.payeeCapital.CheckOnClick = true;
            this.payeeCapital.Name = "payeeCapital";
            this.payeeCapital.Size = new System.Drawing.Size(134, 22);
            this.payeeCapital.Text = "Capitalize";
            this.payeeCapital.Click += new System.EventHandler(this.payeeCharactersClick);
            // 
            // payeeCustomize
            // 
            this.payeeCustomize.Checked = true;
            this.payeeCustomize.CheckOnClick = true;
            this.payeeCustomize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.payeeCustomize.Name = "payeeCustomize";
            this.payeeCustomize.Size = new System.Drawing.Size(134, 22);
            this.payeeCustomize.Text = "Customize";
            this.payeeCustomize.Click += new System.EventHandler(this.payeeCharactersClick);
            // 
            // wordAmountCharactersToolStripMenuItem
            // 
            this.wordAmountCharactersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.amountLower,
            this.amountCapital,
            this.amountCamille});
            this.wordAmountCharactersToolStripMenuItem.Name = "wordAmountCharactersToolStripMenuItem";
            this.wordAmountCharactersToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.wordAmountCharactersToolStripMenuItem.Text = "Word Amount Characters";
            // 
            // amountLower
            // 
            this.amountLower.CheckOnClick = true;
            this.amountLower.Name = "amountLower";
            this.amountLower.Size = new System.Drawing.Size(142, 22);
            this.amountLower.Text = "Lower Case";
            this.amountLower.Click += new System.EventHandler(this.amountCharacterClick);
            // 
            // amountCapital
            // 
            this.amountCapital.CheckOnClick = true;
            this.amountCapital.Name = "amountCapital";
            this.amountCapital.Size = new System.Drawing.Size(142, 22);
            this.amountCapital.Text = "Capitalize";
            this.amountCapital.Click += new System.EventHandler(this.amountCharacterClick);
            // 
            // amountCamille
            // 
            this.amountCamille.Checked = true;
            this.amountCamille.CheckOnClick = true;
            this.amountCamille.CheckState = System.Windows.Forms.CheckState.Checked;
            this.amountCamille.Name = "amountCamille";
            this.amountCamille.Size = new System.Drawing.Size(142, 22);
            this.amountCamille.Text = "Camille Case";
            this.amountCamille.Click += new System.EventHandler(this.amountCharacterClick);
            // 
            // dBSetupToolStripMenuItem
            // 
            this.dBSetupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnlineMode,
            this.OfflineMode});
            this.dBSetupToolStripMenuItem.Name = "dBSetupToolStripMenuItem";
            this.dBSetupToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.dBSetupToolStripMenuItem.Text = "DB Setup";
            // 
            // OnlineMode
            // 
            this.OnlineMode.CheckOnClick = true;
            this.OnlineMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverSetupToolStripMenuItem,
            this.manageUsersToolStripMenuItem});
            this.OnlineMode.Name = "OnlineMode";
            this.OnlineMode.Size = new System.Drawing.Size(180, 22);
            this.OnlineMode.Text = "Online Mode";
            this.OnlineMode.Click += new System.EventHandler(this.modeLineClick);
            // 
            // serverSetupToolStripMenuItem
            // 
            this.serverSetupToolStripMenuItem.Name = "serverSetupToolStripMenuItem";
            this.serverSetupToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.serverSetupToolStripMenuItem.Text = "Server Setup & Activate";
            this.serverSetupToolStripMenuItem.Click += new System.EventHandler(this.serverSetupToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // OfflineMode
            // 
            this.OfflineMode.CheckOnClick = true;
            this.OfflineMode.Name = "OfflineMode";
            this.OfflineMode.Size = new System.Drawing.Size(180, 22);
            this.OfflineMode.Text = "Offline Mode";
            this.OfflineMode.Click += new System.EventHandler(this.modeLineClick);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // signInToolStripMenuItem
            // 
            this.signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            this.signInToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.signInToolStripMenuItem.Text = "Sign In";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cheque Type:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(820, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 45);
            this.button1.TabIndex = 23;
            this.button1.Text = "Clear/New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(444, 356);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(344, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(820, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 41);
            this.button2.TabIndex = 25;
            this.button2.Text = "Save and Reference Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1041, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Online Mode/Offline Mode(Red)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Cheque_Print_Writer.Properties.Settings.Default, "D_Payee", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(92, 359);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(239, 21);
            this.comboBox2.TabIndex = 24;
            this.comboBox2.Text = global::Cheque_Print_Writer.Properties.Settings.Default.D_Payee;
            this.comboBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = global::Cheque_Print_Writer.Properties.Settings.Default.D_DateCheckCap;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Cheque_Print_Writer.Properties.Settings.Default, "D_DateCheckCap", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox4.Location = new System.Drawing.Point(700, 329);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(88, 17);
            this.checkBox4.TabIndex = 22;
            this.checkBox4.Text = "Upper Month";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Cheque_Print_Writer.Properties.Settings.Default, "D_WordAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox5.Location = new System.Drawing.Point(165, 406);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(623, 20);
            this.textBox5.TabIndex = 21;
            this.textBox5.Text = global::Cheque_Print_Writer.Properties.Settings.Default.D_WordAmount;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = global::Cheque_Print_Writer.Properties.Settings.Default.D_RadioCustom;
            this.radioButton2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Cheque_Print_Writer.Properties.Settings.Default, "D_RadioCustom", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioButton2.Location = new System.Drawing.Point(15, 409);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(144, 17);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.Text = "Customize convert value.";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = global::Cheque_Print_Writer.Properties.Settings.Default.D_RadioAuto;
            this.radioButton1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Cheque_Print_Writer.Properties.Settings.Default, "D_RadioAuto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioButton1.Location = new System.Drawing.Point(15, 386);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(205, 17);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Automatically convert amount to word.";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = global::Cheque_Print_Writer.Properties.Settings.Default.D_AmountCheck;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Cheque_Print_Writer.Properties.Settings.Default, "D_AmountCheck", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox3.Location = new System.Drawing.Point(364, 358);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = global::Cheque_Print_Writer.Properties.Settings.Default.D_PayeeCheck;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Cheque_Print_Writer.Properties.Settings.Default, "D_PayeeCheck", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.Location = new System.Drawing.Point(15, 363);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(56, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Payee";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Cheque_Print_Writer.Properties.Settings.Default, "D_DateFormat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Location = new System.Drawing.Point(585, 328);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = global::Cheque_Print_Writer.Properties.Settings.Default.D_DateFormat;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "MMM dd, yyyy";
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Cheque_Print_Writer.Properties.Settings.Default, "D_Date", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(386, 326);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = global::Cheque_Print_Writer.Properties.Settings.Default.D_Date;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::Cheque_Print_Writer.Properties.Settings.Default.D_DateCheck;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Cheque_Print_Writer.Properties.Settings.Default, "D_DateCheck", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(365, 329);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cheque Printer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payeeCharactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payeeLower;
        private System.Windows.Forms.ToolStripMenuItem payeeCapital;
        private System.Windows.Forms.ToolStripMenuItem payeeCustomize;
        private System.Windows.Forms.ToolStripMenuItem wordAmountCharactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amountLower;
        private System.Windows.Forms.ToolStripMenuItem amountCapital;
        private System.Windows.Forms.ToolStripMenuItem amountCamille;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OnlineMode;
        private System.Windows.Forms.ToolStripMenuItem serverSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OfflineMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem signInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
    }
}

