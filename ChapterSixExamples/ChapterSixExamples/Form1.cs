using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ChapterSixExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void AgeCheck(string name, int age)
        {
            if (name == "") {
                lblResult.Text = "Please enter your name!";
            }
            if(age <= 0)
            {
                lblResult.Text = "Please enter your age!";
            }
            else if (age < 18)
            {
                lblResult.Text = $"Sorry, {name}. You must be at least 18 years old to enter.";
            }
            else if (age >= 18 && age < 21)
            {
                lblResult.Text = $"Welcome, {name}! You are old enough to enter, but you may need to provide ID.";
            }
            else // age >= 21
            {
                lblResult.Text = $"Welcome, {name}! You are old enough to enter.";
            }
        }

        private void btnEnterData_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text;
            int userAge = Convert.ToInt32(txtAge.Text);

            AgeCheck(userName, userAge);



        }
    }
}
