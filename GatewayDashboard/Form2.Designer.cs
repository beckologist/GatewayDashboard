namespace SamplingStartStop
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EdgeDeviceGroupBox1 = new System.Windows.Forms.GroupBox();
            this.EDPortTextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EDIPTextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EDPasswordTextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EDUsernameTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ThingworxGroupBox1 = new System.Windows.Forms.GroupBox();
            this.EdgeDeviceGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Broker API Settings";
            // 
            // EdgeDeviceGroupBox1
            // 
            this.EdgeDeviceGroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.EdgeDeviceGroupBox1.Controls.Add(this.EDPortTextBox1);
            this.EdgeDeviceGroupBox1.Controls.Add(this.label4);
            this.EdgeDeviceGroupBox1.Controls.Add(this.EDIPTextBox1);
            this.EdgeDeviceGroupBox1.Controls.Add(this.label3);
            this.EdgeDeviceGroupBox1.Controls.Add(this.EDPasswordTextBox1);
            this.EdgeDeviceGroupBox1.Controls.Add(this.label2);
            this.EdgeDeviceGroupBox1.Controls.Add(this.EDUsernameTextBox1);
            this.EdgeDeviceGroupBox1.Controls.Add(this.label1);
            this.EdgeDeviceGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdgeDeviceGroupBox1.Location = new System.Drawing.Point(39, 12);
            this.EdgeDeviceGroupBox1.Name = "EdgeDeviceGroupBox1";
            this.EdgeDeviceGroupBox1.Size = new System.Drawing.Size(256, 245);
            this.EdgeDeviceGroupBox1.TabIndex = 4;
            this.EdgeDeviceGroupBox1.TabStop = false;
            this.EdgeDeviceGroupBox1.Text = "Edge Device Settings";
            // 
            // EDPortTextBox1
            // 
            this.EDPortTextBox1.Location = new System.Drawing.Point(6, 188);
            this.EDPortTextBox1.Name = "EDPortTextBox1";
            this.EDPortTextBox1.Size = new System.Drawing.Size(55, 22);
            this.EDPortTextBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Port";
            // 
            // EDIPTextBox1
            // 
            this.EDIPTextBox1.Location = new System.Drawing.Point(7, 142);
            this.EDIPTextBox1.Name = "EDIPTextBox1";
            this.EDIPTextBox1.Size = new System.Drawing.Size(84, 22);
            this.EDIPTextBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP Address";
            // 
            // EDPasswordTextBox1
            // 
            this.EDPasswordTextBox1.Location = new System.Drawing.Point(6, 96);
            this.EDPasswordTextBox1.Name = "EDPasswordTextBox1";
            this.EDPasswordTextBox1.Size = new System.Drawing.Size(242, 22);
            this.EDPasswordTextBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // EDUsernameTextBox1
            // 
            this.EDUsernameTextBox1.Location = new System.Drawing.Point(6, 50);
            this.EDUsernameTextBox1.Name = "EDUsernameTextBox1";
            this.EDUsernameTextBox1.Size = new System.Drawing.Size(242, 22);
            this.EDUsernameTextBox1.TabIndex = 1;
            this.EDUsernameTextBox1.TextChanged += new System.EventHandler(this.EDUsernameTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // ThingworxGroupBox1
            // 
            this.ThingworxGroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.ThingworxGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThingworxGroupBox1.Location = new System.Drawing.Point(39, 263);
            this.ThingworxGroupBox1.Name = "ThingworxGroupBox1";
            this.ThingworxGroupBox1.Size = new System.Drawing.Size(454, 128);
            this.ThingworxGroupBox1.TabIndex = 3;
            this.ThingworxGroupBox1.TabStop = false;
            this.ThingworxGroupBox1.Text = "Thingworx Settings";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EdgeDeviceGroupBox1);
            this.Controls.Add(this.ThingworxGroupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.EdgeDeviceGroupBox1.ResumeLayout(false);
            this.EdgeDeviceGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox EdgeDeviceGroupBox1;
        private System.Windows.Forms.TextBox EDPortTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EDIPTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EDPasswordTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EDUsernameTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ThingworxGroupBox1;
    }
}