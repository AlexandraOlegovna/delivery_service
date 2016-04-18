﻿namespace Delivery
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
            this.AmountField = new MetroFramework.Controls.MetroTextBox();
            this.AmountTrack = new MetroFramework.Controls.MetroTrackBar();
            this.PriseField = new MetroFramework.Controls.MetroTextBox();
            this.ItemList = new MetroFramework.Controls.MetroComboBox();
            this.DateTime = new MetroFramework.Controls.MetroDateTime();
            this.TimeList = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.butApply = new MetroFramework.Controls.MetroTile();
            this.butReset1 = new MetroFramework.Controls.MetroTile();
            this.butQuit = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.checkDelivery = new MetroFramework.Controls.MetroCheckBox();
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
            this.metroLabel2.Size = new System.Drawing.Size(30, 19);
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
            // AmountField
            // 
            // 
            // 
            // 
            this.AmountField.CustomButton.Image = null;
            this.AmountField.CustomButton.Location = new System.Drawing.Point(39, 1);
            this.AmountField.CustomButton.Name = "";
            this.AmountField.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AmountField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AmountField.CustomButton.TabIndex = 1;
            this.AmountField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AmountField.CustomButton.UseSelectable = true;
            this.AmountField.CustomButton.Visible = false;
            this.AmountField.Lines = new string[] {
        "0"};
            this.AmountField.Location = new System.Drawing.Point(390, 124);
            this.AmountField.MaxLength = 32767;
            this.AmountField.Name = "AmountField";
            this.AmountField.PasswordChar = '\0';
            this.AmountField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AmountField.SelectedText = "";
            this.AmountField.SelectionLength = 0;
            this.AmountField.SelectionStart = 0;
            this.AmountField.Size = new System.Drawing.Size(61, 23);
            this.AmountField.Style = MetroFramework.MetroColorStyle.Pink;
            this.AmountField.TabIndex = 9;
            this.AmountField.Text = "0";
            this.AmountField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AmountField.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AmountField.UseSelectable = true;
            this.AmountField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AmountField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.AmountField.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            this.AmountField.Click += new System.EventHandler(this.metroTextBox1_Click);
            this.AmountField.Leave += new System.EventHandler(this.metroTextBox1_Leave);
            // 
            // AmountTrack
            // 
            this.AmountTrack.BackColor = System.Drawing.Color.Transparent;
            this.AmountTrack.Location = new System.Drawing.Point(314, 156);
            this.AmountTrack.Name = "AmountTrack";
            this.AmountTrack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AmountTrack.Size = new System.Drawing.Size(137, 23);
            this.AmountTrack.Style = MetroFramework.MetroColorStyle.Pink;
            this.AmountTrack.TabIndex = 10;
            this.AmountTrack.Text = "metroTrackBar1";
            this.AmountTrack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AmountTrack.Value = 0;
            this.AmountTrack.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar1_Scroll);
            // 
            // PriseField
            // 
            // 
            // 
            // 
            this.PriseField.CustomButton.Image = null;
            this.PriseField.CustomButton.Location = new System.Drawing.Point(38, 1);
            this.PriseField.CustomButton.Name = "";
            this.PriseField.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PriseField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PriseField.CustomButton.TabIndex = 1;
            this.PriseField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PriseField.CustomButton.UseSelectable = true;
            this.PriseField.CustomButton.Visible = false;
            this.PriseField.Lines = new string[] {
        "0"};
            this.PriseField.Location = new System.Drawing.Point(573, 138);
            this.PriseField.MaxLength = 32767;
            this.PriseField.Name = "PriseField";
            this.PriseField.PasswordChar = '\0';
            this.PriseField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PriseField.SelectedText = "";
            this.PriseField.SelectionLength = 0;
            this.PriseField.SelectionStart = 0;
            this.PriseField.Size = new System.Drawing.Size(60, 23);
            this.PriseField.Style = MetroFramework.MetroColorStyle.Pink;
            this.PriseField.TabIndex = 12;
            this.PriseField.Text = "0";
            this.PriseField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PriseField.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PriseField.UseSelectable = true;
            this.PriseField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PriseField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PriseField.TextChanged += new System.EventHandler(this.metroTextBox2_TextChanged);
            this.PriseField.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // ItemList
            // 
            this.ItemList.Enabled = false;
            this.ItemList.FormattingEnabled = true;
            this.ItemList.ItemHeight = 23;
            this.ItemList.Location = new System.Drawing.Point(74, 136);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(179, 29);
            this.ItemList.Style = MetroFramework.MetroColorStyle.Pink;
            this.ItemList.TabIndex = 14;
            this.ItemList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ItemList.UseSelectable = true;
            this.ItemList.SelectedIndexChanged += new System.EventHandler(this.ItemList_SelectedIndexChanged);
            // 
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(722, 138);
            this.DateTime.MinDate = new System.DateTime(2016, 4, 12, 0, 0, 0, 0);
            this.DateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(176, 29);
            this.DateTime.Style = MetroFramework.MetroColorStyle.Pink;
            this.DateTime.TabIndex = 16;
            this.DateTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TimeList
            // 
            this.TimeList.Enabled = false;
            this.TimeList.FormattingEnabled = true;
            this.TimeList.ItemHeight = 23;
            this.TimeList.Location = new System.Drawing.Point(205, 228);
            this.TimeList.Name = "TimeList";
            this.TimeList.Size = new System.Drawing.Size(179, 29);
            this.TimeList.Style = MetroFramework.MetroColorStyle.Pink;
            this.TimeList.TabIndex = 17;
            this.TimeList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TimeList.UseSelectable = true;
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
            // butApply
            // 
            this.butApply.ActiveControl = null;
            this.butApply.Location = new System.Drawing.Point(599, 271);
            this.butApply.Name = "butApply";
            this.butApply.Size = new System.Drawing.Size(129, 23);
            this.butApply.Style = MetroFramework.MetroColorStyle.Pink;
            this.butApply.TabIndex = 19;
            this.butApply.Text = "APPLY";
            this.butApply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butApply.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.butApply.UseSelectable = true;
            // 
            // butReset1
            // 
            this.butReset1.ActiveControl = null;
            this.butReset1.Location = new System.Drawing.Point(428, 271);
            this.butReset1.Name = "butReset1";
            this.butReset1.Size = new System.Drawing.Size(129, 23);
            this.butReset1.Style = MetroFramework.MetroColorStyle.Pink;
            this.butReset1.TabIndex = 20;
            this.butReset1.Text = "RESET";
            this.butReset1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butReset1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.butReset1.UseSelectable = true;
            this.butReset1.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // butQuit
            // 
            this.butQuit.ActiveControl = null;
            this.butQuit.Location = new System.Drawing.Point(760, 271);
            this.butQuit.Name = "butQuit";
            this.butQuit.Size = new System.Drawing.Size(129, 23);
            this.butQuit.Style = MetroFramework.MetroColorStyle.Pink;
            this.butQuit.TabIndex = 23;
            this.butQuit.Text = "QUIT";
            this.butQuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butQuit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.butQuit.UseSelectable = true;
            this.butQuit.Click += new System.EventHandler(this.butQuit_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(522, 139);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(45, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroLabel5.TabIndex = 24;
            this.metroLabel5.Text = "PRISE:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // checkDelivery
            // 
            this.checkDelivery.AutoSize = true;
            this.checkDelivery.Location = new System.Drawing.Point(36, 236);
            this.checkDelivery.Name = "checkDelivery";
            this.checkDelivery.Size = new System.Drawing.Size(73, 15);
            this.checkDelivery.Style = MetroFramework.MetroColorStyle.Pink;
            this.checkDelivery.TabIndex = 25;
            this.checkDelivery.Text = "DELIVERY";
            this.checkDelivery.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkDelivery.UseSelectable = true;
            this.checkDelivery.CheckedChanged += new System.EventHandler(this.checkDelivery_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 318);
            this.Controls.Add(this.checkDelivery);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.butQuit);
            this.Controls.Add(this.butReset1);
            this.Controls.Add(this.butApply);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.TimeList);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.PriseField);
            this.Controls.Add(this.AmountTrack);
            this.Controls.Add(this.AmountField);
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
        private MetroFramework.Controls.MetroTextBox AmountField;
        private MetroFramework.Controls.MetroTrackBar AmountTrack;
        private MetroFramework.Controls.MetroTextBox PriseField;
        private MetroFramework.Controls.MetroComboBox ItemList;
        private MetroFramework.Controls.MetroDateTime DateTime;
        private MetroFramework.Controls.MetroComboBox TimeList;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTile butApply;
        private MetroFramework.Controls.MetroTile butReset1;



        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnExit;
        private MetroFramework.Controls.MetroTile butQuit;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroCheckBox checkDelivery;
    }
}

