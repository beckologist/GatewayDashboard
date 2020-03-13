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
            EDPortTextBox1.Text = Properties.Settings.Default.EDPort;
        }

        private void EDUsernameTextBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EDUsername = EDUsernameTextBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void EDPasswordTextBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EDPassword = EDPasswordTextBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void EDIPTextBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EDIPAddress = EDIPTextBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void EDPortTextBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EDPort = EDPortTextBox1.Text;
            Properties.Settings.Default.Save();
        }

    }
}
