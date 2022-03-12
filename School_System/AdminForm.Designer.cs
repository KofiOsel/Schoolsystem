
namespace School_System
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.courseRB = new System.Windows.Forms.RadioButton();
            this.teacherRB = new System.Windows.Forms.RadioButton();
            this.studentRB = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.displayInfoTextBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Name = "passwordTextBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
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
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // idTextBox
            // 
            resources.ApplyResources(this.idTextBox, "idTextBox");
            this.idTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTextBox.Name = "idTextBox";
            // 
            // displayButton
            // 
            resources.ApplyResources(this.displayButton, "displayButton");
            this.displayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.displayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayButton.FlatAppearance.BorderSize = 0;
            this.displayButton.ForeColor = System.Drawing.Color.White;
            this.displayButton.Name = "displayButton";
            this.displayButton.UseVisualStyleBackColor = false;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.courseRB);
            this.panel1.Controls.Add(this.teacherRB);
            this.panel1.Controls.Add(this.studentRB);
            this.panel1.Name = "panel1";
            // 
            // courseRB
            // 
            resources.ApplyResources(this.courseRB, "courseRB");
            this.courseRB.ForeColor = System.Drawing.Color.Black;
            this.courseRB.Name = "courseRB";
            this.courseRB.UseVisualStyleBackColor = true;
            this.courseRB.CheckedChanged += new System.EventHandler(this.courseRB_CheckedChanged);
            // 
            // teacherRB
            // 
            resources.ApplyResources(this.teacherRB, "teacherRB");
            this.teacherRB.ForeColor = System.Drawing.Color.Black;
            this.teacherRB.Name = "teacherRB";
            this.teacherRB.UseVisualStyleBackColor = true;
            this.teacherRB.CheckedChanged += new System.EventHandler(this.teacherRB_CheckedChanged);
            // 
            // studentRB
            // 
            resources.ApplyResources(this.studentRB, "studentRB");
            this.studentRB.Checked = true;
            this.studentRB.ForeColor = System.Drawing.Color.Black;
            this.studentRB.Name = "studentRB";
            this.studentRB.TabStop = true;
            this.studentRB.UseVisualStyleBackColor = true;
            this.studentRB.CheckedChanged += new System.EventHandler(this.studentRB_CheckedChanged);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.nameTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.idTextBox);
            this.panel2.Controls.Add(this.passwordTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Name = "panel2";
            // 
            // nameTextBox
            // 
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Name = "nameTextBox";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // createButton
            // 
            resources.ApplyResources(this.createButton, "createButton");
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.createButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.Name = "createButton";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // displayInfoTextBox
            // 
            resources.ApplyResources(this.displayInfoTextBox, "displayInfoTextBox");
            this.displayInfoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.displayInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayInfoTextBox.Name = "displayInfoTextBox";
            // 
            // errorLabel
            // 
            resources.ApplyResources(this.errorLabel, "errorLabel");
            this.errorLabel.Name = "errorLabel";
            // 
            // AdminForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.displayInfoTextBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton courseRB;
        private System.Windows.Forms.RadioButton teacherRB;
        private System.Windows.Forms.RadioButton studentRB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox displayInfoTextBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}