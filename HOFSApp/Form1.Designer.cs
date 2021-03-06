﻿namespace HOFSApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.estateTypeLabel = new System.Windows.Forms.Label();
            this.estateTypeComboBox = new System.Windows.Forms.ComboBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.searchListBox = new System.Windows.Forms.ListBox();
            this.modifyTab = new System.Windows.Forms.TabPage();
            this.imageLabel = new System.Windows.Forms.Label();
            this.modifyLegalFormComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.estateTypeModifyComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.imageModifyButton = new System.Windows.Forms.Button();
            this.modifyPictureBox = new System.Windows.Forms.PictureBox();
            this.confirmModifyButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.estateRentModifyTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dimensionsModifyTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.estatePriceTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.zipCodeModifyTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.streetModifyTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioGroupBox = new System.Windows.Forms.GroupBox();
            this.addRadioButton = new System.Windows.Forms.RadioButton();
            this.modifyRadioButton = new System.Windows.Forms.RadioButton();
            this.cityModifyTextBox = new System.Windows.Forms.TextBox();
            this.modifyCountryComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDModifyTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemXML = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExportXML = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.searchTab.SuspendLayout();
            this.modifyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modifyPictureBox)).BeginInit();
            this.radioGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.searchTab);
            this.tabControl1.Controls.Add(this.modifyTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // searchTab
            // 
            this.searchTab.BackColor = System.Drawing.Color.Silver;
            this.searchTab.Controls.Add(this.deleteButton);
            this.searchTab.Controls.Add(this.searchButton);
            this.searchTab.Controls.Add(this.label1);
            this.searchTab.Controls.Add(this.cityTextBox);
            this.searchTab.Controls.Add(this.estateTypeLabel);
            this.searchTab.Controls.Add(this.estateTypeComboBox);
            this.searchTab.Controls.Add(this.countryLabel);
            this.searchTab.Controls.Add(this.countryComboBox);
            this.searchTab.Controls.Add(this.searchListBox);
            this.searchTab.Location = new System.Drawing.Point(4, 24);
            this.searchTab.Name = "searchTab";
            this.searchTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchTab.Size = new System.Drawing.Size(795, 407);
            this.searchTab.TabIndex = 0;
            this.searchTab.Text = "Search";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(298, 100);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(180, 100);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "City";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(217, 44);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(110, 23);
            this.cityTextBox.TabIndex = 5;
            // 
            // estateTypeLabel
            // 
            this.estateTypeLabel.AutoSize = true;
            this.estateTypeLabel.Location = new System.Drawing.Point(364, 15);
            this.estateTypeLabel.Name = "estateTypeLabel";
            this.estateTypeLabel.Size = new System.Drawing.Size(65, 15);
            this.estateTypeLabel.TabIndex = 4;
            this.estateTypeLabel.Text = "Estate Type";
            // 
            // estateTypeComboBox
            // 
            this.estateTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.estateTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.estateTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estateTypeComboBox.FormattingEnabled = true;
            this.estateTypeComboBox.Location = new System.Drawing.Point(346, 44);
            this.estateTypeComboBox.Name = "estateTypeComboBox";
            this.estateTypeComboBox.Size = new System.Drawing.Size(110, 23);
            this.estateTypeComboBox.Sorted = true;
            this.estateTypeComboBox.TabIndex = 3;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(73, 15);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(50, 15);
            this.countryLabel.TabIndex = 2;
            this.countryLabel.Text = "Country";
            // 
            // countryComboBox
            // 
            this.countryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.countryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(20, 44);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(176, 23);
            this.countryComboBox.Sorted = true;
            this.countryComboBox.TabIndex = 1;
            // 
            // searchListBox
            // 
            this.searchListBox.FormattingEnabled = true;
            this.searchListBox.ItemHeight = 15;
            this.searchListBox.Location = new System.Drawing.Point(-1, 138);
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(800, 289);
            this.searchListBox.TabIndex = 0;
            // 
            // modifyTab
            // 
            this.modifyTab.BackColor = System.Drawing.Color.Silver;
            this.modifyTab.Controls.Add(this.imageLabel);
            this.modifyTab.Controls.Add(this.modifyLegalFormComboBox);
            this.modifyTab.Controls.Add(this.label13);
            this.modifyTab.Controls.Add(this.estateTypeModifyComboBox);
            this.modifyTab.Controls.Add(this.label11);
            this.modifyTab.Controls.Add(this.imageModifyButton);
            this.modifyTab.Controls.Add(this.modifyPictureBox);
            this.modifyTab.Controls.Add(this.confirmModifyButton);
            this.modifyTab.Controls.Add(this.label10);
            this.modifyTab.Controls.Add(this.estateRentModifyTextBox);
            this.modifyTab.Controls.Add(this.label9);
            this.modifyTab.Controls.Add(this.dimensionsModifyTextBox);
            this.modifyTab.Controls.Add(this.label8);
            this.modifyTab.Controls.Add(this.estatePriceTextBox);
            this.modifyTab.Controls.Add(this.label7);
            this.modifyTab.Controls.Add(this.zipCodeModifyTextBox);
            this.modifyTab.Controls.Add(this.label6);
            this.modifyTab.Controls.Add(this.streetModifyTextBox);
            this.modifyTab.Controls.Add(this.label5);
            this.modifyTab.Controls.Add(this.radioGroupBox);
            this.modifyTab.Controls.Add(this.cityModifyTextBox);
            this.modifyTab.Controls.Add(this.modifyCountryComboBox);
            this.modifyTab.Controls.Add(this.label4);
            this.modifyTab.Controls.Add(this.label3);
            this.modifyTab.Controls.Add(this.label2);
            this.modifyTab.Controls.Add(this.IDModifyTextBox);
            this.modifyTab.Location = new System.Drawing.Point(4, 24);
            this.modifyTab.Name = "modifyTab";
            this.modifyTab.Padding = new System.Windows.Forms.Padding(3);
            this.modifyTab.Size = new System.Drawing.Size(795, 407);
            this.modifyTab.TabIndex = 1;
            this.modifyTab.Text = "Modify";
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(575, 242);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(0, 15);
            this.imageLabel.TabIndex = 31;
            // 
            // modifyLegalFormComboBox
            // 
            this.modifyLegalFormComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.modifyLegalFormComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.modifyLegalFormComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modifyLegalFormComboBox.FormattingEnabled = true;
            this.modifyLegalFormComboBox.Location = new System.Drawing.Point(39, 215);
            this.modifyLegalFormComboBox.Name = "modifyLegalFormComboBox";
            this.modifyLegalFormComboBox.Size = new System.Drawing.Size(121, 23);
            this.modifyLegalFormComboBox.Sorted = true;
            this.modifyLegalFormComboBox.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(51, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "Estate Type";
            // 
            // estateTypeModifyComboBox
            // 
            this.estateTypeModifyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.estateTypeModifyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.estateTypeModifyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estateTypeModifyComboBox.FormattingEnabled = true;
            this.estateTypeModifyComboBox.Location = new System.Drawing.Point(39, 87);
            this.estateTypeModifyComboBox.Name = "estateTypeModifyComboBox";
            this.estateTypeModifyComboBox.Size = new System.Drawing.Size(102, 23);
            this.estateTypeModifyComboBox.Sorted = true;
            this.estateTypeModifyComboBox.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(649, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Image";
            // 
            // imageModifyButton
            // 
            this.imageModifyButton.Location = new System.Drawing.Point(631, 260);
            this.imageModifyButton.Name = "imageModifyButton";
            this.imageModifyButton.Size = new System.Drawing.Size(75, 23);
            this.imageModifyButton.TabIndex = 24;
            this.imageModifyButton.Text = "Upload";
            this.imageModifyButton.UseVisualStyleBackColor = true;
            this.imageModifyButton.Click += new System.EventHandler(this.imageModifyButton_Click);
            // 
            // modifyPictureBox
            // 
            this.modifyPictureBox.Location = new System.Drawing.Point(598, 126);
            this.modifyPictureBox.Name = "modifyPictureBox";
            this.modifyPictureBox.Size = new System.Drawing.Size(141, 112);
            this.modifyPictureBox.TabIndex = 23;
            this.modifyPictureBox.TabStop = false;
            // 
            // confirmModifyButton
            // 
            this.confirmModifyButton.Location = new System.Drawing.Point(328, 364);
            this.confirmModifyButton.Name = "confirmModifyButton";
            this.confirmModifyButton.Size = new System.Drawing.Size(75, 23);
            this.confirmModifyButton.TabIndex = 22;
            this.confirmModifyButton.Text = "Confirm";
            this.confirmModifyButton.UseVisualStyleBackColor = true;
            this.confirmModifyButton.Click += new System.EventHandler(this.confirmModifyButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Legal Form:";
            // 
            // estateRentModifyTextBox
            // 
            this.estateRentModifyTextBox.Location = new System.Drawing.Point(312, 215);
            this.estateRentModifyTextBox.Name = "estateRentModifyTextBox";
            this.estateRentModifyTextBox.Size = new System.Drawing.Size(100, 23);
            this.estateRentModifyTextBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Estate Rent:";
            // 
            // dimensionsModifyTextBox
            // 
            this.dimensionsModifyTextBox.Location = new System.Drawing.Point(187, 215);
            this.dimensionsModifyTextBox.Name = "dimensionsModifyTextBox";
            this.dimensionsModifyTextBox.Size = new System.Drawing.Size(100, 23);
            this.dimensionsModifyTextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Estate Dimensions:";
            // 
            // estatePriceTextBox
            // 
            this.estatePriceTextBox.Location = new System.Drawing.Point(442, 215);
            this.estatePriceTextBox.Name = "estatePriceTextBox";
            this.estatePriceTextBox.Size = new System.Drawing.Size(100, 23);
            this.estatePriceTextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Estate Price:";
            // 
            // zipCodeModifyTextBox
            // 
            this.zipCodeModifyTextBox.Location = new System.Drawing.Point(442, 144);
            this.zipCodeModifyTextBox.Name = "zipCodeModifyTextBox";
            this.zipCodeModifyTextBox.Size = new System.Drawing.Size(100, 23);
            this.zipCodeModifyTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Zip Code:";
            // 
            // streetModifyTextBox
            // 
            this.streetModifyTextBox.Location = new System.Drawing.Point(312, 144);
            this.streetModifyTextBox.Name = "streetModifyTextBox";
            this.streetModifyTextBox.Size = new System.Drawing.Size(100, 23);
            this.streetModifyTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Street:";
            // 
            // radioGroupBox
            // 
            this.radioGroupBox.Controls.Add(this.addRadioButton);
            this.radioGroupBox.Controls.Add(this.modifyRadioButton);
            this.radioGroupBox.Location = new System.Drawing.Point(145, 8);
            this.radioGroupBox.Name = "radioGroupBox";
            this.radioGroupBox.Size = new System.Drawing.Size(74, 101);
            this.radioGroupBox.TabIndex = 9;
            this.radioGroupBox.TabStop = false;
            // 
            // addRadioButton
            // 
            this.addRadioButton.AutoSize = true;
            this.addRadioButton.Location = new System.Drawing.Point(6, 79);
            this.addRadioButton.Name = "addRadioButton";
            this.addRadioButton.Size = new System.Drawing.Size(47, 19);
            this.addRadioButton.TabIndex = 8;
            this.addRadioButton.TabStop = true;
            this.addRadioButton.Text = "Add";
            this.addRadioButton.UseVisualStyleBackColor = true;
            // 
            // modifyRadioButton
            // 
            this.modifyRadioButton.AutoSize = true;
            this.modifyRadioButton.Location = new System.Drawing.Point(6, 23);
            this.modifyRadioButton.Name = "modifyRadioButton";
            this.modifyRadioButton.Size = new System.Drawing.Size(63, 19);
            this.modifyRadioButton.TabIndex = 7;
            this.modifyRadioButton.TabStop = true;
            this.modifyRadioButton.Text = "Modify";
            this.modifyRadioButton.UseVisualStyleBackColor = true;
            // 
            // cityModifyTextBox
            // 
            this.cityModifyTextBox.Location = new System.Drawing.Point(187, 144);
            this.cityModifyTextBox.Name = "cityModifyTextBox";
            this.cityModifyTextBox.Size = new System.Drawing.Size(100, 23);
            this.cityModifyTextBox.TabIndex = 6;
            // 
            // modifyCountryComboBox
            // 
            this.modifyCountryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.modifyCountryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.modifyCountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modifyCountryComboBox.FormattingEnabled = true;
            this.modifyCountryComboBox.Location = new System.Drawing.Point(39, 144);
            this.modifyCountryComboBox.Name = "modifyCountryComboBox";
            this.modifyCountryComboBox.Size = new System.Drawing.Size(121, 23);
            this.modifyCountryComboBox.Sorted = true;
            this.modifyCountryComboBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Country:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID to modify:";
            // 
            // IDModifyTextBox
            // 
            this.IDModifyTextBox.Location = new System.Drawing.Point(39, 30);
            this.IDModifyTextBox.Name = "IDModifyTextBox";
            this.IDModifyTextBox.Size = new System.Drawing.Size(100, 23);
            this.IDModifyTextBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemFile
            // 
            this.menuItemFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNew,
            this.menuItemOpen,
            this.toolStripSeparator,
            this.menuItemSave,
            this.menuItemSaveAs,
            this.toolStripSeparator1,
            this.menuItemXML,
            this.toolStripSeparator2,
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "&File";
            // 
            // menuItemNew
            // 
            this.menuItemNew.Image = ((System.Drawing.Image)(resources.GetObject("menuItemNew.Image")));
            this.menuItemNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuItemNew.Name = "menuItemNew";
            this.menuItemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuItemNew.Size = new System.Drawing.Size(146, 22);
            this.menuItemNew.Text = "&New";
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuItemOpen.Image")));
            this.menuItemOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuItemOpen.Size = new System.Drawing.Size(146, 22);
            this.menuItemOpen.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Image = ((System.Drawing.Image)(resources.GetObject("menuItemSave.Image")));
            this.menuItemSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuItemSave.Size = new System.Drawing.Size(146, 22);
            this.menuItemSave.Text = "&Save";
            // 
            // menuItemSaveAs
            // 
            this.menuItemSaveAs.Name = "menuItemSaveAs";
            this.menuItemSaveAs.Size = new System.Drawing.Size(146, 22);
            this.menuItemSaveAs.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // menuItemXML
            // 
            this.menuItemXML.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemExportXML});
            this.menuItemXML.Name = "menuItemXML";
            this.menuItemXML.Size = new System.Drawing.Size(146, 22);
            this.menuItemXML.Text = "XML";
            // 
            // menuItemExportXML
            // 
            this.menuItemExportXML.Name = "menuItemExportXML";
            this.menuItemExportXML.Size = new System.Drawing.Size(149, 22);
            this.menuItemExportXML.Text = "Export to XML";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(146, 22);
            this.menuItemExit.Text = "E&xit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.searchTab.ResumeLayout(false);
            this.searchTab.PerformLayout();
            this.modifyTab.ResumeLayout(false);
            this.modifyTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modifyPictureBox)).EndInit();
            this.radioGroupBox.ResumeLayout(false);
            this.radioGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage searchTab;
        private System.Windows.Forms.ListBox searchListBox;
        private System.Windows.Forms.TabPage modifyTab;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Label estateTypeLabel;
        private System.Windows.Forms.ComboBox estateTypeComboBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDModifyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox modifyCountryComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox radioGroupBox;
        private System.Windows.Forms.RadioButton addRadioButton;
        private System.Windows.Forms.RadioButton modifyRadioButton;
        private System.Windows.Forms.TextBox cityModifyTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox streetModifyTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox zipCodeModifyTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox estatePriceTextBox;
        private System.Windows.Forms.Button confirmModifyButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox estateRentModifyTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dimensionsModifyTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button imageModifyButton;
        private System.Windows.Forms.PictureBox modifyPictureBox;
        private System.Windows.Forms.ComboBox estateTypeModifyComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox modifyLegalFormComboBox;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemXML;
        private System.Windows.Forms.ToolStripMenuItem menuItemExportXML;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

