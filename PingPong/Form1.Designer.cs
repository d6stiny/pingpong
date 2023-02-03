namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playground = new System.Windows.Forms.Panel();
            this.scoreText = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            //
            // playground
            //
            this.playground.Controls.Add(this.label1);
            this.playground.Controls.Add(this.scoreText);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(1227, 1112);
            this.playground.TabIndex = 0;
            //
            // scoreText
            //
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Comic Sans MS", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreText.Location = new System.Drawing.Point(39, 26);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(209, 60);
            this.scoreText.TabIndex = 3;
            this.scoreText.Text = "Score: 0";
            //
            // ball
            //
            this.ball.BackColor = System.Drawing.Color.LightCoral;
            this.ball.Location = new System.Drawing.Point(549, 921);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            //
            // racket
            //
            this.racket.BackColor = System.Drawing.SystemColors.HotTrack;
            this.racket.Location = new System.Drawing.Point(474, 976);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 20);
            this.racket.TabIndex = 1;
            this.racket.TabStop = false;
            //
            // timer1
            //
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(357, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 384);
            this.label1.TabIndex = 4;
            this.label1.Text = "Game Over\r\n\r\nF1 - Restart\r\nESC - Exit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 1112);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Ping Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel playground;
        private PictureBox ball;
        private PictureBox racket;
        private System.Windows.Forms.Timer timer1;
        private Label scoreText;
        private Label label1;
    }
}
