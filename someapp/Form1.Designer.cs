namespace someapp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.schoolNameLabel = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.schoolNameTextBox = new System.Windows.Forms.TextBox();
            this.twitterTextBox = new System.Windows.Forms.TextBox();
            this.twitterName = new System.Windows.Forms.Label();
            this.testTeacher = new System.Windows.Forms.Button();
            this.TestStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // schoolNameLabel
            // 
            this.schoolNameLabel.AutoSize = true;
            this.schoolNameLabel.Location = new System.Drawing.Point(39, 120);
            this.schoolNameLabel.Name = "schoolNameLabel";
            this.schoolNameLabel.Size = new System.Drawing.Size(92, 13);
            this.schoolNameLabel.TabIndex = 0;
            this.schoolNameLabel.Text = "school name label";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(183, 30);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 1;
            this.testButton.Text = "test button";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // schoolNameTextBox
            // 
            this.schoolNameTextBox.Location = new System.Drawing.Point(163, 117);
            this.schoolNameTextBox.Name = "schoolNameTextBox";
            this.schoolNameTextBox.Size = new System.Drawing.Size(140, 20);
            this.schoolNameTextBox.TabIndex = 2;
            // 
            // twitterTextBox
            // 
            this.twitterTextBox.Location = new System.Drawing.Point(163, 81);
            this.twitterTextBox.Name = "twitterTextBox";
            this.twitterTextBox.Size = new System.Drawing.Size(137, 20);
            this.twitterTextBox.TabIndex = 3;
            // 
            // twitterName
            // 
            this.twitterName.AutoSize = true;
            this.twitterName.Location = new System.Drawing.Point(67, 81);
            this.twitterName.Name = "twitterName";
            this.twitterName.Size = new System.Drawing.Size(64, 13);
            this.twitterName.TabIndex = 4;
            this.twitterName.Text = "twitter name";
            // 
            // testTeacher
            // 
            this.testTeacher.Location = new System.Drawing.Point(529, 110);
            this.testTeacher.Name = "testTeacher";
            this.testTeacher.Size = new System.Drawing.Size(75, 23);
            this.testTeacher.TabIndex = 5;
            this.testTeacher.Text = "testTeacher";
            this.testTeacher.UseVisualStyleBackColor = true;
            this.testTeacher.Click += new System.EventHandler(this.testTeacher_Click);
            // 
            // TestStudent
            // 
            this.TestStudent.Location = new System.Drawing.Point(529, 159);
            this.TestStudent.Name = "TestStudent";
            this.TestStudent.Size = new System.Drawing.Size(75, 23);
            this.TestStudent.TabIndex = 6;
            this.TestStudent.Text = "testStudent";
            this.TestStudent.UseVisualStyleBackColor = true;
            this.TestStudent.Click += new System.EventHandler(this.TestStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 388);
            this.Controls.Add(this.TestStudent);
            this.Controls.Add(this.testTeacher);
            this.Controls.Add(this.twitterName);
            this.Controls.Add(this.twitterTextBox);
            this.Controls.Add(this.schoolNameTextBox);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.schoolNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label schoolNameLabel;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.TextBox schoolNameTextBox;
        private System.Windows.Forms.TextBox twitterTextBox;
        private System.Windows.Forms.Label twitterName;
        private System.Windows.Forms.Button testTeacher;
        private System.Windows.Forms.Button TestStudent;
    }
}

