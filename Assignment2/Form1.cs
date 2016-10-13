﻿using System;
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
        String Language = "English";
        Double AdditionalOptions = 0;


        /* -------- Labels ----------------------------------------------------------- */
        private void label1_Click(object sender, EventArgs e)
            {

            }
        private void BasePriceLabel_Click(object sender, EventArgs e)
        {

        }
        /* -------- End of Labels ---------------------------------------------------- */


        /* -------- Language --------------------------------------------------------- */
            // English
            private void englishDefaultToolStripMenuItem_Click(object sender, EventArgs e)
            {
                // Set language.
                Language = "English";

                // Update labels.
                BasePriceLabel.Text = "Base Price";
                AdditionalOptionsLabel.Text = "Additional Options";
                SubTotalLabel.Text = "Sub Total";
                SalesTaxLabel.Text = "Sales Tax";
                TotalLabel.Text = "Total";
                TradeInAllowanceLabel.Text = "Trade-In Allowance";
                AmountDueLabel.Text = "Amount Due";

                // Update buttons text.
                CalculateButton.Text = "Calculate";
                ClearButton.Text = "Clear";
                ExitButton.Text = "Exit";

                // Update menu links.
                MenuToolStripMenuItem.Text = "File";
                NewToolStripMenuItem.Text = "New";
                SaveToolStripMenuItem.Text = "Save";
                PrintToolStripMenuItem.Text = "Print";
                ExitToolStripMenuItem.Text = "Exit";
                EditToolStripMenuItem.Text = "Edit";
                CalculateToolStripMenuItem.Text = "Calculate";
                ClearToolStripMenuItem.Text = "Clear";
                FontToolStripMenuItem.Text = "Font";
                ColourToolStripMenuItem.Text = "Colour";
                LanguageToolStripMenuItem.Text = "Language";
                HelpToolStripMenuItem.Text = "Help";
                AboutToolStripMenuItem.Text = "About";

                // Update additional options labels. 
                AdditionalItemsGroupBox.Text = "Additional Items";
                StereoSystemCheckBox.Text = "Stereo System";
                LeatherInteriorCheckBox.Text = "Leather Interior";
                ComputerNavigationCheckBox.Text = "Computer Navigation";
                PerformancePackageCheckBox.Text = "Performance Package";
                SunRoofCheckBox.Text = "Sun Roof";
                ExtendedWarrantyCheckBox.Text = "Extended Warranty";

                // Update Exterior Finish labels.
                ExteriorFinishBox.Text = "Exterior Finish";
                StandardRadioButton.Text = "Standard";
                PearlizedRadioButton.Text = "Pearlized";
                CustomDetailingRadioButton.Text = "Custom Detailing";
            }

        // French
        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
            {
            // Set language.
            Language = "French";

            // Update labels.
            BasePriceLabel.Text = "Prix ​​de base";
            AdditionalOptionsLabel.Text = "Options additionelles";
            SubTotalLabel.Text = "Sub Total";
            SalesTaxLabel.Text = "Sous-Total";
            TotalLabel.Text = "Total";
            TradeInAllowanceLabel.Text = "Dans le commerce Allocation";
            AmountDueLabel.Text = "Montant dû";

            // Update buttons text.
            CalculateButton.Text = "Calculer";
            ClearButton.Text = "Clair";
            ExitButton.Text = "Sortie";

            // Update menu links.
            MenuToolStripMenuItem.Text = "Fichier";
            NewToolStripMenuItem.Text = "Nouveau";
            SaveToolStripMenuItem.Text = "Sauvegarder";
            PrintToolStripMenuItem.Text = "Impression";
            ExitToolStripMenuItem.Text = "Sortie";
            EditToolStripMenuItem.Text = "Modifier";
            CalculateToolStripMenuItem.Text = "Calculer";
            ClearToolStripMenuItem.Text = "Clair";
            FontToolStripMenuItem.Text = "Police de caractère";
            ColourToolStripMenuItem.Text = "Couleur";
            LanguageToolStripMenuItem.Text = "La langue";
            HelpToolStripMenuItem.Text = "Aidez - moi";
            AboutToolStripMenuItem.Text = "Sur";

            // Update additional options labels. 
            AdditionalItemsGroupBox.Text = "Additional Items";
            StereoSystemCheckBox.Text = "Stereo System";
            LeatherInteriorCheckBox.Text = "Leather Interior";
            ComputerNavigationCheckBox.Text = "Computer Navigation";
            PerformancePackageCheckBox.Text = "Performance Package";
            SunRoofCheckBox.Text = "Sun Roof";
            ExtendedWarrantyCheckBox.Text = "Extended Warranty";

            // Update Exterior Finish labels.
            ExteriorFinishBox.Text = "Exterior Finish";
            StandardRadioButton.Text = "Standard";
            PearlizedRadioButton.Text = "Pearlized";
            CustomDetailingRadioButton.Text = "Custom Detailing";
        }

        // Spanish
        private void spanishToolStripMenuItem_Click(object sender, EventArgs e)
            {
                // Set language.
                Language = "Spanish";

                // Update labels.
            }
        /* -------- End of Language -------------------------------------------------- */


        /* -------- Buttons ---------------------------------------------------------- */
            // Calculate Button
            private void CalculateButton_Click(object sender, EventArgs e)
            {
                Calculate();
            }
            // Clear Button
            private void ClearButton_Click(object sender, EventArgs e)
            {
                Clear();
            }
            // Exit Button
            private void ExitButton_Click(object sender, EventArgs e)
            {
                Exit();
            }
        /* -------- End of Buttons --------------------------------------------------- */


        /* -------- Menu ------------------------------------------------------------- */
            // File / New
            private void newToolStripMenuItem_Click(object sender, EventArgs e)
                {

                }

            // File / Save
            private void saveToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            // File / Print
            private void printToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            // File / Exit
            private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Exit();
            }

            // Edit / Calculate
            private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Calculate();
            }

            // Edit / Clear
            private void clearToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Clear();
            }

            // Edit / Font
            private void fontToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            // Edit / Colour
            private void colourToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            // Help / About
            private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
                        {
                            MessageBox.Show("This program calculates the amount due on a New or Used Vehicle");
                        }
        /* -------- End of Menu ------------------------------------------------------ */


        /* ---==---- Methods --------------------------------===---------------------- */
            private void Calculate()
        {
            try
            {
                // Get values from user.
                Double BasePrice = Convert.ToDouble(BasePriceTextbox.Text);
                Double TradeInAllowance = Convert.ToDouble(TradeInAllowanceTextbox.Text);

                // Calculate additional options.
                CalculateAdditionalOptions();
                

                AdditionalOptions = Convert.ToDouble(AdditionalOptionsTextbox.Text);
                Double Subtotal = BasePrice + AdditionalOptions;
                SubTotalTextbox.Text = Subtotal.ToString();
                SalesTaxTextbox.Text = "13%";
                Double Total = Subtotal * 1.13;
                Total = Math.Round(Total, 2);
                TotalTextbox.Text = Total.ToString();
                Double AmountDue = Total - TradeInAllowance;
                AmountDueTextbox.Text = AmountDue.ToString();

            }
            catch
            {
                if (Language == "English")
                {
                    MessageBox.Show(":( General Error.");
                }
                else if (Language == "French")
                {
                    MessageBox.Show(":( Erreur générale.");
                }
                else if (Language == "Spanish")
                {
                    MessageBox.Show(":( Error general.");
                }
            }
        } // End of Calculate method.
            public void Clear()
                {
                    try
                    {
                        // This clear each field individually.
                        BasePriceTextbox.Text = String.Empty;
                        TradeInAllowanceTextbox.Text = String.Empty;
                        AdditionalOptionsTextbox.Text = String.Empty;
                        SubTotalTextbox.Text = String.Empty;
                        SalesTaxTextbox.Text = String.Empty;
                        TotalTextbox.Text = String.Empty;
                        AmountDueTextbox.Text = String.Empty;
                        StereoSystemCheckBox.Checked = checked(false);
                        LeatherInteriorCheckBox.Checked = checked(false);
                        ComputerNavigationCheckBox.Checked = checked(false);
                        PerformancePackageCheckBox.Checked = checked(false);
                        SunRoofCheckBox.Checked = checked(false);
                        ExtendedWarrantyCheckBox.Checked = checked(false);
                        StandardRadioButton.Checked = checked(true);
                    }
                    catch
                    {
                        MessageBox.Show("There was an error clearing the form.");
                    }
                }
            public void Exit()
            {
                /* Determines whether the user wants to exit the application and exits if user answers yes. */
                if (MessageBox.Show("Exit application?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }

            public void CalculateAdditionalOptions()
            {
                // Clears existing values.
                AdditionalOptions = 0;

                if (StereoSystemCheckBox.Checked == true)
                {
                    AdditionalOptions = AdditionalOptions + 425.76;
                }
                if (LeatherInteriorCheckBox.Checked == true)
                {
                    AdditionalOptions = AdditionalOptions + 987.41;
                }
                if (ComputerNavigationCheckBox.Checked == true)
                {
                    AdditionalOptions = AdditionalOptions + 1741.23;
                }
                if (PerformancePackageCheckBox.Checked == true)
                {
                    AdditionalOptions = AdditionalOptions + 3478.24;
                }
                if (SunRoofCheckBox.Checked == true)
                {
                    AdditionalOptions = AdditionalOptions + 298.71;
                }
                if (ExtendedWarrantyCheckBox.Checked == true)
                {
                    AdditionalOptions = AdditionalOptions + 1645.21;
                }
                if (PearlizedRadioButton.Checked == true)
                {
                    AdditionalOptions = AdditionalOptions + 345.72;
                }
                if (CustomDetailingRadioButton.Checked == true)
                {
                    AdditionalOptions = AdditionalOptions + 599.99;
                }
                AdditionalOptionsTextbox.Text = AdditionalOptions.ToString();
            }
        /* ----=---- End of Methods ------------------------------------------------------ */

        /* --------- Additional Options Active Pricing ------------------------------------------------ */
        private void StereoSystemCheckBox_CheckedChanged(object sender, EventArgs e)
            {
                // Update additional options box.
                CalculateAdditionalOptions();
            }
            private void LeatherInteriorCheckBox_CheckedChanged(object sender, EventArgs e)
            {
                // Update additional options box.
                CalculateAdditionalOptions();
            }
            private void ComputerNavigationCheckBox_CheckedChanged(object sender, EventArgs e)
            {
                // Update additional options box.
                CalculateAdditionalOptions();
            }
            private void PerformancePackageCheckBox_CheckedChanged(object sender, EventArgs e)
            {
                // Update additional options box.
                CalculateAdditionalOptions();
            }
            private void SunRoofCheckBox_CheckedChanged(object sender, EventArgs e)
            {
                // Update additional options box.
                CalculateAdditionalOptions();
            }
            private void ExtendedWarrantyCheckBox_CheckedChanged(object sender, EventArgs e)
            {
                // Update additional options box.
                CalculateAdditionalOptions();
            }
            private void PearlizedRadioButton_CheckedChanged(object sender, EventArgs e)
            {
                // Update additional options box.
                CalculateAdditionalOptions();
            }
            private void CustomDetailingRadioButton_CheckedChanged(object sender, EventArgs e)
            {
                // Update additional options box.
                CalculateAdditionalOptions();
            }
        /* -------- End of Additional Options Active Pricing ------------------------------------------ */


        private void AdditionalOptionsTextbox_TextChanged(object sender, EventArgs e)
        {

        }
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
