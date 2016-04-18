namespace Delivery
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
            this.r_AgToWh = new MetroFramework.Controls.MetroRadioButton();
            this.r_WhToAg = new MetroFramework.Controls.MetroRadioButton();
            this.ListFrom = new MetroFramework.Controls.MetroComboBox();
            this.ListTo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.ItemList = new MetroFramework.Controls.MetroComboBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // r_AgToWh
            // 
            this.r_AgToWh.AutoSize = true;
            this.r_AgToWh.Location = new System.Drawing.Point(225, 31);
            this.r_AgToWh.Name = "r_AgToWh";
            this.r_AgToWh.Size = new System.Drawing.Size(155, 15);
            this.r_AgToWh.Style = MetroFramework.MetroColorStyle.Pink;
            this.r_AgToWh.TabIndex = 0;
            this.r_AgToWh.Text = "AGENT --> WAREHOUSE";
            this.r_AgToWh.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.r_AgToWh.UseSelectable = true;
            this.r_AgToWh.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // r_WhToAg
            // 
            this.r_WhToAg.AutoSize = true;
            this.r_WhToAg.Location = new System.Drawing.Point(225, 63);
            this.r_WhToAg.Name = "r_WhToAg";
            this.r_WhToAg.Size = new System.Drawing.Size(155, 15);
            this.r_WhToAg.Style = MetroFramework.MetroColorStyle.Pink;
            this.r_WhToAg.TabIndex = 1;
            this.r_WhToAg.Text = "WAREHOUSE --> AGENT";
            this.r_WhToAg.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.r_WhToAg.UseSelectable = true;
            this.r_WhToAg.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // ListFrom
            // 
            this.ListFrom.Enabled = false;
            this.ListFrom.FormattingEnabled = true;
            this.ListFrom.ItemHeight = 23;
            this.ListFrom.Location = new System.Drawing.Point(483, 36);
            this.ListFrom.Name = "ListFrom";
            this.ListFrom.Size = new System.Drawing.Size(179, 29);
            this.ListFrom.Style = MetroFramework.MetroColorStyle.Pink;
            this.ListFrom.TabIndex = 2;
            this.ListFrom.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ListFrom.UseSelectable = true;
            this.ListFrom.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // ListTo
            // 
            this.ListTo.Enabled = false;
            this.ListTo.FormattingEnabled = true;
            this.ListTo.ItemHeight = 23;
            this.ListTo.Location = new System.Drawing.Point(722, 36);
            this.ListTo.Name = "ListTo";
            this.ListTo.Size = new System.Drawing.Size(176, 29);
            this.ListTo.Style = MetroFramework.MetroColorStyle.Pink;
            this.ListTo.TabIndex = 3;
            this.ListTo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ListTo.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(427, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "FROM:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(686, 39);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(29, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "TO:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(27, 138);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "ITEM:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(314, 126);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "AMOUNT:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(39, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "0"};
            this.metroTextBox1.Location = new System.Drawing.Point(390, 124);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.Size = new System.Drawing.Size(61, 23);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroTextBox1.TabIndex = 9;
            this.metroTextBox1.Text = "0";
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            this.metroTextBox1.Leave += new System.EventHandler(this.metroTextBox1_Leave);
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Location = new System.Drawing.Point(314, 156);
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.metroTrackBar1.Size = new System.Drawing.Size(137, 23);
            this.metroTrackBar1.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroTrackBar1.TabIndex = 10;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroTrackBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTrackBar1.Value = 0;
            this.metroTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar1_Scroll);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(38, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[] {
        "0"};
            this.metroTextBox2.Location = new System.Drawing.Point(573, 138);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.Size = new System.Drawing.Size(60, 23);
            this.metroTextBox2.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroTextBox2.TabIndex = 12;
            this.metroTextBox2.Text = "0";
            this.metroTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.metroTextBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox2.TextChanged += new System.EventHandler(this.metroTextBox2_TextChanged);
            this.metroTextBox2.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(510, 140);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(47, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "PRICE:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ItemList
            // 
            this.ItemList.FormattingEnabled = true;
            this.ItemList.ItemHeight = 23;
            this.ItemList.Location = new System.Drawing.Point(74, 136);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(179, 29);
            this.ItemList.Style = MetroFramework.MetroColorStyle.Pink;
            this.ItemList.TabIndex = 14;
            this.ItemList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ItemList.UseSelectable = true;
            this.ItemList.SelectedIndexChanged += new System.EventHandler(this.metroComboBox4_SelectedIndexChanged);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(34, 235);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(73, 15);
            this.metroCheckBox1.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroCheckBox1.TabIndex = 15;
            this.metroCheckBox1.Text = "DELIVERY";
            this.metroCheckBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(722, 138);
            this.metroDateTime1.MinDate = new System.DateTime(2016, 4, 12, 0, 0, 0, 0);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(176, 29);
            this.metroDateTime1.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroDateTime1.TabIndex = 16;
            this.metroDateTime1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.Enabled = false;
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 23;
            this.metroComboBox3.Location = new System.Drawing.Point(205, 228);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(179, 29);
            this.metroComboBox3.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroComboBox3.TabIndex = 17;
            this.metroComboBox3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox3.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(149, 232);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(41, 19);
            this.metroLabel6.TabIndex = 18;
            this.metroLabel6.Text = "TIME:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(769, 271);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(129, 23);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroTile1.TabIndex = 19;
            this.metroTile1.Text = "APPLY";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(587, 271);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(129, 23);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroTile2.TabIndex = 20;
            this.metroTile2.Text = "RESET";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(390, 271);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(149, 19);
            this.metroLabel7.TabIndex = 21;
            this.metroLabel7.Text = "SUCCESS / UNSUCCESS";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 300);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(489, 176);
            this.textBox1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 514);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroComboBox3);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroTrackBar1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ListTo);
            this.Controls.Add(this.ListFrom);
            this.Controls.Add(this.r_WhToAg);
            this.Controls.Add(this.r_AgToWh);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 21);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Add New Order";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton r_AgToWh;
        private MetroFramework.Controls.MetroRadioButton r_WhToAg;
        private MetroFramework.Controls.MetroComboBox ListFrom;
        private MetroFramework.Controls.MetroComboBox ListTo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox ItemList;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox textBox1;




        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnExit;
    }
}

