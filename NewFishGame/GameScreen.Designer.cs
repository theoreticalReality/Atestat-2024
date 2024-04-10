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
            player.Image = Properties.Resources.fish;
            player.Location = new Point(687, 504);
            player.Name = "player";
            player.Size = new Size(109, 67);
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
            wasteBinsButtons.Image = Properties.Resources.unnamed;
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
            paperBin.Image = Properties.Resources.hartie;
            paperBin.Location = new Point(177, -1);
            paperBin.Name = "paperBin";
            paperBin.Size = new Size(196, 235);
            paperBin.SizeMode = PictureBoxSizeMode.StretchImage;
            paperBin.TabIndex = 2;
            paperBin.TabStop = false;
            // 
            // plasticBin
            // 
            plasticBin.Image = Properties.Resources.plastic;
            plasticBin.Location = new Point(425, -1);
            plasticBin.Name = "plasticBin";
            plasticBin.Size = new Size(196, 235);
            plasticBin.SizeMode = PictureBoxSizeMode.StretchImage;
            plasticBin.TabIndex = 3;
            plasticBin.TabStop = false;
            // 
            // bioHazardsBin
            // 
            bioHazardsBin.Image = Properties.Resources.hazarde_biologie;
            bioHazardsBin.Location = new Point(680, -1);
            bioHazardsBin.Name = "bioHazardsBin";
            bioHazardsBin.Size = new Size(196, 235);
            bioHazardsBin.SizeMode = PictureBoxSizeMode.StretchImage;
            bioHazardsBin.TabIndex = 4;
            bioHazardsBin.TabStop = false;
            // 
            // batteriesBin
            // 
            batteriesBin.Image = Properties.Resources.baterii;
            batteriesBin.Location = new Point(919, -1);
            batteriesBin.Name = "batteriesBin";
            batteriesBin.Size = new Size(196, 235);
            batteriesBin.SizeMode = PictureBoxSizeMode.StretchImage;
            batteriesBin.TabIndex = 5;
            batteriesBin.TabStop = false;
            // 
            // scoreGameScreen
            // 
            scoreGameScreen.AutoSize = true;
            scoreGameScreen.BackColor = Color.Transparent;
            scoreGameScreen.Font = new Font("Cooper Black", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreGameScreen.Location = new Point(919, 580);
            scoreGameScreen.Name = "scoreGameScreen";
            scoreGameScreen.Size = new Size(169, 42);
            scoreGameScreen.TabIndex = 6;
            scoreGameScreen.Text = "SCOR: 0";
            // 
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1138, 631);
            Controls.Add(scoreGameScreen);
            Controls.Add(batteriesBin);
            Controls.Add(bioHazardsBin);
            Controls.Add(plasticBin);
            Controls.Add(paperBin);
            Controls.Add(wasteBinsButtons);
            Controls.Add(player);
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
    }
}