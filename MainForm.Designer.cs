namespace Hangman {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ImgHangMan = new System.Windows.Forms.PictureBox();
            this.LBLTrashHeading = new System.Windows.Forms.Label();
            this.TBCMain = new System.Windows.Forms.TabControl();
            this.TPMenu = new System.Windows.Forms.TabPage();
            this.BTNPlay = new System.Windows.Forms.Button();
            this.TPDifficulty = new System.Windows.Forms.TabPage();
            this.BTNHard = new System.Windows.Forms.Button();
            this.BTNMedium = new System.Windows.Forms.Button();
            this.BTNEasy = new System.Windows.Forms.Button();
            this.LBLDifficulty = new System.Windows.Forms.Label();
            this.TPGame = new System.Windows.Forms.TabPage();
            this.BtnPlayAgain = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LBLLetters = new System.Windows.Forms.Label();
            this.LBLUsed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgHangMan)).BeginInit();
            this.TBCMain.SuspendLayout();
            this.TPMenu.SuspendLayout();
            this.TPDifficulty.SuspendLayout();
            this.TPGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImgHangMan
            // 
            this.ImgHangMan.Location = new System.Drawing.Point(242, 25);
            this.ImgHangMan.Name = "ImgHangMan";
            this.ImgHangMan.Size = new System.Drawing.Size(234, 237);
            this.ImgHangMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgHangMan.TabIndex = 0;
            this.ImgHangMan.TabStop = false;
            this.ImgHangMan.Click += new System.EventHandler(this.ImgHangMan_Click);
            // 
            // LBLTrashHeading
            // 
            this.LBLTrashHeading.AutoSize = true;
            this.LBLTrashHeading.Location = new System.Drawing.Point(53, 40);
            this.LBLTrashHeading.Name = "LBLTrashHeading";
            this.LBLTrashHeading.Size = new System.Drawing.Size(115, 20);
            this.LBLTrashHeading.TabIndex = 1;
            this.LBLTrashHeading.Text = "Incorrect Letters";
            // 
            // TBCMain
            // 
            this.TBCMain.Controls.Add(this.TPMenu);
            this.TBCMain.Controls.Add(this.TPDifficulty);
            this.TBCMain.Controls.Add(this.TPGame);
            this.TBCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBCMain.Location = new System.Drawing.Point(0, 0);
            this.TBCMain.Name = "TBCMain";
            this.TBCMain.SelectedIndex = 0;
            this.TBCMain.Size = new System.Drawing.Size(800, 450);
            this.TBCMain.TabIndex = 2;
            this.TBCMain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCMain_KeyPress);
            // 
            // TPMenu
            // 
            this.TPMenu.Controls.Add(this.BTNPlay);
            this.TPMenu.Location = new System.Drawing.Point(4, 29);
            this.TPMenu.Name = "TPMenu";
            this.TPMenu.Padding = new System.Windows.Forms.Padding(3);
            this.TPMenu.Size = new System.Drawing.Size(792, 417);
            this.TPMenu.TabIndex = 0;
            this.TPMenu.Text = "TPMenu";
            this.TPMenu.UseVisualStyleBackColor = true;
            // 
            // BTNPlay
            // 
            this.BTNPlay.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTNPlay.Location = new System.Drawing.Point(284, 150);
            this.BTNPlay.Name = "BTNPlay";
            this.BTNPlay.Size = new System.Drawing.Size(216, 131);
            this.BTNPlay.TabIndex = 0;
            this.BTNPlay.Text = "Play";
            this.BTNPlay.UseVisualStyleBackColor = true;
            this.BTNPlay.Click += new System.EventHandler(this.BTNPlay_Click);
            // 
            // TPDifficulty
            // 
            this.TPDifficulty.Controls.Add(this.BTNHard);
            this.TPDifficulty.Controls.Add(this.BTNMedium);
            this.TPDifficulty.Controls.Add(this.BTNEasy);
            this.TPDifficulty.Controls.Add(this.LBLDifficulty);
            this.TPDifficulty.Location = new System.Drawing.Point(4, 29);
            this.TPDifficulty.Name = "TPDifficulty";
            this.TPDifficulty.Padding = new System.Windows.Forms.Padding(3);
            this.TPDifficulty.Size = new System.Drawing.Size(792, 417);
            this.TPDifficulty.TabIndex = 2;
            this.TPDifficulty.Text = "Difficulty";
            this.TPDifficulty.UseVisualStyleBackColor = true;
            // 
            // BTNHard
            // 
            this.BTNHard.Location = new System.Drawing.Point(606, 225);
            this.BTNHard.Name = "BTNHard";
            this.BTNHard.Size = new System.Drawing.Size(94, 29);
            this.BTNHard.TabIndex = 3;
            this.BTNHard.Text = "Hard";
            this.BTNHard.UseVisualStyleBackColor = true;
            this.BTNHard.Click += new System.EventHandler(this.BTNHard_Click);
            // 
            // BTNMedium
            // 
            this.BTNMedium.Location = new System.Drawing.Point(329, 225);
            this.BTNMedium.Name = "BTNMedium";
            this.BTNMedium.Size = new System.Drawing.Size(94, 29);
            this.BTNMedium.TabIndex = 2;
            this.BTNMedium.Text = "Medium";
            this.BTNMedium.UseVisualStyleBackColor = true;
            this.BTNMedium.Click += new System.EventHandler(this.BTNMedium_Click);
            // 
            // BTNEasy
            // 
            this.BTNEasy.Location = new System.Drawing.Point(8, 225);
            this.BTNEasy.Name = "BTNEasy";
            this.BTNEasy.Size = new System.Drawing.Size(94, 29);
            this.BTNEasy.TabIndex = 1;
            this.BTNEasy.Text = "Easy";
            this.BTNEasy.UseVisualStyleBackColor = true;
            this.BTNEasy.Click += new System.EventHandler(this.BTNEasy_Click);
            // 
            // LBLDifficulty
            // 
            this.LBLDifficulty.AutoSize = true;
            this.LBLDifficulty.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBLDifficulty.Location = new System.Drawing.Point(58, 33);
            this.LBLDifficulty.Name = "LBLDifficulty";
            this.LBLDifficulty.Size = new System.Drawing.Size(617, 112);
            this.LBLDifficulty.TabIndex = 0;
            this.LBLDifficulty.Text = "Select Difficulty";
            // 
            // TPGame
            // 
            this.TPGame.Controls.Add(this.BtnPlayAgain);
            this.TPGame.Controls.Add(this.BtnBack);
            this.TPGame.Controls.Add(this.LBLLetters);
            this.TPGame.Controls.Add(this.LBLUsed);
            this.TPGame.Controls.Add(this.ImgHangMan);
            this.TPGame.Controls.Add(this.LBLTrashHeading);
            this.TPGame.Location = new System.Drawing.Point(4, 29);
            this.TPGame.Name = "TPGame";
            this.TPGame.Padding = new System.Windows.Forms.Padding(3);
            this.TPGame.Size = new System.Drawing.Size(792, 417);
            this.TPGame.TabIndex = 1;
            this.TPGame.Text = "Game";
            this.TPGame.UseVisualStyleBackColor = true;
            // 
            // BtnPlayAgain
            // 
            this.BtnPlayAgain.Location = new System.Drawing.Point(690, 384);
            this.BtnPlayAgain.Name = "BtnPlayAgain";
            this.BtnPlayAgain.Size = new System.Drawing.Size(94, 29);
            this.BtnPlayAgain.TabIndex = 5;
            this.BtnPlayAgain.Text = "Play Again?";
            this.BtnPlayAgain.UseVisualStyleBackColor = true;
            this.BtnPlayAgain.Click += new System.EventHandler(this.BtnPlayAgain_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(8, 380);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(94, 29);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "<< Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LBLLetters
            // 
            this.LBLLetters.AutoSize = true;
            this.LBLLetters.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBLLetters.Location = new System.Drawing.Point(267, 307);
            this.LBLLetters.Name = "LBLLetters";
            this.LBLLetters.Size = new System.Drawing.Size(172, 46);
            this.LBLLetters.TabIndex = 3;
            this.LBLLetters.Text = "Blank Atm";
            // 
            // LBLUsed
            // 
            this.LBLUsed.AutoSize = true;
            this.LBLUsed.Location = new System.Drawing.Point(53, 108);
            this.LBLUsed.Name = "LBLUsed";
            this.LBLUsed.Size = new System.Drawing.Size(0, 20);
            this.LBLUsed.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBCMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Cam Hang Man";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ImgHangMan)).EndInit();
            this.TBCMain.ResumeLayout(false);
            this.TPMenu.ResumeLayout(false);
            this.TPDifficulty.ResumeLayout(false);
            this.TPDifficulty.PerformLayout();
            this.TPGame.ResumeLayout(false);
            this.TPGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox ImgHangMan;
        private Label LBLTrashHeading;
        private TabControl TBCMain;
        private TabPage TPMenu;
        private TabPage TPGame;
        private Label LBLUsed;
        private Label LBLLetters;
        private Button BTNPlay;
        private Button BtnBack;
        private Button BtnPlayAgain;
        private TabPage TPDifficulty;
        private Label LBLDifficulty;
        private Button BTNEasy;
        private Button BTNHard;
        private Button BTNMedium;
    }
}