using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamplingStartStop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            EDUsernameTextBox1.Text = Properties.Settings.Default.EDUsername;
            EDPasswordTextBox1.Text = Properties.Settings.Default.EDPassword;
            EDIPTextBox1.Text = Properties.Settings.Default.EDIPAddress;
            EDPortTextBox1.Text = Properties.Settings.Default.EDPort.ToString();

            APIKey.Text = Properties.Settings.Default.APIKey;
            BaseURL.Text = Properties.Settings.Default.BaseURL;

            CheckBox1.Checked = Properties.Settings.Default.RadioButton1;
            CheckBox2.Checked = Properties.Settings.Default.RadioButton2;
            CheckBox3.Checked = Properties.Settings.Default.RadioButton3;
            CheckBox4.Checked = Properties.Settings.Default.RadioButton4;
            CheckBox5.Checked = Properties.Settings.Default.RadioButton5;
            CheckBox6.Checked = Properties.Settings.Default.RadioButton6;
            CheckBox7.Checked = Properties.Settings.Default.RadioButton7;
            CheckBox8.Checked = Properties.Settings.Default.RadioButton8;

            BrokerAPIKeyTextBox1.Text = Properties.Settings.Default.BrokerAPIKey;
            BrokerIPTextBox1.Text = Properties.Settings.Default.BrokerIPAddress;
            BrokerPortTextBox1.Text = Properties.Settings.Default.BrokerPort.ToString();
        }

        private void APIKey_TextChanged_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.APIKey = APIKey.Text;
            Properties.Settings.Default.Save();
        }

        private void BaseURL_TextChanged_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.BaseURL = BaseURL.Text;
            Properties.Settings.Default.Save();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RadioButton1 = CheckBox1.Checked;
            Properties.Settings.Default.Save();
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RadioButton2 = CheckBox2.Checked;
            Properties.Settings.Default.Save();
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RadioButton3 = CheckBox3.Checked;
            Properties.Settings.Default.Save();
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RadioButton4 = CheckBox4.Checked;
            Properties.Settings.Default.Save();
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RadioButton5 = CheckBox5.Checked;
            Properties.Settings.Default.Save();
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RadioButton6 = CheckBox6.Checked;
            Properties.Settings.Default.Save();
        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RadioButton7 = CheckBox7.Checked;
            Properties.Settings.Default.Save();
        }

        private void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RadioButton8 = CheckBox8.Checked;
            Properties.Settings.Default.Save();
        }

        private void BrokerAPIKeyTextBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.BrokerAPIKey = BrokerAPIKeyTextBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void BrokerIPTextBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.BrokerIPAddress = BrokerIPTextBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void BrokerPortTextBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.BrokerPort = Int32.Parse(BrokerPortTextBox1.Text);
            Properties.Settings.Default.Save();
        }

        private void EDPasswordTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.EDPassword = EDPasswordTextBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void EDIPTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.EDIPAddress = EDIPTextBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void EDPortTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.EDPort = Int32.Parse(EDPortTextBox1.Text);
            Properties.Settings.Default.Save();
        }

        private void EDUsernameTextBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EDUsername = EDUsernameTextBox1.Text;
            Properties.Settings.Default.Save();
        }
    }
}
