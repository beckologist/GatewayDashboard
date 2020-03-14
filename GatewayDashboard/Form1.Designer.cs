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
            this.GroupBoxThingworxUpload = new System.Windows.Forms.GroupBox();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ConfigurationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxMotorSampling.SuspendLayout();
            this.GroupBoxThingworxUpload.SuspendLayout();
            this.groupBoxDiagnostics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.GroupBoxMotorSampling.Controls.Add(this.labelSamplingStatus);
            this.GroupBoxMotorSampling.Controls.Add(this.SamplingStart);
            this.GroupBoxMotorSampling.Controls.Add(this.labelMotorSampling);
            this.GroupBoxMotorSampling.Controls.Add(this.SamplingStop);
            this.GroupBoxMotorSampling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxMotorSampling.Location = new System.Drawing.Point(28, 50);
            this.GroupBoxMotorSampling.Name = "GroupBoxMotorSampling";
            this.GroupBoxMotorSampling.Size = new System.Drawing.Size(360, 185);
            this.GroupBoxMotorSampling.TabIndex = 4;
            this.GroupBoxMotorSampling.TabStop = false;
            this.GroupBoxMotorSampling.Text = "Motor Sampling";
            this.GroupBoxMotorSampling.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // GroupBoxThingworxUpload
            // 
            this.GroupBoxThingworxUpload.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBoxThingworxUpload.Controls.Add(this.ThingworxUploadStop);
            this.GroupBoxThingworxUpload.Controls.Add(this.ThingworxUploadStart);
            this.GroupBoxThingworxUpload.Controls.Add(this.labelUploadStatus);
            this.GroupBoxThingworxUpload.Controls.Add(this.labelThingworxUpload);
            this.GroupBoxThingworxUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxThingworxUpload.Location = new System.Drawing.Point(417, 50);
            this.GroupBoxThingworxUpload.Name = "GroupBoxThingworxUpload";
            this.GroupBoxThingworxUpload.Size = new System.Drawing.Size(360, 185);
            this.GroupBoxThingworxUpload.TabIndex = 5;
            this.GroupBoxThingworxUpload.TabStop = false;
            this.GroupBoxThingworxUpload.Text = "Thingworx Upload";
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
            this.groupBoxDiagnostics.Location = new System.Drawing.Point(28, 252);
            this.groupBoxDiagnostics.Name = "groupBoxDiagnostics";
            this.groupBoxDiagnostics.Size = new System.Drawing.Size(749, 190);
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
            this.listBoxNotifications.Enabled = false;
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
            this.textBoxNotificationQueueCount.Enabled = false;
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
            this.pictureBox1.Location = new System.Drawing.Point(804, 50);
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
            this.pictureBox2.Location = new System.Drawing.Point(804, 215);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(247, 55);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(804, 289);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(247, 63);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(804, 372);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(247, 70);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // Label3Sponsors
            // 
            this.Label3Sponsors.AutoSize = true;
            this.Label3Sponsors.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3Sponsors.Location = new System.Drawing.Point(821, 162);
            this.Label3Sponsors.Name = "Label3Sponsors";
            this.Label3Sponsors.Size = new System.Drawing.Size(207, 33);
            this.Label3Sponsors.TabIndex = 12;
            this.Label3Sponsors.Text = "IOT Sponsors";
            this.Label3Sponsors.Click += new System.EventHandler(this.Label3Sponsors_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigurationToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ConfigurationToolStripMenuItem1
            // 
            this.ConfigurationToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.ConfigurationToolStripMenuItem1.Name = "ConfigurationToolStripMenuItem1";
            this.ConfigurationToolStripMenuItem1.Size = new System.Drawing.Size(93, 20);
            this.ConfigurationToolStripMenuItem1.Text = "Configuration";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1065, 463);
            this.Controls.Add(this.Label3Sponsors);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxDiagnostics);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.GroupBoxThingworxUpload);
            this.Controls.Add(this.GroupBoxMotorSampling);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "IOT Gateway Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxMotorSampling.ResumeLayout(false);
            this.GroupBoxMotorSampling.PerformLayout();
            this.GroupBoxThingworxUpload.ResumeLayout(false);
            this.GroupBoxThingworxUpload.PerformLayout();
            this.groupBoxDiagnostics.ResumeLayout(false);
            this.groupBoxDiagnostics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label Label3Sponsors;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ConfigurationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

