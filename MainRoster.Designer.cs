namespace C868
{
    partial class MainRoster
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
            this.PerSearchButton = new System.Windows.Forms.Button();
            this.PerSearchBox = new System.Windows.Forms.TextBox();
            this.DgPer = new System.Windows.Forms.DataGridView();
            this.PerAddButton = new System.Windows.Forms.Button();
            this.PerEditButton = new System.Windows.Forms.Button();
            this.PerDeleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TeamSearchButton = new System.Windows.Forms.Button();
            this.TeamSearchBox = new System.Windows.Forms.TextBox();
            this.DgTeam = new System.Windows.Forms.DataGridView();
            this.TeamAddButton = new System.Windows.Forms.Button();
            this.TeamEditButton = new System.Windows.Forms.Button();
            this.TeamDeleteButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgPer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgTeam)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rostering";
            // 
            // PerSearchButton
            // 
            this.PerSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerSearchButton.Location = new System.Drawing.Point(8, 18);
            this.PerSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.PerSearchButton.Name = "PerSearchButton";
            this.PerSearchButton.Size = new System.Drawing.Size(79, 23);
            this.PerSearchButton.TabIndex = 1;
            this.PerSearchButton.Text = "ID No.";
            this.PerSearchButton.UseVisualStyleBackColor = true;
            this.PerSearchButton.Click += new System.EventHandler(this.PerSearchButton_Click);
            // 
            // PerSearchBox
            // 
            this.PerSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerSearchBox.Location = new System.Drawing.Point(105, 18);
            this.PerSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.PerSearchBox.Name = "PerSearchBox";
            this.PerSearchBox.Size = new System.Drawing.Size(79, 23);
            this.PerSearchBox.TabIndex = 2;
            this.PerSearchBox.TextChanged += new System.EventHandler(this.PerSearchBox_TextChanged_1);
            // 
            // DgPer
            // 
            this.DgPer.AllowUserToAddRows = false;
            this.DgPer.AllowUserToDeleteRows = false;
            this.DgPer.AllowUserToResizeColumns = false;
            this.DgPer.AllowUserToResizeRows = false;
            this.DgPer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgPer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgPer.ColumnHeadersHeight = 46;
            this.DgPer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgPer.Location = new System.Drawing.Point(16, 109);
            this.DgPer.Margin = new System.Windows.Forms.Padding(4);
            this.DgPer.MultiSelect = false;
            this.DgPer.Name = "DgPer";
            this.DgPer.ReadOnly = true;
            this.DgPer.RowHeadersVisible = false;
            this.DgPer.RowHeadersWidth = 82;
            this.DgPer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgPer.RowTemplate.Height = 33;
            this.DgPer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgPer.ShowCellErrors = false;
            this.DgPer.ShowCellToolTips = false;
            this.DgPer.ShowEditingIcon = false;
            this.DgPer.ShowRowErrors = false;
            this.DgPer.Size = new System.Drawing.Size(711, 203);
            this.DgPer.TabIndex = 3;
            this.DgPer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPer_CellContentClick);
            // 
            // PerAddButton
            // 
            this.PerAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerAddButton.Location = new System.Drawing.Point(16, 74);
            this.PerAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.PerAddButton.Name = "PerAddButton";
            this.PerAddButton.Size = new System.Drawing.Size(79, 23);
            this.PerAddButton.TabIndex = 4;
            this.PerAddButton.Text = "Add";
            this.PerAddButton.UseVisualStyleBackColor = true;
            this.PerAddButton.Click += new System.EventHandler(this.PerAddButton_Click);
            // 
            // PerEditButton
            // 
            this.PerEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerEditButton.Location = new System.Drawing.Point(327, 74);
            this.PerEditButton.Margin = new System.Windows.Forms.Padding(4);
            this.PerEditButton.Name = "PerEditButton";
            this.PerEditButton.Size = new System.Drawing.Size(79, 23);
            this.PerEditButton.TabIndex = 5;
            this.PerEditButton.Text = "Edit";
            this.PerEditButton.UseVisualStyleBackColor = true;
            this.PerEditButton.Click += new System.EventHandler(this.PerEditButton_Click);
            // 
            // PerDeleteButton
            // 
            this.PerDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerDeleteButton.Location = new System.Drawing.Point(648, 74);
            this.PerDeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.PerDeleteButton.Name = "PerDeleteButton";
            this.PerDeleteButton.Size = new System.Drawing.Size(79, 23);
            this.PerDeleteButton.TabIndex = 6;
            this.PerDeleteButton.Text = "Delete";
            this.PerDeleteButton.UseVisualStyleBackColor = true;
            this.PerDeleteButton.Click += new System.EventHandler(this.PerDeleteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PerSearchButton);
            this.groupBox1.Controls.Add(this.PerSearchBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(194, 51);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PerAddButton);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.PerEditButton);
            this.groupBox2.Controls.Add(this.PerDeleteButton);
            this.groupBox2.Controls.Add(this.DgPer);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(748, 332);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personnel";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TeamSearchButton
            // 
            this.TeamSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamSearchButton.Location = new System.Drawing.Point(8, 19);
            this.TeamSearchButton.Name = "TeamSearchButton";
            this.TeamSearchButton.Size = new System.Drawing.Size(79, 23);
            this.TeamSearchButton.TabIndex = 9;
            this.TeamSearchButton.Text = "ID No.";
            this.TeamSearchButton.UseVisualStyleBackColor = true;
            this.TeamSearchButton.Click += new System.EventHandler(this.TeamSearchButton_Click);
            // 
            // TeamSearchBox
            // 
            this.TeamSearchBox.Location = new System.Drawing.Point(105, 18);
            this.TeamSearchBox.Name = "TeamSearchBox";
            this.TeamSearchBox.Size = new System.Drawing.Size(89, 23);
            this.TeamSearchBox.TabIndex = 10;
            // 
            // DgTeam
            // 
            this.DgTeam.AllowUserToAddRows = false;
            this.DgTeam.AllowUserToDeleteRows = false;
            this.DgTeam.AllowUserToResizeColumns = false;
            this.DgTeam.AllowUserToResizeRows = false;
            this.DgTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgTeam.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgTeam.ColumnHeadersHeight = 46;
            this.DgTeam.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgTeam.Location = new System.Drawing.Point(8, 127);
            this.DgTeam.MultiSelect = false;
            this.DgTeam.Name = "DgTeam";
            this.DgTeam.ReadOnly = true;
            this.DgTeam.RowHeadersVisible = false;
            this.DgTeam.RowHeadersWidth = 82;
            this.DgTeam.RowTemplate.Height = 33;
            this.DgTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgTeam.ShowCellErrors = false;
            this.DgTeam.ShowCellToolTips = false;
            this.DgTeam.ShowEditingIcon = false;
            this.DgTeam.ShowRowErrors = false;
            this.DgTeam.Size = new System.Drawing.Size(711, 236);
            this.DgTeam.TabIndex = 11;
            this.DgTeam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgTeam_CellContentClick);
            // 
            // TeamAddButton
            // 
            this.TeamAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamAddButton.Location = new System.Drawing.Point(16, 91);
            this.TeamAddButton.Name = "TeamAddButton";
            this.TeamAddButton.Size = new System.Drawing.Size(79, 23);
            this.TeamAddButton.TabIndex = 12;
            this.TeamAddButton.Text = "Add";
            this.TeamAddButton.UseVisualStyleBackColor = true;
            this.TeamAddButton.Click += new System.EventHandler(this.TeamAddButton_Click);
            // 
            // TeamEditButton
            // 
            this.TeamEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamEditButton.Location = new System.Drawing.Point(319, 91);
            this.TeamEditButton.Name = "TeamEditButton";
            this.TeamEditButton.Size = new System.Drawing.Size(79, 23);
            this.TeamEditButton.TabIndex = 13;
            this.TeamEditButton.Text = "Edit";
            this.TeamEditButton.UseVisualStyleBackColor = true;
            this.TeamEditButton.Click += new System.EventHandler(this.TeamEditButton_Click);
            // 
            // TeamDeleteButton
            // 
            this.TeamDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamDeleteButton.Location = new System.Drawing.Point(640, 91);
            this.TeamDeleteButton.Name = "TeamDeleteButton";
            this.TeamDeleteButton.Size = new System.Drawing.Size(79, 23);
            this.TeamDeleteButton.TabIndex = 14;
            this.TeamDeleteButton.Text = "Delete";
            this.TeamDeleteButton.UseVisualStyleBackColor = true;
            this.TeamDeleteButton.Click += new System.EventHandler(this.TeamDeleteButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TeamSearchButton);
            this.groupBox3.Controls.Add(this.TeamSearchBox);
            this.groupBox3.Location = new System.Drawing.Point(8, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 57);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DgTeam);
            this.groupBox4.Controls.Add(this.TeamDeleteButton);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.TeamEditButton);
            this.groupBox4.Controls.Add(this.TeamAddButton);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(23, 365);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(740, 378);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Teams";
            // 
            // MainRoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 758);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainRoster";
            this.Text = "Main Rostering";
            ((System.ComponentModel.ISupportInitialize)(this.DgPer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgTeam)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PerSearchButton;
        private System.Windows.Forms.TextBox PerSearchBox;
        private System.Windows.Forms.DataGridView DgPer;
        private System.Windows.Forms.Button PerAddButton;
        private System.Windows.Forms.Button PerEditButton;
        private System.Windows.Forms.Button PerDeleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button TeamSearchButton;
        private System.Windows.Forms.TextBox TeamSearchBox;
        private System.Windows.Forms.DataGridView DgTeam;
        private System.Windows.Forms.Button TeamAddButton;
        private System.Windows.Forms.Button TeamEditButton;
        private System.Windows.Forms.Button TeamDeleteButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}