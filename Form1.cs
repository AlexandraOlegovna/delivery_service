using MetroFramework.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Delivery
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            Model1 dbContext = new Model1();
            string s = dbContext.Database.Connection.ConnectionString;
            var builder = new FbConnectionStringBuilder(s);
            builder.UserID = "it39";
            builder.Password = "it39";

            dbContext.Database.Connection.ConnectionString = builder.ConnectionString;

            // пробуем подключится
            dbContext.Database.Connection.Open();
        }

        private void metroCheckBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (metroCheckBox1.Checked)
            {
                metroComboBox3.Enabled = true;
            }
            else
            {
                metroComboBox3.Enabled = false;
            }
        }

        private void metroTrackBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            metroTextBox1.Text = metroTrackBar1.Value.ToString();
        }


        private bool NotContainSymbols(string s)
        {
            foreach (char c in s)
            {
                if (!"0123456789".Contains(c.ToString()))
                    return false;
            }
            return true;
        }

        private void metroTextBox1_TextChanged(object sender, System.EventArgs e)
        {
            if (!NotContainSymbols(metroTextBox1.Text))
                metroTextBox1.Text = metroTextBox1.Text.Substring(0, metroTextBox1.Text.Length - 1);
            if (metroTextBox1.Text == "")
                metroTextBox1.Text = "0";
            metroTextBox1.Select(metroTextBox1.Text.Length, 0);
            int v = System.Convert.ToInt32(metroTextBox1.Text);
            if (v > metroTrackBar1.Maximum)
                metroTrackBar1.Value = metroTrackBar1.Maximum;
            else
                metroTrackBar1.Value = v;
        }

        private void metroTextBox1_Click(object sender, System.EventArgs e)
        {
            metroTextBox1.SelectAll();
        }

        private void metroTextBox2_Click(object sender, System.EventArgs e)
        {
            metroTextBox2.SelectAll();
        }

        private void metroTextBox2_TextChanged(object sender, System.EventArgs e)
        {
            if (!NotContainSymbols(metroTextBox1.Text))
                metroTextBox1.Text = metroTextBox1.Text.Substring(0, metroTextBox1.Text.Length - 1);
            if (metroTextBox1.Text == "")
                metroTextBox1.Text = "0";
            metroTextBox1.Select(metroTextBox1.Text.Length, 0);
        }

        private void metroTile2_Click(object sender, System.EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void metroTextBox1_Leave(object sender, System.EventArgs e)
        {
            if (System.Convert.ToInt32(metroTextBox1.Text) > metroTrackBar1.Maximum)
                metroTextBox1.Text = metroTrackBar1.Maximum.ToString();
        }
    }
}
