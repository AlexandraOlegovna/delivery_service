using MetroFramework.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Linq;


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

            var customers =
                from customer in dbContext.AGENTs
                orderby customer.NAME_AG
                select customer;
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

        private void metroTrackBar2_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            metroTextBox2.Text = metroTrackBar2.Value.ToString();
        }

        private bool NotContainSymbols(string s)
        {
            foreach(char c in s)
            {
                if (!"0123456789".Contains(c.ToString()))
                    return false;
            }
            return true;
        }

        private void textbox_Handler(MetroFramework.Controls.MetroTextBox mtxtbx, MetroFramework.Controls.MetroTrackBar mtrckbr)
        {
            if (!NotContainSymbols(mtxtbx.Text))
                mtxtbx.Text = mtxtbx.Text.Substring(0, mtxtbx.Text.Length - 1);
            if (mtxtbx.Text == "")
                mtxtbx.Text = "0";
            mtxtbx.Select(mtxtbx.Text.Length, 0);
            int v = System.Convert.ToInt32(mtxtbx.Text);
            if (v > mtrckbr.Maximum)
                mtrckbr.Value = mtrckbr.Maximum;
            else
                mtrckbr.Value = v;
        }

        private void metroTextBox1_TextChanged(object sender, System.EventArgs e)
        {
            textbox_Handler(metroTextBox1, metroTrackBar1);
            //if (!NotContainSymbols(metroTextBox1.Text))
            //    metroTextBox1.Text = metroTextBox1.Text.Substring(0, metroTextBox1.Text.Length - 1);
            //if (metroTextBox1.Text == "")
            //    metroTextBox1.Text = "0";
            //metroTextBox1.Select(metroTextBox1.Text.Length, 0);
            //int v = System.Convert.ToInt32(metroTextBox1.Text);
            //if (v > metroTrackBar1.Maximum)
            //    metroTrackBar1.Value = metroTrackBar1.Maximum;
            //else
            //    metroTrackBar1.Value = v;
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
            textbox_Handler(metroTextBox2, metroTrackBar2);
        }

        private void S(object sender, System.EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, System.EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }
    }
}
