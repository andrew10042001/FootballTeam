namespace FootballTeam
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_showteaminfo = new System.Windows.Forms.Button();
            this.lb_name_secondteam = new System.Windows.Forms.Label();
            this.lb_name_firstteam = new System.Windows.Forms.Label();
            this.btn_moreinfo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_goals_secondteam = new System.Windows.Forms.Label();
            this.lb_goals_firstteam = new System.Windows.Forms.Label();
            this.cb_secondteam = new System.Windows.Forms.ComboBox();
            this.btn_play = new System.Windows.Forms.Button();
            this.cb_firstteam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_showteaminfo
            // 
            this.btn_showteaminfo.BackColor = System.Drawing.Color.Green;
            this.btn_showteaminfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_showteaminfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_showteaminfo.ForeColor = System.Drawing.Color.White;
            this.btn_showteaminfo.Location = new System.Drawing.Point(-2, -1);
            this.btn_showteaminfo.Name = "btn_showteaminfo";
            this.btn_showteaminfo.Size = new System.Drawing.Size(637, 31);
            this.btn_showteaminfo.TabIndex = 22;
            this.btn_showteaminfo.Text = "БАЗА ДАНИХ КОМАНД";
            this.btn_showteaminfo.UseVisualStyleBackColor = false;
            this.btn_showteaminfo.Click += new System.EventHandler(this.btn_showteaminfo_Click);
            // 
            // lb_name_secondteam
            // 
            this.lb_name_secondteam.AutoSize = true;
            this.lb_name_secondteam.BackColor = System.Drawing.Color.Transparent;
            this.lb_name_secondteam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_name_secondteam.ForeColor = System.Drawing.Color.White;
            this.lb_name_secondteam.Location = new System.Drawing.Point(381, 291);
            this.lb_name_secondteam.Name = "lb_name_secondteam";
            this.lb_name_secondteam.Size = new System.Drawing.Size(15, 18);
            this.lb_name_secondteam.TabIndex = 21;
            this.lb_name_secondteam.Text = "*";
            // 
            // lb_name_firstteam
            // 
            this.lb_name_firstteam.AutoSize = true;
            this.lb_name_firstteam.BackColor = System.Drawing.Color.Transparent;
            this.lb_name_firstteam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_name_firstteam.ForeColor = System.Drawing.Color.White;
            this.lb_name_firstteam.Location = new System.Drawing.Point(126, 291);
            this.lb_name_firstteam.Name = "lb_name_firstteam";
            this.lb_name_firstteam.Size = new System.Drawing.Size(15, 18);
            this.lb_name_firstteam.TabIndex = 20;
            this.lb_name_firstteam.Text = "*";
            // 
            // btn_moreinfo
            // 
            this.btn_moreinfo.BackColor = System.Drawing.Color.Green;
            this.btn_moreinfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_moreinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_moreinfo.ForeColor = System.Drawing.Color.White;
            this.btn_moreinfo.Location = new System.Drawing.Point(93, 352);
            this.btn_moreinfo.Name = "btn_moreinfo";
            this.btn_moreinfo.Size = new System.Drawing.Size(450, 49);
            this.btn_moreinfo.TabIndex = 19;
            this.btn_moreinfo.Text = "More information";
            this.btn_moreinfo.UseVisualStyleBackColor = false;
            this.btn_moreinfo.Click += new System.EventHandler(this.btn_moreinfo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(379, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Choose team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Choose team";
            // 
            // lb_goals_secondteam
            // 
            this.lb_goals_secondteam.AutoSize = true;
            this.lb_goals_secondteam.BackColor = System.Drawing.Color.Transparent;
            this.lb_goals_secondteam.Font = new System.Drawing.Font("Microsoft Sans Serif", 159.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_goals_secondteam.ForeColor = System.Drawing.Color.White;
            this.lb_goals_secondteam.Location = new System.Drawing.Point(350, 78);
            this.lb_goals_secondteam.Name = "lb_goals_secondteam";
            this.lb_goals_secondteam.Size = new System.Drawing.Size(220, 241);
            this.lb_goals_secondteam.TabIndex = 16;
            this.lb_goals_secondteam.Text = "0";
            // 
            // lb_goals_firstteam
            // 
            this.lb_goals_firstteam.AutoSize = true;
            this.lb_goals_firstteam.BackColor = System.Drawing.Color.Transparent;
            this.lb_goals_firstteam.Font = new System.Drawing.Font("Microsoft Sans Serif", 159.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_goals_firstteam.ForeColor = System.Drawing.Color.White;
            this.lb_goals_firstteam.Location = new System.Drawing.Point(85, 78);
            this.lb_goals_firstteam.Name = "lb_goals_firstteam";
            this.lb_goals_firstteam.Size = new System.Drawing.Size(220, 241);
            this.lb_goals_firstteam.TabIndex = 15;
            this.lb_goals_firstteam.Text = "0";
            // 
            // cb_secondteam
            // 
            this.cb_secondteam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_secondteam.FormattingEnabled = true;
            this.cb_secondteam.Location = new System.Drawing.Point(382, 51);
            this.cb_secondteam.Name = "cb_secondteam";
            this.cb_secondteam.Size = new System.Drawing.Size(192, 28);
            this.cb_secondteam.TabIndex = 14;
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Green;
            this.btn_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_play.ForeColor = System.Drawing.Color.White;
            this.btn_play.Location = new System.Drawing.Point(278, 49);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 30);
            this.btn_play.TabIndex = 13;
            this.btn_play.Text = "PLAY";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // cb_firstteam
            // 
            this.cb_firstteam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_firstteam.FormattingEnabled = true;
            this.cb_firstteam.Location = new System.Drawing.Point(64, 49);
            this.cb_firstteam.Name = "cb_firstteam";
            this.cb_firstteam.Size = new System.Drawing.Size(192, 28);
            this.cb_firstteam.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(632, 429);
            this.Controls.Add(this.btn_showteaminfo);
            this.Controls.Add(this.lb_name_secondteam);
            this.Controls.Add(this.lb_name_firstteam);
            this.Controls.Add(this.btn_moreinfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_goals_secondteam);
            this.Controls.Add(this.lb_goals_firstteam);
            this.Controls.Add(this.cb_secondteam);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.cb_firstteam);
            this.Name = "MainForm";
            this.Text = "Football";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_showteaminfo;
        private System.Windows.Forms.Label lb_name_secondteam;
        private System.Windows.Forms.Label lb_name_firstteam;
        private System.Windows.Forms.Button btn_moreinfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_goals_secondteam;
        private System.Windows.Forms.Label lb_goals_firstteam;
        private System.Windows.Forms.ComboBox cb_secondteam;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.ComboBox cb_firstteam;
    }
}

