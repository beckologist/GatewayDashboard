namespace SamplingStartStop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SamplingStart = new System.Windows.Forms.Button();
            this.SamplingStop = new System.Windows.Forms.Button();
            this.labelMotorSampling = new System.Windows.Forms.Label();
            this.labelSamplingStatus = new System.Windows.Forms.Label();
            this.GroupBoxMotorSampling = new System.Windows.Forms.GroupBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckBox8 = new System.Windows.Forms.CheckBox();
            this.CheckBox7 = new System.Windows.Forms.CheckBox();
            this.CheckBox6 = new System.Windows.Forms.CheckBox();
            this.CheckBox5 = new System.Windows.Forms.CheckBox();
            this.CheckBox4 = new System.Windows.Forms.CheckBox();
            this.CheckBox3 = new System.Windows.Forms.CheckBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.GroupBoxThingworxUpload = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BaseURL = new System.Windows.Forms.TextBox();
            this.APIKey = new System.Windows.Forms.TextBox();
            this.ThingworxUploadStop = new System.Windows.Forms.Button();
            this.ThingworxUploadStart = new System.Windows.Forms.Button();
            this.labelUploadStatus = new System.Windows.Forms.Label();
            this.labelThingworxUpload = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxDiagnostics = new System.Windows.Forms.GroupBox();
            this.labelNotificationsList = new System.Windows.Forms.Label();
            this.listBoxNotifications = new System.Windows.Forms.ListBox();
            this.textBoxNotificationQueueCount = new System.Windows.Forms.TextBox();
            this.textBoxInboundQueueCount = new System.Windows.Forms.TextBox();
            this.labelNotificationQueueCount = new System.Windows.Forms.Label();
            this.labelInboundQueueCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Label3Sponsors = new System.Windows.Forms.Label();
            this.GroupBoxMotorSampling.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBoxThingworxUpload.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.groupBoxDiagnostics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // SamplingStart
            // 
            this.SamplingStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SamplingStart.Location = new System.Drawing.Point(52, 103);
            this.SamplingStart.Name = "SamplingStart";
            this.SamplingStart.Size = new System.Drawing.Size(116, 48);
            this.SamplingStart.TabIndex = 0;
            this.SamplingStart.Text = "Start";
            this.SamplingStart.UseVisualStyleBackColor = true;
            this.SamplingStart.Click += new System.EventHandler(this.SamplingStart_Click);
            // 
            // SamplingStop
            // 
            this.SamplingStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SamplingStop.Location = new System.Drawing.Point(202, 103);
            this.SamplingStop.Name = "SamplingStop";
            this.SamplingStop.Size = new System.Drawing.Size(116, 48);
            this.SamplingStop.TabIndex = 1;
            this.SamplingStop.Text = "Stop";
            this.SamplingStop.UseVisualStyleBackColor = true;
            this.SamplingStop.Click += new System.EventHandler(this.SamplingStop_Click);
            // 
            // labelMotorSampling
            // 
            this.labelMotorSampling.AutoSize = true;
            this.labelMotorSampling.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotorSampling.Location = new System.Drawing.Point(45, 45);
            this.labelMotorSampling.Name = "labelMotorSampling";
            this.labelMotorSampling.Size = new System.Drawing.Size(124, 37);
            this.labelMotorSampling.TabIndex = 2;
            this.labelMotorSampling.Text = "Status:";
            this.labelMotorSampling.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSamplingStatus
            // 
            this.labelSamplingStatus.AutoSize = true;
            this.labelSamplingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSamplingStatus.Location = new System.Drawing.Point(175, 45);
            this.labelSamplingStatus.Name = "labelSamplingStatus";
            this.labelSamplingStatus.Size = new System.Drawing.Size(143, 37);
            this.labelSamplingStatus.TabIndex = 3;
            this.labelSamplingStatus.Text = "Stopped";
            // 
            // GroupBoxMotorSampling
            // 
            this.GroupBoxMotorSampling.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBoxMotorSampling.Controls.Add(this.GroupBox1);
            this.GroupBoxMotorSampling.Controls.Add(this.labelSamplingStatus);
            this.GroupBoxMotorSampling.Controls.Add(this.SamplingStart);
            this.GroupBoxMotorSampling.Controls.Add(this.labelMotorSampling);
            this.GroupBoxMotorSampling.Controls.Add(this.SamplingStop);
            this.GroupBoxMotorSampling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxMotorSampling.Location = new System.Drawing.Point(17, 11);
            this.GroupBoxMotorSampling.Name = "GroupBoxMotorSampling";
            this.GroupBoxMotorSampling.Size = new System.Drawing.Size(360, 287);
            this.GroupBoxMotorSampling.TabIndex = 4;
            this.GroupBoxMotorSampling.TabStop = false;
            this.GroupBoxMotorSampling.Text = "Motor Sampling";
            this.GroupBoxMotorSampling.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.CheckBox8);
            this.GroupBox1.Controls.Add(this.CheckBox7);
            this.GroupBox1.Controls.Add(this.CheckBox6);
            this.GroupBox1.Controls.Add(this.CheckBox5);
            this.GroupBox1.Controls.Add(this.CheckBox4);
            this.GroupBox1.Controls.Add(this.CheckBox3);
            this.GroupBox1.Controls.Add(this.CheckBox2);
            this.GroupBox1.Controls.Add(this.CheckBox1);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(6, 205);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(348, 70);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Motors to Include";
            // 
            // CheckBox8
            // 
            this.CheckBox8.AutoSize = true;
            this.CheckBox8.Location = new System.Drawing.Point(302, 26);
            this.CheckBox8.Name = "CheckBox8";
            this.CheckBox8.Size = new System.Drawing.Size(36, 22);
            this.CheckBox8.TabIndex = 7;
            this.CheckBox8.Text = "8";
            this.CheckBox8.UseVisualStyleBackColor = true;
            this.CheckBox8.CheckedChanged += new System.EventHandler(this.CheckBox8_CheckedChanged);
            // 
            // CheckBox7
            // 
            this.CheckBox7.AutoSize = true;
            this.CheckBox7.Location = new System.Drawing.Point(260, 26);
            this.CheckBox7.Name = "CheckBox7";
            this.CheckBox7.Size = new System.Drawing.Size(36, 22);
            this.CheckBox7.TabIndex = 6;
            this.CheckBox7.Text = "7";
            this.CheckBox7.UseVisualStyleBackColor = true;
            this.CheckBox7.CheckedChanged += new System.EventHandler(this.CheckBox7_CheckedChanged);
            // 
            // CheckBox6
            // 
            this.CheckBox6.AutoSize = true;
            this.CheckBox6.Location = new System.Drawing.Point(218, 26);
            this.CheckBox6.Name = "CheckBox6";
            this.CheckBox6.Size = new System.Drawing.Size(36, 22);
            this.CheckBox6.TabIndex = 5;
            this.CheckBox6.Text = "6";
            this.CheckBox6.UseVisualStyleBackColor = true;
            this.CheckBox6.CheckedChanged += new System.EventHandler(this.CheckBox6_CheckedChanged);
            // 
            // CheckBox5
            // 
            this.CheckBox5.AutoSize = true;
            this.CheckBox5.Location = new System.Drawing.Point(176, 26);
            this.CheckBox5.Name = "CheckBox5";
            this.CheckBox5.Size = new System.Drawing.Size(36, 22);
            this.CheckBox5.TabIndex = 4;
            this.CheckBox5.Text = "5";
            this.CheckBox5.UseVisualStyleBackColor = true;
            this.CheckBox5.CheckedChanged += new System.EventHandler(this.CheckBox5_CheckedChanged);
            // 
            // CheckBox4
            // 
            this.CheckBox4.AutoSize = true;
            this.CheckBox4.Location = new System.Drawing.Point(134, 26);
            this.CheckBox4.Name = "CheckBox4";
            this.CheckBox4.Size = new System.Drawing.Size(36, 22);
            this.CheckBox4.TabIndex = 3;
            this.CheckBox4.Text = "4";
            this.CheckBox4.UseVisualStyleBackColor = true;
            this.CheckBox4.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // CheckBox3
            // 
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.Location = new System.Drawing.Point(92, 26);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(36, 22);
            this.CheckBox3.TabIndex = 2;
            this.CheckBox3.Text = "3";
            this.CheckBox3.UseVisualStyleBackColor = true;
            this.CheckBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(50, 26);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(36, 22);
            this.CheckBox2.TabIndex = 1;
            this.CheckBox2.Text = "2";
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.CheckBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(7, 26);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(36, 22);
            this.CheckBox1.TabIndex = 0;
            this.CheckBox1.Text = "1";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // GroupBoxThingworxUpload
            // 
            this.GroupBoxThingworxUpload.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBoxThingworxUpload.Controls.Add(this.GroupBox2);
            this.GroupBoxThingworxUpload.Controls.Add(this.ThingworxUploadStop);
            this.GroupBoxThingworxUpload.Controls.Add(this.ThingworxUploadStart);
            this.GroupBoxThingworxUpload.Controls.Add(this.labelUploadStatus);
            this.GroupBoxThingworxUpload.Controls.Add(this.labelThingworxUpload);
            this.GroupBoxThingworxUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxThingworxUpload.Location = new System.Drawing.Point(426, 12);
            this.GroupBoxThingworxUpload.Name = "GroupBoxThingworxUpload";
            this.GroupBoxThingworxUpload.Size = new System.Drawing.Size(360, 286);
            this.GroupBoxThingworxUpload.TabIndex = 5;
            this.GroupBoxThingworxUpload.TabStop = false;
            this.GroupBoxThingworxUpload.Text = "Thingworx Upload";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.label2);
            this.GroupBox2.Controls.Add(this.label1);
            this.GroupBox2.Controls.Add(this.BaseURL);
            this.GroupBox2.Controls.Add(this.APIKey);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(7, 156);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(347, 124);
            this.GroupBox2.TabIndex = 7;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Connection Configuration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Base URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "APIKey";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // BaseURL
            // 
            this.BaseURL.Location = new System.Drawing.Point(20, 94);
            this.BaseURL.Name = "BaseURL";
            this.BaseURL.Size = new System.Drawing.Size(295, 24);
            this.BaseURL.TabIndex = 1;
            this.BaseURL.TextChanged += new System.EventHandler(this.BaseURL_TextChanged);
            // 
            // APIKey
            // 
            this.APIKey.ForeColor = System.Drawing.SystemColors.WindowText;
            this.APIKey.Location = new System.Drawing.Point(20, 41);
            this.APIKey.Name = "APIKey";
            this.APIKey.Size = new System.Drawing.Size(295, 24);
            this.APIKey.TabIndex = 0;
            this.APIKey.TextChanged += new System.EventHandler(this.APIKey_TextChanged);
            // 
            // ThingworxUploadStop
            // 
            this.ThingworxUploadStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThingworxUploadStop.Location = new System.Drawing.Point(206, 102);
            this.ThingworxUploadStop.Name = "ThingworxUploadStop";
            this.ThingworxUploadStop.Size = new System.Drawing.Size(116, 48);
            this.ThingworxUploadStop.TabIndex = 6;
            this.ThingworxUploadStop.Text = "Stop";
            this.ThingworxUploadStop.UseVisualStyleBackColor = true;
            this.ThingworxUploadStop.Click += new System.EventHandler(this.ThingworxUploadStop_Click);
            // 
            // ThingworxUploadStart
            // 
            this.ThingworxUploadStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThingworxUploadStart.Location = new System.Drawing.Point(43, 102);
            this.ThingworxUploadStart.Name = "ThingworxUploadStart";
            this.ThingworxUploadStart.Size = new System.Drawing.Size(116, 48);
            this.ThingworxUploadStart.TabIndex = 5;
            this.ThingworxUploadStart.Text = "Start";
            this.ThingworxUploadStart.UseVisualStyleBackColor = true;
            this.ThingworxUploadStart.Click += new System.EventHandler(this.ThingworxUploadStart_Click);
            // 
            // labelUploadStatus
            // 
            this.labelUploadStatus.AutoSize = true;
            this.labelUploadStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUploadStatus.Location = new System.Drawing.Point(165, 44);
            this.labelUploadStatus.Name = "labelUploadStatus";
            this.labelUploadStatus.Size = new System.Drawing.Size(143, 37);
            this.labelUploadStatus.TabIndex = 4;
            this.labelUploadStatus.Text = "Stopped";
            // 
            // labelThingworxUpload
            // 
            this.labelThingworxUpload.AutoSize = true;
            this.labelThingworxUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThingworxUpload.Location = new System.Drawing.Point(35, 44);
            this.labelThingworxUpload.Name = "labelThingworxUpload";
            this.labelThingworxUpload.Size = new System.Drawing.Size(124, 37);
            this.labelThingworxUpload.TabIndex = 3;
            this.labelThingworxUpload.Text = "Status:";
            this.labelThingworxUpload.Click += new System.EventHandler(this.label3_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(596, 375);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // groupBoxDiagnostics
            // 
            this.groupBoxDiagnostics.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxDiagnostics.Controls.Add(this.labelNotificationsList);
            this.groupBoxDiagnostics.Controls.Add(this.listBoxNotifications);
            this.groupBoxDiagnostics.Controls.Add(this.textBoxNotificationQueueCount);
            this.groupBoxDiagnostics.Controls.Add(this.textBoxInboundQueueCount);
            this.groupBoxDiagnostics.Controls.Add(this.labelNotificationQueueCount);
            this.groupBoxDiagnostics.Controls.Add(this.labelInboundQueueCount);
            this.groupBoxDiagnostics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDiagnostics.Location = new System.Drawing.Point(17, 324);
            this.groupBoxDiagnostics.Name = "groupBoxDiagnostics";
            this.groupBoxDiagnostics.Size = new System.Drawing.Size(769, 190);
            this.groupBoxDiagnostics.TabIndex = 7;
            this.groupBoxDiagnostics.TabStop = false;
            this.groupBoxDiagnostics.Text = "Diagnostics";
            this.groupBoxDiagnostics.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // labelNotificationsList
            // 
            this.labelNotificationsList.AutoSize = true;
            this.labelNotificationsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotificationsList.Location = new System.Drawing.Point(469, 21);
            this.labelNotificationsList.Name = "labelNotificationsList";
            this.labelNotificationsList.Size = new System.Drawing.Size(129, 24);
            this.labelNotificationsList.TabIndex = 5;
            this.labelNotificationsList.Text = "Notifications:";
            // 
            // listBoxNotifications
            // 
            this.listBoxNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNotifications.FormattingEnabled = true;
            this.listBoxNotifications.ItemHeight = 20;
            this.listBoxNotifications.Location = new System.Drawing.Point(473, 48);
            this.listBoxNotifications.Name = "listBoxNotifications";
            this.listBoxNotifications.Size = new System.Drawing.Size(258, 124);
            this.listBoxNotifications.TabIndex = 4;
            // 
            // textBoxNotificationQueueCount
            // 
            this.textBoxNotificationQueueCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotificationQueueCount.Location = new System.Drawing.Point(283, 118);
            this.textBoxNotificationQueueCount.Name = "textBoxNotificationQueueCount";
            this.textBoxNotificationQueueCount.Size = new System.Drawing.Size(134, 26);
            this.textBoxNotificationQueueCount.TabIndex = 3;
            // 
            // textBoxInboundQueueCount
            // 
            this.textBoxInboundQueueCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInboundQueueCount.Location = new System.Drawing.Point(283, 66);
            this.textBoxInboundQueueCount.Name = "textBoxInboundQueueCount";
            this.textBoxInboundQueueCount.Size = new System.Drawing.Size(134, 26);
            this.textBoxInboundQueueCount.TabIndex = 2;
            // 
            // labelNotificationQueueCount
            // 
            this.labelNotificationQueueCount.AutoSize = true;
            this.labelNotificationQueueCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotificationQueueCount.Location = new System.Drawing.Point(27, 118);
            this.labelNotificationQueueCount.Name = "labelNotificationQueueCount";
            this.labelNotificationQueueCount.Size = new System.Drawing.Size(250, 24);
            this.labelNotificationQueueCount.TabIndex = 1;
            this.labelNotificationQueueCount.Text = "Notification Queue Count:";
            // 
            // labelInboundQueueCount
            // 
            this.labelInboundQueueCount.AutoSize = true;
            this.labelInboundQueueCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInboundQueueCount.Location = new System.Drawing.Point(53, 66);
            this.labelInboundQueueCount.Name = "labelInboundQueueCount";
            this.labelInboundQueueCount.Size = new System.Drawing.Size(224, 24);
            this.labelInboundQueueCount.TabIndex = 0;
            this.labelInboundQueueCount.Text = "Inbound Queue Count:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(804, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 93);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(806, 284);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(247, 55);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(806, 358);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(247, 63);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(806, 441);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(247, 70);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // Label3Sponsors
            // 
            this.Label3Sponsors.AutoSize = true;
            this.Label3Sponsors.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3Sponsors.Location = new System.Drawing.Point(823, 231);
            this.Label3Sponsors.Name = "Label3Sponsors";
            this.Label3Sponsors.Size = new System.Drawing.Size(207, 33);
            this.Label3Sponsors.TabIndex = 12;
            this.Label3Sponsors.Text = "IOT Sponsors";
            this.Label3Sponsors.Click += new System.EventHandler(this.Label3Sponsors_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1065, 544);
            this.Controls.Add(this.Label3Sponsors);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxDiagnostics);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.GroupBoxThingworxUpload);
            this.Controls.Add(this.GroupBoxMotorSampling);
            this.Name = "Form1";
            this.Text = "IOT Gateway Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxMotorSampling.ResumeLayout(false);
            this.GroupBoxMotorSampling.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBoxThingworxUpload.ResumeLayout(false);
            this.GroupBoxThingworxUpload.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.groupBoxDiagnostics.ResumeLayout(false);
            this.groupBoxDiagnostics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SamplingStart;
        private System.Windows.Forms.Button SamplingStop;
        private System.Windows.Forms.Label labelMotorSampling;
        private System.Windows.Forms.Label labelSamplingStatus;
        private System.Windows.Forms.GroupBox GroupBoxMotorSampling;
        private System.Windows.Forms.GroupBox GroupBoxThingworxUpload;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelThingworxUpload;
        private System.Windows.Forms.Button ThingworxUploadStop;
        private System.Windows.Forms.Button ThingworxUploadStart;
        private System.Windows.Forms.Label labelUploadStatus;
        private System.Windows.Forms.GroupBox groupBoxDiagnostics;
        private System.Windows.Forms.Label labelNotificationQueueCount;
        private System.Windows.Forms.Label labelInboundQueueCount;
        private System.Windows.Forms.TextBox textBoxNotificationQueueCount;
        private System.Windows.Forms.TextBox textBoxInboundQueueCount;
        private System.Windows.Forms.Label labelNotificationsList;
        private System.Windows.Forms.ListBox listBoxNotifications;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BaseURL;
        private System.Windows.Forms.TextBox APIKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckBox8;
        private System.Windows.Forms.CheckBox CheckBox7;
        private System.Windows.Forms.CheckBox CheckBox6;
        private System.Windows.Forms.CheckBox CheckBox5;
        private System.Windows.Forms.CheckBox CheckBox4;
        private System.Windows.Forms.CheckBox CheckBox3;
        private System.Windows.Forms.CheckBox CheckBox2;
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label Label3Sponsors;
    }
}

