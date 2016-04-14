using MetroFramework.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Linq;
using System.Text;
using System.Collections.Generic;


namespace Delivery
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            Model3 dbContext = new Model3();
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
            var custs = dbContext.AGENTs.Local;
            string ss = custs.ToString();
            bindingSource = new System.Windows.Forms.BindingSource();
            List<AGENT> a = customers.ToList();
            //bindingSource.DataSource = customers.ToBindingList();
            metroComboBox1.Items.Clear();
            for (int i = 0; i < a.Count; ++i)
                metroComboBox1.Items.Add(a[i].NAME_AG.Replace(" ", string.Empty));

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
    }
}
