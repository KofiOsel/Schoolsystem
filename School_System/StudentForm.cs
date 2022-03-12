using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_System
{
    public partial class StudentForm : Form
    {
        private static Student student;

        //Takes the login information from login form
        public StudentForm(String id, String name, String password)
        {
            student = new Student(null, id, name, password, null);
            InitializeComponent();
            registerPanel.Visible = true;
            displayGradesPanel.Visible = false;
            registerPanel.Location = new Point(43, 190);
            helloLabel.Text = $"Hello, {student.Name}";
        }

        private void classRegistrationButton_Click(object sender, EventArgs e)
        {
            registerPanel.Visible = true;
            displayGradesPanel.Visible = false;
            registerPanel.Location = new Point(43, 190);
        }

        private void gradesButton_Click(object sender, EventArgs e)
        {
            registerPanel.Visible = false;
            displayGradesPanel.Visible = true;
            displayGradesPanel.Location = new Point(43, 190);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //Goes to the login form
            this.Hide();
            loginForm login = new loginForm();
            login.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //puts the inserted value in a variable
            String courseId = courseIDTextBox.Text;
            int placeLeft = 0;

            //Creates a connection
            String source = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kofi3\\Downloads\\School_System2_2\\School_System2(2)\\School_System\\SchoolSystem.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();

            //Checks if course exists
            SqlCommand courseExists = new SqlCommand($"SELECT * FROM [dbo].[Course] WHERE courseId = '{courseId}'", con);

            SqlDataAdapter reader = new SqlDataAdapter(courseExists);
            DataTable dt1 = new DataTable();
            //Creates a table with the result set
            reader.Fill(dt1);
            if (dt1.Rows.Count == 1)
            {
                SqlDataReader r = courseExists.ExecuteReader();
                while (r.Read())
                {
                    //puts the max amount of the course selected in a variable
                    placeLeft = (int)r["maxAmount"];
                }
                
                //closing the reader (to start another reader you need to close this one)
                r.Close();

                //Checks if there is place for students in this course or it's full
                if (placeLeft > 0)
                {
                    //Checks if the student has already registered in this course
                    SqlCommand alreadyRegistered = new SqlCommand($"SELECT * FROM [dbo].[RegStudent] WHERE courseId = '{courseId}' AND studentId = '{student.Id}'", con);

                    SqlDataAdapter reader2 = new SqlDataAdapter(alreadyRegistered);
                    DataTable dt2 = new DataTable();
                    //Creates table with the result set
                    reader2.Fill(dt2);
                    if (dt2.Rows.Count == 0)
                    {
                        //Insert a new record into the RegStudent table
                        SqlCommand addRegStudent = new SqlCommand($"INSERT INTO [dbo].[RegStudent] VALUES(NULL,'{student.Id}','{courseId}')", con);
                        SqlDataReader r2 = addRegStudent.ExecuteReader();
                        r2.Close();
                        //Decrement the max amount by one for the specific course 
                        SqlCommand decrement = new SqlCommand($"Update [dbo].[Course] set maxAmount=maxAmount-1 WHERE courseId = '{courseId}'", con);
                        decrement.ExecuteReader();

                        //Success
                        if (SwitchLanguage.num == 2)
                        {
                            errorLabel.ForeColor = System.Drawing.Color.Green;
                            errorLabel.Text = "Vous êtes maintenant inscrit au cours inséré";
                        } else
                        {
                            errorLabel.ForeColor = System.Drawing.Color.Green;
                            errorLabel.Text = "You are now registered in the inserted course";
                        }
                    }
                    else
                    {
                        if (SwitchLanguage.num == 2)
                        {
                            errorLabel.ForeColor = System.Drawing.Color.Red;
                            errorLabel.Text = "Vous êtes déjà inscrit à ce cours";
                        } else
                        {
                            errorLabel.ForeColor = System.Drawing.Color.Red;
                            errorLabel.Text = "You are already registered in this course";
                        }
                    }
                }
                else
                {
                    if (SwitchLanguage.num == 2)
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Red;
                        errorLabel.Text = "Ce cours est déjà complet";
                    } else
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Red;
                        errorLabel.Text = "This course is already full";
                    }
                }
            }

            else
            {
                if (SwitchLanguage.num == 2)
                {
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Ce cours n'existe pas, veuillez réessayer";
                } else
                {
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "This course doesn't exist, please try again";
                }
            }

            courseIDTextBox.Clear();
            con.Close();
        }

        private void displayGradeButton_Click(object sender, EventArgs e)
        {
            //clears the text box
            displayGradesTextBox.Clear();
            //Takes the two null lists and initiate them 
            student.RegsCourses = new List<string>();
            student.Grades = new List<String>();

            //Creates a connection
            String source = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\georg\\Downloads\\School_System2\\School_System\\School_System\\School_System\\School_System\\School_System\\SchoolSystem.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();

            //join the RegStudent and Course tables to be able to retrieve the course name and checks for the registered courses for this student
            SqlCommand studentGrades = new SqlCommand($"SELECT [dbo].[RegStudent].regId, [dbo].[Course].courseName as courseName, [dbo].[RegStudent].score as score " +
                $"FROM [dbo].[RegStudent] INNER JOIN [dbo].[Course] ON [dbo].[RegStudent].courseId = [dbo].[Course].courseId where [dbo].[RegStudent].studentId='{student.Id}'; ", con);

            SqlDataReader r = studentGrades.ExecuteReader();
           
            //Checks for registered courses
            if (r.HasRows)
            {
                while (r.Read())
                {
                    student.RegsCourses.Add(r["courseName"].ToString());
                    if (r["score"].ToString() == "")
                        student.Grades.Add("No Score Yet");
                    else
                        student.Grades.Add(r["score"].ToString());
                }

                //display part
                for (int i = 0; i < student.RegsCourses.Count; i++)
                {
                    if (SwitchLanguage.num == 2)
                    {
                        displayGradesTextBox.Text += $"Nom du cours: {student.RegsCourses[i]} \r\n";
                        displayGradesTextBox.Text += $"Note: {student.Grades[i]}\r\n\r\n";
                    } else
                    {
                        displayGradesTextBox.Text += $"Course Name: {student.RegsCourses[i]} \r\n";
                        displayGradesTextBox.Text += $"Score: {student.Grades[i]}\r\n\r\n";
                    }
                }
            }
            else
            {
                if (SwitchLanguage.num == 2)
                {
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Inscrivez-vous à un cours svp";
                } else
                {
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Register for a course plz";
                }
            }

            //closes the connection
            con.Close();
        }
    }
}
