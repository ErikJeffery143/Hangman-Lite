using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_Lite
{
    public partial class frmHangman : Form
    {
        string word = "ZEPHYR";
        int lives = 5;
        string displayWord = "______";
        List<string> Guesses = new List<string>();
        public frmHangman()
        {
            InitializeComponent();
        }

        private void frmHangman_Load(object sender, EventArgs e)
        {
            lblHint.Visible = false;
            lblLives.Text = ("Lives: " + lives);

        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            lblHint.Visible = true;
            lives = lives - 2;
            lblLives.Text = ("Lives: " + lives);
            btnHint.Visible = false;

            if (lives == 2)
            {
                picHangman.Image = Hangman_Lite.Properties.Resources._2balloon;
            }

            if (lives == 3)
            {
                picHangman.Image = Hangman_Lite.Properties.Resources._3Balloon;
            }

            if (lives == 1)
            {
                picHangman.Image = Hangman_Lite.Properties.Resources._1Balloon;
            }

            if (lives == 4)
            {
                picHangman.Image = Hangman_Lite.Properties.Resources._4balloon;
            }

            if (lives == 5)
            {
                picHangman.Image = Hangman_Lite.Properties.Resources._5balloon;
            }

            if (lives <= 0)
            {

                this.Close();

            }


        }

        private void btnGuess_Click(object sender, EventArgs e)
        { 
            
            txtGuess.Text = txtGuess.Text.ToUpper();
            int index = word.IndexOf(txtGuess.Text);
            if (word.IndexOf(txtGuess.Text) != -1)
            {
                displayWord = displayWord.Remove(index, 1);
                lblWord.Text = displayWord;
                displayWord = displayWord.Insert(index,txtGuess.Text);
                lblWord.Text = displayWord;
            }
            else if (Guesses.Contains(txtGuess.Text))
            {

            }
            else
            {
                Guesses.Add(txtGuess.Text);
                lstGuessedLetters.DataSource = null;
                lstGuessedLetters.DataSource = Guesses;
                lives = lives - 1;
                lblLives.Text = "Lives:" + lives;
            }
            
            


            if (lives == 2)
            {
                picHangman.Image = Hangman_Lite.Properties.Resources._2balloon;
            }

            if (lives == 3)
            {
                picHangman.Image = Hangman_Lite.Properties.Resources._3Balloon;
            }

            if (lives == 1)
            {
                picHangman.Image = Hangman_Lite.Properties.Resources._1Balloon;
            }

            if (lives == 4)
            {
                picHangman.Image = Hangman_Lite.Properties.Resources._4balloon;
            }

            if (lives == 5)
            {
                picHangman.Image = Hangman_Lite.Properties.Resources._5balloon;
            }

            if(lives <= 0)
            {

                this.Close();

            }



        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
