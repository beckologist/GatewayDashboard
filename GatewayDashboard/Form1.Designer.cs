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
            this.buttonSamplingStart = new System.Windows.Forms.Button();
            this.buttonSamplingStop = new System.Windows.Forms.Button();
            this.labelMotorSampling = new System.Windows.Forms.Label();
            this.labelSamplingStatus = new System.Windows.Forms.Label();
            this.groupBoxMotorSampling = new System.Windows.Forms.GroupBox();
            this.groupBoxThingworxUpload = new System.Windows.Forms.GroupBox();
            this.buttonThingworxUploadStop = new System.Windows.Forms.Button();
            this.buttonThingworxUploadStart = new System.Windows.Forms.Button();
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
            this.groupBoxMotorSampling.SuspendLayout();
            this.groupBoxThingworxUpload.SuspendLayout();
            this.groupBoxDiagnostics.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSamplingStart
            // 
            this.buttonSamplingStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSamplingStart.Location = new System.Drawing.Point(41, 103);
            this.buttonSamplingStart.Name = "buttonSamplingStart";
            this.buttonSamplingStart.Size = new System.Drawing.Size(116, 48);
            this.buttonSamplingStart.TabIndex = 0;
            this.buttonSamplingStart.Text = "Start";
            this.buttonSamplingStart.UseVisualStyleBackColor = true;
            this.buttonSamplingStart.Click += new System.EventHandler(this.buttonSamplingStart_Click);
            // 
            // buttonSamplingStop
            // 
            this.buttonSamplingStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSamplingStop.Location = new System.Drawing.Point(202, 103);
            this.buttonSamplingStop.Name = "buttonSamplingStop";
            this.buttonSamplingStop.Size = new System.Drawing.Size(116, 48);
            this.buttonSamplingStop.TabIndex = 1;
            this.buttonSamplingStop.Text = "Stop";
            this.buttonSamplingStop.UseVisualStyleBackColor = true;
            this.buttonSamplingStop.Click += new System.EventHandler(this.buttonSamplingStop_Click);
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
            // groupBoxMotorSampling
            // 
            this.groupBoxMotorSampling.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxMotorSampling.Controls.Add(this.labelSamplingStatus);
            this.groupBoxMotorSampling.Controls.Add(this.buttonSamplingStart);
            this.groupBoxMotorSampling.Controls.Add(this.labelMotorSampling);
            this.groupBoxMotorSampling.Controls.Add(this.buttonSamplingStop);
            this.groupBoxMotorSampling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMotorSampling.Location = new System.Drawing.Point(39, 30);
            this.groupBoxMotorSampling.Name = "groupBoxMotorSampling";
            this.groupBoxMotorSampling.Size = new System.Drawing.Size(360, 196);
            this.groupBoxMotorSampling.TabIndex = 4;
            this.groupBoxMotorSampling.TabStop = false;
            this.groupBoxMotorSampling.Text = "Motor Sampling";
            this.groupBoxMotorSampling.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBoxThingworxUpload
            // 
            this.groupBoxThingworxUpload.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxThingworxUpload.Controls.Add(this.buttonThingworxUploadStop);
            this.groupBoxThingworxUpload.Controls.Add(this.buttonThingworxUploadStart);
            this.groupBoxThingworxUpload.Controls.Add(this.labelUploadStatus);
            this.groupBoxThingworxUpload.Controls.Add(this.labelThingworxUpload);
            this.groupBoxThingworxUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxThingworxUpload.Location = new System.Drawing.Point(448, 31);
            this.groupBoxThingworxUpload.Name = "groupBoxThingworxUpload";
            this.groupBoxThingworxUpload.Size = new System.Drawing.Size(360, 195);
            this.groupBoxThingworxUpload.TabIndex = 5;
            this.groupBoxThingworxUpload.TabStop = false;
            this.groupBoxThingworxUpload.Text = "Thingworx Upload";
            // 
            // buttonThingworxUploadStop
            // 
            this.buttonThingworxUploadStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThingworxUploadStop.Location = new System.Drawing.Point(206, 102);
            this.buttonThingworxUploadStop.Name = "buttonThingworxUploadStop";
            this.buttonThingworxUploadStop.Size = new System.Drawing.Size(116, 48);
            this.buttonThingworxUploadStop.TabIndex = 6;
            this.buttonThingworxUploadStop.Text = "Stop";
            this.buttonThingworxUploadStop.UseVisualStyleBackColor = true;
            this.buttonThingworxUploadStop.Click += new System.EventHandler(this.buttonThingworxUploadStop_Click);
            // 
            // buttonThingworxUploadStart
            // 
            this.buttonThingworxUploadStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThingworxUploadStart.Location = new System.Drawing.Point(43, 102);
            this.buttonThingworxUploadStart.Name = "buttonThingworxUploadStart";
            this.buttonThingworxUploadStart.Size = new System.Drawing.Size(116, 48);
            this.buttonThingworxUploadStart.TabIndex = 5;
            this.buttonThingworxUploadStart.Text = "Start";
            this.buttonThingworxUploadStart.UseVisualStyleBackColor = true;
            this.buttonThingworxUploadStart.Click += new System.EventHandler(this.buttonThingworxUploadStart_Click);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(618, 394);
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
            this.groupBoxDiagnostics.Location = new System.Drawing.Point(39, 249);
            this.groupBoxDiagnostics.Name = "groupBoxDiagnostics";
            this.groupBoxDiagnostics.Size = new System.Drawing.Size(769, 190);
            this.groupBoxDiagnostics.TabIndex = 7;
            this.groupBoxDiagnostics.TabStop = false;
            this.groupBoxDiagnostics.Text = "Diagnostics";
            this.groupBoxDiagnostics.Enter += new System.EventHandler(this.groupBox3_Enter);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(852, 451);
            this.Controls.Add(this.groupBoxDiagnostics);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBoxThingworxUpload);
            this.Controls.Add(this.groupBoxMotorSampling);
            this.Name = "Form1";
            this.Text = "IOT Gateway Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMotorSampling.ResumeLayout(false);
            this.groupBoxMotorSampling.PerformLayout();
            this.groupBoxThingworxUpload.ResumeLayout(false);
            this.groupBoxThingworxUpload.PerformLayout();
            this.groupBoxDiagnostics.ResumeLayout(false);
            this.groupBoxDiagnostics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSamplingStart;
        private System.Windows.Forms.Button buttonSamplingStop;
        private System.Windows.Forms.Label labelMotorSampling;
        private System.Windows.Forms.Label labelSamplingStatus;
        private System.Windows.Forms.GroupBox groupBoxMotorSampling;
        private System.Windows.Forms.GroupBox groupBoxThingworxUpload;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelThingworxUpload;
        private System.Windows.Forms.Button buttonThingworxUploadStop;
        private System.Windows.Forms.Button buttonThingworxUploadStart;
        private System.Windows.Forms.Label labelUploadStatus;
        private System.Windows.Forms.GroupBox groupBoxDiagnostics;
        private System.Windows.Forms.Label labelNotificationQueueCount;
        private System.Windows.Forms.Label labelInboundQueueCount;
        private System.Windows.Forms.TextBox textBoxNotificationQueueCount;
        private System.Windows.Forms.TextBox textBoxInboundQueueCount;
        private System.Windows.Forms.Label labelNotificationsList;
        private System.Windows.Forms.ListBox listBoxNotifications;
    }
}

