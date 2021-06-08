
namespace AirHockey
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.outputText = new System.Windows.Forms.Label();
            this.score1output = new System.Windows.Forms.Label();
            this.score2output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.Color.Silver;
            this.outputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.outputText.Location = new System.Drawing.Point(192, 301);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(280, 138);
            this.outputText.TabIndex = 0;
            this.outputText.Text = "label1";
            this.outputText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outputText.Visible = false;
            // 
            // score1output
            // 
            this.score1output.BackColor = System.Drawing.Color.Silver;
            this.score1output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1output.Location = new System.Drawing.Point(587, 701);
            this.score1output.Name = "score1output";
            this.score1output.Size = new System.Drawing.Size(56, 61);
            this.score1output.TabIndex = 1;
            this.score1output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score2output
            // 
            this.score2output.BackColor = System.Drawing.Color.Silver;
            this.score2output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2output.Location = new System.Drawing.Point(583, 18);
            this.score2output.Name = "score2output";
            this.score2output.Size = new System.Drawing.Size(60, 58);
            this.score2output.TabIndex = 2;
            this.score2output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(655, 771);
            this.Controls.Add(this.score2output);
            this.Controls.Add(this.score1output);
            this.Controls.Add(this.outputText);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label outputText;
        private System.Windows.Forms.Label score1output;
        private System.Windows.Forms.Label score2output;
    }
}

