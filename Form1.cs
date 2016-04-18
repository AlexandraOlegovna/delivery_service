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

        public Form1()
        {
            InitializeComponent();
            string s = dbContext.Database.Connection.ConnectionString;
            var builder = new FbConnectionStringBuilder(s);
            builder.UserID = "it39";
            builder.Password = "it39";

            dbContext.Database.Connection.ConnectionString = builder.ConnectionString;

            // пробуем подключится
            dbContext.Database.Connection.Open();

            //var custs = dbContext.AGENTs.Local;
            //string ss = custs.ToString();
            //bindingSource = new System.Windows.Forms.BindingSource();
            //bindingSource.DataSource = customers.ToBindingList();


            //for (int i = 0; i < a.Count; ++i)
            //    textBox1.Text += a[i].NOMENCLATURE.Replace(" ", string.Empty);
            bool b = true;
        }

        private string Win1251ToUTF8(string source)
        {

            //Encoding ascii = Encoding.GetEncoding("windows-1251");
            //Encoding unicode = Encoding.Unicode;

            //// Convert the string into a byte array.
            //byte[] asciiBytes = ascii.GetBytes(source);

            //// Perform the conversion from one encoding to the other.
            //byte[] unicodeBytes = Encoding.Convert(ascii, unicode, asciiBytes);

            //// Convert the new byte[] into a char[] and then into a string.
            //char[] unicodeChars = new char[unicode.GetCharCount(unicodeBytes, 0, unicodeBytes.Length)];
            //unicode.GetChars(unicodeBytes, 0, unicodeBytes.Length, unicodeChars, 0);
            //string unicodeString = new string(unicodeChars);
            //return unicodeString;

            //Encoding utf8 = Encoding.Unicode;
            //Encoding win1251 = Encoding.GetEncoding("windows-1251");

            //byte[] utf8Bytes = win1251.GetBytes(source);
            //byte[] win1251Bytes = Encoding.Convert(win1251, utf8, utf8Bytes);
            //source = utf8.GetString(win1251Bytes);
            //return source;

            try
            {
                Encoding fromEncoding = System.Text.Encoding.GetEncoding("koi8-r");
                Encoding toEncoding = System.Text.Encoding.GetEncoding("windows-1251");
                byte[] toEncodeAsBytes = fromEncoding.GetBytes(source);
                string returnValue = fromEncoding.GetString(System.Text.Encoding.Convert(fromEncoding, toEncoding, toEncodeAsBytes));
                return returnValue;
            }
            catch
            {
                return "Ошибка декодирования";
            }

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
            if (r_AgToWh.Checked)
            {

                //FbParameter parm = new FbParameter()
                //{
                //    FbDbType = FbDbType.VarChar,
                //    Direction = System.Data.ParameterDirection.Output
                //};

                //dbContext.Database.ExecuteSqlCommand("EXECUTE PROCEDURE ITEM_NAMES", parm);

                //var p = parm.SourceColumn;
                //textBox1.Text = parm.Value.ToString();
                //var goods = new FbParameter("GOODS", FbDbType.Char);
                //dbContext.Database.ExecuteSqlCommand(
                //     "EXECUTE PROCEDURE ITEM_NAMES");
                //textBox1.Text = goods.Value.ToString();

            }
        }

        private void metroComboBox4_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
        }
    }
}
