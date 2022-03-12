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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Goes back to the login form
            this.Hide();
            loginForm login = new loginForm();
            login.Show();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            
            //Creates connection
            String source = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kofi3\\Downloads\\School_System2_2\\School_System2(2)\\School_System\\SchoolSystem.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();
            string id = idTextBox.Text;
            string name = nameTextBox.Text;
            string password = passwordTextBox.Text;
            string verify = verifyTextBox.Text;

            //First thing that checks if you have the same password
            if (password.Equals(verify))
            {
                //Checks the radio button that is checked
                if (studentRB.Checked)
                {
                    //Try catch block to see if the info inserted is correct or not 
                    try
                    {
                        //Create another student
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
                        {
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
                //Checks the radio button that is checked
                else if (teacherRB.Checked)
                {
                    //Try catch block to see if the info inserted is correct or not
                    try
                    {
                        //Create another teacher
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
                            errorLabel.Text = "The teacher information wasn't valide, please try again";
                        } else
                        {
                            errorLabel.ForeColor = System.Drawing.Color.Red;
                            errorLabel.Text = "Les informations de l'enseignant n'étaient pas valides, veuillez réessayer";
                        }
                    }
                }
            }
            else
            {
                if (SwitchLanguage.num == 2)
                {
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Vous avez des mots de passe différents";
                    
                } else
                {
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "You have different passwords";
                }
            }
        }
    }
}
