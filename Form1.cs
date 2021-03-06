﻿using MetroFramework.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;

namespace Delivery
{
    public partial class Form1 : MetroForm
    {

        Model3 dbContext = new Model3();
        FbConnection Connection;
        List<string> Agents = new List<string>();
        List<string> Warehouses = new List<string>();
        List<string> Items = new List<string>();
        SortedDictionary<string, int> ItemsVolume = new SortedDictionary<string, int>();
        string num_auto = "";

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

            var agents =
                   from agent in dbContext.AGENTs
                   orderby agent.NAME_AG
                   select agent;
            List<AGENT> a = agents.ToList();
            for (int i = 0; i < a.Count; ++i)
                Agents.Add(a[i].NAME_AG);

            var whs =
                    from warehouse in dbContext.WAREHOUSEs
                    orderby warehouse.NAIMEN
                    select warehouse;
            List<WAREHOUSE> b = whs.ToList();
            for (int i = 0; i < b.Count; ++i)
                Warehouses.Add(b[i].NAIMEN);

            var items =
                    from item in dbContext.TOVARs
                    orderby item.NOMENCLATURE
                    select item;
            List<TOVAR> t = items.ToList();
            for (int i = 0; i < t.Count; ++i)
            {
                Items.Add(t[i].NOMENCLATURE);
                ItemsVolume.Add(t[i].NOMENCLATURE, t[i].VOLUME);
        }
    }  

        private void metroTrackBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            AmountField.Text = AmountTrack.Value.ToString();
            TimeList.SelectedItem = null;
            resultVehicle.Visible = false;
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

            TimeList.SelectedItem = null;
            resultVehicle.Visible = false;
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
                ListFrom.Items.Clear();
                for (int i = 0; i < Agents.Count; ++i)
                    ListFrom.Items.Add(Agents[i]);

                ListTo.Items.Clear();
                for (int i = 0; i < Warehouses.Count; ++i)
                    ListTo.Items.Add(Warehouses[i]);

