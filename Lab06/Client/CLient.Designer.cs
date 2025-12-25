namespace Client
{
    partial class CLient
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Btn_SendEmail = new System.Windows.Forms.Button();
            this.DT_Date = new System.Windows.Forms.DateTimePicker();
            this.Tb_Size = new System.Windows.Forms.TextBox();
            this.Lb_Size = new System.Windows.Forms.Label();
            this.Lb_Time = new System.Windows.Forms.Label();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Transaction = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tb_Email = new System.Windows.Forms.TextBox();
            this.Lb_Email = new System.Windows.Forms.Label();
            this.Notification = new System.Windows.Forms.TabPage();
            this.ListBox_Mess = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Transaction.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Notification.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridView.Location = new System.Drawing.Point(3, 115);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridView.Size = new System.Drawing.Size(1089, 539);
            this.DataGridView.TabIndex = 1;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "StockCode";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 208;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "StockName";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 208;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ClosePrice";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 208;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Change";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 208;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "PerChange";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 208;
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Search.Font = new System.Drawing.Font("Segoe UI", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(254)));
            this.Btn_Search.ForeColor = System.Drawing.Color.Red;
            this.Btn_Search.Location = new System.Drawing.Point(974, 27);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(110, 49);
            this.Btn_Search.TabIndex = 2;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_SendEmail
            // 
            this.Btn_SendEmail.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_SendEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SendEmail.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_SendEmail.Font = new System.Drawing.Font("Segoe UI", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(254)));
            this.Btn_SendEmail.ForeColor = System.Drawing.Color.Red;
            this.Btn_SendEmail.Location = new System.Drawing.Point(841, 27);
            this.Btn_SendEmail.Name = "Btn_SendEmail";
            this.Btn_SendEmail.Size = new System.Drawing.Size(110, 49);
            this.Btn_SendEmail.TabIndex = 6;
            this.Btn_SendEmail.Text = "Send Email";
            this.Btn_SendEmail.UseVisualStyleBackColor = false;
            this.Btn_SendEmail.Click += new System.EventHandler(this.Btn_SendEmail_Click);
            // 
            // DT_Date
            // 
            this.DT_Date.Location = new System.Drawing.Point(578, 54);
            this.DT_Date.Name = "DT_Date";
            this.DT_Date.Size = new System.Drawing.Size(244, 22);
            this.DT_Date.TabIndex = 3;
            // 
            // Tb_Size
            // 
            this.Tb_Size.Location = new System.Drawing.Point(306, 54);
            this.Tb_Size.Name = "Tb_Size";
            this.Tb_Size.Size = new System.Drawing.Size(246, 22);
            this.Tb_Size.TabIndex = 4;
            // 
            // Lb_Size
            // 
            this.Lb_Size.AutoSize = true;
            this.Lb_Size.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Lb_Size.Location = new System.Drawing.Point(306, 25);
            this.Lb_Size.Name = "Lb_Size";
            this.Lb_Size.Size = new System.Drawing.Size(158, 23);
            this.Lb_Size.TabIndex = 5;
            this.Lb_Size.Text = "Numeric Up Down";
            // 
            // Lb_Time
            // 
            this.Lb_Time.AutoSize = true;
            this.Lb_Time.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Lb_Time.Location = new System.Drawing.Point(578, 25);
            this.Lb_Time.Name = "Lb_Time";
            this.Lb_Time.Size = new System.Drawing.Size(147, 23);
            this.Lb_Time.TabIndex = 7;
            this.Lb_Time.Text = "Date Time Picker";
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Connect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Connect.Font = new System.Drawing.Font("Segoe UI", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(254)));
            this.Btn_Connect.ForeColor = System.Drawing.Color.Red;
            this.Btn_Connect.Location = new System.Drawing.Point(26, 77);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(110, 32);
            this.Btn_Connect.TabIndex = 10;
            this.Btn_Connect.Text = "Connect";
            this.Btn_Connect.UseVisualStyleBackColor = false;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Transaction);
            this.tabControl1.Controls.Add(this.Notification);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1103, 686);
            this.tabControl1.TabIndex = 8;
            // 
            // Transaction
            // 
            this.Transaction.Controls.Add(this.panel1);
            this.Transaction.Controls.Add(this.DataGridView);
            this.Transaction.Location = new System.Drawing.Point(4, 25);
            this.Transaction.Name = "Transaction";
            this.Transaction.Padding = new System.Windows.Forms.Padding(3);
            this.Transaction.Size = new System.Drawing.Size(1095, 657);
            this.Transaction.TabIndex = 0;
            this.Transaction.Text = "Transaction_Statistics";
            this.Transaction.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Tb_Email);
            this.panel1.Controls.Add(this.Btn_Search);
            this.panel1.Controls.Add(this.Btn_SendEmail);
            this.panel1.Controls.Add(this.Btn_Connect);
            this.panel1.Controls.Add(this.Lb_Email);
            this.panel1.Controls.Add(this.Tb_Size);
            this.panel1.Controls.Add(this.Lb_Time);
            this.panel1.Controls.Add(this.Lb_Size);
            this.panel1.Controls.Add(this.DT_Date);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 112);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Tb_Email
            // 
            this.Tb_Email.Location = new System.Drawing.Point(22, 54);
            this.Tb_Email.Name = "Tb_Email";
            this.Tb_Email.Size = new System.Drawing.Size(246, 22);
            this.Tb_Email.TabIndex = 8;
            // 
            // Lb_Email
            // 
            this.Lb_Email.AutoSize = true;
            this.Lb_Email.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Lb_Email.Location = new System.Drawing.Point(22, 25);
            this.Lb_Email.Name = "Lb_Email";
            this.Lb_Email.Size = new System.Drawing.Size(54, 23);
            this.Lb_Email.TabIndex = 9;
            this.Lb_Email.Text = "Email";
            // 
            // Notification
            // 
            this.Notification.Controls.Add(this.ListBox_Mess);
            this.Notification.Location = new System.Drawing.Point(4, 25);
            this.Notification.Name = "Notification";
            this.Notification.Padding = new System.Windows.Forms.Padding(3);
            this.Notification.Size = new System.Drawing.Size(1095, 657);
            this.Notification.TabIndex = 1;
            this.Notification.Text = "System_Notification";
            this.Notification.UseVisualStyleBackColor = true;
            // 
            // ListBox_Mess
            // 
            this.ListBox_Mess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox_Mess.FormattingEnabled = true;
            this.ListBox_Mess.ItemHeight = 16;
            this.ListBox_Mess.Location = new System.Drawing.Point(3, 3);
            this.ListBox_Mess.Name = "ListBox_Mess";
            this.ListBox_Mess.Size = new System.Drawing.Size(1089, 651);
            this.ListBox_Mess.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(841, 82);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(110, 32);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(26, 154);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(246, 22);
            this.txtFrom.TabIndex = 12;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(306, 154);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(246, 22);
            this.txtTo.TabIndex = 13;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(578, 154);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(246, 22);
            this.txtSubject.TabIndex = 14;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(26, 215);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(798, 114);
            this.txtBody.TabIndex = 15;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblFrom.Location = new System.Drawing.Point(22, 125);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(55, 23);
            this.lblFrom.TabIndex = 16;
            this.lblFrom.Text = "From:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTo.Location = new System.Drawing.Point(302, 125);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(37, 23);
            this.lblTo.TabIndex = 17;
            this.lblTo.Text = "To:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblSubject.Location = new System.Drawing.Point(574, 125);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(76, 23);
            this.lblSubject.TabIndex = 18;
            this.lblSubject.Text = "Subject:";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblBody.Location = new System.Drawing.Point(22, 186);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(57, 23);
            this.lblBody.TabIndex = 19;
            this.lblBody.Text = "Body:";
            // 
            // CLient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1103, 686);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CLient";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Transaction.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Notification.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button Btn_SendEmail;
        private System.Windows.Forms.DateTimePicker DT_Date;
        private System.Windows.Forms.TextBox Tb_Size;
        private System.Windows.Forms.Label Lb_Size;
        private System.Windows.Forms.Label Lb_Time;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Notification;
        private System.Windows.Forms.TabPage Transaction;
        private System.Windows.Forms.Label Lb_Email;
        private System.Windows.Forms.TextBox Tb_Email;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ListBox_Mess;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button Btn_Connect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblBody;
    }
}

