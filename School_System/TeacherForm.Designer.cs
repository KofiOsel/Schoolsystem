
namespace School_System
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.teacherLabel = new System.Windows.Forms.Label();
            this.helloLabel = new System.Windows.Forms.Label();
            this.gradesButton = new System.Windows.Forms.Button();
            this.gradePanel = new System.Windows.Forms.Panel();
            this.courseIDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentIDtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.teachButton = new System.Windows.Forms.Button();
            this.courseRegsPanel = new System.Windows.Forms.Panel();
            this.courseRegisterButton = new System.Windows.Forms.Button();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.gradePanel.SuspendLayout();
            this.courseRegsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // teacherLabel
            // 
            resources.ApplyResources(this.teacherLabel, "teacherLabel");
            this.teacherLabel.BackColor = System.Drawing.Color.White;
            this.teacherLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teacherLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.teacherLabel.Name = "teacherLabel";
            // 
            // helloLabel
            // 
            resources.ApplyResources(this.helloLabel, "helloLabel");
            this.helloLabel.BackColor = System.Drawing.Color.White;
            this.helloLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.helloLabel.Name = "helloLabel";
            // 
            // gradesButton
            // 
            resources.ApplyResources(this.gradesButton, "gradesButton");
            this.gradesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.gradesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gradesButton.ForeColor = System.Drawing.Color.White;
            this.gradesButton.Name = "gradesButton";
            this.gradesButton.UseVisualStyleBackColor = false;
            this.gradesButton.Click += new System.EventHandler(this.gradesButton_Click);
            // 
            // gradePanel
            // 
            resources.ApplyResources(this.gradePanel, "gradePanel");
            this.gradePanel.Controls.Add(this.courseIDTextBox);
            this.gradePanel.Controls.Add(this.label4);
            this.gradePanel.Controls.Add(this.submitButton);
            this.gradePanel.Controls.Add(this.gradeTextBox);
            this.gradePanel.Controls.Add(this.label2);
            this.gradePanel.Controls.Add(this.studentIDtextBox);
            this.gradePanel.Controls.Add(this.label1);
            this.gradePanel.Name = "gradePanel";
            // 
            // courseIDTextBox
            // 
            resources.ApplyResources(this.courseIDTextBox, "courseIDTextBox");
            this.courseIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.courseIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseIDTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.courseIDTextBox.Name = "courseIDTextBox";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // submitButton
            // 
            resources.ApplyResources(this.submitButton, "submitButton");
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Name = "submitButton";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // gradeTextBox
            // 
            resources.ApplyResources(this.gradeTextBox, "gradeTextBox");
            this.gradeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.gradeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradeTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gradeTextBox.Name = "gradeTextBox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // studentIDtextBox
            // 
            resources.ApplyResources(this.studentIDtextBox, "studentIDtextBox");
            this.studentIDtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.studentIDtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentIDtextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentIDtextBox.Name = "studentIDtextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label1.Name = "label1";
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
            // teachButton
            // 
            resources.ApplyResources(this.teachButton, "teachButton");
            this.teachButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.teachButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teachButton.ForeColor = System.Drawing.Color.White;
            this.teachButton.Name = "teachButton";
            this.teachButton.UseVisualStyleBackColor = false;
            this.teachButton.Click += new System.EventHandler(this.teachButton_Click);
            // 
            // courseRegsPanel
            // 
            resources.ApplyResources(this.courseRegsPanel, "courseRegsPanel");
            this.courseRegsPanel.Controls.Add(this.courseRegisterButton);
            this.courseRegsPanel.Controls.Add(this.courseTextBox);
            this.courseRegsPanel.Controls.Add(this.label3);
            this.courseRegsPanel.Name = "courseRegsPanel";
            // 
            // courseRegisterButton
            // 
            resources.ApplyResources(this.courseRegisterButton, "courseRegisterButton");
            this.courseRegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.courseRegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.courseRegisterButton.ForeColor = System.Drawing.Color.White;
            this.courseRegisterButton.Name = "courseRegisterButton";
            this.courseRegisterButton.UseVisualStyleBackColor = false;
            this.courseRegisterButton.Click += new System.EventHandler(this.courseRegisterButton_Click);
            // 
            // courseTextBox
            // 
            resources.ApplyResources(this.courseTextBox, "courseTextBox");
            this.courseTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.courseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.courseTextBox.Name = "courseTextBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Name = "label3";
            // 
            // errorLabel
            // 
            resources.ApplyResources(this.errorLabel, "errorLabel");
            this.errorLabel.Name = "errorLabel";
            // 
            // TeacherForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.courseRegsPanel);
            this.Controls.Add(this.teachButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.gradePanel);
            this.Controls.Add(this.gradesButton);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.teacherLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherForm";
            this.gradePanel.ResumeLayout(false);
            this.gradePanel.PerformLayout();
            this.courseRegsPanel.ResumeLayout(false);
            this.courseRegsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teacherLabel;
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Button gradesButton;
        private System.Windows.Forms.Panel gradePanel;
        private System.Windows.Forms.TextBox studentIDtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button teachButton;
        private System.Windows.Forms.Panel courseRegsPanel;
        private System.Windows.Forms.Button courseRegisterButton;
        private System.Windows.Forms.TextBox courseTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox courseIDTextBox;
        private System.Windows.Forms.Label label4;
    }
}