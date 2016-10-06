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
 * Application name: Sharp Auto Center
 * Created by: Matthew Walichnowsky
 * Student ID: 200171919
 * App creation date: 2016-10-06
 * App description: This program calculates the amount due on a New or Used Vehicle
 */

namespace Assignment2
{
    public partial class Form1 : Form
    {
        // Variables
        // _varible nameExample


        /* -------- Labels ----------------------------------------------------------- */
private void label1_Click(object sender, EventArgs e)
            {

            }
        /* -------- End of Labels ---------------------------------------------------- */


        /* -------- Language --------------------------------------------------------- */

        /* -------- End of Language -------------------------------------------------- */


        /* -------- Buttons ---------------------------------------------------------- */

        /* -------- End of Buttons --------------------------------------------------- */


        /* -------- Menu ------------------------------------------------------------- */
            // About
            private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    MessageBox.Show("This program calculates the amount due on a New or Used Vehicle");
                }
        /* -------- End of Menu ------------------------------------------------------ */

        
        public Form1()
        {
            InitializeComponent();
        }



        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
