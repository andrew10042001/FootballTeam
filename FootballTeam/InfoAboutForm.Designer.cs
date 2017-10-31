namespace FootballTeam
{
    partial class InfoAboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoAboutForm));
            this.dg_players = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EfficiencyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_seach = new System.Windows.Forms.GroupBox();
            this.cb_team = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_country = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_city = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_players)).BeginInit();
            this.gb_seach.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_players
            // 
            this.dg_players.AllowUserToAddRows = false;
            this.dg_players.AllowUserToDeleteRows = false;
            this.dg_players.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dg_players.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_players.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.RoleColumn,
            this.AgeColumn,
            this.NameColumn,
            this.PositionColumn,
            this.EfficiencyColumn});
            this.dg_players.Location = new System.Drawing.Point(12, 71);
            this.dg_players.Name = "dg_players";
            this.dg_players.ReadOnly = true;
            this.dg_players.Size = new System.Drawing.Size(808, 385);
            this.dg_players.TabIndex = 1;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            this.IdColumn.Width = 5;
            // 
            // RoleColumn
            // 
            this.RoleColumn.HeaderText = "Role";
            this.RoleColumn.Name = "RoleColumn";
            this.RoleColumn.ReadOnly = true;
            // 
            // AgeColumn
            // 
            this.AgeColumn.HeaderText = "Age";
            this.AgeColumn.Name = "AgeColumn";
            this.AgeColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 200;
            // 
            // PositionColumn
            // 
            this.PositionColumn.HeaderText = "Position";
            this.PositionColumn.Name = "PositionColumn";
            this.PositionColumn.ReadOnly = true;
            this.PositionColumn.Width = 150;
            // 
            // EfficiencyColumn
            // 
            this.EfficiencyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EfficiencyColumn.HeaderText = "Efficiency";
            this.EfficiencyColumn.Name = "EfficiencyColumn";
            this.EfficiencyColumn.ReadOnly = true;
            // 
            // gb_seach
            // 
            this.gb_seach.BackColor = System.Drawing.Color.Transparent;
            this.gb_seach.Controls.Add(this.cb_team);
            this.gb_seach.Controls.Add(this.label3);
            this.gb_seach.Controls.Add(this.cb_country);
            this.gb_seach.Controls.Add(this.label2);
            this.gb_seach.Controls.Add(this.cb_city);
            this.gb_seach.Controls.Add(this.btn_search);
            this.gb_seach.Controls.Add(this.label1);
            this.gb_seach.ForeColor = System.Drawing.Color.White;
            this.gb_seach.Location = new System.Drawing.Point(12, 12);
            this.gb_seach.Name = "gb_seach";
            this.gb_seach.Size = new System.Drawing.Size(808, 53);
            this.gb_seach.TabIndex = 2;
            this.gb_seach.TabStop = false;
            this.gb_seach.Text = "Search";
            // 
            // cb_team
            // 
            this.cb_team.FormattingEnabled = true;
            this.cb_team.Location = new System.Drawing.Point(484, 20);
            this.cb_team.Name = "cb_team";
            this.cb_team.Size = new System.Drawing.Size(201, 21);
            this.cb_team.TabIndex = 6;
            this.cb_team.SelectedIndexChanged += new System.EventHandler(this.cb_team_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(425, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Team:";
            // 
            // cb_country
            // 
            this.cb_country.FormattingEnabled = true;
            this.cb_country.Location = new System.Drawing.Point(91, 20);
            this.cb_country.Name = "cb_country";
            this.cb_country.Size = new System.Drawing.Size(132, 21);
            this.cb_country.TabIndex = 4;
            this.cb_country.SelectedIndexChanged += new System.EventHandler(this.cb_country_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Country:";
            // 
            // cb_city
            // 
            this.cb_city.FormattingEnabled = true;
            this.cb_city.Location = new System.Drawing.Point(274, 20);
            this.cb_city.Name = "cb_city";
            this.cb_city.Size = new System.Drawing.Size(145, 21);
            this.cb_city.TabIndex = 2;
            this.cb_city.SelectedIndexChanged += new System.EventHandler(this.cb_city_SelectedIndexChanged);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Navy;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_search.Location = new System.Drawing.Point(704, 13);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(98, 31);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(229, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // InfoAboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(833, 468);
            this.Controls.Add(this.dg_players);
            this.Controls.Add(this.gb_seach);
            this.Name = "InfoAboutForm";
            this.Text = "InfoAbout";
            ((System.ComponentModel.ISupportInitialize)(this.dg_players)).EndInit();
            this.gb_seach.ResumeLayout(false);
            this.gb_seach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_players;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EfficiencyColumn;
        private System.Windows.Forms.GroupBox gb_seach;
        private System.Windows.Forms.ComboBox cb_team;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_country;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_city;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
    }
}