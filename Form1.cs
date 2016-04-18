using MetroFramework.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Delivery
{
    public partial class Form1 : MetroForm
    {

        Model3 dbContext = new Model3();
        FbConnection Connection;

        public Form1()
        {
            InitializeComponent();
            string s = dbContext.Database.Connection.ConnectionString;
            var builder = new FbConnectionStringBuilder(s);
            builder.UserID = "it39";
            builder.Password = "it39";

            dbContext.Database.Connection.ConnectionString = builder.ConnectionString;
            //Connection = new FbConnection(dbContext.Database.Connection.ConnectionString);
            dbContext.Database.Connection.Open();
            //Connection.Open();

            //InitializeComponent();
            //string s = dbContext.Database.Connection.ConnectionString;
            //var builder = new FbConnectionStringBuilder(s);
            //builder.UserID = "it39";
            //builder.Password = "it39";

            //dbContext.Database.Connection.ConnectionString = builder.ConnectionString;

            //// пробуем подключится
            //dbContext.Database.Connection.Open();
        }


        private void metroCheckBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (metroCheckBox1.Checked)
            {
                TimeList.Enabled = true;
            }
            else
            {
                TimeList.Enabled = false;
            }
        }

        private void metroTrackBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            AmountField.Text = metroTrackBar1.Value.ToString();
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
            if (!NotContainSymbols(AmountField.Text))
                AmountField.Text = AmountField.Text.Substring(0, AmountField.Text.Length - 1);
            if (AmountField.Text == "")
                AmountField.Text = "0";
            AmountField.Select(AmountField.Text.Length, 0);
            int v = System.Convert.ToInt32(AmountField.Text);
            if (v > metroTrackBar1.Maximum)
                metroTrackBar1.Value = metroTrackBar1.Maximum;
            else
                metroTrackBar1.Value = v;
        }

        private void metroTextBox1_Click(object sender, System.EventArgs e)
        {
            AmountField.SelectAll();
        }

        private void metroTextBox2_Click(object sender, System.EventArgs e)
        {
            PriseField.SelectAll();
        }

        private void metroTextBox2_TextChanged(object sender, System.EventArgs e)
        {
            if (!NotContainSymbols(AmountField.Text))
                AmountField.Text = AmountField.Text.Substring(0, AmountField.Text.Length - 1);
            if (AmountField.Text == "")
                AmountField.Text = "0";
            AmountField.Select(AmountField.Text.Length, 0);
        }

        private void metroTile2_Click(object sender, System.EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void metroTextBox1_Leave(object sender, System.EventArgs e)
        {
            if (System.Convert.ToInt32(AmountField.Text) > metroTrackBar1.Maximum)
                AmountField.Text = metroTrackBar1.Maximum.ToString();
        }

        private void metroRadioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (r_AgToWh.Checked)
            {
                var customers =
                   from customer in dbContext.AGENTs
                   orderby customer.NAME_AG
                   select customer;
                List<AGENT> a = customers.ToList();
                ListFrom.Items.Clear();
                for (int i = 0; i < a.Count; ++i)
                    ListFrom.Items.Add(a[i].NAME_AG);

                var whs =
                    from customer in dbContext.WAREHOUSEs
                    orderby customer.NAIMEN
                    select customer;
                List<WAREHOUSE> b = whs.ToList();
                ListTo.Items.Clear();
                for (int i = 0; i < b.Count; ++i)
                    ListTo.Items.Add(b[i].NAIMEN);

                ListFrom.Enabled = true;
                ListTo.Enabled = true;
            }
            
        }

        private void metroRadioButton2_CheckedChanged(object sender, System.EventArgs e)
        {
            if (r_WhToAg.Checked)
            {
                var customers =
                                from customer in dbContext.AGENTs
                                orderby customer.NAME_AG
                                select customer;
                List<AGENT> a = customers.ToList();
                ListTo.Items.Clear();
                for (int i = 0; i < a.Count; ++i)
                    ListTo.Items.Add(a[i].NAME_AG);

                var whs =
                    from customer in dbContext.WAREHOUSEs
                    orderby customer.NAIMEN
                    select customer;
                List<WAREHOUSE> b = whs.ToList();
                ListFrom.Items.Clear();
                for (int i = 0; i < b.Count; ++i)
                    ListFrom.Items.Add(b[i].NAIMEN);

                ListFrom.Enabled = true;
                ListTo.Enabled = true;
            }
        
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (r_WhToAg.Checked)
            {
                FbParameter parm = new FbParameter("Warehouse", FbDbType.Char);
                parm.Value = ListFrom.SelectedItem.ToString();

                Connection = new FbConnection(dbContext.Database.Connection.ConnectionString);
                Connection.Open();

                FbCommand cmd = new FbCommand("ITEMS_NAMES_WH", Connection);
                cmd.CommandText = "ITEMS_NAMES_WH";
                cmd.Parameters.Add(parm);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                var reader = cmd.ExecuteReader();
                ItemList.Enabled = true;
                ItemList.Items.Clear();
                while (reader.Read())
                    ItemList.Items.Add(reader.GetValue(0).ToString());


                

            }
        }

        private void metroComboBox4_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
        }

        private void butQuit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
