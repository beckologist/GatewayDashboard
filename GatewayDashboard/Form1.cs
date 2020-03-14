using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using System.Threading;
using System.Messaging;
using System.Net.Http;
using System.Net.Http.Headers;
using RestSharp;
using SamplingStartStop.Properties;

namespace SamplingStartStop
{
    public partial class Form1 : Form
    {
        // Connection info for Raspberry PI
        //static string theUser = "pi";
        static string theUser = Properties.Settings.Default.EDUsername;
        //static string thePass = "raspberry";
        static string thePass = Properties.Settings.Default.EDPassword;
        //static string theHost = "10.5.37.222";
        static string theHost = Properties.Settings.Default.EDIPAddress;
        //static int thePort = 5800;
        static int thePort = Properties.Settings.Default.EDPort;

        // Constants for working with MSMQ
        static string theInboundPath = @".\private$\IOTData";
        static string theNotificationsPath = @".\private$\IOTNotifications";
        MessageQueue theInboundMessageQueue = new MessageQueue(theInboundPath);
        MessageQueue theNotificationsMessageQueue = new MessageQueue(theNotificationsPath);

        // Flag to continue sending to Thingworx
        static Boolean theContinueSendingFlag = true;


        public Form1()
        {
            InitializeComponent();


        }

        // Sampling start button click.  
        private void SamplingStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a background process
                BackgroundWorker myBG = new BackgroundWorker();
                myBG.DoWork += new DoWorkEventHandler(MyBG_DoWork);
                myBG.RunWorkerCompleted += new RunWorkerCompletedEventHandler(MyBG_RunWorkerCompleted);
                myBG.RunWorkerAsync();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:: " + exception.Message);
            }

        }

        // This gets called when the background job completes
        private void MyBG_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                // Call routine to set UI buttons/text to stopped state
                StoppedSettings();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:: " + exception.Message);
            }
        }

        // This is the routine that does the work for the background process
        private void MyBG_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                // Call routine to set UI buttons/text to started state
                StartedSettings();

                //Set up the SSH connection
                var myClient = new SshClient(theHost, thePort, theUser, thePass);
                labelSamplingStatus.Text = "Connecting";
                labelSamplingStatus.ForeColor = System.Drawing.Color.Orange;
                myClient.Connect();
                //var output = client.RunCommand("./Documents/HelloIP/StartTest");
                //var output = client.RunCommand("pwd");
                //MessageBox.Show(output.Result);
                // Call routine to set UI buttons/text to started state
                StartedSettings();

                // Set the CAN interface buffer size
                myClient.RunCommand("sudo ifconfig can0 txqueuelen 100000");

                // Build Command String with ars
                string myCommand = "./sample.sh";

                myCommand = myCommand + " " + Properties.Settings.Default.BrokerIPAddress;
                myCommand = myCommand + " " + Properties.Settings.Default.BrokerPort;
                myCommand = myCommand + " " + Properties.Settings.Default.BrokerAPIKey;

                if (Properties.Settings.Default.RadioButton1)
                {
                    myCommand = myCommand + " 1";
                }

                if (Properties.Settings.Default.RadioButton2)
                {
                    myCommand = myCommand + " 2";
                }

                if (Properties.Settings.Default.RadioButton3)
                {
                    myCommand = myCommand + " 3";
                }

                if (Properties.Settings.Default.RadioButton4)
                {
                    myCommand = myCommand + " 4";
                }

                if (Properties.Settings.Default.RadioButton5)
                {
                    myCommand = myCommand + " 5";
                }

                if (Properties.Settings.Default.RadioButton6)
                {
                    myCommand = myCommand + " 6";
                }

                if (Properties.Settings.Default.RadioButton7)
                {
                    myCommand = myCommand + " 7";
                }

                if (Properties.Settings.Default.RadioButton8)
                {
                    myCommand = myCommand + " 8";
                }
                //MessageBox.Show(myCommand);

                // Run the command on the PI to start sampling
                myClient.RunCommand(myCommand);
                myClient.Disconnect();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:: " + exception.Message);
            }
        }

        // Set Sampling UI buttons and text to started state
        private void StartedSettings()
        {
            try
            {
                SamplingStart.Enabled = false;
                SamplingStop.Enabled = true;
                labelSamplingStatus.Text = "Started";
                labelSamplingStatus.ForeColor = System.Drawing.Color.Green;
                settingsToolStripMenuItem.Enabled = false;
            }
            catch (Exception myException)
            {
                MessageBox.Show("Error:: " + myException.Message);
            }
        }

        // Set Thingworx send UI buttons and text to started state
        private void StartedSettingsSend()
        {
            try
            {
                ThingworxUploadStart.Enabled = false;
                ThingworxUploadStop.Enabled = true;
                labelUploadStatus.Text = "Started";
                labelUploadStatus.ForeColor = System.Drawing.Color.Green;
                settingsToolStripMenuItem.Enabled = false;
            }
            catch (Exception myException)
            {
                MessageBox.Show("Error:: " + myException.Message);
            }
        }


        // Set UI buttons and text to stopped state
        private void StoppedSettings()
        {
            try
            {
                SamplingStart.Enabled = true;
                SamplingStop.Enabled = false;
                labelSamplingStatus.Text = "Stopped";
                labelSamplingStatus.ForeColor = System.Drawing.Color.Red;
                settingsToolStripMenuItem.Enabled = true;
            }
            catch (Exception myException)
            {
                MessageBox.Show("Error:: " + myException.Message);
            }
        }

        // Set Thingworx send UI buttons and text to stopped state
        private void StoppedSettingsSend()
        {
            try
            {
                ThingworxUploadStart.Enabled = true;
                ThingworxUploadStop.Enabled = false;
                labelUploadStatus.Text = "Stopped";
                labelUploadStatus.ForeColor = System.Drawing.Color.Red;
                settingsToolStripMenuItem.Enabled = true;
            }
            catch (Exception myException)
            {
                MessageBox.Show("Error:: " + myException.Message);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Initialize UI buttons and text to stopped state
                StoppedSettings();
                StoppedSettingsSend();

                // Allow visability of variables between main 
                //and background process.
                CheckForIllegalCrossThreadCalls = false;

                // Create a background process to update queue diagnostics
                BackgroundWorker myBGQueueDiagnostics = new BackgroundWorker();
                myBGQueueDiagnostics.DoWork += new DoWorkEventHandler(MyBGQueueDiagnostics_DoWork);
                myBGQueueDiagnostics.RunWorkerCompleted += new RunWorkerCompletedEventHandler(MyBGQueueDiagnostics_RunWorkerCompleted);
                myBGQueueDiagnostics.RunWorkerAsync();
            }
            catch (Exception myException)
            {
                MessageBox.Show("Error:: " + myException.Message);
            }
        }

        // This gets called when the background job completes
        private void MyBGQueueDiagnostics_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        // This is the routine that does the work for the background process
        private void MyBGQueueDiagnostics_DoWork(object sender, DoWorkEventArgs e)
        {
            int myInboundCount = 0;
            int myNotificationCount = 0;


            try
            {
                while (true)
                {
                    // Get the number of messages in the inbound queue, and display results
                    myInboundCount = theInboundMessageQueue.GetAllMessages().Length;
                    textBoxInboundQueueCount.Text = myInboundCount.ToString();

                    // Get the number of messages in the inbound queue, and display results
                    myNotificationCount = theNotificationsMessageQueue.GetAllMessages().Length;
                    textBoxNotificationQueueCount.Text = myNotificationCount.ToString();

                    //Load Notification messages into the Notifications Listbox
                    listBoxNotifications.Items.Clear();
                    foreach (System.Messaging.Message myMessage in theNotificationsMessageQueue.GetAllMessages())
                    {
                        // Display the label of each message.
                        myMessage.Formatter = new XmlMessageFormatter(new Type[] { typeof(String) });
                        var myMessageText = (String)myMessage.Body;
                        listBoxNotifications.Items.Add(myMessageText);
                    }


                    // Sleep before checking again
                    Thread.Sleep(2000);
                }
            }
            catch (Exception myException)
            {
                MessageBox.Show("Error:: " + myException.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void SamplingStop_Click(object sender, EventArgs e)
        {
            try
            {
                //Set up the SSH connection
                var myClient = new SshClient(theHost, thePort, theUser, thePass);
                myClient.Connect();

                // Kill the shell on the PI that running the sampling command
                myClient.RunCommand("killall java");
                myClient.Disconnect();

                //var output = client.RunCommand("pwd");
                //MessageBox.Show(" Stop Disconnected");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:: " + exception.Message);
            }
        }

        private void ThingworxUploadStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the flag to stop sending to Thingworx
                theContinueSendingFlag = true;

                // Set the UI setting 
                StartedSettingsSend();

                // Create a background process to update queue diagnostics
                BackgroundWorker myBGThingworxSend = new BackgroundWorker();
                myBGThingworxSend.DoWork += new DoWorkEventHandler(MyBGThingworxSend_DoWork);
                myBGThingworxSend.RunWorkerCompleted += new RunWorkerCompletedEventHandler(MyBGThingworxSend_RunWorkerCompleted);
                myBGThingworxSend.RunWorkerAsync();
            }
            catch (Exception myException)
            {
                MessageBox.Show("Error:: " + myException.Message);
            }
        }

        // This gets called when the background job completes
        private void MyBGThingworxSend_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Change the UI settings
            StoppedSettingsSend();
        }

        // This is the routine that does the work for the background process
        private void MyBGThingworxSend_DoWork(object sender, DoWorkEventArgs e)
        {
       
            try
            {
                while (theContinueSendingFlag && (theInboundMessageQueue.GetAllMessages().Length > 0))
                {
                    //Dequeue a message
                    System.Messaging.Message myMessage = theInboundMessageQueue.Receive();
                    myMessage.Formatter = new XmlMessageFormatter(new Type[] { typeof(String) });
                    string myMessageText = (String)myMessage.Body;

                    //Split the Thing name from the data
                    string[] myMessageParts = myMessageText.Split('*');

                    //var myClient = new RestClient("https://pp-2003021532te.devportal.ptc.io/Thingworx/Things/" + myMessageParts.ElementAt(0) + "/Properties/*");
                    var myClient = new RestClient(Properties.Settings.Default.BaseURL + "/Thingworx/Things/" + myMessageParts.ElementAt(0) + "/Properties/*");
                    //MessageBox.Show("https://" + Properties.Settings.Default.BaseURL + "/Thingworx/Things/" + myMessageParts.ElementAt(0) + "/Properties/*");

                    myClient.Timeout = -1;
                    var myRequest = new RestRequest(Method.PUT);
                    myRequest.AddHeader("AppKey", Properties.Settings.Default.APIKey);
                    //myRequest.AddHeader("AppKey", "45fc7688-5832-494f-8423-847c7e98eb65");
                    myRequest.AddHeader("Content-Type", "application/json");
                    myRequest.AddHeader("Accept", "application/json");
                    myRequest.AddParameter("application/json", myMessageParts.ElementAt(1), ParameterType.RequestBody);
                    IRestResponse response = myClient.Execute(myRequest);
                    //Console.WriteLine(response.Content);
                    if (response.StatusCode.ToString() != "204")
                    {
                        // put the message back onto the queue and break out of while loop and throw an exception
                        theContinueSendingFlag = false;
                        theInboundMessageQueue.Send(myMessage);
                        throw new Exception("Connection Error:   " + response.Content + "   " + response.StatusCode + "**** " + myMessageParts.ElementAt(0) + "   " + myMessageParts.ElementAt(1));
                    }
                    //MessageBox.Show(response.Content + "   " + response.StatusCode + "**** " + myMessageParts.ElementAt(0) + "   " + myMessageParts.ElementAt(1));

                }
            }
            catch (HttpRequestException myException)
            {
                MessageBox.Show("Error1:: " + myException.Message + "  ::  " + myException.InnerException.Message);
            }
            catch (ArgumentNullException myException)
            {
                MessageBox.Show("Error2:: " + myException.Message);
            }
            catch (Exception myException)
            {
                MessageBox.Show("Error3:: " + myException.Message);
            }
        }

        private void ThingworxUploadStop_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the flag to stop sending to Thingworx
                theContinueSendingFlag = false;
            }
            catch (Exception myException)
            {
                MessageBox.Show("Error:: " + myException.Message);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label3Sponsors_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 myAboutForm = new AboutBox1();
            myAboutForm.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 mySettingsForm = new Form2();
            mySettingsForm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
