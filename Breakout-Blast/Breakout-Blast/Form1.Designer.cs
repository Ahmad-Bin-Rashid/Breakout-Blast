namespace Breakout_Blast
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
            this.components = new System.ComponentModel.Container();
            this.ScoreLb = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.ResultLb = new System.Windows.Forms.Label();
            this.PlayAgainMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreLb
            // 
            this.ScoreLb.AutoSize = true;
            this.ScoreLb.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ScoreLb.Location = new System.Drawing.Point(676, 17);
            this.ScoreLb.Name = "ScoreLb";
            this.ScoreLb.Size = new System.Drawing.Size(91, 25);
            this.ScoreLb.TabIndex = 0;
            this.ScoreLb.Text = "Score: 0";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Player.Location = new System.Drawing.Point(370, 505);
            this.Player.Margin = new System.Windows.Forms.Padding(0);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(100, 25);
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            this.Player.Tag = "Player";
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Gold;
            this.Ball.Location = new System.Drawing.Point(401, 340);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(15, 15);
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            this.Ball.Tag = "Ball";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // ResultLb
            // 
            this.ResultLb.AutoSize = true;
            this.ResultLb.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLb.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ResultLb.Location = new System.Drawing.Point(243, 226);
            this.ResultLb.Name = "ResultLb";
            this.ResultLb.Size = new System.Drawing.Size(139, 36);
            this.ResultLb.TabIndex = 2;
            this.ResultLb.Text = "You Win !!";
            this.ResultLb.Visible = false;
            // 
            // PlayAgainMsg
            // 
            this.PlayAgainMsg.AutoSize = true;
            this.PlayAgainMsg.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgainMsg.ForeColor = System.Drawing.Color.Blue;
            this.PlayAgainMsg.Location = new System.Drawing.Point(243, 262);
            this.PlayAgainMsg.Name = "PlayAgainMsg";
            this.PlayAgainMsg.Size = new System.Drawing.Size(325, 36);
            this.PlayAgainMsg.TabIndex = 2;
            this.PlayAgainMsg.Text = "Press Enter to Play Again...";
            this.PlayAgainMsg.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(796, 537);
            this.Controls.Add(this.PlayAgainMsg);
            this.Controls.Add(this.ResultLb);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.ScoreLb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Breakout-Blast";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpEvent);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreLb;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label ResultLb;
        private System.Windows.Forms.Label PlayAgainMsg;
    }
}

