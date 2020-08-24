namespace C868
{
    partial class EditTeamRoster
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
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.TeamIdLabel = new System.Windows.Forms.Label();
            this.TeamIdBox = new System.Windows.Forms.TextBox();
            this.TeamNameBox = new System.Windows.Forms.TextBox();
            this.TeamPhoneBox = new System.Windows.Forms.TextBox();
            this.TeamCityBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgCanPersonnel = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.DgAssigTeam = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCanPersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgAssigTeam)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Team Roster";
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(16, 20);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(111, 23);
            this.SearchBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(150, 20);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(109, 27);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "ID Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TeamIdLabel
            // 
            this.TeamIdLabel.AutoSize = true;
            this.TeamIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamIdLabel.Location = new System.Drawing.Point(24, 56);
            this.TeamIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TeamIdLabel.Name = "TeamIdLabel";
            this.TeamIdLabel.Size = new System.Drawing.Size(61, 17);
            this.TeamIdLabel.TabIndex = 3;
            this.TeamIdLabel.Text = "Team ID";
            // 
            // TeamIdBox
            // 
            this.TeamIdBox.BackColor = System.Drawing.SystemColors.Window;
            this.TeamIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamIdBox.Location = new System.Drawing.Point(27, 79);
            this.TeamIdBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TeamIdBox.Name = "TeamIdBox";
            this.TeamIdBox.Size = new System.Drawing.Size(58, 23);
            this.TeamIdBox.TabIndex = 4;
            this.TeamIdBox.TextChanged += new System.EventHandler(this.TeamIdBox_TextChanged);
            // 
            // TeamNameBox
            // 
            this.TeamNameBox.BackColor = System.Drawing.SystemColors.Window;
            this.TeamNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameBox.Location = new System.Drawing.Point(104, 79);
            this.TeamNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TeamNameBox.Name = "TeamNameBox";
            this.TeamNameBox.Size = new System.Drawing.Size(111, 23);
            this.TeamNameBox.TabIndex = 5;
            this.TeamNameBox.TextChanged += new System.EventHandler(this.TeamNameBox_TextChanged);
            // 
            // TeamPhoneBox
            // 
            this.TeamPhoneBox.BackColor = System.Drawing.SystemColors.Window;
            this.TeamPhoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamPhoneBox.Location = new System.Drawing.Point(352, 48);
            this.TeamPhoneBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TeamPhoneBox.Name = "TeamPhoneBox";
            this.TeamPhoneBox.Size = new System.Drawing.Size(111, 23);
            this.TeamPhoneBox.TabIndex = 6;
            this.TeamPhoneBox.TextChanged += new System.EventHandler(this.TeamPhoneBox_TextChanged);
            // 
            // TeamCityBox
            // 
            this.TeamCityBox.BackColor = System.Drawing.SystemColors.Window;
            this.TeamCityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamCityBox.Location = new System.Drawing.Point(233, 79);
            this.TeamCityBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TeamCityBox.Name = "TeamCityBox";
            this.TeamCityBox.Size = new System.Drawing.Size(111, 23);
            this.TeamCityBox.TabIndex = 7;
            this.TeamCityBox.TextChanged += new System.EventHandler(this.TeamCityBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TeamPhoneBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(481, 84);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team Information";
            // 
            // DgCanPersonnel
            // 
            this.DgCanPersonnel.AllowUserToAddRows = false;
            this.DgCanPersonnel.AllowUserToDeleteRows = false;
            this.DgCanPersonnel.AllowUserToResizeColumns = false;
            this.DgCanPersonnel.AllowUserToResizeRows = false;
            this.DgCanPersonnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgCanPersonnel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgCanPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCanPersonnel.Location = new System.Drawing.Point(16, 51);
            this.DgCanPersonnel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgCanPersonnel.MultiSelect = false;
            this.DgCanPersonnel.Name = "DgCanPersonnel";
            this.DgCanPersonnel.RowHeadersVisible = false;
            this.DgCanPersonnel.RowHeadersWidth = 82;
            this.DgCanPersonnel.RowTemplate.Height = 33;
            this.DgCanPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgCanPersonnel.ShowCellErrors = false;
            this.DgCanPersonnel.ShowCellToolTips = false;
            this.DgCanPersonnel.ShowEditingIcon = false;
            this.DgCanPersonnel.ShowRowErrors = false;
            this.DgCanPersonnel.Size = new System.Drawing.Size(444, 147);
            this.DgCanPersonnel.TabIndex = 12;
            this.DgCanPersonnel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCanPersonnel_CellContentClick);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(32, 333);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(93, 27);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DgAssigTeam
            // 
            this.DgAssigTeam.AllowUserToAddRows = false;
            this.DgAssigTeam.AllowUserToDeleteRows = false;
            this.DgAssigTeam.AllowUserToResizeColumns = false;
            this.DgAssigTeam.AllowUserToResizeRows = false;
            this.DgAssigTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgAssigTeam.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgAssigTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgAssigTeam.Location = new System.Drawing.Point(6, 31);
            this.DgAssigTeam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgAssigTeam.MultiSelect = false;
            this.DgAssigTeam.Name = "DgAssigTeam";
            this.DgAssigTeam.ReadOnly = true;
            this.DgAssigTeam.RowHeadersVisible = false;
            this.DgAssigTeam.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgAssigTeam.RowTemplate.Height = 33;
            this.DgAssigTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgAssigTeam.ShowCellErrors = false;
            this.DgAssigTeam.ShowCellToolTips = false;
            this.DgAssigTeam.ShowEditingIcon = false;
            this.DgAssigTeam.ShowRowErrors = false;
            this.DgAssigTeam.Size = new System.Drawing.Size(444, 147);
            this.DgAssigTeam.TabIndex = 14;
            this.DgAssigTeam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgAssigTeam_CellContentClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(33, 556);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(93, 27);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(384, 556);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(93, 27);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(216, 556);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(93, 27);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchBox);
            this.groupBox2.Controls.Add(this.SearchButton);
            this.groupBox2.Controls.Add(this.DgCanPersonnel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 119);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(476, 210);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available Personnel";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DgAssigTeam);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(27, 364);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(465, 188);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personnel Assigned to this Team";
            // 
            // EditTeamRoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 603);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TeamCityBox);
            this.Controls.Add(this.TeamNameBox);
            this.Controls.Add(this.TeamIdBox);
            this.Controls.Add(this.TeamIdLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditTeamRoster";
            this.Text = "Edit Team Roster";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCanPersonnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgAssigTeam)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label TeamIdLabel;
        private System.Windows.Forms.TextBox TeamIdBox;
        private System.Windows.Forms.TextBox TeamNameBox;
        private System.Windows.Forms.TextBox TeamPhoneBox;
        private System.Windows.Forms.TextBox TeamCityBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgCanPersonnel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView DgAssigTeam;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}