                ListFrom.Enabled = true;
                ListTo.Enabled = true;
                butApply.Enabled = true;
                butReset1.Enabled = true;
            }
            
        }

        private void metroRadioButton2_CheckedChanged(object sender, System.EventArgs e)
        {
            if (r_WhToAg.Checked)
            {
                reset();

                ListTo.Items.Clear();
                for (int i = 0; i < Agents.Count; ++i)
                    ListTo.Items.Add(Agents[i]);

                ListFrom.Items.Clear();
                for (int i = 0; i < Warehouses.Count; ++i)
                    ListFrom.Items.Add(Warehouses[i]);

                ListFrom.Enabled = true;
                ListTo.Enabled = true;
                butApply.Enabled = true;
                butReset1.Enabled = true;
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
                ItemList.Items.Clear();
                while (reader.Read())
                    ItemList.Items.Add(reader.GetValue(0).ToString());
                Connection.Close();
            }

            if (r_AgToWh.Checked) {
                ItemList.Items.Clear();
                for (int i = 0; i < Items.Count; ++i)
                    ItemList.Items.Add(Items[i]);

            }

            ItemList.Enabled = true;

        } 
        
        private void butQuit_Click(object sender, System.EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void checkDelivery_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkDelivery.Checked)
                TimeList.Enabled = true;
            else
                TimeList.Enabled = false;

        }

        private void reset() {
            ItemList.Enabled = true;
            ListFrom.Enabled = true;
            ListTo.Enabled = true;
            AmountField.Enabled = false;
            PriseField.Enabled = false;
            DateTime.Enabled = false;
            ListFrom.Items.Clear();
            ListTo.Items.Clear();
            ItemList.Items.Clear();
            ListFrom.Enabled = false;
            ListTo.Enabled = false;
            ItemList.Enabled = false;
            AmountTrack.Value = 1;
            AmountField.Text = "1";
            PriseField.Text = "0";
            DateTime.Value = System.DateTime.Now;
            checkDelivery.Checked = false;
            resultVehicle.Visible = false;
            ResultLabel.Visible = false;
            butApply.Enabled = false;
            butReset1.Enabled = false;
            num_auto = "";
        }

        private void ItemList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            AmountField.Enabled = true;
            AmountTrack.Enabled = true;
            AmountField.Text = "1";
            AmountTrack.Value = 1;
            PriseField.Enabled = true;
            DateTime.Enabled = true;


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
                reader.Read();
                AmountTrack.Maximum = System.Convert.ToInt32(reader.GetValue(0).ToString());
                Connection.Close();
            }
        }

        private void TimeList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            num_auto = "";
            if ((TimeList.SelectedItem != null) && (ItemList.SelectedItem != null))
            {

                FbParameter parm1 = new FbParameter("Volume", FbDbType.Integer);
                FbParameter parm2 = new FbParameter("Date", FbDbType.Date);
                FbParameter parm3 = new FbParameter("Time", FbDbType.Time);
                parm1.Value = ItemsVolume[ItemList.SelectedItem.ToString()] * System.Convert.ToInt32(AmountField.Text);
                parm2.Value = DateTime.Value.Date;

                parm3.Value = System.TimeSpan.Parse(TimeList.SelectedItem.ToString()); //new System.TimeSpan(System.Convert.ToInt32(tmp.Remove(tmp.IndexOf(':'))), 0, 0);
                Connection = new FbConnection(dbContext.Database.Connection.ConnectionString);
                Connection.Open();

                FbCommand cmd = new FbCommand("CHOOSE_VEHICLE", Connection);
                cmd.CommandText = "CHOOSE_VEHICLE";
                cmd.Parameters.Add(parm2);
                cmd.Parameters.Add(parm3);
                cmd.Parameters.Add(parm1);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                var reader = cmd.ExecuteReader();
                reader.Read();
                string result;
                try
                {
                    result = reader.GetValue(0).ToString();
                }
                catch
                {
                    result = "null";
                }
                resultVehicle.Visible = true;
                resultVehicle.Text = "";
                if (result == "null")
                {
                    resultVehicle.ForeColor = Color.Red;
                    resultVehicle.Text = "FAIL";
                }
                else
                {
                    num_auto = result;
                    resultVehicle.ForeColor = Color.Green;
                    resultVehicle.Text = "OK";
                }
                Connection.Close();  
            }
        }

        private void r_AgToWh_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            int thickness = 1;//it's up to you
            int halfThickness = thickness / 2;
            using (System.Drawing.Pen p = new Pen(Color.FromArgb(231, 113, 189), thickness))
            {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                          halfThickness,
                                                          panel1.ClientSize.Width - thickness,
                                                          panel1.ClientSize.Height - thickness));

            }
        }

        private void DateTime_ValueChanged(object sender, System.EventArgs e)
        {
            TimeList.SelectedItem = null;
            resultVehicle.Visible = false;
        }

        private void butApply_Click(object sender, System.EventArgs e)
        {
            string Type_OP = "";
            if (r_AgToWh.Checked)
                Type_OP = "R";
            if (r_WhToAg.Checked)
                Type_OP = "A";

            var From = ListFrom.SelectedItem;
            var To = ListTo.SelectedItem;
            var Item = ItemList.SelectedItem;

            if ((Type_OP != "") && (From != null) && (To != null) && (Item != null) && (((checkDelivery.Checked) && (num_auto != "")) || (!checkDelivery.Checked)))
            {
                int Amount = System.Convert.ToInt32(AmountField.Text);
                int Prise = System.Convert.ToInt32(PriseField.Text);
                System.TimeSpan Del_time;
                if (TimeList.SelectedItem == null)
                    Del_time = new System.TimeSpan(0, 0, 0);
                else
                    Del_time = System.TimeSpan.Parse(TimeList.SelectedItem.ToString());
                System.DateTime Del_Date = DateTime.Value.Date;


                FbParameter GOODS = new FbParameter("GOODS", FbDbType.Char);
                FbParameter AMOUNT = new FbParameter("AMOUNT", FbDbType.Integer);
                FbParameter AGENT_NAME = new FbParameter("AGENT_NAME", FbDbType.Char);
                FbParameter WH_NAME = new FbParameter("WH_NAME", FbDbType.Char);
                FbParameter TYPE_OP = new FbParameter("TYPE_OP", FbDbType.Char);
                FbParameter PRICE = new FbParameter("PRICE", FbDbType.Integer);
                FbParameter DEL_TIME = new FbParameter("DEL_TIME", FbDbType.Time);
                FbParameter DEL_DATE = new FbParameter("DEL_DATE", FbDbType.Date);
                FbParameter DELIV = new FbParameter("DELIV", FbDbType.Char);
                GOODS.Value = Item;
                AMOUNT.Value = Amount;
                if (r_AgToWh.Checked)
                {
                    AGENT_NAME.Value = From.ToString();
                    WH_NAME.Value = To.ToString();
                }
                if (r_WhToAg.Checked)
                {
                    AGENT_NAME.Value = To.ToString();
                    WH_NAME.Value = From.ToString();
                }
                PRICE.Value = Prise;
                DEL_TIME.Value = Del_time;
                DEL_DATE.Value = Del_Date;
                if (checkDelivery.Checked)
                    DELIV.Value = 'Y';
                else DELIV.Value = 'N';
                TYPE_OP.Value = Type_OP[0];

                Connection = new FbConnection(dbContext.Database.Connection.ConnectionString);
                Connection.Open();

                dbContext.Database.ExecuteSqlCommand("EXECUTE PROCEDURE ADD_ORDER(@GOODS, @AMOUNT, @AGENT_NAME, @WH_NAME, @TYPE_OP, @PRICE, @DEL_TIME, @DEL_DATE, @DELIV)", GOODS, AMOUNT, AGENT_NAME, WH_NAME, TYPE_OP, PRICE, DEL_TIME, DEL_DATE, DELIV);

                string tmp = num_auto;
                metroTile2_Click(null, null);

                ResultLabel.Visible = true;
                ResultLabel.ForeColor = Color.Green;
                ResultLabel.Text = "Your order has been successfully submitted. ";
                if (tmp != "")
                    ResultLabel.Text += ("Vehicle №" + tmp);
               
            }

            else
            {
                ResultLabel.Visible = true;
                ResultLabel.ForeColor = Color.Red;
                ResultLabel.Text = "Your order has not been submitted. Correct fields and try again.";
            }


        }
    }
}
