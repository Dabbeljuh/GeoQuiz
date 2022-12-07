
namespace GeoQuiz
{
    partial class QFlag
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
            this.pb_Flags = new System.Windows.Forms.PictureBox();
            this.gBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Flags)).BeginInit();
            this.SuspendLayout();
            // 
            // gBox1
            // 
            this.gBox1.Controls.Add(this.pb_Flags);
            this.gBox1.Text = "Frage: 0 / 10";
            this.gBox1.Controls.SetChildIndex(this.labelQVar, 0);
            this.gBox1.Controls.SetChildIndex(this.labelQ, 0);
            this.gBox1.Controls.SetChildIndex(this.pb_Flags, 0);
            // 
            // pb_Flags
            // 
            this.pb_Flags.Location = new System.Drawing.Point(259, 22);
            this.pb_Flags.Name = "pb_Flags";
            this.pb_Flags.Size = new System.Drawing.Size(250, 125);
            this.pb_Flags.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Flags.TabIndex = 8;
            this.pb_Flags.TabStop = false;
            // 
            // QFlag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Name = "QFlag";
            this.Text = "Flaggen";
            this.gBox1.ResumeLayout(false);
            this.gBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Flags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Flags;
    }
}