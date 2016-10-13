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
        String Language = "English";
        Double AdditionalOptions = 0;
        Double BasePrice;
        Double TradeInAllowance;

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
                WhiteDefaultToolStripMenuItem.Text = "White";
                LightBlueToolStripMenuItem.Text = "Light Blue";
                LightYellowToolStripMenuItem.Text = "Light Yellow";
                LanguageToolStripMenuItem.Text = "Language";
                HelpToolStripMenuItem.Text = "Help";
                AboutToolStripMenuItem.Text = "About";
                EnglishDefaultToolStripMenuItem.Text = "English";
                FrenchToolStripMenuItem.Text = "French";
                SpanishToolStripMenuItem.Text = "Spanish";

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
                BasePriceLabel.Text = "Prix ​​de Base";
                AdditionalOptionsLabel.Text = "Options Additionelles";
                SubTotalLabel.Text = "Sub Total";
                SalesTaxLabel.Text = "Sous-Total";
                TotalLabel.Text = "Total";
                TradeInAllowanceLabel.Text = "Dans le Commerce Allocation";
                AmountDueLabel.Text = "Montant Dû";

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
                FontToolStripMenuItem.Text = "Police de Caractère";
                ColourToolStripMenuItem.Text = "Couleur";
                WhiteDefaultToolStripMenuItem.Text = "Blanc";
                LightBlueToolStripMenuItem.Text = "Bleu Clair";
                LightYellowToolStripMenuItem.Text = "Jaune Clair";
                LanguageToolStripMenuItem.Text = "La Langue";
                HelpToolStripMenuItem.Text = "Aidez - Moi";
                AboutToolStripMenuItem.Text = "Sur";
                EnglishDefaultToolStripMenuItem.Text = "Anglais";
                FrenchToolStripMenuItem.Text = "Français";
                SpanishToolStripMenuItem.Text = "Espanol";

                // Update additional options labels. 
                AdditionalItemsGroupBox.Text = "Des Éléments supplémentaires";
                StereoSystemCheckBox.Text = "Système stéréo";
                LeatherInteriorCheckBox.Text = "Intérieur en cuir";
                ComputerNavigationCheckBox.Text = "Ordinateur de Navigation";
                PerformancePackageCheckBox.Text = "Performance Paquet";
                SunRoofCheckBox.Text = "Toit Ouvrant";
                ExtendedWarrantyCheckBox.Text = "Garantie Prolongée";

                // Update Exterior Finish labels.
                ExteriorFinishBox.Text = "Finition Extérieure";
                StandardRadioButton.Text = "Standard";
                PearlizedRadioButton.Text = "Pearlized";
                CustomDetailingRadioButton.Text = "Détailler Personnalisé";
            }

            // Spanish
            private void spanishToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    // Set language.
                    Language = "Spanish";

                    // Update labels.
                    BasePriceLabel.Text = "Precio Base";
                    AdditionalOptionsLabel.Text = "Opciones Adicionales";
                    SubTotalLabel.Text = "Sub Total";
                    SalesTaxLabel.Text = "Sales Tax";
                    TotalLabel.Text = "Impuesto de venta";
                    TradeInAllowanceLabel.Text = "En el Comercio - Asignación";
                    AmountDueLabel.Text = "Monto a Pagar";

                    // Update buttons text.
                    CalculateButton.Text = "Calcular";
                    ClearButton.Text = "Claro";
                    ExitButton.Text = "Salida";

                    // Update menu links.
                    MenuToolStripMenuItem.Text = "Archivo";
                    NewToolStripMenuItem.Text = "Nuevo";
                    SaveToolStripMenuItem.Text = "Salvar";
                    PrintToolStripMenuItem.Text = "Impresión";
                    ExitToolStripMenuItem.Text = "Salida";
                    EditToolStripMenuItem.Text = "Editar";
                    CalculateToolStripMenuItem.Text = "Calcular";
                    ClearToolStripMenuItem.Text = "Claro";
                    FontToolStripMenuItem.Text = "Fuente";
                    ColourToolStripMenuItem.Text = "Color";
                    WhiteDefaultToolStripMenuItem.Text = "Blanco";
                    LightBlueToolStripMenuItem.Text = "Azul Claro";
                    LightYellowToolStripMenuItem.Text = "Amarillo Claro";
                    LanguageToolStripMenuItem.Text = "Idioma";
                    HelpToolStripMenuItem.Text = "Ayuda";
                    AboutToolStripMenuItem.Text = "Acerca de";
                    EnglishDefaultToolStripMenuItem.Text = "Inglés";
                    FrenchToolStripMenuItem.Text = "Francés";
                    SpanishToolStripMenuItem.Text = "Español";

                    // Update additional options labels. 
                    AdditionalItemsGroupBox.Text = "Artículos Adicionales";
                    StereoSystemCheckBox.Text = "Sistema Estéreo";
                    LeatherInteriorCheckBox.Text = "Interior de Cuero";
                    ComputerNavigationCheckBox.Text = "Ordenador de Navegación";
                    PerformancePackageCheckBox.Text = "Paquete de Alto Rendimiento";
                    SunRoofCheckBox.Text = "Sun Roof";
                    ExtendedWarrantyCheckBox.Text = "Garantía Extendida";

                    // Update Exterior Finish labels.
                    ExteriorFinishBox.Text = "Acabado Exterior";
                    StandardRadioButton.Text = "Estándar";
                    PearlizedRadioButton.Text = "Perlado";
                    CustomDetailingRadioButton.Text = "Detallando Personalizada";
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
                    New();
                }

            // File / Save
            private void saveToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Save();
            }

            // File / Print
            private void printToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Print();
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
                try
                {
                    if (Language == "English")
                    {
                        MessageBox.Show("This program calculates the amount due on a New or Used Vehicle.");
                    }
                    else if (Language == "French")
                    {
                        MessageBox.Show("Ce programme calcule le montant dû sur un véhicule neuf ou d'occasion.");
                    }
                    else if (Language == "Spanish")
                    {
                        MessageBox.Show("Este programa calcula la cantidad debida en un vehículo nuevo o usado.");
                    }
                }
                catch
                {
                    MessageBox.Show("There was an error selecting your language.");
                }            
            }
        /* -------- End of Menu ------------------------------------------------------ */

        /* ---==---- Font Size --------------------------------===---------------------- */
            private void FontSize16_Click(object sender, EventArgs e)
            {
                ChangeFont(16);
            }
            private void FontSize12_Click(object sender, EventArgs e)
            {
                ChangeFont(12);
            }
            private void FontSize2_Click(object sender, EventArgs e)
            {
                ChangeFont(8);
            }
            public void ChangeFont(int Size)
                {
                    String FontStyle = "Times New Roman";

                    // Update Labels.
                    BasePriceLabel.Font = new Font(FontStyle, Size);
                    AdditionalOptionsLabel.Font = new Font(FontStyle, Size);
                    SubTotalLabel.Font = new Font(FontStyle, Size);
                    SalesTaxLabel.Font = new Font(FontStyle, Size);
                    TotalLabel.Font = new Font(FontStyle, Size);
                    TradeInAllowanceLabel.Font = new Font(FontStyle, Size);
                    AmountDueLabel.Font = new Font(FontStyle, Size);

                    // Update buttons text.
                    CalculateButton.Font = new Font(FontStyle, Size);
                    ClearButton.Font = new Font(FontStyle, Size);
                    ExitButton.Font = new Font(FontStyle, Size);

                    // Update menu links.
                    MenuToolStripMenuItem.Font = new Font(FontStyle, Size);
                    NewToolStripMenuItem.Font = new Font(FontStyle, Size);
                    SaveToolStripMenuItem.Font = new Font(FontStyle, Size);
                    PrintToolStripMenuItem.Font = new Font(FontStyle, Size);
                    ExitToolStripMenuItem.Font = new Font(FontStyle, Size);
                    EditToolStripMenuItem.Font = new Font(FontStyle, Size);
                    CalculateToolStripMenuItem.Font = new Font(FontStyle, Size);
                    ClearToolStripMenuItem.Font = new Font(FontStyle, Size);
                    FontToolStripMenuItem.Font = new Font(FontStyle, Size);
                    ColourToolStripMenuItem.Font = new Font(FontStyle, Size);
                    LanguageToolStripMenuItem.Font = new Font(FontStyle, Size);
                    HelpToolStripMenuItem.Font = new Font(FontStyle, Size);
                    AboutToolStripMenuItem.Font = new Font(FontStyle, Size);
                    EnglishDefaultToolStripMenuItem.Font = new Font(FontStyle, Size);
                    FrenchToolStripMenuItem.Font = new Font(FontStyle, Size);
                    SpanishToolStripMenuItem.Font = new Font(FontStyle, Size);

                    // Update additional options labels. 
                    AdditionalItemsGroupBox.Font = new Font(FontStyle, Size);
                    StereoSystemCheckBox.Font = new Font(FontStyle, Size);
                    LeatherInteriorCheckBox.Font = new Font(FontStyle, Size);
                    ComputerNavigationCheckBox.Font = new Font(FontStyle, Size);
                    PerformancePackageCheckBox.Font = new Font(FontStyle, Size);
                    SunRoofCheckBox.Font = new Font(FontStyle, Size);
                    ExtendedWarrantyCheckBox.Font = new Font(FontStyle, Size);

                    // Update Exterior Finish labels.
                    ExteriorFinishBox.Font = new Font(FontStyle, Size);
                    StandardRadioButton.Font = new Font(FontStyle, Size);
                    PearlizedRadioButton.Font = new Font(FontStyle, Size);
                    CustomDetailingRadioButton.Font = new Font(FontStyle, Size);
                }
        /* ---==---- End Font Size --------------------------------===------------------ */

        /* ---==---- Change Colour --------------------------------===------------------ */
            // White
            private void whiteDefaultToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.BackColor = System.Drawing.Color.White;
            }

            // Light Blue
            private void lightBlueToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.BackColor = System.Drawing.Color.LightBlue;
            }

            // Light Yellow
            private void lightYellowToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.BackColor = System.Drawing.Color.LightYellow;
            }
        /* ---==---- End of Change Colour --------------------------------===--------- */

        /* ---==---- Methods --------------------------------===---------------------- */
        private void Calculate()
            {
                try
                {
                    // Get values from user.
                    try
                    {
                        BasePrice = Convert.ToDouble(BasePriceTextbox.Text);
                    }
                    catch
                    {
                        if (Language == "English")
                        {
                            MessageBox.Show(":( Base price has an invalid input.");
                        }
                        else if (Language == "French")
                        {
                            MessageBox.Show(":( Prix ​​de base a une entrée non valide.");
                        }
                        else if (Language == "Spanish")
                        {
                            MessageBox.Show(":( Precio base tiene una entrada no válida.");
                        }
                    }
                    try
                    {
                        TradeInAllowance = Convert.ToDouble(TradeInAllowanceTextbox.Text);
                    }
                    catch
                    {
                        if (Language == "English")
                        {
                            MessageBox.Show(":( Trade in allowance has an invalid input.");
                        }
                        else if (Language == "French")
                        {
                            MessageBox.Show(":( Commerce de l'allocation a une entrée non valide.");
                        }
                        else if (Language == "Spanish")
                        {
                            MessageBox.Show(":( El comercio de asignación tiene una entrada no válida.");
                        }
                    }

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

                    // Change text box colour based on amount owing.
                    if (AmountDue > 0)
                    {
                        AmountDueTextbox.ForeColor = Color.Red;
                        AmountDueTextbox.BackColor = Color.White;
                    }
                    else if (AmountDue < 0)
                    {
                        AmountDueTextbox.ForeColor = Color.Green;
                        AmountDueTextbox.BackColor = Color.White;
                    }

                    AmountDueTextbox.Text = AmountDue.ToString();
                } // End of try.
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
            public void New()
            {

            }
            public void Save()
            {

            }
            public void Print()
            {

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
        private void AmountDueTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
