namespace Hangman {
    partial class MainForm : Form {
        //The word being played defaulted
        private string playWord = string.Empty;
        //The guess defaulted
        private string insertedWord = string.Empty;
        //List of all incorrect characters played
        private List<char> incorrect = new();
        /// <summary>
        /// Moves the necessary components to keep them fitting on the right area
        /// </summary>
        private void SetSizes() {
            this.BTNPlay.Left = (this.Width / 2) - this.BTNPlay.Width / 2;
            this.BTNPlay.Top = (this.Height / 2) - this.BTNPlay.Height;

            this.LBLDifficulty.Left = (this.Width / 2) - this.LBLDifficulty.Width / 2;
            this.LBLDifficulty.Top = 50;

            this.BTNEasy.Left = 50;
            this.BTNEasy.Top = this.Height / 2;

            this.BTNMedium.Left = (this.Width / 2) - this.BTNMedium.Width / 2;
            this.BTNMedium.Top = this.Height / 2;

            this.BTNHard.Left = this.Width - 175;
            this.BTNHard.Top = this.Height / 2;

            this.LBLTrashHeading.Left = (this.Width / 100) * 5;
            this.LBLTrashHeading.Top = (this.Height / 100) * 5;

            this.LBLUsed.Left = (this.Width / 100) * 5;
            this.LBLTrashHeading.Top = (this.Height / 100) * 6;

            this.ImgHangMan.Width = this.Width / 3;
            this.ImgHangMan.Height = this.Height / 2;
            this.ImgHangMan.Left = (this.Width / 2) - (this.ImgHangMan.Width / 2);

            this.LBLLetters.Left = ((this.Width / 2) - (this.LBLLetters.Width / 2)) - (this.LBLLetters.Width / 4);
            this.LBLLetters.Top = this.ImgHangMan.Height + 50;

            this.BtnBack.Left = 25;
            this.BtnBack.Top = this.Height - 125;

            this.BtnPlayAgain.Left = (this.Width - this.BtnPlayAgain.Width) - 40;
            this.BtnPlayAgain.Top = this.Height - 125;
        }
        /// <summary>
        /// Initialise the game to be played by getting the word and setting it
        /// </summary>
        private void Play() {
            //Make the Play Again and Back button invisible
            this.BtnBack.Visible = false;
            this.BtnPlayAgain.Visible = false;
            //Default the Hangman image
            this.ImgHangMan.ImageLocation = this.images[0];
            //Set the game state to 'inGame'
            this.inGame = true;
            //Get a list of all the words that can be played
            List<string> words = new(File.ReadAllLines($@"{Environment.CurrentDirectory}\Words\WORDS_{this.difficulty}.txt"));
            //psudo randomly select a word
            this.playWord = words[this.rand.Next(0, words.Count)];
            //Get the correct amount of '_' to be output
            for (int i = 0; i < this.playWord.Length; i++) { this.insertedWord += "_"; }
            //Print the output
            this.Print();
            //Set the tab to the game tab
            this.TBCMain.SelectedTab = TPGame;
        }
        /// <summary>
        /// Print the currently guessed word all letters and/or underscores
        /// </summary>
        private void Print() {
            //Defining the output stirng
            string outStr = string.Empty;
            //Output the string followed by a space
            foreach (char c in this.insertedWord) {
                outStr += $"{c} ";
            }
            //Send the output string to a label
            this.LBLLetters.Text = outStr;
        }
        /// <summary>
        /// Add incorrect characters to a list of incorrect characters
        /// </summary>
        /// <param name="c">The incorrect characters</param>
        private void TrashChars(char c) {
            //Check to see if the list already has the character or not
            if (!this.incorrect.Contains(c)) {
                //if not the character is added
                this.incorrect.Add(c);
            }
            //Make an output string to output to the user and default it
            string outStr = string.Empty;
            //Add each character to the output string
            foreach (char character in this.incorrect) { outStr += $"{character},"; }
            //Send the output string to the used label
            this.LBLUsed.Text = outStr;
        }
        /// <summary>
        /// Resets all the elements when the game is finished
        /// </summary>
        private void OnFinish() {
            //Remove all the letters
            this.LBLLetters.Text = string.Empty;
            //Reset the incorrect list
            this.incorrect = new();
            //Reset the used character label
            this.LBLUsed.Text = string.Empty;
            //reset the words guessed
            this.insertedWord = string.Empty;
            //Set the text letters to nothing
            this.LBLLetters.Text = string.Empty;
            //Reset the index of the image path
            this.imgIndex = 0;
        }
        /// <summary>
        /// Display a lose message when the user loses
        /// </summary>
        /// <param name="msg">The message to be displayed</param>
        private void LoseMessage(string msg) {
            MessageBox.Show(
                this, 
                msg,
                this.Text,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
        /// <summary>
        /// Display a win message when the user wins
        /// </summary>
        /// <param name="msg">the message to be displayed</param>
        private void WinMessage(string msg) {
            MessageBox.Show(
                this, 
                msg,
                this.Text,
                MessageBoxButtons.OK,
                MessageBoxIcon.Question
            );
        }
    }
}