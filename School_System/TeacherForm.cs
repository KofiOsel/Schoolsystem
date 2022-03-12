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
    public partial class TeacherForm : Form
    {
        private static Teacher teacher;

        public TeacherForm(String id, String name, String password)
        {
            //Initiates a new teacher instance
            teacher = new Teacher(null, id, name, password);
            InitializeComponent();
            gradePanel.Visible = true;
            courseRegsPanel.Visible = false;
            gradePanel.Location = new Point(26, 200);
            helloLabel.Text = $"Hello, {teacher.Name}";
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //Goes back to login form
            this.Hide();
            loginForm login = new loginForm();
            login.Show();
        }

        private void gradesButton_Click(object sender, EventArgs e)
        {
            gradePanel.Visible = true;
            courseRegsPanel.Visible = false;
            gradePanel.Location = new Point(26, 200);
        }

        private void teachButton_Click(object sender, EventArgs e)
        {
            gradePanel.Visible = false;
            courseRegsPanel.Visible = true;
            courseRegsPanel.Location = new Point(26, 200);
        }

        private void courseRegisterButton_Click(object sender, EventArgs e)
        {
            //Takes the input string and put it in a variable
            String courseId = courseTextBox.Text;

            //Creates a connection
            String source = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kofi3\\Downloads\\School_System2_2\\School_System2(2)\\School_System\\SchoolSystem.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();

            //Checks if the course exists
            SqlCommand courseExists = new SqlCommand($"SELECT * FROM [dbo].[Course] WHERE courseId = '{courseId}'", con);

            SqlDataAdapter reader = new SqlDataAdapter(courseExists);
            DataTable dt1 = new DataTable();
            //Creates a table with result set
            reader.Fill(dt1);
            if (dt1.Rows.Count != 1)
            {
                if (SwitchLanguage.num == 2)
                {
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Ce cours n'existe pas";
                } else
                {
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "This course doesn't exists";
                }
            }
            else
            {
                //Checks if the course already have a teacher
                SqlCommand courseHasTeacher = new SqlCommand($"SELECT * FROM [dbo].[RegTeacher] WHERE courseId = '{courseId}'", con);

                SqlDataAdapter reader2 = new SqlDataAdapter(courseHasTeacher);
                DataTable dt2 = new DataTable();
                //Create table with result set
                reader2.Fill(dt2);
                if (dt2.Rows.Count != 0)
                {
                    if (SwitchLanguage.num == 2)
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Red;
                        errorLabel.Text = "Ce cours a déjà un professeur";
                    } else
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Red;
                        errorLabel.Text = "This course already has a teacher";
                    }
                }
                else
                {
                    //Inserts a new record in the RegTeacher table
                    SqlCommand addTeaching = new SqlCommand($"Insert into [dbo].[RegTeacher] values ('{teacher.Id}','{courseId}')", con);

                    addTeaching.ExecuteReader();
                    if (SwitchLanguage.num == 2)
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Green;
                        errorLabel.Text = "Vous êtes maintenant l'enseignant du cours inséré";
                    } else
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Green;
                        errorLabel.Text = "You are now the teacher of the inserted Course";
                    }
                }
            }

            //Clears the text box no matter what happens
            courseTextBox.Clear();

            //Closes the connection
            con.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Puts every user input in a variable
            String studentId = studentIDtextBox.Text;
            String courseId = courseIDTextBox.Text;

            //Creates a connection
            String source = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kofi3\\Downloads\\School_System2_2\\School_System2(2)\\School_System\\SchoolSystem.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();

            //Checks if the teacher actually teaches this course 
            SqlCommand courseTeacher = new SqlCommand($"SELECT * FROM [dbo].[RegTeacher] WHERE courseId = '{courseId}' AND teacherId='{teacher.Id}'", con);

            SqlDataAdapter reader = new SqlDataAdapter(courseTeacher);
            DataTable dt1 = new DataTable();
            //Creates a table with result set
            reader.Fill(dt1);
            if (dt1.Rows.Count == 1)
            {
                //Checks if the student is registered in this class
                SqlCommand courseStudent = new SqlCommand($"SELECT * FROM [dbo].[RegStudent] WHERE courseId = '{courseId}' AND studentId='{studentId}'", con);

                SqlDataAdapter reader2 = new SqlDataAdapter(courseStudent);
                DataTable dt2 = new DataTable();
                //Creates a table with result set
                reader2.Fill(dt2);
                if(dt2.Rows.Count == 1)
                {
                    try
                    {
                        Double grade = Double.Parse(gradeTextBox.Text);
                        //Override the garde for the student in the database
                        SqlCommand addGrade = new SqlCommand($"Update [dbo].[RegStudent] set score={grade} WHERE courseId = '{courseId}' AND studentId='{studentId}'", con);
                        addGrade.ExecuteReader();

                        //Dislpay a Success message
                        if (SwitchLanguage.num == 2)
                        {
                            errorLabel.ForeColor = System.Drawing.Color.Green;
                            errorLabel.Text = "La note a été insérée";
                        } else
                        {
                            errorLabel.ForeColor = System.Drawing.Color.Green;
                            errorLabel.Text = "The grade has been inserted";
                        }
                    }
                    catch (Exception)
                    {
                        if (SwitchLanguage.num == 2)
                        {
                            errorLabel.ForeColor = System.Drawing.Color.Red;
                            errorLabel.Text = "Veuillez insérer une note valide";
                        } else
                        {
                            errorLabel.ForeColor = System.Drawing.Color.Red;
                            errorLabel.Text = "Please insert a valid grade";
                        }
                    }
                    
                }
                else
                {
                    if (SwitchLanguage.num == 2)
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Red;
                        errorLabel.Text = "Cette carte d'étudiant n'est pas valide";
                    } else
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Red;
                        errorLabel.Text = "This student ID isn't valid";
                    }
                }
            }
            else
            {
                if (SwitchLanguage.num == 2)
                {
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Vous ne pouvez pas insérer de note pour ce cours";
                } else
                {
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "You can't insert a grade for this course";
                }
            }

            //Clears every text box
            studentIDtextBox.Clear();
            gradeTextBox.Clear();
            courseIDTextBox.Clear();

            //Closes the connection
            con.Close();
        }
    }
}
