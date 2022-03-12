using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_System
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            //Creates a connection
            String source = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kofi3\\Downloads\\School_System2_2\\School_System2(2)\\School_System\\SchoolSystem.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();
            string id = idTextBox.Text;
            string password = passwordTextBox.Text;
            
            //Checks if admin is checked
            if (adminRB.Checked)
            {
                //Creates nes instance of admin
                Admin admin = new Admin();
                //Comparing id and password that was inserted with the admin's ones
                if (id.Equals(admin.Id) && password.Equals(admin.Password))
                {
                    //goes to admin form
                    this.Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                else
                {
                    if (SwitchLanguage.num == 2)
                    {
                        MessageBox.Show("Identifiant ou mot de passe ou type incorrects");
                    } else {
                        MessageBox.Show("Incorrect id or password or type");
                    }
                }
            }
            //checks if the student radio button is checked
            else if (studentRB.Checked)
            {
                //Checks if the student with the information inserted exists or not
                SqlCommand studentExist = new SqlCommand($"SELECT * FROM [dbo].[Students] WHERE studentId = '{id}' AND stuPassword = '{password}'", con);

                SqlDataAdapter reader = new SqlDataAdapter(studentExist);
                DataTable dt1 = new DataTable();
                //creates a table that has the sql command result
                reader.Fill(dt1);
                //if there is one row then student exists else there is no student with this info
                if(dt1.Rows.Count == 1)
                {

                    SqlDataReader r = studentExist.ExecuteReader();
                    while (r.Read())
                    {
                        //retrieve the information found for the sql command solution
                        String sid = r["studentId"].ToString();
                        String sname = r["stuName"].ToString();
                        String spass = r["stuPassword"].ToString();

                        //Goes to student form
                        this.Hide();
                        StudentForm studentForm = new StudentForm(sid, sname, spass);
                        studentForm.Show();
                    }
                }
                else
                {
                    if (SwitchLanguage.num == 2)
                    {
                        MessageBox.Show("Identifiant ou mot de passe ou type incorrect");
                    } else
                    {
                        MessageBox.Show("Incorrect id or password or type");
                    }
                }
            }
            //checks if the teacher radio button is checked
            else if (teacherRB.Checked)
            {
                //Checks if the teacher with the information inserted exists or not
                SqlCommand teacherExist = new SqlCommand($"SELECT * FROM [dbo].[Teachers] WHERE teacherId = '{id}' AND teacherPassword = '{password}'", con);

                SqlDataAdapter reader = new SqlDataAdapter(teacherExist);
                DataTable dt1 = new DataTable();
                //creates a table that has the sql command result
                reader.Fill(dt1);
                //if there is one row then teacher exists else there is no teaher with this info
                if (dt1.Rows.Count == 1)
                {
                    SqlDataReader r = teacherExist.ExecuteReader();
                    while (r.Read())
                    {
                        //retrieve the information found for the sql command solution
                        String sid = r["teacherId"].ToString();
                        String sname = r["teacherName"].ToString();
                        String spass = r["teacherPassword"].ToString();

                        //Goes to teacher form
                        this.Hide();
                        TeacherForm teacherForm = new TeacherForm(sid, sname, spass);
                        teacherForm.Show();
                    }
                }
                else
                {
                    if (SwitchLanguage.num == 2)
                    {
                        MessageBox.Show("Identifiant ou mot de passe ou type incorrect");
                    } else
                    {
                        MessageBox.Show("Incorrect id or password or type");
                    }
                    
                }
            }
            else
            {
                if (SwitchLanguage.num == 2)
                {
                    MessageBox.Show("Identifiant ou mot de passe ou type incorrect");
                 
                } else
                {
                    MessageBox.Show("Incorrect id or password or type");
              
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close Application completely
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            //Internationalization
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    SwitchLanguage.num = 0;
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    break;
                case 1:
                    SwitchLanguage.num = 2;
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-CA");
                    break;
            }
            this.Controls.Clear();
            InitializeComponent();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            //Goes to the registartion form
            this.Hide();
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
        }
    }
}
