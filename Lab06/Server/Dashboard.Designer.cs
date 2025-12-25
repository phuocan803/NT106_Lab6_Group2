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
            this.groupBox_Connection.Location = new System.Drawing.Point(16, 15);
            this.groupBox_Connection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Connection.Name = "groupBox_Connection";
            this.groupBox_Connection.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Connection.Size = new System.Drawing.Size(695, 110);
            this.groupBox_Connection.TabIndex = 0;
            this.groupBox_Connection.TabStop = false;
            this.groupBox_Connection.Text = "Connection";
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(532, 65);
            this.button_Stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(155, 33);
            this.button_Stop.TabIndex = 5;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Listen
            // 
            this.button_Listen.Location = new System.Drawing.Point(532, 30);
            this.button_Listen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Listen.Name = "button_Listen";
            this.button_Listen.Size = new System.Drawing.Size(155, 33);
            this.button_Listen.TabIndex = 4;
            this.button_Listen.Text = "Listen";
            this.button_Listen.UseVisualStyleBackColor = true;
            this.button_Listen.Click += new System.EventHandler(this.button_Listen_Click);
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(137, 65);
            this.textBox_Port.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(361, 29);
            this.textBox_Port.TabIndex = 3;
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Location = new System.Drawing.Point(8, 69);
            this.label_Port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(45, 23);
            this.label_Port.TabIndex = 2;
            this.label_Port.Text = "Port:";
            // 
            // textBox_IP_Address
            // 
            this.textBox_IP_Address.Location = new System.Drawing.Point(137, 25);
            this.textBox_IP_Address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_IP_Address.Name = "textBox_IP_Address";
            this.textBox_IP_Address.Size = new System.Drawing.Size(361, 29);
            this.textBox_IP_Address.TabIndex = 1;
            // 
            // label_IP_Address
            // 
            this.label_IP_Address.AutoSize = true;
            this.label_IP_Address.Location = new System.Drawing.Point(8, 28);
            this.label_IP_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_IP_Address.Name = "label_IP_Address";
            this.label_IP_Address.Size = new System.Drawing.Size(94, 23);
            this.label_IP_Address.TabIndex = 0;
            this.label_IP_Address.Text = "IP Address:";
            // 
            // groupBox_Log
            // 
            this.groupBox_Log.Controls.Add(this.textBox_Log);
            this.groupBox_Log.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Log.Location = new System.Drawing.Point(16, 132);
            this.groupBox_Log.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Log.Name = "groupBox_Log";
            this.groupBox_Log.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Log.Size = new System.Drawing.Size(695, 352);
            this.groupBox_Log.TabIndex = 6;
            this.groupBox_Log.TabStop = false;
            this.groupBox_Log.Text = "Server\'s Log";
            // 
            // textBox_Log
            // 
            this.textBox_Log.Location = new System.Drawing.Point(8, 32);
            this.textBox_Log.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Log.Multiline = true;
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.ReadOnly = true;
            this.textBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_Log.Size = new System.Drawing.Size(677, 312);
            this.textBox_Log.TabIndex = 0;
            // 
            // groupBox_Broadcast
            // 
            this.groupBox_Broadcast.Controls.Add(this.button_Broadcast);
            this.groupBox_Broadcast.Controls.Add(this.textBox_Notification);
            this.groupBox_Broadcast.Controls.Add(this.label_Notification);
            this.groupBox_Broadcast.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Broadcast.Location = new System.Drawing.Point(16, 491);
            this.groupBox_Broadcast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Broadcast.Name = "groupBox_Broadcast";
            this.groupBox_Broadcast.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Broadcast.Size = new System.Drawing.Size(695, 75);
            this.groupBox_Broadcast.TabIndex = 6;
            this.groupBox_Broadcast.TabStop = false;
            this.groupBox_Broadcast.Text = "Broadcast";
            // 
            // button_Broadcast
            // 
            this.button_Broadcast.Location = new System.Drawing.Point(532, 32);
            this.button_Broadcast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Broadcast.Name = "button_Broadcast";
            this.button_Broadcast.Size = new System.Drawing.Size(155, 33);
            this.button_Broadcast.TabIndex = 7;
            this.button_Broadcast.Text = "Broadcast";
            this.button_Broadcast.UseVisualStyleBackColor = true;
            this.button_Broadcast.Click += new System.EventHandler(this.button_Broadcast_Click);
            // 
            // textBox_Notification
            // 
            this.textBox_Notification.Location = new System.Drawing.Point(137, 32);
            this.textBox_Notification.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Notification.Name = "textBox_Notification";
            this.textBox_Notification.Size = new System.Drawing.Size(361, 29);
            this.textBox_Notification.TabIndex = 6;
            // 
            // label_Notification
            // 
            this.label_Notification.AutoSize = true;
            this.label_Notification.Location = new System.Drawing.Point(8, 36);
            this.label_Notification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Notification.Name = "label_Notification";
            this.label_Notification.Size = new System.Drawing.Size(103, 23);
            this.label_Notification.TabIndex = 5;
            this.label_Notification.Text = "Notification:";
            // 
            // lbClients
            // 
            this.lbClients.FormattingEnabled = true;
            this.lbClients.ItemHeight = 16;
            this.lbClients.Location = new System.Drawing.Point(737, 15);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(217, 516);
            this.lbClients.TabIndex = 7;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 578);
            this.Controls.Add(this.lbClients);
            this.Controls.Add(this.groupBox_Broadcast);
            this.Controls.Add(this.groupBox_Log);
            this.Controls.Add(this.groupBox_Connection);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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