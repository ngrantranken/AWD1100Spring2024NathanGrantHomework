namespace HW02_06
{
    partial class frmRockPaperScissors
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
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            lblComputerPick = new Label();
            lblScores = new Label();
            lblWinner = new Label();
            SuspendLayout();
            // 
            // btnRock
            // 
            btnRock.Location = new Point(12, 12);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(75, 23);
            btnRock.TabIndex = 0;
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += btnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.Location = new Point(93, 12);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(75, 23);
            btnPaper.TabIndex = 1;
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.Location = new Point(174, 12);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(75, 23);
            btnScissors.TabIndex = 2;
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += btnScissors_Click;
            // 
            // lblComputerPick
            // 
            lblComputerPick.AutoSize = true;
            lblComputerPick.Location = new Point(12, 50);
            lblComputerPick.Name = "lblComputerPick";
            lblComputerPick.Size = new Size(0, 15);
            lblComputerPick.TabIndex = 3;
            // 
            // lblScores
            // 
            lblScores.AutoSize = true;
            lblScores.Location = new Point(12, 82);
            lblScores.Name = "lblScores";
            lblScores.Size = new Size(0, 15);
            lblScores.TabIndex = 4;
            // 
            // lblWinner
            // 
            lblWinner.AutoSize = true;
            lblWinner.Location = new Point(12, 120);
            lblWinner.Name = "lblWinner";
            lblWinner.Size = new Size(0, 15);
            lblWinner.TabIndex = 5;
            // 
            // frmRockPaperScissors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 157);
            Controls.Add(lblWinner);
            Controls.Add(lblScores);
            Controls.Add(lblComputerPick);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Name = "frmRockPaperScissors";
            Text = "Rock Paper Scissors";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private Label lblComputerPick;
        private Label lblScores;
        private Label lblWinner;
    }
}
