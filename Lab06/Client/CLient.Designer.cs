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
            this.Btn_Search = new System.Windows.Forms.Button();
            this.DT_Date = new System.Windows.Forms.DateTimePicker();
            this.Tb_Size = new System.Windows.Forms.TextBox();
            this.Lb_Size = new System.Windows.Forms.Label();
            this.Lb_Time = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Transaction = new System.Windows.Forms.TabPage();
            this.Notification = new System.Windows.Forms.TabPage();
            this.Tb_Email = new System.Windows.Forms.TextBox();
            this.Lb_Email = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListBox_Mess = new System.Windows.Forms.ListBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Transaction.SuspendLayout();
            this.Notification.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Search.Font = new System.Drawing.Font("Segoe UI", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(254)));
            this.Btn_Search.ForeColor = System.Drawing.Color.Red;
            this.Btn_Search.Location = new System.Drawing.Point(943, 25);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(127, 49);
            this.Btn_Search.TabIndex = 2;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = false;
            // 
            // DT_Date
            // 
            this.DT_Date.Location = new System.Drawing.Point(643, 52);
            this.DT_Date.Name = "DT_Date";
            this.DT_Date.Size = new System.Drawing.Size(244, 22);
            this.DT_Date.TabIndex = 3;
            // 
            // Tb_Size
            // 
            this.Tb_Size.Location = new System.Drawing.Point(332, 54);
            this.Tb_Size.Name = "Tb_Size";
            this.Tb_Size.Size = new System.Drawing.Size(246, 22);
            this.Tb_Size.TabIndex = 4;
            // 
            // Lb_Size
            // 
            this.Lb_Size.AutoSize = true;
            this.Lb_Size.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Lb_Size.Location = new System.Drawing.Point(332, 25);
            this.Lb_Size.Name = "Lb_Size";
            this.Lb_Size.Size = new System.Drawing.Size(158, 23);
            this.Lb_Size.TabIndex = 5;
            this.Lb_Size.Text = "Numeric Up Down";
            // 
            // Lb_Time
            // 
            this.Lb_Time.AutoSize = true;
            this.Lb_Time.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Lb_Time.Location = new System.Drawing.Point(643, 23);
            this.Lb_Time.Name = "Lb_Time";
            this.Lb_Time.Size = new System.Drawing.Size(147, 23);
            this.Lb_Time.TabIndex = 7;
            this.Lb_Time.Text = "Date Time Picker";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.Tb_Email);
            this.panel1.Controls.Add(this.Btn_Search);
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
            this.Notification.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button Btn_Search;
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
    }
}

