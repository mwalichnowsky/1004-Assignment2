﻿namespace Assignment2
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
            this.BasePriceLabel = new System.Windows.Forms.Label();
            this.TradeInAllowanceLabel = new System.Windows.Forms.Label();
            this.TradeInAllowanceTextbox = new System.Windows.Forms.TextBox();
            this.BasePriceTextbox = new System.Windows.Forms.TextBox();
            this.AdditionalOptionsTextbox = new System.Windows.Forms.TextBox();
            this.SubTotalTextbox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextbox = new System.Windows.Forms.TextBox();
            this.AdditionalOptionsLabel = new System.Windows.Forms.Label();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.AmountDueLabel = new System.Windows.Forms.Label();
            this.TotalTextbox = new System.Windows.Forms.TextBox();
            this.AmountDueTextbox = new System.Windows.Forms.TextBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnglishDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FrenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdditionalItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.ExtendedWarrantyCheckBox = new System.Windows.Forms.CheckBox();
            this.SunRoofCheckBox = new System.Windows.Forms.CheckBox();
            this.PerformancePackageCheckBox = new System.Windows.Forms.CheckBox();
            this.ComputerNavigationCheckBox = new System.Windows.Forms.CheckBox();
            this.LeatherInteriorCheckBox = new System.Windows.Forms.CheckBox();
            this.StereoSystemCheckBox = new System.Windows.Forms.CheckBox();
            this.ExteriorFinishBox = new System.Windows.Forms.GroupBox();
            this.CustomDetailingRadioButton = new System.Windows.Forms.RadioButton();
            this.PearlizedRadioButton = new System.Windows.Forms.RadioButton();
            this.StandardRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.AdditionalItemsGroupBox.SuspendLayout();
            this.ExteriorFinishBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BasePriceLabel
            // 
            this.BasePriceLabel.AutoSize = true;
            this.BasePriceLabel.Location = new System.Drawing.Point(43, 72);
            this.BasePriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BasePriceLabel.Name = "BasePriceLabel";
            this.BasePriceLabel.Size = new System.Drawing.Size(85, 20);
            this.BasePriceLabel.TabIndex = 0;
            this.BasePriceLabel.Text = "Base Price";
            this.BasePriceLabel.Click += new System.EventHandler(this.BasePriceLabel_Click);
            // 
            // TradeInAllowanceLabel
            // 
            this.TradeInAllowanceLabel.AutoSize = true;
            this.TradeInAllowanceLabel.Location = new System.Drawing.Point(43, 396);
            this.TradeInAllowanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TradeInAllowanceLabel.Name = "TradeInAllowanceLabel";
            this.TradeInAllowanceLabel.Size = new System.Drawing.Size(145, 20);
            this.TradeInAllowanceLabel.TabIndex = 2;
            this.TradeInAllowanceLabel.Text = "Trade-In Allowance";
            // 
            // TradeInAllowanceTextbox
            // 
            this.TradeInAllowanceTextbox.ForeColor = System.Drawing.Color.Green;
            this.TradeInAllowanceTextbox.Location = new System.Drawing.Point(282, 393);
            this.TradeInAllowanceTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.TradeInAllowanceTextbox.Name = "TradeInAllowanceTextbox";
            this.TradeInAllowanceTextbox.Size = new System.Drawing.Size(148, 26);
            this.TradeInAllowanceTextbox.TabIndex = 3;
            this.TradeInAllowanceTextbox.Text = "0";
            // 
            // BasePriceTextbox
            // 
            this.BasePriceTextbox.Location = new System.Drawing.Point(282, 69);
            this.BasePriceTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.BasePriceTextbox.Name = "BasePriceTextbox";
            this.BasePriceTextbox.Size = new System.Drawing.Size(148, 26);
            this.BasePriceTextbox.TabIndex = 4;
            // 
            // AdditionalOptionsTextbox
            // 
            this.AdditionalOptionsTextbox.Location = new System.Drawing.Point(282, 128);
            this.AdditionalOptionsTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.AdditionalOptionsTextbox.Name = "AdditionalOptionsTextbox";
            this.AdditionalOptionsTextbox.ReadOnly = true;
            this.AdditionalOptionsTextbox.Size = new System.Drawing.Size(148, 26);
            this.AdditionalOptionsTextbox.TabIndex = 5;
            this.AdditionalOptionsTextbox.Text = "0";
            this.AdditionalOptionsTextbox.TextChanged += new System.EventHandler(this.AdditionalOptionsTextbox_TextChanged);
            // 
            // SubTotalTextbox
            // 
            this.SubTotalTextbox.Location = new System.Drawing.Point(282, 191);
            this.SubTotalTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.SubTotalTextbox.Name = "SubTotalTextbox";
            this.SubTotalTextbox.ReadOnly = true;
            this.SubTotalTextbox.Size = new System.Drawing.Size(148, 26);
            this.SubTotalTextbox.TabIndex = 6;
            // 
            // SalesTaxTextbox
            // 
            this.SalesTaxTextbox.Location = new System.Drawing.Point(282, 254);
            this.SalesTaxTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.SalesTaxTextbox.Name = "SalesTaxTextbox";
            this.SalesTaxTextbox.ReadOnly = true;
            this.SalesTaxTextbox.Size = new System.Drawing.Size(148, 26);
            this.SalesTaxTextbox.TabIndex = 7;
            // 
            // AdditionalOptionsLabel
            // 
            this.AdditionalOptionsLabel.AutoSize = true;
            this.AdditionalOptionsLabel.Location = new System.Drawing.Point(43, 131);
            this.AdditionalOptionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdditionalOptionsLabel.Name = "AdditionalOptionsLabel";
            this.AdditionalOptionsLabel.Size = new System.Drawing.Size(138, 20);
            this.AdditionalOptionsLabel.TabIndex = 8;
            this.AdditionalOptionsLabel.Text = "Additional Options";
            this.AdditionalOptionsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(43, 194);
            this.SubTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(73, 20);
            this.SubTotalLabel.TabIndex = 9;
            this.SubTotalLabel.Text = "SubTotal";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(43, 257);
            this.SalesTaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(78, 20);
            this.SalesTaxLabel.TabIndex = 10;
            this.SalesTaxLabel.Text = "Sales Tax";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(43, 327);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(44, 20);
            this.TotalLabel.TabIndex = 11;
            this.TotalLabel.Text = "Total";
            // 
            // AmountDueLabel
            // 
            this.AmountDueLabel.AutoSize = true;
            this.AmountDueLabel.Location = new System.Drawing.Point(43, 459);
            this.AmountDueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AmountDueLabel.Name = "AmountDueLabel";
            this.AmountDueLabel.Size = new System.Drawing.Size(99, 20);
            this.AmountDueLabel.TabIndex = 12;
            this.AmountDueLabel.Text = "Amount Due";
            // 
            // TotalTextbox
            // 
            this.TotalTextbox.Location = new System.Drawing.Point(282, 324);
            this.TotalTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalTextbox.Name = "TotalTextbox";
            this.TotalTextbox.ReadOnly = true;
            this.TotalTextbox.Size = new System.Drawing.Size(148, 26);
            this.TotalTextbox.TabIndex = 13;
            // 
            // AmountDueTextbox
            // 
            this.AmountDueTextbox.Location = new System.Drawing.Point(282, 456);
            this.AmountDueTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.AmountDueTextbox.Name = "AmountDueTextbox";
            this.AmountDueTextbox.ReadOnly = true;
            this.AmountDueTextbox.Size = new System.Drawing.Size(148, 26);
            this.AmountDueTextbox.TabIndex = 14;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.Menu.Size = new System.Drawing.Size(777, 25);
            this.Menu.TabIndex = 15;
            this.Menu.Text = "Menu";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.PrintToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.MenuToolStripMenuItem.Text = "File";
            this.MenuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.NewToolStripMenuItem.Text = "New";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.PrintToolStripMenuItem.Text = "Print";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalculateToolStripMenuItem,
            this.ClearToolStripMenuItem,
            this.FontToolStripMenuItem,
            this.ColourToolStripMenuItem,
            this.LanguageToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // CalculateToolStripMenuItem
            // 
            this.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem";
            this.CalculateToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.CalculateToolStripMenuItem.Text = "Calculate";
            this.CalculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ClearToolStripMenuItem.Text = "Clear";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.FontToolStripMenuItem.Text = "Font";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // ColourToolStripMenuItem
            // 
            this.ColourToolStripMenuItem.Name = "ColourToolStripMenuItem";
            this.ColourToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ColourToolStripMenuItem.Text = "Colour";
            this.ColourToolStripMenuItem.Click += new System.EventHandler(this.colourToolStripMenuItem_Click);
            // 
            // LanguageToolStripMenuItem
            // 
            this.LanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EnglishDefaultToolStripMenuItem,
            this.FrenchToolStripMenuItem,
            this.SpanishToolStripMenuItem});
            this.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem";
            this.LanguageToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.LanguageToolStripMenuItem.Text = "Language";
            // 
            // EnglishDefaultToolStripMenuItem
            // 
            this.EnglishDefaultToolStripMenuItem.Name = "EnglishDefaultToolStripMenuItem";
            this.EnglishDefaultToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.EnglishDefaultToolStripMenuItem.Text = "English (Default)";
            this.EnglishDefaultToolStripMenuItem.Click += new System.EventHandler(this.englishDefaultToolStripMenuItem_Click);
            // 
            // FrenchToolStripMenuItem
            // 
            this.FrenchToolStripMenuItem.Name = "FrenchToolStripMenuItem";
            this.FrenchToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.FrenchToolStripMenuItem.Text = "French";
            this.FrenchToolStripMenuItem.Click += new System.EventHandler(this.frenchToolStripMenuItem_Click);
            // 
            // SpanishToolStripMenuItem
            // 
            this.SpanishToolStripMenuItem.Name = "SpanishToolStripMenuItem";
            this.SpanishToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.SpanishToolStripMenuItem.Text = "Spanish";
            this.SpanishToolStripMenuItem.Click += new System.EventHandler(this.spanishToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // AdditionalItemsGroupBox
            // 
            this.AdditionalItemsGroupBox.Controls.Add(this.ExtendedWarrantyCheckBox);
            this.AdditionalItemsGroupBox.Controls.Add(this.SunRoofCheckBox);
            this.AdditionalItemsGroupBox.Controls.Add(this.PerformancePackageCheckBox);
            this.AdditionalItemsGroupBox.Controls.Add(this.ComputerNavigationCheckBox);
            this.AdditionalItemsGroupBox.Controls.Add(this.LeatherInteriorCheckBox);
            this.AdditionalItemsGroupBox.Controls.Add(this.StereoSystemCheckBox);
            this.AdditionalItemsGroupBox.Location = new System.Drawing.Point(500, 69);
            this.AdditionalItemsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.AdditionalItemsGroupBox.Name = "AdditionalItemsGroupBox";
            this.AdditionalItemsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.AdditionalItemsGroupBox.Size = new System.Drawing.Size(231, 233);
            this.AdditionalItemsGroupBox.TabIndex = 16;
            this.AdditionalItemsGroupBox.TabStop = false;
            this.AdditionalItemsGroupBox.Text = "Additional Items";
            // 
            // ExtendedWarrantyCheckBox
            // 
            this.ExtendedWarrantyCheckBox.AutoSize = true;
            this.ExtendedWarrantyCheckBox.Location = new System.Drawing.Point(36, 185);
            this.ExtendedWarrantyCheckBox.Name = "ExtendedWarrantyCheckBox";
            this.ExtendedWarrantyCheckBox.Size = new System.Drawing.Size(164, 24);
            this.ExtendedWarrantyCheckBox.TabIndex = 5;
            this.ExtendedWarrantyCheckBox.Text = "Extended Warranty";
            this.ExtendedWarrantyCheckBox.UseVisualStyleBackColor = true;
            this.ExtendedWarrantyCheckBox.CheckedChanged += new System.EventHandler(this.ExtendedWarrantyCheckBox_CheckedChanged);
            // 
            // SunRoofCheckBox
            // 
            this.SunRoofCheckBox.AutoSize = true;
            this.SunRoofCheckBox.Location = new System.Drawing.Point(36, 154);
            this.SunRoofCheckBox.Name = "SunRoofCheckBox";
            this.SunRoofCheckBox.Size = new System.Drawing.Size(96, 24);
            this.SunRoofCheckBox.TabIndex = 4;
            this.SunRoofCheckBox.Text = "Sun Roof";
            this.SunRoofCheckBox.UseVisualStyleBackColor = true;
            this.SunRoofCheckBox.CheckedChanged += new System.EventHandler(this.SunRoofCheckBox_CheckedChanged);
            // 
            // PerformancePackageCheckBox
            // 
            this.PerformancePackageCheckBox.AutoSize = true;
            this.PerformancePackageCheckBox.Location = new System.Drawing.Point(36, 124);
            this.PerformancePackageCheckBox.Name = "PerformancePackageCheckBox";
            this.PerformancePackageCheckBox.Size = new System.Drawing.Size(185, 24);
            this.PerformancePackageCheckBox.TabIndex = 3;
            this.PerformancePackageCheckBox.Text = "Performance Package";
            this.PerformancePackageCheckBox.UseVisualStyleBackColor = true;
            this.PerformancePackageCheckBox.CheckedChanged += new System.EventHandler(this.PerformancePackageCheckBox_CheckedChanged);
            // 
            // ComputerNavigationCheckBox
            // 
            this.ComputerNavigationCheckBox.AutoSize = true;
            this.ComputerNavigationCheckBox.Location = new System.Drawing.Point(36, 93);
            this.ComputerNavigationCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ComputerNavigationCheckBox.Name = "ComputerNavigationCheckBox";
            this.ComputerNavigationCheckBox.Size = new System.Drawing.Size(176, 24);
            this.ComputerNavigationCheckBox.TabIndex = 2;
            this.ComputerNavigationCheckBox.Text = "Computer Navigation";
            this.ComputerNavigationCheckBox.UseVisualStyleBackColor = true;
            this.ComputerNavigationCheckBox.CheckedChanged += new System.EventHandler(this.ComputerNavigationCheckBox_CheckedChanged);
            // 
            // LeatherInteriorCheckBox
            // 
            this.LeatherInteriorCheckBox.AutoSize = true;
            this.LeatherInteriorCheckBox.Location = new System.Drawing.Point(36, 61);
            this.LeatherInteriorCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.LeatherInteriorCheckBox.Name = "LeatherInteriorCheckBox";
            this.LeatherInteriorCheckBox.Size = new System.Drawing.Size(137, 24);
            this.LeatherInteriorCheckBox.TabIndex = 1;
            this.LeatherInteriorCheckBox.Text = "Leather Interior";
            this.LeatherInteriorCheckBox.UseVisualStyleBackColor = true;
            this.LeatherInteriorCheckBox.CheckedChanged += new System.EventHandler(this.LeatherInteriorCheckBox_CheckedChanged);
            // 
            // StereoSystemCheckBox
            // 
            this.StereoSystemCheckBox.AutoSize = true;
            this.StereoSystemCheckBox.Location = new System.Drawing.Point(36, 29);
            this.StereoSystemCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.StereoSystemCheckBox.Name = "StereoSystemCheckBox";
            this.StereoSystemCheckBox.Size = new System.Drawing.Size(133, 24);
            this.StereoSystemCheckBox.TabIndex = 0;
            this.StereoSystemCheckBox.Text = "Stereo System";
            this.StereoSystemCheckBox.UseVisualStyleBackColor = true;
            this.StereoSystemCheckBox.CheckedChanged += new System.EventHandler(this.StereoSystemCheckBox_CheckedChanged);
            // 
            // ExteriorFinishBox
            // 
            this.ExteriorFinishBox.Controls.Add(this.CustomDetailingRadioButton);
            this.ExteriorFinishBox.Controls.Add(this.PearlizedRadioButton);
            this.ExteriorFinishBox.Controls.Add(this.StandardRadioButton);
            this.ExteriorFinishBox.Location = new System.Drawing.Point(500, 335);
            this.ExteriorFinishBox.Margin = new System.Windows.Forms.Padding(4);
            this.ExteriorFinishBox.Name = "ExteriorFinishBox";
            this.ExteriorFinishBox.Padding = new System.Windows.Forms.Padding(4);
            this.ExteriorFinishBox.Size = new System.Drawing.Size(231, 151);
            this.ExteriorFinishBox.TabIndex = 17;
            this.ExteriorFinishBox.TabStop = false;
            this.ExteriorFinishBox.Text = "Exterior Finish";
            // 
            // CustomDetailingRadioButton
            // 
            this.CustomDetailingRadioButton.AutoSize = true;
            this.CustomDetailingRadioButton.Location = new System.Drawing.Point(36, 103);
            this.CustomDetailingRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.CustomDetailingRadioButton.Name = "CustomDetailingRadioButton";
            this.CustomDetailingRadioButton.Size = new System.Drawing.Size(148, 24);
            this.CustomDetailingRadioButton.TabIndex = 2;
            this.CustomDetailingRadioButton.Text = "Custom Detailing";
            this.CustomDetailingRadioButton.UseVisualStyleBackColor = true;
            this.CustomDetailingRadioButton.CheckedChanged += new System.EventHandler(this.CustomDetailingRadioButton_CheckedChanged);
            // 
            // PearlizedRadioButton
            // 
            this.PearlizedRadioButton.AutoSize = true;
            this.PearlizedRadioButton.Location = new System.Drawing.Point(36, 68);
            this.PearlizedRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.PearlizedRadioButton.Name = "PearlizedRadioButton";
            this.PearlizedRadioButton.Size = new System.Drawing.Size(92, 24);
            this.PearlizedRadioButton.TabIndex = 1;
            this.PearlizedRadioButton.Text = "Pearlized";
            this.PearlizedRadioButton.UseVisualStyleBackColor = true;
            this.PearlizedRadioButton.CheckedChanged += new System.EventHandler(this.PearlizedRadioButton_CheckedChanged);
            // 
            // StandardRadioButton
            // 
            this.StandardRadioButton.AutoSize = true;
            this.StandardRadioButton.Checked = true;
            this.StandardRadioButton.Location = new System.Drawing.Point(36, 32);
            this.StandardRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.StandardRadioButton.Name = "StandardRadioButton";
            this.StandardRadioButton.Size = new System.Drawing.Size(93, 24);
            this.StandardRadioButton.TabIndex = 0;
            this.StandardRadioButton.TabStop = true;
            this.StandardRadioButton.Text = "Standard";
            this.StandardRadioButton.UseVisualStyleBackColor = true;
            this.StandardRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.Green;
            this.CalculateButton.Location = new System.Drawing.Point(47, 558);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(112, 36);
            this.CalculateButton.TabIndex = 18;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Yellow;
            this.ClearButton.Location = new System.Drawing.Point(342, 558);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(112, 36);
            this.ClearButton.TabIndex = 19;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(619, 558);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(112, 36);
            this.ExitButton.TabIndex = 20;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(777, 629);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ExteriorFinishBox);
            this.Controls.Add(this.AdditionalItemsGroupBox);
            this.Controls.Add(this.AmountDueTextbox);
            this.Controls.Add(this.TotalTextbox);
            this.Controls.Add(this.AmountDueLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.SalesTaxLabel);
            this.Controls.Add(this.SubTotalLabel);
            this.Controls.Add(this.AdditionalOptionsLabel);
            this.Controls.Add(this.SalesTaxTextbox);
            this.Controls.Add(this.SubTotalTextbox);
            this.Controls.Add(this.AdditionalOptionsTextbox);
            this.Controls.Add(this.BasePriceTextbox);
            this.Controls.Add(this.TradeInAllowanceTextbox);
            this.Controls.Add(this.TradeInAllowanceLabel);
            this.Controls.Add(this.BasePriceLabel);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Sharp Auto Center";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.AdditionalItemsGroupBox.ResumeLayout(false);
            this.AdditionalItemsGroupBox.PerformLayout();
            this.ExteriorFinishBox.ResumeLayout(false);
            this.ExteriorFinishBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BasePriceLabel;
        private System.Windows.Forms.Label TradeInAllowanceLabel;
        private System.Windows.Forms.TextBox TradeInAllowanceTextbox;
        private System.Windows.Forms.TextBox BasePriceTextbox;
        private System.Windows.Forms.TextBox AdditionalOptionsTextbox;
        private System.Windows.Forms.TextBox SubTotalTextbox;
        private System.Windows.Forms.TextBox SalesTaxTextbox;
        private System.Windows.Forms.Label AdditionalOptionsLabel;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label AmountDueLabel;
        private System.Windows.Forms.TextBox TotalTextbox;
        private System.Windows.Forms.TextBox AmountDueTextbox;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        private System.Windows.Forms.GroupBox AdditionalItemsGroupBox;
        private System.Windows.Forms.CheckBox ComputerNavigationCheckBox;
        private System.Windows.Forms.CheckBox LeatherInteriorCheckBox;
        private System.Windows.Forms.CheckBox StereoSystemCheckBox;
        private System.Windows.Forms.GroupBox ExteriorFinishBox;
        private System.Windows.Forms.RadioButton CustomDetailingRadioButton;
        private System.Windows.Forms.RadioButton PearlizedRadioButton;
        private System.Windows.Forms.RadioButton StandardRadioButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CalculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EnglishDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FrenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpanishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.CheckBox PerformancePackageCheckBox;
        private System.Windows.Forms.CheckBox ExtendedWarrantyCheckBox;
        private System.Windows.Forms.CheckBox SunRoofCheckBox;
    }
}

