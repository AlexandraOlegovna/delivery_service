namespace Delivery
{
    partial class Form2
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.LoginField = new MetroFramework.Controls.MetroTextBox();
            this.PassField = new MetroFramework.Controls.MetroTextBox();
            this.butSignIn = new MetroFramework.Controls.MetroTile();
            this.butQiut = new MetroFramework.Controls.MetroTile();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(72, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "LOGIN:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(72, 142);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(112, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "PASSWORD:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LoginField
            // 
            // 
            // 
            // 
            this.LoginField.CustomButton.Image = null;
            this.LoginField.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.LoginField.CustomButton.Name = "";
            this.LoginField.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.LoginField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LoginField.CustomButton.TabIndex = 1;
            this.LoginField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LoginField.CustomButton.UseSelectable = true;
            this.LoginField.CustomButton.Visible = false;
            this.LoginField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.LoginField.Lines = new string[0];
            this.LoginField.Location = new System.Drawing.Point(202, 74);
            this.LoginField.MaxLength = 32767;
            this.LoginField.Name = "LoginField";
            this.LoginField.PasswordChar = '\0';
            this.LoginField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LoginField.SelectedText = "";
            this.LoginField.SelectionLength = 0;
            this.LoginField.SelectionStart = 0;
            this.LoginField.Size = new System.Drawing.Size(187, 30);
            this.LoginField.Style = MetroFramework.MetroColorStyle.Pink;
            this.LoginField.TabIndex = 2;
            this.LoginField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginField.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LoginField.UseSelectable = true;
            this.LoginField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LoginField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.LoginField.TextChanged += new System.EventHandler(this.LoginField_TextChanged);
            // 
            // PassField
            // 
            // 
            // 
            // 
            this.PassField.CustomButton.Image = null;
            this.PassField.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.PassField.CustomButton.Name = "";
            this.PassField.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.PassField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PassField.CustomButton.TabIndex = 1;
            this.PassField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PassField.CustomButton.UseSelectable = true;
            this.PassField.CustomButton.Visible = false;
            this.PassField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.PassField.Lines = new string[0];
            this.PassField.Location = new System.Drawing.Point(202, 137);
            this.PassField.MaxLength = 32767;
            this.PassField.Name = "PassField";
            this.PassField.PasswordChar = '\0';
            this.PassField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PassField.SelectedText = "";
            this.PassField.SelectionLength = 0;
            this.PassField.SelectionStart = 0;
            this.PassField.Size = new System.Drawing.Size(187, 30);
            this.PassField.Style = MetroFramework.MetroColorStyle.Pink;
            this.PassField.TabIndex = 3;
            this.PassField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassField.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PassField.UseSelectable = true;
            this.PassField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PassField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PassField.TextChanged += new System.EventHandler(this.LoginField_TextChanged);
            // 
            // butSignIn
            // 
            this.butSignIn.ActiveControl = null;
            this.butSignIn.Location = new System.Drawing.Point(72, 215);
            this.butSignIn.Name = "butSignIn";
            this.butSignIn.Size = new System.Drawing.Size(101, 30);
            this.butSignIn.Style = MetroFramework.MetroColorStyle.Pink;
            this.butSignIn.TabIndex = 4;
            this.butSignIn.Text = "SIGN IN";
            this.butSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butSignIn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.butSignIn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.butSignIn.UseSelectable = true;
            this.butSignIn.Click += new System.EventHandler(this.butSignIn_Click);
            // 
            // butQiut
            // 
            this.butQiut.ActiveControl = null;
            this.butQiut.Location = new System.Drawing.Point(288, 215);
            this.butQiut.Name = "butQiut";
            this.butQiut.Size = new System.Drawing.Size(101, 30);
            this.butQiut.Style = MetroFramework.MetroColorStyle.Pink;
            this.butQiut.TabIndex = 5;
            this.butQiut.Text = "QUIT";
            this.butQiut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butQiut.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.butQiut.UseSelectable = true;
            this.butQiut.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(185, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "TRY AGAIN";
            this.label1.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butQiut);
            this.Controls.Add(this.butSignIn);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Sign In";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox LoginField;
        private MetroFramework.Controls.MetroTextBox PassField;
        private MetroFramework.Controls.MetroTile butSignIn;
        private MetroFramework.Controls.MetroTile butQiut;
        private System.Windows.Forms.Label label1;
    }
}