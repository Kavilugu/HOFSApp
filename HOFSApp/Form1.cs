using System;
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
    public partial class Form1 : Form
    {
        private Controller controller;
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
            var estateCategories = Enum.GetValues(typeof(EstateCategory));
            for (int i = 0; i < estateCategories.Length; i++)
            {
                estateCategoryModifyComboBox.Items.Add(estateCategories.GetValue(i));
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
            estateCategoryModifyComboBox.SelectedIndex = 0;
            estateTypeComboBox.SelectedIndex = 0;
            modifyLegalFormComboBox.SelectedIndex = 0;
            addRadioButton.Checked = true;
            estateTypeModifyComboBox.SelectedIndex = 0;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            refreshListBox(controller.SearchEstate((Countries)countryComboBox.SelectedItem, cityTextBox.Text, (EstateType)estateTypeComboBox.SelectedItem));
        }

        private void refreshListBox(List<Estate> estateList)
        {
            searchListBox.DataSource = estateList;
            searchListBox.DisplayMember = "GetSummary";
        }

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

        private void confirmModifyButton_Click(object sender, EventArgs e)
        {
            if (addRadioButton.Checked)
            {
                Address address = new Address((Countries)modifyCountryComboBox.SelectedItem, cityModifyTextBox.Text, streetModifyTextBox.Text, zipCodeModifyTextBox.Text);
                if (controller.AddEstate(address, (EstateCategory)estateCategoryModifyComboBox.SelectedItem, (EstateType)estateTypeModifyComboBox.SelectedItem, (EstateLegalForm)modifyLegalFormComboBox.SelectedItem, estatePriceTextBox.Text, dimensionsModifyTextBox.Text, estateRentModifyTextBox.Text))
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
                if (controller.ModifyEstate(IDModifyTextBox.Text, (Countries)modifyCountryComboBox.SelectedItem, cityModifyTextBox.Text, streetModifyTextBox.Text, zipCodeModifyTextBox.Text, (EstateType)estateTypeModifyComboBox.SelectedItem, (EstateLegalForm)modifyLegalFormComboBox.SelectedItem, estatePriceTextBox.Text, dimensionsModifyTextBox.Text, estateRentModifyTextBox.Text))
                {
                    MessageBox.Show("Estate Successfully modified!");
                }
                else
                {
                    MessageBox.Show("Invalid Input \nTry Again!");
                }

            }
        }

        private void radioButton_CheckedChanged(Object sender, EventArgs e)
        {
            IDModifyTextBox.Enabled = modifyRadioButton.Checked;
            estateCategoryModifyComboBox.Enabled = addRadioButton.Checked;
        }

        private void imageModifyButton_Click(object sender, EventArgs e)
        {

        }

        private void IDModifyTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
