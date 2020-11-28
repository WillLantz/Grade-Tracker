namespace Assignment3
{
    partial class Scores
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
            this.userCountBox = new System.Windows.Forms.GroupBox();
            this.numberOfAssErrorLabel = new System.Windows.Forms.Label();
            this.numberOfStudentsErrorLabel = new System.Windows.Forms.Label();
            this.submitCountsButton = new System.Windows.Forms.Button();
            this.numberOfAssignmentsTB = new System.Windows.Forms.TextBox();
            this.numberOfStudentsTB = new System.Windows.Forms.TextBox();
            this.numberofassignmentslabel = new System.Windows.Forms.Label();
            this.Numberofstudentslabel = new System.Windows.Forms.Label();
            this.navigateGroupBox = new System.Windows.Forms.GroupBox();
            this.lastStudentButton = new System.Windows.Forms.Button();
            this.nextStudentButton = new System.Windows.Forms.Button();
            this.previousStudentButton = new System.Windows.Forms.Button();
            this.firstStudentButton = new System.Windows.Forms.Button();
            this.studentInfoBox1 = new System.Windows.Forms.GroupBox();
            this.saveNameButton = new System.Windows.Forms.Button();
            this.studentNameTB = new System.Windows.Forms.TextBox();
            this.studentNumberLabel = new System.Windows.Forms.Label();
            this.studentInfoBox2 = new System.Windows.Forms.GroupBox();
            this.assScoreError = new System.Windows.Forms.Label();
            this.assErrorLbl2 = new System.Windows.Forms.Label();
            this.saveScoreButton = new System.Windows.Forms.Button();
            this.assScoreTB = new System.Windows.Forms.TextBox();
            this.assScoreLabel = new System.Windows.Forms.Label();
            this.assNumberTB = new System.Windows.Forms.TextBox();
            this.enterAssNumberLabel = new System.Windows.Forms.Label();
            this.displayScoresButton = new System.Windows.Forms.Button();
            this.scoreDisplayBox = new System.Windows.Forms.RichTextBox();
            this.resetScoresButton = new System.Windows.Forms.Button();
            this.userCountBox.SuspendLayout();
            this.navigateGroupBox.SuspendLayout();
            this.studentInfoBox1.SuspendLayout();
            this.studentInfoBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // userCountBox
            // 
            this.userCountBox.Controls.Add(this.numberOfAssErrorLabel);
            this.userCountBox.Controls.Add(this.numberOfStudentsErrorLabel);
            this.userCountBox.Controls.Add(this.submitCountsButton);
            this.userCountBox.Controls.Add(this.numberOfAssignmentsTB);
            this.userCountBox.Controls.Add(this.numberOfStudentsTB);
            this.userCountBox.Controls.Add(this.numberofassignmentslabel);
            this.userCountBox.Controls.Add(this.Numberofstudentslabel);
            this.userCountBox.Location = new System.Drawing.Point(12, 2);
            this.userCountBox.Name = "userCountBox";
            this.userCountBox.Size = new System.Drawing.Size(583, 165);
            this.userCountBox.TabIndex = 0;
            this.userCountBox.TabStop = false;
            this.userCountBox.Text = "Counts";
            // 
            // numberOfAssErrorLabel
            // 
            this.numberOfAssErrorLabel.AutoSize = true;
            this.numberOfAssErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfAssErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.numberOfAssErrorLabel.Location = new System.Drawing.Point(220, 122);
            this.numberOfAssErrorLabel.Name = "numberOfAssErrorLabel";
            this.numberOfAssErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.numberOfAssErrorLabel.TabIndex = 6;
            // 
            // numberOfStudentsErrorLabel
            // 
            this.numberOfStudentsErrorLabel.AutoSize = true;
            this.numberOfStudentsErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfStudentsErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.numberOfStudentsErrorLabel.Location = new System.Drawing.Point(220, 18);
            this.numberOfStudentsErrorLabel.Name = "numberOfStudentsErrorLabel";
            this.numberOfStudentsErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.numberOfStudentsErrorLabel.TabIndex = 5;
            // 
            // submitCountsButton
            // 
            this.submitCountsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitCountsButton.Location = new System.Drawing.Point(358, 60);
            this.submitCountsButton.Name = "submitCountsButton";
            this.submitCountsButton.Size = new System.Drawing.Size(135, 32);
            this.submitCountsButton.TabIndex = 4;
            this.submitCountsButton.Text = "Submit Counts";
            this.submitCountsButton.UseVisualStyleBackColor = true;
            this.submitCountsButton.Click += new System.EventHandler(this.submitCountsButton_Click);
            // 
            // numberOfAssignmentsTB
            // 
            this.numberOfAssignmentsTB.Location = new System.Drawing.Point(223, 87);
            this.numberOfAssignmentsTB.Name = "numberOfAssignmentsTB";
            this.numberOfAssignmentsTB.Size = new System.Drawing.Size(40, 22);
            this.numberOfAssignmentsTB.TabIndex = 3;
            // 
            // numberOfStudentsTB
            // 
            this.numberOfStudentsTB.Location = new System.Drawing.Point(223, 38);
            this.numberOfStudentsTB.Name = "numberOfStudentsTB";
            this.numberOfStudentsTB.Size = new System.Drawing.Size(40, 22);
            this.numberOfStudentsTB.TabIndex = 2;
            // 
            // numberofassignmentslabel
            // 
            this.numberofassignmentslabel.AutoSize = true;
            this.numberofassignmentslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberofassignmentslabel.Location = new System.Drawing.Point(6, 87);
            this.numberofassignmentslabel.Name = "numberofassignmentslabel";
            this.numberofassignmentslabel.Size = new System.Drawing.Size(198, 18);
            this.numberofassignmentslabel.TabIndex = 1;
            this.numberofassignmentslabel.Text = "Number of Assignments: ";
            // 
            // Numberofstudentslabel
            // 
            this.Numberofstudentslabel.AutoSize = true;
            this.Numberofstudentslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numberofstudentslabel.Location = new System.Drawing.Point(36, 38);
            this.Numberofstudentslabel.Name = "Numberofstudentslabel";
            this.Numberofstudentslabel.Size = new System.Drawing.Size(168, 18);
            this.Numberofstudentslabel.TabIndex = 0;
            this.Numberofstudentslabel.Text = "Number of Students: ";
            // 
            // navigateGroupBox
            // 
            this.navigateGroupBox.Controls.Add(this.lastStudentButton);
            this.navigateGroupBox.Controls.Add(this.nextStudentButton);
            this.navigateGroupBox.Controls.Add(this.previousStudentButton);
            this.navigateGroupBox.Controls.Add(this.firstStudentButton);
            this.navigateGroupBox.Location = new System.Drawing.Point(12, 173);
            this.navigateGroupBox.Name = "navigateGroupBox";
            this.navigateGroupBox.Size = new System.Drawing.Size(583, 94);
            this.navigateGroupBox.TabIndex = 1;
            this.navigateGroupBox.TabStop = false;
            this.navigateGroupBox.Text = "Navigate";
            // 
            // lastStudentButton
            // 
            this.lastStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastStudentButton.Location = new System.Drawing.Point(444, 29);
            this.lastStudentButton.Name = "lastStudentButton";
            this.lastStudentButton.Size = new System.Drawing.Size(133, 50);
            this.lastStudentButton.TabIndex = 3;
            this.lastStudentButton.Text = "Last Student>>";
            this.lastStudentButton.UseVisualStyleBackColor = true;
            this.lastStudentButton.Click += new System.EventHandler(this.lastStudentButton_Click);
            // 
            // nextStudentButton
            // 
            this.nextStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextStudentButton.Location = new System.Drawing.Point(289, 29);
            this.nextStudentButton.Name = "nextStudentButton";
            this.nextStudentButton.Size = new System.Drawing.Size(149, 50);
            this.nextStudentButton.TabIndex = 2;
            this.nextStudentButton.Text = "Next Student>";
            this.nextStudentButton.UseVisualStyleBackColor = true;
            this.nextStudentButton.Click += new System.EventHandler(this.nextStudentButton_Click);
            // 
            // previousStudentButton
            // 
            this.previousStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousStudentButton.Location = new System.Drawing.Point(132, 29);
            this.previousStudentButton.Name = "previousStudentButton";
            this.previousStudentButton.Size = new System.Drawing.Size(149, 50);
            this.previousStudentButton.TabIndex = 1;
            this.previousStudentButton.Text = "<Previous Student";
            this.previousStudentButton.UseVisualStyleBackColor = true;
            this.previousStudentButton.Click += new System.EventHandler(this.previousStudentButton_Click);
            // 
            // firstStudentButton
            // 
            this.firstStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstStudentButton.Location = new System.Drawing.Point(6, 29);
            this.firstStudentButton.Name = "firstStudentButton";
            this.firstStudentButton.Size = new System.Drawing.Size(120, 50);
            this.firstStudentButton.TabIndex = 0;
            this.firstStudentButton.Text = "<<First Student";
            this.firstStudentButton.UseVisualStyleBackColor = true;
            this.firstStudentButton.Click += new System.EventHandler(this.firstStudentButton_Click);
            // 
            // studentInfoBox1
            // 
            this.studentInfoBox1.Controls.Add(this.saveNameButton);
            this.studentInfoBox1.Controls.Add(this.studentNameTB);
            this.studentInfoBox1.Controls.Add(this.studentNumberLabel);
            this.studentInfoBox1.Location = new System.Drawing.Point(13, 273);
            this.studentInfoBox1.Name = "studentInfoBox1";
            this.studentInfoBox1.Size = new System.Drawing.Size(582, 100);
            this.studentInfoBox1.TabIndex = 2;
            this.studentInfoBox1.TabStop = false;
            this.studentInfoBox1.Text = "Student Info";
            // 
            // saveNameButton
            // 
            this.saveNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNameButton.Location = new System.Drawing.Point(426, 45);
            this.saveNameButton.Name = "saveNameButton";
            this.saveNameButton.Size = new System.Drawing.Size(132, 23);
            this.saveNameButton.TabIndex = 2;
            this.saveNameButton.Text = "Save Name";
            this.saveNameButton.UseVisualStyleBackColor = true;
            this.saveNameButton.Click += new System.EventHandler(this.saveNameButton_Click);
            // 
            // studentNameTB
            // 
            this.studentNameTB.Location = new System.Drawing.Point(134, 45);
            this.studentNameTB.Name = "studentNameTB";
            this.studentNameTB.Size = new System.Drawing.Size(265, 22);
            this.studentNameTB.TabIndex = 1;
            // 
            // studentNumberLabel
            // 
            this.studentNumberLabel.AutoSize = true;
            this.studentNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNumberLabel.Location = new System.Drawing.Point(27, 45);
            this.studentNumberLabel.Name = "studentNumberLabel";
            this.studentNumberLabel.Size = new System.Drawing.Size(98, 18);
            this.studentNumberLabel.TabIndex = 0;
            this.studentNumberLabel.Text = "Student #1: ";
            // 
            // studentInfoBox2
            // 
            this.studentInfoBox2.Controls.Add(this.assScoreError);
            this.studentInfoBox2.Controls.Add(this.assErrorLbl2);
            this.studentInfoBox2.Controls.Add(this.saveScoreButton);
            this.studentInfoBox2.Controls.Add(this.assScoreTB);
            this.studentInfoBox2.Controls.Add(this.assScoreLabel);
            this.studentInfoBox2.Controls.Add(this.assNumberTB);
            this.studentInfoBox2.Controls.Add(this.enterAssNumberLabel);
            this.studentInfoBox2.Location = new System.Drawing.Point(12, 379);
            this.studentInfoBox2.Name = "studentInfoBox2";
            this.studentInfoBox2.Size = new System.Drawing.Size(583, 139);
            this.studentInfoBox2.TabIndex = 3;
            this.studentInfoBox2.TabStop = false;
            this.studentInfoBox2.Text = "Student Info";
            // 
            // assScoreError
            // 
            this.assScoreError.AutoSize = true;
            this.assScoreError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assScoreError.ForeColor = System.Drawing.Color.Crimson;
            this.assScoreError.Location = new System.Drawing.Point(286, 120);
            this.assScoreError.Name = "assScoreError";
            this.assScoreError.Size = new System.Drawing.Size(0, 15);
            this.assScoreError.TabIndex = 6;
            // 
            // assErrorLbl2
            // 
            this.assErrorLbl2.AutoSize = true;
            this.assErrorLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assErrorLbl2.ForeColor = System.Drawing.Color.Crimson;
            this.assErrorLbl2.Location = new System.Drawing.Point(286, 18);
            this.assErrorLbl2.Name = "assErrorLbl2";
            this.assErrorLbl2.Size = new System.Drawing.Size(0, 15);
            this.assErrorLbl2.TabIndex = 5;
            // 
            // saveScoreButton
            // 
            this.saveScoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveScoreButton.Location = new System.Drawing.Point(427, 56);
            this.saveScoreButton.Name = "saveScoreButton";
            this.saveScoreButton.Size = new System.Drawing.Size(109, 36);
            this.saveScoreButton.TabIndex = 4;
            this.saveScoreButton.Text = "Save Score";
            this.saveScoreButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveScoreButton.UseVisualStyleBackColor = true;
            this.saveScoreButton.Click += new System.EventHandler(this.saveScoreButton_Click);
            // 
            // assScoreTB
            // 
            this.assScoreTB.Location = new System.Drawing.Point(289, 87);
            this.assScoreTB.Name = "assScoreTB";
            this.assScoreTB.Size = new System.Drawing.Size(63, 22);
            this.assScoreTB.TabIndex = 3;
            // 
            // assScoreLabel
            // 
            this.assScoreLabel.AutoSize = true;
            this.assScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assScoreLabel.Location = new System.Drawing.Point(118, 87);
            this.assScoreLabel.Name = "assScoreLabel";
            this.assScoreLabel.Size = new System.Drawing.Size(155, 18);
            this.assScoreLabel.TabIndex = 2;
            this.assScoreLabel.Text = "Assignment Score: ";
            // 
            // assNumberTB
            // 
            this.assNumberTB.Location = new System.Drawing.Point(289, 43);
            this.assNumberTB.Name = "assNumberTB";
            this.assNumberTB.Size = new System.Drawing.Size(63, 22);
            this.assNumberTB.TabIndex = 1;
            // 
            // enterAssNumberLabel
            // 
            this.enterAssNumberLabel.AutoSize = true;
            this.enterAssNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterAssNumberLabel.Location = new System.Drawing.Point(16, 43);
            this.enterAssNumberLabel.Name = "enterAssNumberLabel";
            this.enterAssNumberLabel.Size = new System.Drawing.Size(248, 17);
            this.enterAssNumberLabel.TabIndex = 0;
            this.enterAssNumberLabel.Text = "Enter Assignment Number  (1 - ):";
            // 
            // displayScoresButton
            // 
            this.displayScoresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayScoresButton.Location = new System.Drawing.Point(244, 535);
            this.displayScoresButton.Name = "displayScoresButton";
            this.displayScoresButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.displayScoresButton.Size = new System.Drawing.Size(142, 29);
            this.displayScoresButton.TabIndex = 4;
            this.displayScoresButton.Text = "Display Scores";
            this.displayScoresButton.UseVisualStyleBackColor = true;
            this.displayScoresButton.Click += new System.EventHandler(this.displayScoresButton_Click);
            // 
            // scoreDisplayBox
            // 
            this.scoreDisplayBox.Location = new System.Drawing.Point(13, 616);
            this.scoreDisplayBox.Name = "scoreDisplayBox";
            this.scoreDisplayBox.Size = new System.Drawing.Size(775, 184);
            this.scoreDisplayBox.TabIndex = 5;
            this.scoreDisplayBox.Text = "";
            this.scoreDisplayBox.WordWrap = false;
            // 
            // resetScoresButton
            // 
            this.resetScoresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetScoresButton.Location = new System.Drawing.Point(633, 62);
            this.resetScoresButton.Name = "resetScoresButton";
            this.resetScoresButton.Size = new System.Drawing.Size(129, 49);
            this.resetScoresButton.TabIndex = 6;
            this.resetScoresButton.Text = "Reset Scores";
            this.resetScoresButton.UseVisualStyleBackColor = true;
            this.resetScoresButton.Click += new System.EventHandler(this.resetScoresButton_Click);
            // 
            // Scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 812);
            this.Controls.Add(this.resetScoresButton);
            this.Controls.Add(this.scoreDisplayBox);
            this.Controls.Add(this.displayScoresButton);
            this.Controls.Add(this.studentInfoBox2);
            this.Controls.Add(this.studentInfoBox1);
            this.Controls.Add(this.navigateGroupBox);
            this.Controls.Add(this.userCountBox);
            this.Name = "Scores";
            this.Text = "Scores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.userCountBox.ResumeLayout(false);
            this.userCountBox.PerformLayout();
            this.navigateGroupBox.ResumeLayout(false);
            this.studentInfoBox1.ResumeLayout(false);
            this.studentInfoBox1.PerformLayout();
            this.studentInfoBox2.ResumeLayout(false);
            this.studentInfoBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox userCountBox;
        private System.Windows.Forms.Button submitCountsButton;
        private System.Windows.Forms.TextBox numberOfAssignmentsTB;
        private System.Windows.Forms.TextBox numberOfStudentsTB;
        private System.Windows.Forms.Label numberofassignmentslabel;
        private System.Windows.Forms.Label Numberofstudentslabel;
        private System.Windows.Forms.Label numberOfStudentsErrorLabel;
        private System.Windows.Forms.Label numberOfAssErrorLabel;
        private System.Windows.Forms.GroupBox navigateGroupBox;
        private System.Windows.Forms.Button nextStudentButton;
        private System.Windows.Forms.Button previousStudentButton;
        private System.Windows.Forms.Button firstStudentButton;
        private System.Windows.Forms.Button lastStudentButton;
        private System.Windows.Forms.GroupBox studentInfoBox1;
        private System.Windows.Forms.Button saveNameButton;
        private System.Windows.Forms.TextBox studentNameTB;
        private System.Windows.Forms.Label studentNumberLabel;
        private System.Windows.Forms.GroupBox studentInfoBox2;
        private System.Windows.Forms.Button saveScoreButton;
        private System.Windows.Forms.TextBox assScoreTB;
        private System.Windows.Forms.Label assScoreLabel;
        private System.Windows.Forms.TextBox assNumberTB;
        private System.Windows.Forms.Label enterAssNumberLabel;
        private System.Windows.Forms.Button displayScoresButton;
        private System.Windows.Forms.RichTextBox scoreDisplayBox;
        private System.Windows.Forms.Button resetScoresButton;
        private System.Windows.Forms.Label assErrorLbl2;
        private System.Windows.Forms.Label assScoreError;
    }
}

