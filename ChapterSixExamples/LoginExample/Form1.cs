using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] userName = new string[5] { "Doug Gegelman", "Rich Little", "Travis Kelce", "Taylor Swift", "James Bond" };
        string[] userPin = new string[5] {"1001", "6666", "8787", "1989", "0070"};

        private void Login(string name, string pin)
        {
            for(int i = 0; i < userName.Length; i++)
            {
                if (name == userName[i] && pin == userPin[i])
                {
                    lblResult.Text = $"Welcome {userName[i]}! ";
                    break;
                }
                else
                {
                    lblResult.Text = "Please enter correct Name and/or Pin Number";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            string pinNumber = txtPinNumber.Text;

            Login(name, pinNumber);

        }
    }
}
