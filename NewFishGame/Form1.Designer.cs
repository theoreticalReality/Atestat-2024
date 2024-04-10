namespace NewFishGame
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
            startButton = new Button();
            title = new Label();
            creditsButton = new Button();
            helpButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Font = new Font("Silkscreen", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startButton.Location = new Point(416, 278);
            startButton.Name = "startButton";
            startButton.Size = new Size(274, 61);
            startButton.TabIndex = 0;
            startButton.Text = "Start Game";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += button1_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Silkscreen", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(220, 46);
            title.Name = "title";
            title.Size = new Size(674, 120);
            title.TabIndex = 1;
            title.Text = "FISHGAME";
            // 
            // creditsButton
            // 
            creditsButton.Font = new Font("Silkscreen", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            creditsButton.Location = new Point(620, 449);
            creditsButton.Name = "creditsButton";
            creditsButton.Size = new Size(274, 61);
            creditsButton.TabIndex = 2;
            creditsButton.Text = "CREDITS";
            creditsButton.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            helpButton.Font = new Font("Silkscreen", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            helpButton.Location = new Point(220, 449);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(274, 61);
            helpButton.TabIndex = 3;
            helpButton.Text = "HELP";
            helpButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Silkscreen", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(979, 540);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(134, 61);
            exitButton.TabIndex = 4;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 631);
            Controls.Add(exitButton);
            Controls.Add(helpButton);
            Controls.Add(creditsButton);
            Controls.Add(title);
            Controls.Add(startButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Label title;
        private Button creditsButton;
        private Button helpButton;
        private Button exitButton;
    }
}
