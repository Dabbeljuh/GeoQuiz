
namespace GeoQuiz
{
    partial class Login
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
            this.tb_enter_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_create_new_user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_enter_user
            // 
            this.tb_enter_user.Location = new System.Drawing.Point(75, 73);
            this.tb_enter_user.Name = "tb_enter_user";
            this.tb_enter_user.Size = new System.Drawing.Size(178, 23);
            this.tb_enter_user.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bitte geben Sie einen Namen ein";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(156, 179);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(117, 52);
            this.Btn_Login.TabIndex = 3;
            this.Btn_Login.Text = "Einloggen";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_create_new_user
            // 
            this.Btn_create_new_user.Location = new System.Drawing.Point(24, 179);
            this.Btn_create_new_user.Name = "Btn_create_new_user";
            this.Btn_create_new_user.Size = new System.Drawing.Size(117, 52);
            this.Btn_create_new_user.TabIndex = 4;
            this.Btn_create_new_user.Text = "Neuen User erstellen";
            this.Btn_create_new_user.UseVisualStyleBackColor = true;
            this.Btn_create_new_user.Click += new System.EventHandler(this.Btn_create_new_user_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 266);
            this.Controls.Add(this.Btn_create_new_user);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_enter_user);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_enter_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_create_new_user;
    }
}