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
        string displayWord = "_ _ _ _ _ _";
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
            Guesses.Add((string)txtGuess.Text.ToUpper());

            lstGuessedLetters.DataSource = null;
            lstGuessedLetters.DataSource = Guesses;

           




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
    }
}
