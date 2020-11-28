using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{


    public partial class Scores : Form
    {

        
        public Scores()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Prints text to student grade result box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initializing all groups to disabled until valid count submitted
            navigateGroupBox.Enabled = false;
            studentInfoBox1.Enabled = false;
            studentInfoBox2.Enabled = false;
            scoreDisplayBox.Enabled = false;
            displayScoresButton.Enabled = false;
        }

        #region Variable Initialization
        private int numberOfStudents;
        private int numberOfAssignments;
        private int studentIndex = 0;
        private int lastStudent; // Keeps track of the Last Student
        private int enterAssNum;
        private int enterAssScore;
        private double averageGrade;
        private string finalGrade;


        

        private string[] sNames;

        /// <summary>
        /// First index is student selected
        /// Second index is the selected assignment
        /// </summary>
        private int[,] studentScores;

        
        #endregion Variable Initialization

        /// <summary>
        /// Verifies the input for the number of students / assignments
        /// Unlocks the rest of the form when verified
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void submitCountsButton_Click(object sender, EventArgs e)
        {

            // number of students input verification
            try
            {
                numberOfStudents = (Int32.Parse(numberOfStudentsTB.Text));
            }
            catch(Exception)
            {
                numberOfStudentsErrorLabel.Text = "Must enter a number between 1 - 10";
                return;
            }

            if (numberOfStudents <= 0 || numberOfStudents > 10)
            {
                numberOfStudentsErrorLabel.Text = "Must enter a number between 1 - 10";
                return;
            }
            else
            {
                numberOfStudentsErrorLabel.Text = "";
            }



            // number of assignments input verification
            try
            {
                numberOfAssignments = (Int32.Parse(numberOfAssignmentsTB.Text));
            }
            catch (Exception)
            {
                numberOfAssErrorLabel.Text = "Must enter a number between 1 - 99";
                return;
            }


            if(numberOfAssignments <= 0 || numberOfAssignments > 99)
            {
                numberOfAssErrorLabel.Text = "Must enter a number between 1 - 99";
                return;
            }
            else
            {
                numberOfAssErrorLabel.Text = "";
            }


            enterAssNumberLabel.Text = $"Enter Assignment Number (1 - {numberOfAssignments}):";

      
            
            sNames = new string[numberOfStudents]; // initializing the Student Names Array


            //Initializing the multi dimension array. 
            //rows = number of students, columns = numberofAssignments
            studentScores = new int[numberOfStudents, numberOfAssignments];

            //Opening all of the other boxes for user input after count validation
            navigateGroupBox.Enabled = true;
            studentInfoBox1.Enabled = true;
            studentInfoBox2.Enabled = true;
            scoreDisplayBox.Enabled = true;
            displayScoresButton.Enabled = true;

            //disabling user count box
            userCountBox.Enabled = false;
        }


        /// <summary>
        /// On click, this function initiates the studentNameArray creation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void saveNameButton_Click(object sender, EventArgs e)
        {
            sNames[studentIndex] = studentNameTB.Text;
        }

        #region Navigate Students
        /// <summary>
        /// Increments the studentIndex to keep track of where we are at in the student name array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextStudentButton_Click(object sender, EventArgs e)
        {
            if(studentIndex < numberOfStudents - 1)
            {
                studentIndex++;
            }

            lastStudent = studentIndex; // keeping track of the last student entered into the student array

            updateStudentInfo();

        }


        /// <summary>
        /// Decrements the studentIndex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void previousStudentButton_Click(object sender, EventArgs e)
        {
            {
                if (studentIndex > 0)
                {
                    studentIndex--;
                }

                updateStudentInfo();

            }
        }

        /// <summary>
        /// Goes to the first student in the studentNames array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firstStudentButton_Click(object sender, EventArgs e)
        {
            studentIndex = 0;

            updateStudentInfo();
        }

        /// <summary>
        /// Takes us to the last student in the studentNames array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lastStudentButton_Click(object sender, EventArgs e)
        {
            studentIndex = numberOfStudents - 1; // subtracting 1 to keep from going out of bounds

            updateStudentInfo();
        }

        #endregion Navigate Students

        /// <summary>
        /// This verifies the input for the student scores
        /// Also fills the scores array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveScoreButton_Click(object sender, EventArgs e)
        {
            //checking user input for the entered assignment numbers
            try
            {
                enterAssNum = (Int32.Parse(assNumberTB.Text));
            }
            catch (Exception)
            {
                assErrorLbl2.Text = $"Must enter a number between 1 - {numberOfAssignments}";
                return;
            }

            if (enterAssNum <= 0 || enterAssNum > numberOfAssignments)
            {
                assErrorLbl2.Text = $"Must enter a number between 1 - {numberOfAssignments}";
                return;
            }
            else
            {
                assErrorLbl2.Text = "";
            }


            //checking user input for the assignment scores
            try
            {
                enterAssScore = (Int32.Parse(assScoreTB.Text));
            }
            catch (Exception)
            {
                assScoreError.Text = $"Must enter a number between 0 - 100";
                return;
            }

            if (enterAssScore < 0 || enterAssScore > 100)
            {
                assScoreError.Text = $"Must enter a number between 0 - 100";
                return;
            }
            else
            {
                assScoreError.Text = "";
            }

            studentScores[studentIndex, enterAssNum - 1] = enterAssScore;// Entering the score at the studentIndex and (assignment number - 1) to keep 0 based index
        }

        /// <summary>
        /// Updates the score in the rich text box
        /// </summary>
        private void displayScore()
        {
            scoreDisplayBox.Text = "Student\t   ";

            for(int i = 1; i <= numberOfAssignments; i++)
            {
                scoreDisplayBox.Text += "#" + i + "\t   ";            
            }

            scoreDisplayBox.Text += "\t    AVG"; // printing AVG in the header
            scoreDisplayBox.Text += "\t\tGRADE"; // printing GRADE in the header

            for(int row = 0; row < studentScores.GetLength(0); row++)
            {
                scoreDisplayBox.Text += Environment.NewLine + (sNames[row]);

                for(int column = 0; column < studentScores.GetLength(1); column++)
                {
                    scoreDisplayBox.Text += "\t   " + studentScores[row, column];
                }

                // call average
                scoreDisplayBox.Text += ($"\t\t{gradeAverage(row),9:F}");

                //call gradeLetter function

                scoreDisplayBox.Text += ($"\t\t{gradeLetter()}");
                

            }

        }

        /// <summary>
        /// Returns the gradeLetter
        /// </summary>
        public string gradeLetter()
        {            

            if(averageGrade > 93)
            {
                finalGrade = "A";
            }
            else if(averageGrade <= 92.9 && averageGrade >= 90)
            {
                finalGrade = "A-";
            }
            else if (averageGrade <= 89.9 && averageGrade >= 87)
            {
                finalGrade = "B+";
            }
            else if (averageGrade <= 86.9 && averageGrade >= 83)
            {
                finalGrade = "B";
            }
            else if (averageGrade <= 82.9 && averageGrade >= 80)
            {
                finalGrade = "B-";
            }
            else if (averageGrade <= 79.9 && averageGrade >= 77)
            {
                finalGrade = "C+";
            }
            else if (averageGrade <= 76.9 && averageGrade >= 73)
            {
                finalGrade = "C";
            }
            else if (averageGrade <= 72.9 && averageGrade >= 70)
            {
                finalGrade = "C-";
            }
            else if (averageGrade <= 69.9 && averageGrade >= 67)
            {
                finalGrade = "D+";
            }
            else if (averageGrade <= 66.9 && averageGrade >= 63)
            {
                finalGrade = "D";
            }
            else if (averageGrade <= 62.9 && averageGrade >= 60)
            {
                finalGrade = "D-";
            }
            else if(averageGrade < 60)
            {
                finalGrade = "E";
            }
            return finalGrade;
        }

        /// <summary>
        /// This function gets the average score for each student
        /// </summary>
        /// <param name="studentIndex"></param>
        /// <returns></returns>
        public double gradeAverage(int studentIndex)
        {
            var gradecount = studentScores.GetLength(1);
            var total = 0.0;

            //adding all the grades for one student
            for(var assignmentNumber = 0; assignmentNumber < gradecount; ++assignmentNumber)
            {
                total += studentScores[studentIndex, assignmentNumber];
            }

            averageGrade = total / gradecount;
            return averageGrade;
        }



        /// <summary>
        /// This is a window updating helper. It will update the labels that print 
        /// which student we are currently updating information for
        /// </summary>
        private void updateStudentInfo()
        {
            studentNumberLabel.Text = $"Student #{studentIndex + 1}: ";

            studentNameTB.Text = sNames[studentIndex];
        }

        /// <summary>
        /// Takes us to the displayScore method
        /// This method will print all scores and students in the 
        /// rich text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayScoresButton_Click(object sender, EventArgs e)
        {
            displayScore();
        }

        /// <summary>
        /// This method calls to the reset scores functions 
        /// which will reset the entire application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetScoresButton_Click(object sender, EventArgs e)
        {
            resetScores();
        }

        /// <summary>
        /// This will reset all values, including arrays
        /// </summary>
        private void resetScores()
        {
            // first, we will flip the availability of all the input boxes
            navigateGroupBox.Enabled = false;
            studentInfoBox1.Enabled = false;
            studentInfoBox2.Enabled = false;
            scoreDisplayBox.Enabled = false;
            displayScoresButton.Enabled = false;

            userCountBox.Enabled = true;

            //Then we need to reset all of the variables, labels and arrays back to 0

            //variables
            numberOfStudents = 0;
            numberOfAssignments = 0;
            studentIndex = 0;
            lastStudent = 0; // Keeps track of the Last Student
            enterAssNum = 0;
            enterAssScore = 0;
            averageGrade = 0;
            finalGrade = " ";

            //labels / textboxes
            numberOfStudentsTB.Text = "";
            numberOfAssignmentsTB.Text = "";
            studentNameTB.Text = "";
            assNumberTB.Text = "";
            assScoreTB.Text = "";
            scoreDisplayBox.Text = "";
            enterAssNumberLabel.Text = "Enter Assignment Number(1 - ):";

            //arrays
            Array.Clear(sNames, 0, sNames.Length);
            Array.Clear(studentScores, 0, studentScores.Length);

    }
}
}
