//This file is made specifically for methods that the components themself use
namespace Hangman {
    public partial class MainForm : Form {
        //Random Object
        private readonly Random rand;
        //List of images
        private readonly List<string> images;
        //Global index of the current image index
        private int imgIndex;
        //The game state
        private bool inGame;
        //Difficulty being played
        private string difficulty;
        /// <summary>
        /// Default constructor
        /// </summary>
        public MainForm() {
            this.InitializeComponent();
            //Position Form in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;
            //Create the random object
            this.rand = new Random();
            //Make a new List of images
            this.images = new();
            //Set the starting index at 0 like it should be
            this.imgIndex = 0;
            //Loading all file paths into the list
            for (int i = 0; i < 10; i++) { this.images.Add($@"{Environment.CurrentDirectory}\Assets\Hangman_{i}.png"); }
            //Make the cursor over the image to a 'NO' cursor because your're not supposed to click on the image
            this.ImgHangMan.Cursor = Cursors.No;
            //Set the default image to the 1st location
            this.ImgHangMan.ImageLocation = this.images[this.imgIndex];
            //Hide the tab pages... idk how it works it just does
            //link:https://stackoverflow.com/questions/10316567/how-do-i-create-a-tab-control-with-no-tab-header-in-windows-form
            this.TBCMain.Appearance = TabAppearance.FlatButtons;
            this.TBCMain.ItemSize = new Size(0, 1);
            this.TBCMain.SizeMode = TabSizeMode.Fixed;
            //Set the sizes and locations of the components
            this.SetSizes();
            //The game starts not being played
            this.inGame = false;
            //Defaulting all the strings
            this.playWord = string.Empty;
            this.insertedWord = string.Empty;
            this.difficulty = string.Empty;
        }
        /// <summary>
        /// The method for when the form resizes
        /// </summary>
        /// <param name="sender">object that raised the event</param>
        /// <param name="e">data related to the event</param>
        private void MainForm_Resize(object sender, EventArgs e) {
            this.SetSizes();
        }
        /// <summary>
        /// When the user clicks the image the index is increased. You were told not to by the cursor
        /// </summary>
        /// <param name="sender">object that raised the event</param>
        /// <param name="e">data related to the event</param>
        private void ImgHangMan_Click(object sender, EventArgs e) {
            this.ImgHangMan.ImageLocation = this.images[++this.imgIndex];
            if (this.imgIndex == 9) {
                this.LoseMessage("You really killed him huh. How sad....");
                this.BtnBack.Visible = true;
            }
        }
        /// <summary>
        /// This method handles the keyboard input for the application. whenever a key is pressed
        /// </summary>
        /// <param name="sender">object that raised the event</param>
        /// <param name="e">data related to the event</param>
        private void TBCMain_KeyPress(object sender, KeyPressEventArgs e) {
            //Only handle the click if the game is active
            if (this.inGame) {
                //Start not knowing there was a change to the word
                bool changed = false;
                //Get the character and make it upper case
                char letter = e.KeyChar.ToString().ToUpper()[0];
                //Make sure the letter is a letter
                if (!(letter >= 'A' && letter <= 'Z')) { return; }
                //Check to see if the trash letters has contained that letter. if it has we just return
                //We do not punish multiple inputs of the same letter
                if (this.incorrect.Contains(letter)) { changed = true; }
                //Default the temporary variable
                string temp = string.Empty;
                //Check each letter in case of double letter words eg::FOOT
                for (int i = 0; i < this.playWord.Length; i++) {
                    if (letter == this.playWord[i]) { //Check to see if that letter is in the word in play
                        //Adding the letter
                        temp += letter; 
                        //Note there was a change
                        changed = true;
                    } else if (this.insertedWord[i] != '_') { //Check to see if that letter has previously been chosen
                        temp += this.insertedWord[i];
                    } else { //Otherwise we add a '_' to show the letter is not discovered
                        temp += "_";
                    }
                }
                //Check to see if there was no change
                if (!changed) {
                    //Punish the incorrect input
                    this.ImgHangMan.ImageLocation = this.images[++this.imgIndex];
                    //Add the letter to the trash
                    this.TrashChars(letter);
                    //Check to see if the game has ended
                    if (this.imgIndex == 9) {
                        //End the game state
                        this.inGame = false;
                        //Output the correct word
                        this.LBLLetters.Text = $"The correct word '{this.playWord}'";
                        //Display the lose message
                        this.LoseMessage("You have lost the game!!");
                        //Make the neccessary components visable
                        this.BtnBack.Visible = true;
                        this.BtnPlayAgain.Visible = true;
                        //Exit this method here to stop the rest of the code from executing
                        return;
                    }
                }
                //Re-assign the inserted word
                this.insertedWord = temp;
                //Print the inserted word
                this.Print(); 
                //Check to see if there is a win
                if (this.insertedWord.Equals(this.playWord)) {
                    //End the game state
                    this.inGame = false;
                    //display the win message
                    this.WinMessage("You have won the game!");
                    //Make the necessary componants visable
                    this.BtnBack.Visible = true;
                    this.BtnPlayAgain.Visible = true;
                }
            }
        }
        /// <summary>
        /// Change the menu to the select difficulty menu
        /// </summary>
        /// <param name="sender">object that raised the event</param>
        /// <param name="e">data related to the event</param>
        private void BTNPlay_Click(object sender, EventArgs e) {
            this.TBCMain.SelectedTab = this.TPDifficulty;
        }
        /// <summary>
        /// Play the game in 'EASY' mode
        /// </summary>
        /// <param name="sender">object that raised the event</param>
        /// <param name="e">data related to the event</param>
        private void BTNEasy_Click(object sender, EventArgs e) {
            this.difficulty = "EASY";
            this.Play();
        }
        /// <summary>
        /// Play the game in medium mode
        /// </summary>
        /// <param name="sender">object that raised the event</param>
        /// <param name="e">data related to the event</param>
        private void BTNMedium_Click(object sender, EventArgs e) {
            this.difficulty = "MEDIUM";
            this.Play();
        }
        /// <summary>
        /// Play the game in hard mode
        /// </summary>
        /// <param name="sender">object that raised the event</param>
        /// <param name="e">data related to the event</param>
        private void BTNHard_Click(object sender, EventArgs e) {
            this.difficulty = "HARD";
            this.Play();
        }
        /// <summary>
        /// Go back at the end of the game
        /// </summary>
        /// <param name="sender">object that raised the event</param>
        /// <param name="e">data related to the event</param>
        private void BtnBack_Click(object sender, EventArgs e) {
            this.TBCMain.SelectedTab = this.TPMenu;
            this.OnFinish();
        }
        /// <summary>
        /// Allow the user to play again at the same difficulty
        /// </summary>
        /// <param name="sender">object that raised the event</param>
        /// <param name="e">data related to the event</param>
        private void BtnPlayAgain_Click(object sender, EventArgs e) {
            this.OnFinish();
            this.Play();
        }

    }
}