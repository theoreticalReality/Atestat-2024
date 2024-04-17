namespace NewFishGame
{
    partial class GameScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            player = new PictureBox();
            playerTimer = new System.Windows.Forms.Timer(components);
            trashTimer = new System.Windows.Forms.Timer(components);
            frequency = new System.Windows.Forms.Timer(components);
            wasteBinsButtons = new PictureBox();
            paperBin = new PictureBox();
            plasticBin = new PictureBox();
            bioHazardsBin = new PictureBox();
            batteriesBin = new PictureBox();
            scoreGameScreen = new Label();
            speedIncrease = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wasteBinsButtons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paperBin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plasticBin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bioHazardsBin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)batteriesBin).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(528, 749);
            player.Name = "player";
            player.Size = new Size(109, 82);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // playerTimer
            // 
            playerTimer.Enabled = true;
            playerTimer.Interval = 20;
            playerTimer.Tick += GameTimerEvent;
            // 
            // trashTimer
            // 
            trashTimer.Enabled = true;
            trashTimer.Interval = 20;
            trashTimer.Tick += TrashTimerEvent;
            // 
            // frequency
            // 
            frequency.Enabled = true;
            frequency.Interval = 2000;
            frequency.Tick += wasteFrquency;
            // 
            // wasteBinsButtons
            // 
            wasteBinsButtons.BackColor = Color.Transparent;
            wasteBinsButtons.Image = (Image)resources.GetObject("wasteBinsButtons.Image");
            wasteBinsButtons.Location = new Point(23, 25);
            wasteBinsButtons.Name = "wasteBinsButtons";
            wasteBinsButtons.Size = new Size(91, 85);
            wasteBinsButtons.SizeMode = PictureBoxSizeMode.StretchImage;
            wasteBinsButtons.TabIndex = 1;
            wasteBinsButtons.TabStop = false;
            wasteBinsButtons.Click += wasteBinsButton_Click;
            // 
            // paperBin
            // 
            paperBin.BackColor = Color.Transparent;
            paperBin.Image = (Image)resources.GetObject("paperBin.Image");
            paperBin.Location = new Point(150, -1);
            paperBin.Name = "paperBin";
            paperBin.Size = new Size(204, 213);
            paperBin.SizeMode = PictureBoxSizeMode.StretchImage;
            paperBin.TabIndex = 2;
            paperBin.TabStop = false;
            // 
            // plasticBin
            // 
            plasticBin.BackColor = Color.Transparent;
            plasticBin.Image = (Image)resources.GetObject("plasticBin.Image");
            plasticBin.Location = new Point(360, -1);
            plasticBin.Name = "plasticBin";
            plasticBin.Size = new Size(204, 213);
            plasticBin.SizeMode = PictureBoxSizeMode.StretchImage;
            plasticBin.TabIndex = 3;
            plasticBin.TabStop = false;
            // 
            // bioHazardsBin
            // 
            bioHazardsBin.BackColor = Color.Transparent;
            bioHazardsBin.Image = (Image)resources.GetObject("bioHazardsBin.Image");
            bioHazardsBin.Location = new Point(570, -1);
            bioHazardsBin.Name = "bioHazardsBin";
            bioHazardsBin.Size = new Size(204, 213);
            bioHazardsBin.SizeMode = PictureBoxSizeMode.StretchImage;
            bioHazardsBin.TabIndex = 4;
            bioHazardsBin.TabStop = false;
            // 
            // batteriesBin
            // 
            batteriesBin.BackColor = Color.Transparent;
            batteriesBin.Image = (Image)resources.GetObject("batteriesBin.Image");
            batteriesBin.Location = new Point(780, -1);
            batteriesBin.Name = "batteriesBin";
            batteriesBin.Size = new Size(204, 213);
            batteriesBin.SizeMode = PictureBoxSizeMode.StretchImage;
            batteriesBin.TabIndex = 5;
            batteriesBin.TabStop = false;
            // 
            // scoreGameScreen
            // 
            scoreGameScreen.AutoSize = true;
            scoreGameScreen.BackColor = Color.Transparent;
            scoreGameScreen.Font = new Font("Silkscreen", 20.2499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreGameScreen.ForeColor = Color.Black;
            scoreGameScreen.Location = new Point(2, 122);
            scoreGameScreen.Name = "scoreGameScreen";
            scoreGameScreen.Size = new Size(142, 34);
            scoreGameScreen.TabIndex = 6;
            scoreGameScreen.Text = "SCORE:0";
            // 
            // speedIncrease
            // 
            speedIncrease.Enabled = true;
            speedIncrease.Interval = 10000;
            speedIncrease.Tick += speedIncreaseTimer;
            // 
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(984, 961);
            Controls.Add(scoreGameScreen);
            Controls.Add(batteriesBin);
            Controls.Add(bioHazardsBin);
            Controls.Add(plasticBin);
            Controls.Add(paperBin);
            Controls.Add(wasteBinsButtons);
            Controls.Add(player);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "GameScreen";
            Text = "GameScreen";
            Load += GameScreen_Load;
            Paint += GamePaintEvent;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            MouseDown += GameMouseDown;
            MouseMove += GameMouseMove;
            MouseUp += GameMouseUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)wasteBinsButtons).EndInit();
            ((System.ComponentModel.ISupportInitialize)paperBin).EndInit();
            ((System.ComponentModel.ISupportInitialize)plasticBin).EndInit();
            ((System.ComponentModel.ISupportInitialize)bioHazardsBin).EndInit();
            ((System.ComponentModel.ISupportInitialize)batteriesBin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox player;
        private System.Windows.Forms.Timer playerTimer;
        private System.Windows.Forms.Timer trashTimer;
        private System.Windows.Forms.Timer frequency;
        private PictureBox wasteBinsButtons;
        private PictureBox paperBin;
        private PictureBox plasticBin;
        private PictureBox bioHazardsBin;
        private PictureBox batteriesBin;
        private Label scoreGameScreen;
        private System.Windows.Forms.Timer speedIncrease;
    }
}