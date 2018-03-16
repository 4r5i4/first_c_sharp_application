using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using schoolLibrary;
namespace someapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            var someSchoolLib = new School();
            someSchoolLib.schoolName = "a new name";
            
            schoolNameTextBox.Text = someSchoolLib.schoolName;

            var student = new Student();
            var teacher = new Teacher(); // for testing only -- remove later

            try
            {

                someSchoolLib.twitterAddress = twitterTextBox.Text;

            }
            catch (Exception ex)
            {
                //we wanna get the message from the class School not from a new throw statement
                MessageBox.Show(ex.Message);
            }


            /** the overriden tostring method of the class is executed no matter what.
             *  We want to make sure that it is not called in case we have an invalid twittername.
             */
            try
            {
                if (someSchoolLib.twitterAddress.Length != 0)
                {
                    MessageBox.Show(someSchoolLib.ToString());

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("this is second exception");
            }
        }

        private void testTeacher_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher();
            var gp = teacher.ComputeGradeAverage();
            MessageBox.Show("TEACHER::: the grade average is " + gp);
        }

        private void TestStudent_Click(object sender, EventArgs e)
        {
            var student = new Student();
            var gp = student.ComputeGradeAverage();
            MessageBox.Show("STUDENT::: the grade average is " + gp);
        }
    }
}
