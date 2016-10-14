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
    public partial class SharpAutoForm : Form
    {
        // Variables
        private String _Language = "English";
        private Double _AdditonalOptions = 0;
        private Double _BasePrice;
        private Double _TradeInAllowance;
        private Boolean _IsValid;
        private String _FontStyle = "Times New Roman";
        private int _FontSize = 12;
        private Color _FontColour = Color.Black;

        public SharpAutoForm()
        {
            KeyPreview = true;
            InitializeComponent();
            // Inializes the KeyEventHandler to look for key combos set in this application.
            KeyDown += new KeyEventHandler(FormKeyDown);
        }

        /* -------- _Language --------------------------------------------------------- */
            // English
            private void englishDefaultToolStripMenuItem_Click(object sender, EventArgs e)
            {
                // Set _Language.
                _Language = "English";

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
                ExitToolStripMenuItem.Text = "Exit";
                EditToolStripMenuItem.Text = "Edit";
                CalculateToolStripMenuItem.Text = "Calculate";
                ClearToolStripMenuItem.Text = "Clear";
                FontToolStripMenuItem.Text = "Font";
                FontSize12.Text = "12 (Default)";
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
                // Set _Language.
                _Language = "French";

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
                ExitToolStripMenuItem.Text = "Sortie";
                EditToolStripMenuItem.Text = "Modifier";
                CalculateToolStripMenuItem.Text = "Calculer";
                ClearToolStripMenuItem.Text = "Clair";
                FontToolStripMenuItem.Text = "Police de Caractère";
                FontSize12.Text = "12";
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
                    _Language = "Spanish";

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
                    ExitToolStripMenuItem.Text = "Salida";
                    EditToolStripMenuItem.Text = "Editar";
                    CalculateToolStripMenuItem.Text = "Calcular";
                    ClearToolStripMenuItem.Text = "Claro";
                    FontToolStripMenuItem.Text = "Fuente";
                    FontSize12.Text = "12";
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

            // Help / About
            private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
            {
                About();
            }
        /* -------- End of Menu ------------------------------------------------------ */

        /* ---==---- Change Font --------------------------------===---------------------- */
            // Changes font size to 16.
            private void FontSize16_Click(object sender, EventArgs e)
            {
                _FontSize = 16;
                ChangeFont(_FontStyle, _FontSize);
            }

            // Changes font size to 12.
            private void FontSize12_Click(object sender, EventArgs e)
            {
                _FontSize = 12;
                ChangeFont(_FontStyle, _FontSize);
            }

            // Changes font size to 8.
            private void FontSize2_Click(object sender, EventArgs e)
            {
                _FontSize = 8;
                ChangeFont(_FontStyle, _FontSize);
            }

            // Changes font style to Times New Roman.
            private void TimesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
            {
                _FontStyle = "Times New Roman";
                ChangeFont(_FontStyle, _FontSize);
            }

            // Changes font style to Calibri.
            private void CalibriToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    _FontStyle = "Calibri";
                    ChangeFont(_FontStyle, _FontSize);
                }

            // Changes font style to Arial.
            private void ArialToolStripMenuItem_Click(object sender, EventArgs e)
            {
                _FontStyle = "Arial";
                ChangeFont(_FontStyle, _FontSize);
            }

            // This method changes all the font on the page to the variables set beforehand.
            public void ChangeFont(String _FontStyle, int _FontSize)
                {
                    // Update Labels.
                    BasePriceLabel.Font = new Font(_FontStyle, _FontSize);
                    AdditionalOptionsLabel.Font = new Font(_FontStyle, _FontSize);
                    SubTotalLabel.Font = new Font(_FontStyle, _FontSize);
                    SalesTaxLabel.Font = new Font(_FontStyle, _FontSize);
                    TotalLabel.Font = new Font(_FontStyle, _FontSize);
                    TradeInAllowanceLabel.Font = new Font(_FontStyle, _FontSize);
                    AmountDueLabel.Font = new Font(_FontStyle, _FontSize);

                    // Update buttons text.
                    CalculateButton.Font = new Font(_FontStyle, _FontSize);
                    ClearButton.Font = new Font(_FontStyle, _FontSize);
                    ExitButton.Font = new Font(_FontStyle, _FontSize);

                    // Update menu links.
                    MenuToolStripMenuItem.Font = new Font(_FontStyle, _FontSize);
                    ExitToolStripMenuItem.Font = new Font(_FontStyle, _FontSize);
                    EditToolStripMenuItem.Font = new Font(_FontStyle, _FontSize);
                    CalculateToolStripMenuItem.Font = new Font(_FontStyle, _FontSize);
                    ClearToolStripMenuItem.Font = new Font(_FontStyle, _FontSize);
                    FontToolStripMenuItem.Font = new Font(_FontStyle, _FontSize);
                    ColourToolStripMenuItem.Font = new Font(_FontStyle, _FontSize);
                    LanguageToolStripMenuItem.Font = new Font(_FontStyle, _FontSize);
                    HelpToolStripMenuItem.Font = new Font(_FontStyle, _FontSize);
                    AboutToolStripMenuItem.Font = new Font(_FontStyle, _FontSize);
                    EnglishDefaultToolStripMenuItem.Font = new Font(_FontStyle, _FontSize);
                    FrenchToolStripMenuItem.Font = new Font(_FontStyle, _FontSize);
                    SpanishToolStripMenuItem.Font = new Font(_FontStyle, _FontSize);

                    // Update additional options labels. 
                    AdditionalItemsGroupBox.Font = new Font(_FontStyle, _FontSize);
                    StereoSystemCheckBox.Font = new Font(_FontStyle, _FontSize);
                    LeatherInteriorCheckBox.Font = new Font(_FontStyle, _FontSize);
                    ComputerNavigationCheckBox.Font = new Font(_FontStyle, _FontSize);
                    PerformancePackageCheckBox.Font = new Font(_FontStyle, _FontSize);
                    SunRoofCheckBox.Font = new Font(_FontStyle, _FontSize);
                    ExtendedWarrantyCheckBox.Font = new Font(_FontStyle, _FontSize);

                    // Update Exterior Finish labels.
                    ExteriorFinishBox.Font = new Font(_FontStyle, _FontSize);
                    StandardRadioButton.Font = new Font(_FontStyle, _FontSize);
                    PearlizedRadioButton.Font = new Font(_FontStyle, _FontSize);
                    CustomDetailingRadioButton.Font = new Font(_FontStyle, _FontSize);
                }
        /* ---==---- End Change Font --------------------------------===------------------ */

        /* ---==---- Change Colour --------------------------------===------------------ */
            // Form White
            private void whiteDefaultToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.BackColor = System.Drawing.Color.White;
            }

            // Form Light Blue
            private void lightBlueToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.BackColor = System.Drawing.Color.LightBlue;
            }

            // Form Light Yellow
            private void lightYellowToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.BackColor = System.Drawing.Color.LightYellow;
            }

            // Text Black (Default)
            private void BlackDefaultToolStripMenuItem_Click(object sender, EventArgs e)
            {
                _FontColour = Color.Black;
                ChangeColourFont();
            }

            // Text Dark Blue
            private void DarkBlueToolStripMenuItem_Click(object sender, EventArgs e)
            {
                _FontColour = Color.DarkBlue;
                ChangeColourFont();
            }

            // Text Dark Orange
            private void DarkOrangeToolStripMenuItem_Click(object sender, EventArgs e)
            {
                _FontColour = Color.DarkOrange;
                ChangeColourFont();
            }

            // This method changes the text colour of everything except text boxes.
            public void ChangeColourFont()
            {
                // Update Labels.
                BasePriceLabel.ForeColor = _FontColour;
                AdditionalOptionsLabel.ForeColor = _FontColour;
                SubTotalLabel.ForeColor = _FontColour;
                SalesTaxLabel.ForeColor = _FontColour;
                TotalLabel.ForeColor = _FontColour;
                TradeInAllowanceLabel.ForeColor = _FontColour;
                AmountDueLabel.ForeColor = _FontColour;

                // Update buttons text.
                CalculateButton.ForeColor = _FontColour;
                ClearButton.ForeColor = _FontColour;
                ExitButton.ForeColor = _FontColour;

                // Update menu links.
                MenuToolStripMenuItem.ForeColor = _FontColour;
                ExitToolStripMenuItem.ForeColor = _FontColour;
                EditToolStripMenuItem.ForeColor = _FontColour;
                CalculateToolStripMenuItem.ForeColor = _FontColour;
                ClearToolStripMenuItem.ForeColor = _FontColour;
                FontToolStripMenuItem.ForeColor = _FontColour;
                FontTypeToolStripMenuItem.ForeColor = _FontColour;
                TimesNewRomanToolStripMenuItem.ForeColor = _FontColour;
                CalibriToolStripMenuItem.ForeColor = _FontColour;
                ArialToolStripMenuItem.ForeColor = _FontColour;
                FontSize8.ForeColor = _FontColour;
                FontSize12.ForeColor = _FontColour;
                FontSize16.ForeColor = _FontColour;
                TextColourToolStripMenuItem.ForeColor = _FontColour;
                BlackDefaultToolStripMenuItem.ForeColor = _FontColour;
                DarkBlueToolStripMenuItem.ForeColor = _FontColour;
                DarkOrangeToolStripMenuItem.ForeColor = _FontColour;
                ColourToolStripMenuItem.ForeColor = _FontColour;
                WhiteDefaultToolStripMenuItem.ForeColor = _FontColour;
                LightBlueToolStripMenuItem.ForeColor = _FontColour;
                LightYellowToolStripMenuItem.ForeColor = _FontColour;
                LanguageToolStripMenuItem.ForeColor = _FontColour;
                HelpToolStripMenuItem.ForeColor = _FontColour;
                AboutToolStripMenuItem.ForeColor = _FontColour;
                EnglishDefaultToolStripMenuItem.ForeColor = _FontColour;
                FrenchToolStripMenuItem.ForeColor = _FontColour;
                SpanishToolStripMenuItem.ForeColor = _FontColour;

                // Update additional options labels. 
                AdditionalItemsGroupBox.ForeColor = _FontColour;
                StereoSystemCheckBox.ForeColor = _FontColour;
                LeatherInteriorCheckBox.ForeColor = _FontColour;
                ComputerNavigationCheckBox.ForeColor = _FontColour;
                PerformancePackageCheckBox.ForeColor = _FontColour;
                SunRoofCheckBox.ForeColor = _FontColour;
                ExtendedWarrantyCheckBox.ForeColor = _FontColour;

                // Update Exterior Finish labels.
                ExteriorFinishBox.ForeColor = _FontColour;
                StandardRadioButton.ForeColor = _FontColour;
                PearlizedRadioButton.ForeColor = _FontColour;
                CustomDetailingRadioButton.ForeColor = _FontColour;
            }
        /* ---==---- End of Change Colour --------------------------------===--------- */

        /* ---==---- Methods --------------------------------===---------------------- */
            // This method calculates all variables.
            private void Calculate()
                {
                    _IsValid = true;
                    try
                    {
                        // Try converting to double.
                        try
                        {
                            _BasePrice = Convert.ToDouble(BasePriceTextbox.Text);
                        }
                        catch
                        {
                            _IsValid = false;
                            if (_Language == "English")
                            {
                                MessageBox.Show(":( Base price has an invalid input.");
                            }
                            else if (_Language == "French")
                            {
                                MessageBox.Show(":( Prix ​​de base a une entrée non valide.");
                            }
                            else if (_Language == "Spanish")
                            {
                                MessageBox.Show(":( Precio base tiene una entrada no válida.");
                            }
                        }
                        // Checks if negative base price was entered.
                        if (_BasePrice < 0)
                        {
                            _IsValid = false;
                            if (_Language == "English")
                            {
                                MessageBox.Show(":( Base price must be greater than 0.");
                            }
                            else if (_Language == "French")
                            {
                                MessageBox.Show(":( Prix ​​de base doit être supérieur à 0.");
                            }
                            else if (_Language == "Spanish")
                            {
                                MessageBox.Show(":( Precio base debe ser mayor que 0.");
                            }
                        }
                        // Checks that base price is less than 3,000,000.
                        else if (_BasePrice > 3000000)
                        {
                            _IsValid = false;
                            if (_Language == "English")
                            {
                                MessageBox.Show(":( Base price must be less than 3,000,000.");
                            }
                            else if (_Language == "French")
                            {
                                MessageBox.Show(":( Prix ​​de base doit être inférieure à 3,000,000.");
                            }
                            else if (_Language == "Spanish")
                            {
                                MessageBox.Show(":( Precio base debe ser inferior a 3,000,000.");
                            }
                        }

                        // Try converting to double.
                        try
                        {
                            _TradeInAllowance = Convert.ToDouble(TradeInAllowanceTextbox.Text);
                        }
                        catch
                        {
                            _IsValid = false;
                            if (_Language == "English")
                            {
                                MessageBox.Show(":( Trade in allowance has an invalid input.");
                            }
                            else if (_Language == "French")
                            {
                                MessageBox.Show(":( Commerce de l'allocation a une entrée non valide.");
                            }
                            else if (_Language == "Spanish")
                            {
                                MessageBox.Show(":( El comercio de asignación tiene una entrada no válida.");
                            }
                        }
                        // Check if negative trade in amount is used and show a message.
                        if (_TradeInAllowance < 0)
                        {
                            _IsValid = false;
                            if (_Language == "English")
                            {
                                MessageBox.Show(":( Trade-In Allowance must be greater than 0.");
                            }
                            else if (_Language == "French")
                            {
                                MessageBox.Show(":( Trade - In allocation doit être supérieure à 0.");
                            }
                            else if (_Language == "Spanish")
                            {
                                MessageBox.Show(":( En el comercio Asignación debe ser mayor que 0.");
                            }
                        }
                        // Checks if a large trade in was used.
                        if (_TradeInAllowance > 3000000)
                        {
                            _IsValid = false;
                            if (_Language == "English")
                            {
                                MessageBox.Show(":( Trade-In Allowance must be less than 3,000,000.");
                            }
                            else if (_Language == "French")
                            {
                                MessageBox.Show(":( Trade-In allocation doit être inférieur à 3,000,000.");
                            }
                            else if (_Language == "Spanish")
                            {
                                MessageBox.Show(":( En el comercio Asignación debe ser inferior a 3,000,000.");
                            }
                        } // End of else if.

                        // If user enters valid inputs, do below code. Else do nothing.
                        if (_IsValid == true)
                        {
                            // Round BasePrice and TradeInAllowance then submit it back into form.
                            BasePriceTextbox.Text = Math.Round(_BasePrice, 2).ToString();
                            TradeInAllowanceTextbox.Text = Math.Round(_TradeInAllowance, 2).ToString();

                            // Calculate additional options.
                            CalculateAdditionalOptions();

                            //AdditionalOptions = Convert.ToDouble(AdditionalOptionsTextbox.Text); Not needed anymore.
                            Double Subtotal = _BasePrice + _AdditonalOptions;
                            SubTotalTextbox.Text = String.Format("{0:C}", Subtotal);
                            SalesTaxTextbox.Text = "13%";
                            Double Total = Subtotal * 1.13;
                            TotalTextbox.Text = String.Format("{0:C}", Total);
                            Double AmountDue = Total - _TradeInAllowance;

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

                            AmountDueTextbox.Text = String.Format("{0:C}", AmountDue);
                        } // End of try.
                    }
                    catch
                    {
                        if (_Language == "English")
                        {
                            MessageBox.Show(":( General Error.");
                        }
                        else if (_Language == "French")
                        {
                            MessageBox.Show(":( Erreur générale.");
                        }
                        else if (_Language == "Spanish")
                        {
                            MessageBox.Show(":( Error general.");
                        }
                    } // End of catch.     
                } // End of Calculate method.

            // This method clears everything on the form and sets variables (other than style) to default.
            public void Clear()
                {
                    try
                    {
                        // This clear each field individually.
                        BasePriceTextbox.Text = String.Empty;
                        TradeInAllowanceTextbox.Text = "0";
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

            // This method askes you if you want to exit. If yes, exits the program. If no, does nothing.
            public void Exit()
            {
                // This determines the error string.
                String MessageString = "";
                if (_Language == "English")
                {
                    MessageString = "Are you sure you want to exit?";
                }
                else if (_Language == "French")
                {
                    MessageString = "Êtes-vous sûr de vouloir quitter?";
                }
                else if (_Language == "Spanish")
                {
                    MessageString = "Seguro que quieres salir?";
                }

                /* Determines whether the user wants to exit the application and exits if user answers yes. */
                if (MessageBox.Show(MessageString, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }

            // This method opens the about message.
            public void About()
            {
                try
                {
                    if (_Language == "English")
                    {
                        MessageBox.Show("This program calculates the amount due on a New or Used Vehicle.");
                    }
                    else if (_Language == "French")
                    {
                        MessageBox.Show("Ce programme calcule le montant dû sur un véhicule neuf ou d'occasion.");
                    }
                    else if (_Language == "Spanish")
                    {
                        MessageBox.Show("Este programa calcula la cantidad debida en un vehículo nuevo o usado.");
                    }
                }
                catch
                {
                    MessageBox.Show("There was an error selecting your language.");
                }
            }

            // This method calculates the additional options that the calculate method uses after.
            public void CalculateAdditionalOptions()
            {
                // Clears existing values.
                _AdditonalOptions = 0;

                if (StereoSystemCheckBox.Checked == true)
                {
                    _AdditonalOptions = _AdditonalOptions + 425.76;
                }
                if (LeatherInteriorCheckBox.Checked == true)
                {
                    _AdditonalOptions = _AdditonalOptions + 987.41;
                }
                if (ComputerNavigationCheckBox.Checked == true)
                {
                    _AdditonalOptions = _AdditonalOptions + 1741.23;
                }
                if (PerformancePackageCheckBox.Checked == true)
                {
                    _AdditonalOptions = _AdditonalOptions + 3478.24;
                }
                if (SunRoofCheckBox.Checked == true)
                {
                    _AdditonalOptions = _AdditonalOptions + 298.71;
                }
                if (ExtendedWarrantyCheckBox.Checked == true)
                {
                    _AdditonalOptions = _AdditonalOptions + 1645.21;
                }
                if (PearlizedRadioButton.Checked == true)
                {
                    _AdditonalOptions = _AdditonalOptions + 345.72;
                }
                if (CustomDetailingRadioButton.Checked == true)
                {
                    _AdditonalOptions = _AdditonalOptions + 599.99;
                }
                AdditionalOptionsTextbox.Text = String.Format("{0:C}", _AdditonalOptions);
            }

            // This method handles the shortcuts for the form.
            private void FormKeyDown(object sender, KeyEventArgs InputKey)
            {
                // These statements looks for a combination of the control key and the key inserted.
                if (InputKey.Control && InputKey.KeyCode == Keys.E)
                {
                    Exit();
                }
                if (InputKey.Control && InputKey.KeyCode == Keys.C)
                {
                    Calculate();
                }
                if (InputKey.Control && InputKey.KeyCode == Keys.R)
                {
                    Clear();
                }
                if (InputKey.Control && InputKey.KeyCode == Keys.A)
                {
                    About();
                }
        }
        /* ----=---- End of Methods ------------------------------------------------------ */

        /* --------- Additional Options Active Pricing ------------------------------------------------ */
            // If any checkbox is changed, update the new pricing for additonal options.
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
