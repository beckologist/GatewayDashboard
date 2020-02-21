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



namespace SamplingStartStop
{
    public partial class Form1 : Form
    {
        // Connection info for Raspberry PI
        static string theUser = "pi";
        static string thePass = "raspberry";
        static string theHost = "10.5.37.222";

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
        private void buttonSamplingStart_Click(object sender, EventArgs e)
        {
            // Create a background process
            BackgroundWorker myBG = new BackgroundWorker();
            myBG.DoWork += new DoWorkEventHandler(myBG_DoWork);
            myBG.RunWorkerCompleted += new RunWorkerCompletedEventHandler(myBG_RunWorkerCompleted);
            myBG.RunWorkerAsync();

        }

        // This gets called when the background job completes
        private void myBG_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Call routine to set UI buttons/text to stopped state
            stoppedSettings();
        }

        // This is the routine that does the work for the background process
        private void myBG_DoWork(object sender, DoWorkEventArgs e)
        {
            // Call routine to set UI buttons/text to started state
            startedSettings();

            try
            {
                //Set up the SSH connection
                var myClient = new SshClient(theHost, theUser, thePass);
                labelSamplingStatus.Text = "Connecting";
                labelSamplingStatus.ForeColor = System.Drawing.Color.Orange;
                myClient.Connect();
                //var output = client.RunCommand("./Documents/HelloIP/StartTest");
                //var output = client.RunCommand("pwd");
                //MessageBox.Show(output.Result);
                // Call routine to set UI buttons/text to started state
                startedSettings();

                // Run the command on the PI to start sampling
                myClient.RunCommand("./StartTest");
                myClient.Disconnect();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error:: " + exception.Message);
            }
        }

        // Set Sampling UI buttons and text to started state
        private void startedSettings()
        {
            buttonSamplingStart.Enabled = false;
            buttonSamplingStop.Enabled = true;
            labelSamplingStatus.Text = "Started";
            labelSamplingStatus.ForeColor = System.Drawing.Color.Green;
        }

        // Set Thingworx send UI buttons and text to started state
        private void startedSettingsSend()
        {
            buttonThingworxUploadStart.Enabled = false;
            buttonThingworxUploadStop.Enabled = true;
            labelUploadStatus.Text = "Started";
            labelUploadStatus.ForeColor = System.Drawing.Color.Green;
        }


        // Set UI buttons and text to stopped state
        private void stoppedSettings()
        {
            buttonSamplingStart.Enabled = true;
            buttonSamplingStop.Enabled = false;
            labelSamplingStatus.Text = "Stopped";
            labelSamplingStatus.ForeColor = System.Drawing.Color.Red;
        }

        // Set Thingworx send UI buttons and text to stopped state
        private void stoppedSettingsSend()
        {
            buttonThingworxUploadStart.Enabled = true;
            buttonThingworxUploadStop.Enabled = false;
            labelUploadStatus.Text = "Stopped";
            labelUploadStatus.ForeColor = System.Drawing.Color.Red;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            // Initialize UI buttons and text to stopped state
            stoppedSettings();
            stoppedSettingsSend();

            // Allow visability of variables between main 
            //and background process.
            CheckForIllegalCrossThreadCalls = false;


            //If message queues do not exist, create them
            MessageQueue myMessageQueue = null;
            string myInboundDescription = "IOT Inbound Queue";
            string myNotificationDescription = "IOT Notification Queue";
            string myInboundPath = theInboundPath;
            string myNotificationsPath = theNotificationsPath;

            // IOT Inbound Path 
            try
            {
                if (MessageQueue.Exists(myInboundPath))
                {
                    myMessageQueue = new MessageQueue(myInboundPath);
                    myMessageQueue.Label = myInboundDescription;
                }
                else
                {
                    MessageQueue.Create(myInboundPath);
                    myMessageQueue = new MessageQueue(myInboundPath);
                    myMessageQueue.Label = myInboundDescription;
                }
            }
            catch(Exception myException)
            {
                MessageBox.Show(myException.Message);
            }

            //IOT Notification Path
            try
            {
                if (MessageQueue.Exists(myNotificationsPath))
                {
                    myMessageQueue = new MessageQueue(myNotificationsPath);
                    myMessageQueue.Label = myNotificationDescription;
                }
                else
                {
                    MessageQueue.Create(myNotificationsPath);
                    myMessageQueue = new MessageQueue(myNotificationsPath);
                    myMessageQueue.Label = myNotificationDescription;
                }
            }
            catch (Exception myException)
            {
                MessageBox.Show(myException.Message);
            }


            // Create a background process to update queue diagnostics
            BackgroundWorker myBGQueueDiagnostics = new BackgroundWorker();
            myBGQueueDiagnostics.DoWork += new DoWorkEventHandler(myBGQueueDiagnostics_DoWork);
            myBGQueueDiagnostics.RunWorkerCompleted += new RunWorkerCompletedEventHandler(myBGQueueDiagnostics_RunWorkerCompleted);
            myBGQueueDiagnostics.RunWorkerAsync();
        }

        // This gets called when the background job completes
        private void myBGQueueDiagnostics_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        // This is the routine that does the work for the background process
        private void myBGQueueDiagnostics_DoWork(object sender, DoWorkEventArgs e)
        {
            int myInboundCount = 0;
            int myNotificationCount = 0;
            

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSamplingStop_Click(object sender, EventArgs e)
        {
            try
            {
                //Set up the SSH connection
                var myClient = new SshClient(theHost, theUser, thePass);
                myClient.Connect();

                // Kill the shell on the PI that running the sampling command
                myClient.RunCommand("pkill bash");
                myClient.Disconnect();

                //var output = client.RunCommand("pwd");
                //MessageBox.Show(" Stop Disconnected");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:: " + exception.Message);
            }
        }

        private void buttonThingworxUploadStart_Click(object sender, EventArgs e)
        {
            // Set the UI setting 
            startedSettingsSend();

            // Create a background process to update queue diagnostics
            BackgroundWorker myBGThingworxSend = new BackgroundWorker();
            myBGThingworxSend.DoWork += new DoWorkEventHandler(myBGThingworxSend_DoWork);
            myBGThingworxSend.RunWorkerCompleted += new RunWorkerCompletedEventHandler(myBGThingworxSend_RunWorkerCompleted);
            myBGThingworxSend.RunWorkerAsync();
        }

        // This gets called when the background job completes
        private void myBGThingworxSend_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Change the UI settings
            stoppedSettingsSend();
        }

        // This is the routine that does the work for the background process
        private void myBGThingworxSend_DoWork(object sender, DoWorkEventArgs e)
        {
            while (theContinueSendingFlag && (theInboundMessageQueue.GetAllMessages().Length > 0)) {
                System.Messaging.Message myMessage = theInboundMessageQueue.Receive();
                myMessage.Formatter = new XmlMessageFormatter(new Type[] { typeof(String) });
                var myMessageText = (String)myMessage.Body;
                MessageBox.Show(myMessageText);
            }
        }

        private void buttonThingworxUploadStop_Click(object sender, EventArgs e)
        {
            // Set the flag to stop sending to Thingworx
            theContinueSendingFlag = false;
        }
    }
}
