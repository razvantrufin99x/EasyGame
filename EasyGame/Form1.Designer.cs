namespace EasyGame
{
    partial class Form1
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
            this.PLAYER = new EasyGame.UserControl1();
            this.userControl11 = new EasyGame.UserControl1();
            this.SuspendLayout();
            // 
            // PLAYER
            // 
            this.PLAYER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PLAYER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PLAYER.Location = new System.Drawing.Point(45, 45);
            this.PLAYER.Name = "PLAYER";
            this.PLAYER.Size = new System.Drawing.Size(40, 40);
            this.PLAYER.TabIndex = 0;
            this.PLAYER.TabStop = false;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Black;
            this.userControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControl11.Enabled = false;
            this.userControl11.Location = new System.Drawing.Point(4, 4);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(604, 606);
            this.userControl11.TabIndex = 1;
            this.userControl11.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 612);
            this.Controls.Add(this.PLAYER);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 PLAYER;
        private UserControl1 userControl11;
    }
}

