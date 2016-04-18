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
            this.Controls.Clear();
            InitializeComponent();
            this.ActiveControl = null;
            string s = dbContext.Database.Connection.ConnectionString;
            var builder = new FbConnectionStringBuilder(s);
            builder.UserID = "it39";
            builder.Password = "it39";

            dbContext.Database.Connection.ConnectionString = builder.ConnectionString;
            dbContext.Database.Connection.Open();
        }


        private void metroTrackBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            AmountField.Text = AmountTrack.Value.ToString();
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
            if (v > AmountTrack.Maximum)
                AmountTrack.Value = AmountTrack.Maximum;
            else
                AmountTrack.Value = v;
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
            r_AgToWh.Checked = false;
            r_WhToAg.Checked = false;
            reset();
        }

        private void metroTextBox1_Leave(object sender, System.EventArgs e)
        {
            if (System.Convert.ToInt32(AmountField.Text) > AmountTrack.Maximum)
                AmountField.Text = AmountTrack.Maximum.ToString();
        }

        private void metroRadioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            reset();

            if (r_AgToWh.Checked)
            {
                var customers =
                   from agent in dbContext.AGENTs
                   orderby agent.NAME_AG
                   select agent;
                List<AGENT> a = customers.ToList();
                ListFrom.Items.Clear();
                for (int i = 0; i < a.Count; ++i)
                    ListFrom.Items.Add(a[i].NAME_AG);

                var whs =
                    from warehouse in dbContext.WAREHOUSEs
                    orderby warehouse.NAIMEN
                    select warehouse;
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
                    from agent in dbContext.AGENTs
                    orderby agent.NAME_AG
                    select agent;
                List<AGENT> a = customers.ToList();
                ListTo.Items.Clear();
                for (int i = 0; i < a.Count; ++i)
                    ListTo.Items.Add(a[i].NAME_AG);

                var whs =
                    from warehouse in dbContext.WAREHOUSEs
                    orderby warehouse.NAIMEN
                    select warehouse;
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
            ItemList.Enabled = true;

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
                ItemList.Items.Clear();
                while (reader.Read())
                    ItemList.Items.Add(reader.GetValue(0).ToString());
                Connection.Close();
            }

            if (r_AgToWh.Checked) {
                var items =
                    from item in dbContext.TOVARs
                    orderby item.NOMENCLATURE
                    select item;
                List<TOVAR> b = items.ToList();
                ItemList.Items.Clear();
                for (int i = 0; i < b.Count; ++i)
                    ItemList.Items.Add(b[i].NOMENCLATURE);
            }

        } 
        

        private void butQuit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void checkDelivery_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkDelivery.Checked)
                TimeList.Enabled = true;
            else
                TimeList.Enabled = false;

        }


        private void reset() {
            ListFrom.Items.Clear();
            ListTo.Items.Clear();
            ItemList.Items.Clear();
            AmountTrack.Value = 0;
            AmountField.Text = "0";
            PriseField.Text = "0";
            DateTime.Value = System.DateTime.Now;
            checkDelivery.Checked = false;
        }

        private void ItemList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            AmountField.Text = "0";
            AmountTrack.Value = 0;

            if (r_AgToWh.Checked)
                AmountTrack.Maximum = 500;
            if (r_WhToAg.Checked) {
                FbParameter parm1 = new FbParameter("Warehouse", FbDbType.Char);
                FbParameter parm2 = new FbParameter("Item", FbDbType.Char);
                parm1.Value = ListFrom.SelectedItem.ToString();
                parm2.Value = ItemList.SelectedItem.ToString();
                Connection = new FbConnection(dbContext.Database.Connection.ConnectionString);
                Connection.Open();

                FbCommand cmd = new FbCommand("AMOUNT_ITEM_WH", Connection);
                cmd.CommandText = "AMOUNT_ITEM_WH";
                cmd.Parameters.Add(parm1);
                cmd.Parameters.Add(parm2);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                   AmountTrack.Maximum = System.Convert.ToInt32(reader.GetValue(0).ToString());
                Connection.Close();
            }
        }
    }
}
