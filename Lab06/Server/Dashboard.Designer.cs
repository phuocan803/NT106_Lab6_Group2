namespace Server
{
    partial class Dashboard
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
            this.groupBox_Connection = new System.Windows.Forms.GroupBox();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Listen = new System.Windows.Forms.Button();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label_Port = new System.Windows.Forms.Label();
            this.textBox_IP_Address = new System.Windows.Forms.TextBox();
            this.label_IP_Address = new System.Windows.Forms.Label();
            this.groupBox_Log = new System.Windows.Forms.GroupBox();
            this.textBox_Log = new System.Windows.Forms.TextBox();
            this.groupBox_Broadcast = new System.Windows.Forms.GroupBox();
            this.button_Broadcast = new System.Windows.Forms.Button();
            this.textBox_Notification = new System.Windows.Forms.TextBox();
            this.label_Notification = new System.Windows.Forms.Label();
            this.lbClients = new System.Windows.Forms.ListBox();
            this.groupBox_Connection.SuspendLayout();
            this.groupBox_Log.SuspendLayout();
            this.groupBox_Broadcast.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Connection
            // 
            this.groupBox_Connection.Controls.Add(this.button_Stop);
            this.groupBox_Connection.Controls.Add(this.button_Listen);
            this.groupBox_Connection.Controls.Add(this.textBox_Port);
            this.groupBox_Connection.Controls.Add(this.label_Port);
            this.groupBox_Connection.Controls.Add(this.textBox_IP_Address);
            this.groupBox_Connection.Controls.Add(this.label_IP_Address);
            this.groupBox_Connection.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Connection.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Connection.Name = "groupBox_Connection";
            this.groupBox_Connection.Size = new System.Drawing.Size(521, 89);
            this.groupBox_Connection.TabIndex = 0;
            this.groupBox_Connection.TabStop = false;
            this.groupBox_Connection.Text = "Connection";
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(399, 53);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(116, 27);
            this.button_Stop.TabIndex = 5;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            // 
            // button_Listen
            // 
            this.button_Listen.Location = new System.Drawing.Point(399, 20);
            this.button_Listen.Name = "button_Listen";
            this.button_Listen.Size = new System.Drawing.Size(116, 27);
            this.button_Listen.TabIndex = 4;
            this.button_Listen.Text = "Listen";
            this.button_Listen.UseVisualStyleBackColor = true;
            this.button_Listen.Click += new System.EventHandler(this.button_Listen_Click);
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(103, 53);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(272, 25);
            this.textBox_Port.TabIndex = 3;
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Location = new System.Drawing.Point(6, 56);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(37, 19);
            this.label_Port.TabIndex = 2;
            this.label_Port.Text = "Port:";
            // 
            // textBox_IP_Address
            // 
            this.textBox_IP_Address.Location = new System.Drawing.Point(103, 20);
            this.textBox_IP_Address.Name = "textBox_IP_Address";
            this.textBox_IP_Address.Size = new System.Drawing.Size(272, 25);
            this.textBox_IP_Address.TabIndex = 1;
            // 
            // label_IP_Address
            // 
            this.label_IP_Address.AutoSize = true;
            this.label_IP_Address.Location = new System.Drawing.Point(6, 23);
            this.label_IP_Address.Name = "label_IP_Address";
            this.label_IP_Address.Size = new System.Drawing.Size(77, 19);
            this.label_IP_Address.TabIndex = 0;
            this.label_IP_Address.Text = "IP Address:";
            // 
            // groupBox_Log
            // 
            this.groupBox_Log.Controls.Add(this.textBox_Log);
            this.groupBox_Log.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Log.Location = new System.Drawing.Point(12, 107);
            this.groupBox_Log.Name = "groupBox_Log";
            this.groupBox_Log.Size = new System.Drawing.Size(521, 286);
            this.groupBox_Log.TabIndex = 6;
            this.groupBox_Log.TabStop = false;
            this.groupBox_Log.Text = "Server\'s Log";
            // 
            // textBox_Log
            // 
            this.textBox_Log.Location = new System.Drawing.Point(6, 26);
            this.textBox_Log.Multiline = true;
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.ReadOnly = true;
            this.textBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_Log.Size = new System.Drawing.Size(509, 254);
            this.textBox_Log.TabIndex = 0;
            // 
            // groupBox_Broadcast
            // 
            this.groupBox_Broadcast.Controls.Add(this.button_Broadcast);
            this.groupBox_Broadcast.Controls.Add(this.textBox_Notification);
            this.groupBox_Broadcast.Controls.Add(this.label_Notification);
            this.groupBox_Broadcast.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Broadcast.Location = new System.Drawing.Point(12, 399);
            this.groupBox_Broadcast.Name = "groupBox_Broadcast";
            this.groupBox_Broadcast.Size = new System.Drawing.Size(521, 61);
            this.groupBox_Broadcast.TabIndex = 6;
            this.groupBox_Broadcast.TabStop = false;
            this.groupBox_Broadcast.Text = "Broadcast";
            // 
            // button_Broadcast
            // 
            this.button_Broadcast.Location = new System.Drawing.Point(399, 26);
            this.button_Broadcast.Name = "button_Broadcast";
            this.button_Broadcast.Size = new System.Drawing.Size(116, 27);
            this.button_Broadcast.TabIndex = 7;
            this.button_Broadcast.Text = "Broadcast";
            this.button_Broadcast.UseVisualStyleBackColor = true;
            // 
            // textBox_Notification
            // 
            this.textBox_Notification.Location = new System.Drawing.Point(103, 26);
            this.textBox_Notification.Name = "textBox_Notification";
            this.textBox_Notification.Size = new System.Drawing.Size(272, 25);
            this.textBox_Notification.TabIndex = 6;
            // 
            // label_Notification
            // 
            this.label_Notification.AutoSize = true;
            this.label_Notification.Location = new System.Drawing.Point(6, 29);
            this.label_Notification.Name = "label_Notification";
            this.label_Notification.Size = new System.Drawing.Size(82, 19);
            this.label_Notification.TabIndex = 5;
            this.label_Notification.Text = "Notification:";
            // 
            // lbClients
            // 
            this.lbClients.FormattingEnabled = true;
            this.lbClients.Location = new System.Drawing.Point(545, 27);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(120, 433);
            this.lbClients.TabIndex = 7;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 470);
            this.Controls.Add(this.lbClients);
            this.Controls.Add(this.groupBox_Broadcast);
            this.Controls.Add(this.groupBox_Log);
            this.Controls.Add(this.groupBox_Connection);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.groupBox_Connection.ResumeLayout(false);
            this.groupBox_Connection.PerformLayout();
            this.groupBox_Log.ResumeLayout(false);
            this.groupBox_Log.PerformLayout();
            this.groupBox_Broadcast.ResumeLayout(false);
            this.groupBox_Broadcast.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Connection;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.TextBox textBox_IP_Address;
        private System.Windows.Forms.Label label_IP_Address;
        private System.Windows.Forms.Button button_Listen;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.GroupBox groupBox_Log;
        private System.Windows.Forms.TextBox textBox_Log;
        private System.Windows.Forms.GroupBox groupBox_Broadcast;
        private System.Windows.Forms.Button button_Broadcast;
        private System.Windows.Forms.TextBox textBox_Notification;
        private System.Windows.Forms.Label label_Notification;
        private System.Windows.Forms.ListBox lbClients;
    }
}