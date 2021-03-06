﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOFSApp
{
    //Makes up the GUI and the logic behind it's components
    public partial class Form1 : Form
    {
        private Controller controller;

        //Construucotr, fills all the comboboxes with Enums, assigns them a default value and adds eventlisteners.
        public Form1()
        {
            InitializeComponent();
            controller = new Controller();
            var countries = Enum.GetValues(typeof(Countries));
            for (int i = 0; i < countries.Length; i++)
            {
                countryComboBox.Items.Add(countries.GetValue(i));
                if ((Countries)countries.GetValue(i) != Countries.All)
                {
                    modifyCountryComboBox.Items.Add(countries.GetValue(i));
                }
            }
            var estateTypes = Enum.GetValues(typeof(EstateType));
            for (int i = 0; i < estateTypes.Length; i++)
            {
                estateTypeComboBox.Items.Add(estateTypes.GetValue(i));
                if ((EstateType)estateTypes.GetValue(i) != EstateType.All)
                {
                    estateTypeModifyComboBox.Items.Add(estateTypes.GetValue(i));
                }
            }

            var estateLegalForm = Enum.GetValues(typeof(EstateLegalForm));
            for (int i = 0; i < estateLegalForm.Length; i++)
            {
                modifyLegalFormComboBox.Items.Add(estateLegalForm.GetValue(i));
            }
            countryComboBox.SelectedItem = Countries.All;
            estateTypeComboBox.SelectedItem = EstateType.All;
            addRadioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            modifyCountryComboBox.SelectedIndex = 0;
            modifyLegalFormComboBox.SelectedIndex = 0;
            addRadioButton.Checked = true;
            estateTypeModifyComboBox.SelectedIndex = 0;
            searchListBox.MouseDoubleClick += new MouseEventHandler(searchListbox_MouseDoubleClick);
            menuItemNew.Click += new EventHandler(menuItemNew_ItemClicked);
            menuItemOpen.Click += new EventHandler(menuItemOpen_ItemClicked);
            menuItemSave.Click += new EventHandler(menuItemSave_ItemClicked);
            menuItemSaveAs.Click += new EventHandler(menuItemSaveAs_ItemClicked);
            menuItemExportXML.Click += new EventHandler(menuItemExportXML_ItemClicked);
            menuItemExit.Click += new EventHandler(menuItemExit_ItemClicked);
        }

        //Listens to clicks on the search button
        private void searchButton_Click(object sender, EventArgs e)
        {
            refreshListBox(controller.SearchEstate((Countries)countryComboBox.SelectedItem, cityTextBox.Text, (EstateType)estateTypeComboBox.SelectedItem));
        }

        //Refreshes the datasource assigned to the listbox
        private void refreshListBox(List<Estate> estateList)
        {
            searchListBox.DataSource = estateList;
            searchListBox.DisplayMember = "GetSummary";
        }

        //Listens to clicks on the delete button
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (searchListBox.SelectedIndex <= -1)
            {
                MessageBox.Show("No item selected");
            }
            else
            {
                Estate tempEstate = (Estate)searchListBox.SelectedItem;
                refreshListBox(controller.DeleteEstate(tempEstate.estateID));
            }
        }

        //Checks which radio button is assigned and then calls methods in controller based on if it's add or modify
        private void confirmModifyButton_Click(object sender, EventArgs e)
        {
            if (addRadioButton.Checked)
            {
                Address address = new Address((Countries)modifyCountryComboBox.SelectedItem, cityModifyTextBox.Text, streetModifyTextBox.Text, zipCodeModifyTextBox.Text);
                if (controller.AddEstate(address, (EstateType)estateTypeModifyComboBox.SelectedItem, (EstateLegalForm)modifyLegalFormComboBox.SelectedItem, estatePriceTextBox.Text, dimensionsModifyTextBox.Text, estateRentModifyTextBox.Text, imageLabel.Text))
                {
                    MessageBox.Show("Estate Succesfully Added!");
                }
                else
                {
                    MessageBox.Show("Invalid Input \nTry Again!");
                }
            }
            else
            {
                if (controller.ModifyEstate(IDModifyTextBox.Text, (Countries)modifyCountryComboBox.SelectedItem, cityModifyTextBox.Text, streetModifyTextBox.Text, zipCodeModifyTextBox.Text, (EstateLegalForm)modifyLegalFormComboBox.SelectedItem, estatePriceTextBox.Text, dimensionsModifyTextBox.Text, estateRentModifyTextBox.Text, imageLabel.Text))
                {
                    MessageBox.Show("Estate Successfully modified!");
                }
                else
                {
                    MessageBox.Show("Invalid Input \nTry Again!");
                }

            }
        }

        //eventlistener for radiobuttons
        private void radioButton_CheckedChanged(Object sender, EventArgs e)
        {
            IDModifyTextBox.Enabled = modifyRadioButton.Checked;
            estateTypeModifyComboBox.Enabled = addRadioButton.Checked;
        }

        /**Passes on a picture box for insertion of a picture to the 
        controller and sets a label to the filepath so it can be retreived
        */
        private void imageModifyButton_Click(object sender, EventArgs e)
        {
            imageLabel.Text = controller.HandleImage(modifyPictureBox);
            modifyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void searchListbox_MouseDoubleClick(Object sender, MouseEventArgs e)
        {
            int index = this.searchListBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Estate estate = (Estate)searchListBox.SelectedItem;
                EstateInfo estateForm = new EstateInfo();
                estateForm.FullInfoLabel.Text = estate.ToString();
                if (!string.IsNullOrEmpty(estate.EstatePicture))
                {
                    estateForm.FullInfoPictureBox.Image = new Bitmap(estate.EstatePicture);
                    estateForm.FullInfoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                estateForm.Show();
            }
        }

        private void menuItemNew_ItemClicked(object sender, EventArgs e)
        {
            if (controller.HasChanged())
            {
                DialogResult dialogResult = MessageBox.Show("Unsaved changes. \nDo you wish to continue without saving)", "Save Notice", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                if (dialogResult == DialogResult.Yes)
                {
                    refreshListBox(controller.NewFile());
                    refreshUI();
                }
            }
            refreshListBox(controller.NewFile());
            refreshUI();
        }
        private void menuItemOpen_ItemClicked(object sender, EventArgs e)
        {
            if (controller.HasChanged())
            {
                DialogResult dialogResult = MessageBox.Show("Unsaved changes. \nDo you wish to continue without saving)", "Save Notice", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                if (dialogResult == DialogResult.Yes)
                {
                    controller.openFile();
                    refreshUI();
                }
            }
            else
            {
                controller.openFile();
                refreshUI();
            }
        }
        private void menuItemSave_ItemClicked(object sender, EventArgs e)
        {
            bool fileExists = controller.Save();
            if (!fileExists)
            {
                controller.SaveAs();
            }

        }
        private void menuItemSaveAs_ItemClicked(object sender, EventArgs e)
        {
            bool saved = controller.SaveAs();
            if (!saved)
            {
                MessageBox.Show("Save Error");
            }
        }
       
        private void menuItemExportXML_ItemClicked(object sender, EventArgs e)
        {
            bool saved = controller.ExportXML();
            if (!saved)
            {
                MessageBox.Show("Save Error");
            }
        }
        private void menuItemExit_ItemClicked(object sender, EventArgs e)
        {

        }

        private void refreshUI()
        {
            cityModifyTextBox.Text = "";
            dimensionsModifyTextBox.Text = "";
            estateRentModifyTextBox.Text = "";
            streetModifyTextBox.Text = "";
            zipCodeModifyTextBox.Text = "";
            cityTextBox.Text = "";
            imageLabel.Text = "";
            IDModifyTextBox.Text = "";
            estatePriceTextBox.Text = "";
            countryComboBox.SelectedItem = Countries.All;
            estateTypeComboBox.SelectedItem = EstateType.All;
            modifyCountryComboBox.SelectedIndex = 0;
            modifyLegalFormComboBox.SelectedIndex = 0;
            estateTypeModifyComboBox.SelectedIndex = 0;
            modifyPictureBox.Image = null;
        }
    }
}
