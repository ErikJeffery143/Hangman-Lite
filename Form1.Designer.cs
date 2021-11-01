namespace Hangman_Lite
{
    partial class frmHangman
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
            this.picHangman = new System.Windows.Forms.PictureBox();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lstGuessedLetters = new System.Windows.Forms.ListBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.lblUsedLetters = new System.Windows.Forms.Label();
            this.btnHint = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // picHangman
            // 
            this.picHangman.Image = global::Hangman_Lite.Properties.Resources._5balloon;
            this.picHangman.Location = new System.Drawing.Point(12, 12);
            this.picHangman.Name = "picHangman";
            this.picHangman.Size = new System.Drawing.Size(127, 214);
            this.picHangman.TabIndex = 0;
            this.picHangman.TabStop = false;
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(179, 147);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(58, 20);
            this.txtGuess.TabIndex = 1;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(243, 148);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 19);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lstGuessedLetters
            // 
            this.lstGuessedLetters.FormattingEnabled = true;
            this.lstGuessedLetters.ItemHeight = 11;
            this.lstGuessedLetters.Location = new System.Drawing.Point(179, 37);
            this.lstGuessedLetters.Name = "lstGuessedLetters";
            this.lstGuessedLetters.Size = new System.Drawing.Size(139, 103);
            this.lstGuessedLetters.TabIndex = 3;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(88, 303);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(111, 33);
            this.lblWord.TabIndex = 4;
            this.lblWord.Text = "______";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.Location = new System.Drawing.Point(131, 258);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(184, 24);
            this.lblHint.TabIndex = 6;
            this.lblHint.Text = "a soft, gentle breeze.";
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.Location = new System.Drawing.Point(7, 229);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(87, 25);
            this.lblLives.TabIndex = 7;
            this.lblLives.Text = "Lives: 5";
            // 
            // lblUsedLetters
            // 
            this.lblUsedLetters.AutoSize = true;
            this.lblUsedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedLetters.Location = new System.Drawing.Point(181, 16);
            this.lblUsedLetters.Name = "lblUsedLetters";
            this.lblUsedLetters.Size = new System.Drawing.Size(134, 25);
            this.lblUsedLetters.TabIndex = 8;
            this.lblUsedLetters.Text = "Used Letters";
            // 
            // btnHint
            // 
            this.btnHint.Location = new System.Drawing.Point(135, 236);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(122, 19);
            this.btnHint.TabIndex = 9;
            this.btnHint.Text = "HINT:Cost 2 lives";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(7, 362);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(87, 19);
            this.btnEnd.TabIndex = 10;
            this.btnEnd.Text = "CLOSE";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // frmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(318, 393);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.lblUsedLetters);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lstGuessedLetters);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.picHangman);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "frmHangman";
            this.Text = "Hangman_Lite";
            this.Load += new System.EventHandler(this.frmHangman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHangman;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.ListBox lstGuessedLetters;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label lblUsedLetters;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Button btnEnd;
    }
}

