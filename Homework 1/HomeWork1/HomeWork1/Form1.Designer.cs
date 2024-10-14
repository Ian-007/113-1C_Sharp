namespace HomeWork1
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
            btnExit = new Button();
            lblTranslation = new Label();
            ptxFrist = new PictureBox();
            ptxSecond = new PictureBox();
            ptxFifth = new PictureBox();
            ptxThird = new PictureBox();
            ptxForth = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptxFrist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxSecond).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxFifth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxThird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxForth).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft JhengHei UI", 30F);
            btnExit.Location = new Point(289, 370);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(485, 73);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblTranslation
            // 
            lblTranslation.BorderStyle = BorderStyle.Fixed3D;
            lblTranslation.Font = new Font("Microsoft JhengHei UI", 26F);
            lblTranslation.Location = new Point(239, 245);
            lblTranslation.Name = "lblTranslation";
            lblTranslation.Size = new Size(569, 52);
            lblTranslation.TabIndex = 1;
            lblTranslation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ptxFrist
            // 
            ptxFrist.Image = Properties.Resources.Queen_Diamonds1;
            ptxFrist.Location = new Point(29, 12);
            ptxFrist.Name = "ptxFrist";
            ptxFrist.Size = new Size(136, 192);
            ptxFrist.SizeMode = PictureBoxSizeMode.Zoom;
            ptxFrist.TabIndex = 2;
            ptxFrist.TabStop = false;
            ptxFrist.Click += ptxFrist_Click;
            // 
            // ptxSecond
            // 
            ptxSecond.Image = Properties.Resources._6_Spades;
            ptxSecond.Location = new Point(221, 12);
            ptxSecond.Name = "ptxSecond";
            ptxSecond.Size = new Size(136, 192);
            ptxSecond.SizeMode = PictureBoxSizeMode.Zoom;
            ptxSecond.TabIndex = 3;
            ptxSecond.TabStop = false;
            ptxSecond.Click += ptxSecond_Click;
            // 
            // ptxFifth
            // 
            ptxFifth.Image = Properties.Resources._3_Hearts;
            ptxFifth.Location = new Point(874, 12);
            ptxFifth.Name = "ptxFifth";
            ptxFifth.Size = new Size(136, 192);
            ptxFifth.SizeMode = PictureBoxSizeMode.Zoom;
            ptxFifth.TabIndex = 4;
            ptxFifth.TabStop = false;
            ptxFifth.Click += ptxFifth_Click;
            // 
            // ptxThird
            // 
            ptxThird.Image = Properties.Resources.Ace_Spades;
            ptxThird.Location = new Point(451, 12);
            ptxThird.Name = "ptxThird";
            ptxThird.Size = new Size(136, 192);
            ptxThird.SizeMode = PictureBoxSizeMode.Zoom;
            ptxThird.TabIndex = 5;
            ptxThird.TabStop = false;
            ptxThird.Click += ptxThird_Click;
            // 
            // ptxForth
            // 
            ptxForth.Image = Properties.Resources._7_Clubs;
            ptxForth.Location = new Point(657, 12);
            ptxForth.Name = "ptxForth";
            ptxForth.Size = new Size(136, 192);
            ptxForth.SizeMode = PictureBoxSizeMode.Zoom;
            ptxForth.TabIndex = 6;
            ptxForth.TabStop = false;
            ptxForth.Click += ptxForth_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 509);
            Controls.Add(ptxForth);
            Controls.Add(ptxThird);
            Controls.Add(ptxFifth);
            Controls.Add(ptxSecond);
            Controls.Add(ptxFrist);
            Controls.Add(lblTranslation);
            Controls.Add(btnExit);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ptxFrist).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxSecond).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxFifth).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxThird).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxForth).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Label lblTranslation;
        private PictureBox ptxFrist;
        private PictureBox ptxSecond;
        private PictureBox ptxFifth;
        private PictureBox ptxThird;
        private PictureBox ptxForth;
    }
}
