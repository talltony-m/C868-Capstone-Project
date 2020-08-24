namespace C868
{
    partial class ScheduleUser
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
            this.ScheduleUserLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ReportButton = new System.Windows.Forms.Button();
            this.userReportView = new System.Windows.Forms.DataGridView();
            this.CancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.userReportView)).BeginInit();
            this.SuspendLayout();
            // 
            // ScheduleUserLabel
            // 
            this.ScheduleUserLabel.AutoSize = true;
            this.ScheduleUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleUserLabel.Location = new System.Drawing.Point(186, 42);
            this.ScheduleUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScheduleUserLabel.Name = "ScheduleUserLabel";
            this.ScheduleUserLabel.Size = new System.Drawing.Size(521, 37);
            this.ScheduleUserLabel.TabIndex = 0;
            this.ScheduleUserLabel.Text = "Report: Schedules by User Name";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Test"});
            this.comboBox1.Location = new System.Drawing.Point(80, 137);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 39);
            this.comboBox1.TabIndex = 1;
            // 
            // ReportButton
            // 
            this.ReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.Location = new System.Drawing.Point(348, 137);
            this.ReportButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(234, 46);
            this.ReportButton.TabIndex = 2;
            this.ReportButton.Text = "Get Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // userReportView
            // 
            this.userReportView.AllowUserToAddRows = false;
            this.userReportView.AllowUserToDeleteRows = false;
            this.userReportView.AllowUserToResizeColumns = false;
            this.userReportView.AllowUserToResizeRows = false;
            this.userReportView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.userReportView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.userReportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userReportView.Enabled = false;
            this.userReportView.Location = new System.Drawing.Point(24, 217);
            this.userReportView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userReportView.MultiSelect = false;
            this.userReportView.Name = "userReportView";
            this.userReportView.RowHeadersVisible = false;
            this.userReportView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.userReportView.RowTemplate.Height = 33;
            this.userReportView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userReportView.ShowCellErrors = false;
            this.userReportView.ShowCellToolTips = false;
            this.userReportView.ShowEditingIcon = false;
            this.userReportView.ShowRowErrors = false;
            this.userReportView.Size = new System.Drawing.Size(900, 354);
            this.userReportView.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(690, 137);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(234, 46);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(602, 98);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User";
            // 
            // ScheduleUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 640);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.userReportView);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ScheduleUserLabel);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ScheduleUser";
            this.Text = "Report: Schedules by User Name";
            ((System.ComponentModel.ISupportInitialize)(this.userReportView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScheduleUserLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.DataGridView userReportView;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}