
namespace School_System
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.logoutButton = new System.Windows.Forms.Button();
            this.displayGradesPanel = new System.Windows.Forms.Panel();
            this.displayGradeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.displayGradesTextBox = new System.Windows.Forms.TextBox();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.registerButton = new System.Windows.Forms.Button();
            this.courseIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gradesButton = new System.Windows.Forms.Button();
            this.classRegistrationButton = new System.Windows.Forms.Button();
            this.helloLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.displayGradesPanel.SuspendLayout();
            this.registerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            resources.ApplyResources(this.logoutButton, "logoutButton");
            this.logoutButton.BackColor = System.Drawing.Color.White;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // displayGradesPanel
            // 
            resources.ApplyResources(this.displayGradesPanel, "displayGradesPanel");
            this.displayGradesPanel.Controls.Add(this.displayGradeButton);
            this.displayGradesPanel.Controls.Add(this.label3);
            this.displayGradesPanel.Controls.Add(this.displayGradesTextBox);
            this.displayGradesPanel.Name = "displayGradesPanel";
            // 
            // displayGradeButton
            // 
            resources.ApplyResources(this.displayGradeButton, "displayGradeButton");
            this.displayGradeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.displayGradeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayGradeButton.ForeColor = System.Drawing.Color.White;
            this.displayGradeButton.Name = "displayGradeButton";
            this.displayGradeButton.UseVisualStyleBackColor = false;
            this.displayGradeButton.Click += new System.EventHandler(this.displayGradeButton_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // displayGradesTextBox
            // 
            resources.ApplyResources(this.displayGradesTextBox, "displayGradesTextBox");
            this.displayGradesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.displayGradesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayGradesTextBox.Name = "displayGradesTextBox";
            this.displayGradesTextBox.ReadOnly = true;
            // 
            // registerPanel
            // 
            resources.ApplyResources(this.registerPanel, "registerPanel");
            this.registerPanel.Controls.Add(this.registerButton);
            this.registerPanel.Controls.Add(this.courseIDTextBox);
            this.registerPanel.Controls.Add(this.label2);
            this.registerPanel.Name = "registerPanel";
            // 
            // registerButton
            // 
            resources.ApplyResources(this.registerButton, "registerButton");
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Name = "registerButton";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // courseIDTextBox
            // 
            resources.ApplyResources(this.courseIDTextBox, "courseIDTextBox");
            this.courseIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.courseIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseIDTextBox.Name = "courseIDTextBox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // gradesButton
            // 
            resources.ApplyResources(this.gradesButton, "gradesButton");
            this.gradesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.gradesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gradesButton.FlatAppearance.BorderSize = 0;
            this.gradesButton.ForeColor = System.Drawing.Color.White;
            this.gradesButton.Name = "gradesButton";
            this.gradesButton.UseVisualStyleBackColor = false;
            this.gradesButton.Click += new System.EventHandler(this.gradesButton_Click);
            // 
            // classRegistrationButton
            // 
            resources.ApplyResources(this.classRegistrationButton, "classRegistrationButton");
            this.classRegistrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.classRegistrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.classRegistrationButton.FlatAppearance.BorderSize = 0;
            this.classRegistrationButton.ForeColor = System.Drawing.Color.White;
            this.classRegistrationButton.Name = "classRegistrationButton";
            this.classRegistrationButton.UseVisualStyleBackColor = false;
            this.classRegistrationButton.Click += new System.EventHandler(this.classRegistrationButton_Click);
            // 
            // helloLabel
            // 
            resources.ApplyResources(this.helloLabel, "helloLabel");
            this.helloLabel.Name = "helloLabel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Name = "label1";
            // 
            // errorLabel
            // 
            resources.ApplyResources(this.errorLabel, "errorLabel");
            this.errorLabel.Name = "errorLabel";
            // 
            // StudentForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.displayGradesPanel);
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.gradesButton);
            this.Controls.Add(this.classRegistrationButton);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentForm";
            this.displayGradesPanel.ResumeLayout(false);
            this.displayGradesPanel.PerformLayout();
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel displayGradesPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox displayGradesTextBox;
        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.TextBox courseIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gradesButton;
        private System.Windows.Forms.Button classRegistrationButton;
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button displayGradeButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label errorLabel;
    }
}