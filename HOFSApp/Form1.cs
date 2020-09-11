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
                
            }
            countryComboBox.SelectedItem = Countries.All;
            estateTypeComboBox.SelectedItem = EstateType.All;
            addRadioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
  

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

        }

        private void radioButton_CheckedChanged(Object sender, EventArgs e)
        {
            IDModifyTextBox.Enabled = modifyRadioButton.Checked;
            estateTypeComboBox.Enabled = addRadioButton.Checked;
        }
    }
}
