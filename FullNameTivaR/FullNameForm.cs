using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Optional Parameters
 * This program let's the user enter their full name and then...
 * ...displays it in a message box.
*/

namespace FullNameTivaR
{
    public partial class frmFullName : Form
    {
        public frmFullName()
        {
            InitializeComponent();
        }

        // Procedure: PrintName
        //Input: String firstName, String middleName, String lastName
        // Output: void
        // Description: This procedure displays a message box with the three parameters
        public void PrintName(String firstName, String middleName, String lastName)
        {
            MessageBox.Show("Thank you, " + firstName + " " + middleName + " " + lastName);
        }

        //Procedure: PrintName
        // Input: String firstName, String lastName
        // Output: void
        // Description: This procedure displays a message box with the two parameters
        public void PrintName(String firstName, String lastName)
        {
            MessageBox.Show("Thank you, " + firstName + " " + lastName);
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Declare Variables
            String userFirstName, userMiddleName, userLastName;

            // Get Names from text Boxes
            userFirstName = this.txtFirstName.Text;
            userMiddleName = this.txtMiddleName.Text;
            userLastName = this.txtLastName.Text;

            // Make the user enter a first name
            if (userFirstName == "")
            {
                MessageBox.Show("Please enter your first name.", "Full Name Program");
            }
            // Make the user enter a last name
            else if (userLastName == "")
            {
                MessageBox.Show("Please enter your last name.", "Full Name Program");
            }
            // If user enters no middle name call two parameter function
            else if (userMiddleName == "")
            {
                PrintName(userFirstName, userLastName);
            }
            // If user enters a middle name call three parameter function
            else
            {
                PrintName(userFirstName, userMiddleName, userLastName);
            }

        }
    }
}
