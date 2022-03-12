using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace School_System
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void studentRB_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Password";
        }

        private void teacherRB_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Password";
        }

        private void courseRB_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Amount of Student";
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //Logs out and goes back to the login form
            this.Hide();
            loginForm login = new loginForm();
            login.Show();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            String source = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kofi3\\Downloads\\School_System2_2\\School_System2(2)\\School_System\\SchoolSystem.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            String id = idTextBox.Text;
            String name = nameTextBox.Text;
            String password = passwordTextBox.Text;

            if (studentRB.Checked)
            {
                try
                {
                    con.Open();
                    SqlCommand addStudent = new SqlCommand($"Insert into [dbo].[Students] values ('{id}','{name}','{password}')", con);

                    addStudent.ExecuteReader();
                    if (SwitchLanguage.num == 2)
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Green;
                        errorLabel.Text = "L'élève a été créé avec succès";
                    } else
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Green;
                        errorLabel.Text = "The student was created successfully";
                    }
                }
                catch (Exception)
                {
                    if (SwitchLanguage.num == 2)
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Red;
                        errorLabel.Text = "Les informations de l'étudiant n'étaient pas valides, veuillez réessayer";
                    } else
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Red;
                        errorLabel.Text = "The student information wasn't valide, please try again";
                    }
                }

            }
            else if (teacherRB.Checked)
            {
                try
                {
                    con.Open();
                    SqlCommand addTeacher = new SqlCommand($"Insert into [dbo].[Teachers] values ('{id}','{name}','{password}')", con);

                    addTeacher.ExecuteReader();
                    if (SwitchLanguage.num == 2)
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Green;
                        errorLabel.Text = "L'enseignant a été créé avec succès";
                    } else
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Green;
                        errorLabel.Text = "The teacher was created successfully";
                    }
                }
                catch (Exception)
                {
                    if (SwitchLanguage.num == 2)
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Red;
                        errorLabel.Text = "Les informations de l'enseignant n'étaient pas valides, veuillez réessayer";
                    } else
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Red;
                        errorLabel.Text = "The teacher information wasn't valide, please try again";
                    }
                }
            }
            else if (courseRB.Checked)
            {
                try
                 {
                    con.Open();
                    SqlCommand addCourse = new SqlCommand($"Insert into [dbo].[Course] values ('{id}','{name}',{password})", con);

                    addCourse.ExecuteReader();
                    if (SwitchLanguage.num == 2)
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Green;
                        errorLabel.Text = "Le cours a été créé avec succès";
                    } else
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Green;
                        errorLabel.Text = "The course was created successfully";
                    }
                }
                catch (Exception)
                {
                    if (SwitchLanguage.num == 2)
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Red;
                        errorLabel.Text = "Les informations sur le cours n'étaient pas valides, veuillez réessayer";
                    } else
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Red;
                        errorLabel.Text = "The course information wasn't valide, please try again";
                    }
                }
            }

            idTextBox.Clear();
            nameTextBox.Clear();
            passwordTextBox.Clear();

            con.Close();
        }

        /*private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Internationalization
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                        break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-CA");
                    break;
            }
            this.Controls.Clear();
            InitializeComponent();
        }*/

        private void displayButton_Click(object sender, EventArgs e)
        {
            //Clears the data first for the text box
            displayInfoTextBox.Clear();
            //Creates a connection
            String source = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kofi3\\Downloads\\School_System2_2\\School_System2(2)\\School_System\\SchoolSystem.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            //Initiating three list where all the tables results going to be saved
            List<string> ids = new List<string>();
            List<string> names = new List<String>();
            List<string> passwords = new List<String>();
            con.Open();

            //Checks if student Radio button is checked
            if (studentRB.Checked)
            {
                //Select everything from students
                SqlCommand displayStudent = new SqlCommand($"SELECT * FROM [dbo].[Students]", con);

                SqlDataReader r = displayStudent.ExecuteReader();
                
                //Checks if reader has rows (checks for the sql command results)
                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        ids.Add(r["studentId"].ToString());
                        names.Add(r["stuName"].ToString());
                        passwords.Add(r["stuPassword"].ToString());
                    }

                    //Display part
                    for (int i = 0; i < ids.Count; i++)
                    {
                        displayInfoTextBox.Text += $"Student Id: {ids[i]} \r\n";
                        displayInfoTextBox.Text += $"Student Name: {names[i]}\r\n";
                        displayInfoTextBox.Text += $"Student Password: {passwords[i]}\r\n\r\n";
                    }
                }
                else
                {
                    if (SwitchLanguage.num == 2)
                    {
                        displayInfoTextBox.Text = "Il n'y a pas d'étudiants";
                    } else
                    {
                        displayInfoTextBox.Text = "There is no students";
                    }
                }
            }

            else if (teacherRB.Checked)
            {
                SqlCommand displayStudent = new SqlCommand($"SELECT * FROM [dbo].[Teachers]", con);

                SqlDataReader r = displayStudent.ExecuteReader();

                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        ids.Add(r["teacherId"].ToString());
                        names.Add(r["teacherName"].ToString());
                        passwords.Add(r["teacherPassword"].ToString());
                    }

                    for (int i = 0; i < ids.Count; i++)
                    {
                        if (SwitchLanguage.num == 2)
                        {
                            displayInfoTextBox.Text += $"Identifiant de l'enseignant: {ids[i]} \r\n";
                            displayInfoTextBox.Text += $"Nom de l'enseignant: {names[i]}\r\n";
                            displayInfoTextBox.Text += $"Mot de passe de l'enseignant: {passwords[i]}\r\n\r\n";
                        } else
                        {
                            displayInfoTextBox.Text += $"Teacher Id: {ids[i]} \r\n";
                            displayInfoTextBox.Text += $"Teacher Name: {names[i]}\r\n";
                            displayInfoTextBox.Text += $"Teacher Password: {passwords[i]}\r\n\r\n";
                        }
                    }
                }
                else
                {
                    if (SwitchLanguage.num == 2)
                    {
                        displayInfoTextBox.Text = "Il n'y a pas de professeur";
                    } else
                    {
                        displayInfoTextBox.Text = "There is no teacher";
                    }
                }
            }
            else if (courseRB.Checked)
            {
                SqlCommand displayStudent = new SqlCommand($"SELECT * FROM [dbo].[Course]", con);

                SqlDataReader r = displayStudent.ExecuteReader();

                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        ids.Add(r["courseId"].ToString());
                        names.Add(r["courseName"].ToString());
                        passwords.Add(r["maxAmount"].ToString());
                    }

                    for (int i = 0; i < ids.Count; i++)
                    {
                        if (SwitchLanguage.num == 2)
                        {
                            displayInfoTextBox.Text += $"Identifiant du cours: {ids[i]} \r\n";
                            displayInfoTextBox.Text += $"Nom du cours: {names[i]}\r\n";
                            displayInfoTextBox.Text += $"Montant du cours restant: {passwords[i]}\r\n\r\n";
                        } else
                        {
                            displayInfoTextBox.Text += $"Course Id: {ids[i]} \r\n";
                            displayInfoTextBox.Text += $"Course Name: {names[i]}\r\n";
                            displayInfoTextBox.Text += $"Course amount left: {passwords[i]}\r\n\r\n";
                        }
                    }
                }
                else
                {
                    if (SwitchLanguage.num == 2)
                    {
                        displayInfoTextBox.Text = "Il n'y a pas de professeur";
                    } else
                    {
                        displayInfoTextBox.Text = "There is no teacher";
                    }
                }
            }
            //close the connection
            con.Close();
        }
    }
}
