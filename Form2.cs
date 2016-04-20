using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Delivery
{
    public partial class Form2 : MetroForm
    {

        private Form1 form1 = new Form1();

        public Form2()
        {
            InitializeComponent();
            this.ActiveControl = null;
            LoginField.Select();
            PassField.UseSystemPasswordChar = true;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butSignIn_Click(object sender, EventArgs e)
        {
            if (LoginField.Text == "it39" && PassField.Text == "it39")
                AddOwnedForm(form1); 
            else
            {
                label1.ForeColor = Color.FromArgb(231, 113, 189);
                label1.Visible = true;
            }
        }

        private void LoginField_TextChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }
}
