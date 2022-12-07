
namespace GeoQuiz
{
    partial class Menu
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
            this.lb_username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_logout = new System.Windows.Forms.Button();
            this.rb_country = new System.Windows.Forms.RadioButton();
            this.rb_capital = new System.Windows.Forms.RadioButton();
            this.rb_flag = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_start = new System.Windows.Forms.Button();
            this.tab_score = new System.Windows.Forms.TabControl();
            this.tab_personal_score = new System.Windows.Forms.TabPage();
            this.pn_noscore = new System.Windows.Forms.Panel();
            this.lb_noscore = new System.Windows.Forms.Label();
            this.DGV_single = new System.Windows.Forms.DataGridView();
            this.Platz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_alltime_score = new System.Windows.Forms.TabPage();
            this.DGV_all = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_score_kat = new System.Windows.Forms.Label();
            this.tab_score.SuspendLayout();
            this.tab_personal_score.SuspendLayout();
            this.pn_noscore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_single)).BeginInit();
            this.tab_alltime_score.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_all)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(157, 530);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(38, 15);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "username:";
            // 
            // Btn_logout
            // 
            this.Btn_logout.Location = new System.Drawing.Point(12, 526);
            this.Btn_logout.Name = "Btn_logout";
            this.Btn_logout.Size = new System.Drawing.Size(67, 23);
            this.Btn_logout.TabIndex = 2;
            this.Btn_logout.Text = "logout";
            this.Btn_logout.UseVisualStyleBackColor = true;
            this.Btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // rb_country
            // 
            this.rb_country.AutoSize = true;
            this.rb_country.Checked = true;
            this.rb_country.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_country.Location = new System.Drawing.Point(31, 110);
            this.rb_country.Name = "rb_country";
            this.rb_country.Size = new System.Drawing.Size(92, 29);
            this.rb_country.TabIndex = 3;
            this.rb_country.TabStop = true;
            this.rb_country.Text = "Länder";
            this.rb_country.UseVisualStyleBackColor = true;
            this.rb_country.CheckedChanged += new System.EventHandler(this.rb_country_CheckedChanged);
            // 
            // rb_capital
            // 
            this.rb_capital.AutoSize = true;
            this.rb_capital.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_capital.Location = new System.Drawing.Point(31, 194);
            this.rb_capital.Name = "rb_capital";
            this.rb_capital.Size = new System.Drawing.Size(140, 29);
            this.rb_capital.TabIndex = 4;
            this.rb_capital.Text = "Hauptstädte";
            this.rb_capital.UseVisualStyleBackColor = true;
            this.rb_capital.CheckedChanged += new System.EventHandler(this.rb_capital_CheckedChanged);
            // 
            // rb_flag
            // 
            this.rb_flag.AutoSize = true;
            this.rb_flag.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_flag.Location = new System.Drawing.Point(31, 279);
            this.rb_flag.Name = "rb_flag";
            this.rb_flag.Size = new System.Drawing.Size(101, 29);
            this.rb_flag.TabIndex = 5;
            this.rb_flag.Text = "Flaggen";
            this.rb_flag.UseVisualStyleBackColor = true;
            this.rb_flag.CheckedChanged += new System.EventHandler(this.rb_flag_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(69, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Spielmodus";
            // 
            // Btn_start
            // 
            this.Btn_start.Location = new System.Drawing.Point(157, 364);
            this.Btn_start.Name = "Btn_start";
            this.Btn_start.Size = new System.Drawing.Size(122, 40);
            this.Btn_start.TabIndex = 7;
            this.Btn_start.Text = "starten";
            this.Btn_start.UseVisualStyleBackColor = true;
            this.Btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // tab_score
            // 
            this.tab_score.Controls.Add(this.tab_personal_score);
            this.tab_score.Controls.Add(this.tab_alltime_score);
            this.tab_score.Location = new System.Drawing.Point(328, 41);
            this.tab_score.Name = "tab_score";
            this.tab_score.SelectedIndex = 0;
            this.tab_score.Size = new System.Drawing.Size(527, 488);
            this.tab_score.TabIndex = 8;
            // 
            // tab_personal_score
            // 
            this.tab_personal_score.Controls.Add(this.pn_noscore);
            this.tab_personal_score.Controls.Add(this.DGV_single);
            this.tab_personal_score.Location = new System.Drawing.Point(4, 24);
            this.tab_personal_score.Name = "tab_personal_score";
            this.tab_personal_score.Padding = new System.Windows.Forms.Padding(3);
            this.tab_personal_score.Size = new System.Drawing.Size(519, 460);
            this.tab_personal_score.TabIndex = 0;
            this.tab_personal_score.Text = "Score - Eigener";
            this.tab_personal_score.UseVisualStyleBackColor = true;
            // 
            // pn_noscore
            // 
            this.pn_noscore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_noscore.Controls.Add(this.lb_noscore);
            this.pn_noscore.Location = new System.Drawing.Point(-4, 0);
            this.pn_noscore.Name = "pn_noscore";
            this.pn_noscore.Size = new System.Drawing.Size(527, 464);
            this.pn_noscore.TabIndex = 1;
            this.pn_noscore.Visible = false;
            // 
            // lb_noscore
            // 
            this.lb_noscore.AutoSize = true;
            this.lb_noscore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_noscore.Location = new System.Drawing.Point(35, 42);
            this.lb_noscore.Name = "lb_noscore";
            this.lb_noscore.Size = new System.Drawing.Size(121, 30);
            this.lb_noscore.TabIndex = 0;
            this.lb_noscore.Text = "placeholder";
            // 
            // DGV_single
            // 
            this.DGV_single.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_single.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_single.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Platz,
            this.Score,
            this.Datum});
            this.DGV_single.Location = new System.Drawing.Point(0, 0);
            this.DGV_single.Name = "DGV_single";
            this.DGV_single.RowTemplate.Height = 25;
            this.DGV_single.Size = new System.Drawing.Size(505, 436);
            this.DGV_single.TabIndex = 0;
            // 
            // Platz
            // 
            this.Platz.HeaderText = "Platz";
            this.Platz.Name = "Platz";
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // tab_alltime_score
            // 
            this.tab_alltime_score.Controls.Add(this.DGV_all);
            this.tab_alltime_score.Location = new System.Drawing.Point(4, 24);
            this.tab_alltime_score.Name = "tab_alltime_score";
            this.tab_alltime_score.Padding = new System.Windows.Forms.Padding(3);
            this.tab_alltime_score.Size = new System.Drawing.Size(519, 460);
            this.tab_alltime_score.TabIndex = 1;
            this.tab_alltime_score.Text = "Score - gesamt";
            this.tab_alltime_score.UseVisualStyleBackColor = true;
            // 
            // DGV_all
            // 
            this.DGV_all.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_all.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Username,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.DGV_all.Location = new System.Drawing.Point(0, 5);
            this.DGV_all.Name = "DGV_all";
            this.DGV_all.RowTemplate.Height = 25;
            this.DGV_all.Size = new System.Drawing.Size(507, 433);
            this.DGV_all.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Platz";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Score";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // lb_score_kat
            // 
            this.lb_score_kat.AutoSize = true;
            this.lb_score_kat.Location = new System.Drawing.Point(546, 23);
            this.lb_score_kat.Name = "lb_score_kat";
            this.lb_score_kat.Size = new System.Drawing.Size(41, 15);
            this.lb_score_kat.TabIndex = 9;
            this.lb_score_kat.Text = "Scores";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lb_score_kat);
            this.Controls.Add(this.tab_score);
            this.Controls.Add(this.Btn_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rb_flag);
            this.Controls.Add(this.rb_capital);
            this.Controls.Add(this.rb_country);
            this.Controls.Add(this.Btn_logout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_username);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tab_score.ResumeLayout(false);
            this.tab_personal_score.ResumeLayout(false);
            this.pn_noscore.ResumeLayout(false);
            this.pn_noscore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_single)).EndInit();
            this.tab_alltime_score.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_all)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_logout;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.RadioButton rb_country;
        private System.Windows.Forms.RadioButton rb_capital;
        private System.Windows.Forms.RadioButton rb_flag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_start;
        private System.Windows.Forms.TabControl tab_score;
        private System.Windows.Forms.TabPage tab_personal_score;
        private System.Windows.Forms.TabPage tab_alltime_score;
        private System.Windows.Forms.Label lb_score_kat;
        private System.Windows.Forms.DataGridView DGV_single;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridView DGV_all;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel pn_noscore;
        private System.Windows.Forms.Label lb_noscore;
    }
}