
namespace GeoQuiz
{
    partial class EndResult
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
            this.EndScore = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGV_Endresult_Single = new System.Windows.Forms.DataGridView();
            this.Platz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGV_EndResult_all = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Menu = new System.Windows.Forms.Button();
            this.Btn_restart = new System.Windows.Forms.Button();
            this.lb_end = new System.Windows.Forms.Label();
            this.lb_cheated = new System.Windows.Forms.Label();
            this.EndScore.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Endresult_Single)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_EndResult_all)).BeginInit();
            this.SuspendLayout();
            // 
            // EndScore
            // 
            this.EndScore.Controls.Add(this.tabPage1);
            this.EndScore.Controls.Add(this.tabPage2);
            this.EndScore.Location = new System.Drawing.Point(307, 187);
            this.EndScore.Name = "EndScore";
            this.EndScore.SelectedIndex = 0;
            this.EndScore.Size = new System.Drawing.Size(565, 362);
            this.EndScore.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGV_Endresult_Single);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(557, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "pers. Score";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGV_Endresult_Single
            // 
            this.DGV_Endresult_Single.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Endresult_Single.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Endresult_Single.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Platz,
            this.Score,
            this.Datum});
            this.DGV_Endresult_Single.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Endresult_Single.Location = new System.Drawing.Point(3, 3);
            this.DGV_Endresult_Single.Name = "DGV_Endresult_Single";
            this.DGV_Endresult_Single.RowTemplate.Height = 25;
            this.DGV_Endresult_Single.Size = new System.Drawing.Size(551, 328);
            this.DGV_Endresult_Single.TabIndex = 0;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGV_EndResult_all);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(557, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Score - All";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGV_EndResult_all
            // 
            this.DGV_EndResult_all.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_EndResult_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_EndResult_all.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Username,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.DGV_EndResult_all.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_EndResult_all.Location = new System.Drawing.Point(3, 3);
            this.DGV_EndResult_all.Name = "DGV_EndResult_all";
            this.DGV_EndResult_all.RowTemplate.Height = 25;
            this.DGV_EndResult_all.Size = new System.Drawing.Size(551, 328);
            this.DGV_EndResult_all.TabIndex = 0;
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
            // Btn_Menu
            // 
            this.Btn_Menu.Location = new System.Drawing.Point(151, 377);
            this.Btn_Menu.Name = "Btn_Menu";
            this.Btn_Menu.Size = new System.Drawing.Size(137, 47);
            this.Btn_Menu.TabIndex = 1;
            this.Btn_Menu.Text = "Zurück zum Menü";
            this.Btn_Menu.UseVisualStyleBackColor = true;
            this.Btn_Menu.Click += new System.EventHandler(this.Btn_Menu_Click);
            // 
            // Btn_restart
            // 
            this.Btn_restart.Location = new System.Drawing.Point(151, 441);
            this.Btn_restart.Name = "Btn_restart";
            this.Btn_restart.Size = new System.Drawing.Size(137, 47);
            this.Btn_restart.TabIndex = 2;
            this.Btn_restart.Text = "Neustarten";
            this.Btn_restart.UseVisualStyleBackColor = true;
            this.Btn_restart.Click += new System.EventHandler(this.Btn_restart_Click);
            // 
            // lb_end
            // 
            this.lb_end.AutoSize = true;
            this.lb_end.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_end.Location = new System.Drawing.Point(41, 27);
            this.lb_end.Name = "lb_end";
            this.lb_end.Size = new System.Drawing.Size(68, 25);
            this.lb_end.TabIndex = 3;
            this.lb_end.Text = "lb_end";
            // 
            // lb_cheated
            // 
            this.lb_cheated.AutoSize = true;
            this.lb_cheated.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_cheated.Location = new System.Drawing.Point(335, 93);
            this.lb_cheated.Name = "lb_cheated";
            this.lb_cheated.Size = new System.Drawing.Size(135, 30);
            this.lb_cheated.TabIndex = 4;
            this.lb_cheated.Text = "cheater_label";
            this.lb_cheated.Visible = false;
            // 
            // EndResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lb_cheated);
            this.Controls.Add(this.lb_end);
            this.Controls.Add(this.Btn_restart);
            this.Controls.Add(this.Btn_Menu);
            this.Controls.Add(this.EndScore);
            this.Name = "EndResult";
            this.Text = "EndResult";
            this.EndScore.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Endresult_Single)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_EndResult_all)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl EndScore;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGV_Endresult_Single;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridView DGV_EndResult_all;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button Btn_Menu;
        private System.Windows.Forms.Button Btn_restart;
        private System.Windows.Forms.Label lb_end;
        private System.Windows.Forms.Label lb_cheated;
    }
}