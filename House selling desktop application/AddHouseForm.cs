using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using House_selling_desktop_application.Models;

namespace House_selling_desktop_application
{
    public partial class AddHouseForm : Form
    {
        public AddHouseForm()
        {
            InitializeComponent();
        }


        private void saveHouseB_Click(object sender, EventArgs e)
        {
            //create the data to be saved then save it
            var newHouse = new House
            {
                Id = Guid.NewGuid(),
                Name = nameTB.Text,
                Price = (double)priceNB.Value,
                Status = statusCB.SelectedItem.ToString(),
                BuildingEndDate =  buildingEndDateDP.Value
                
            };
            Data.Houses.Add(newHouse);

            //reset the form
            saveHouseB.Enabled = false;
            nameTB.Text = null;
            priceNB.Value = 0;
            statusCB.SelectedItem = null;
            buildingEndDateDP.Value = DateTime.Now;

            //create a popup
            MessageBox.Show("House Adding Successfull");
        }

        private void nameTB_Validating(object sender, CancelEventArgs e)
        {
            nameRequiredL.Visible = string.IsNullOrEmpty(nameTB.Text);
            if (statusCB.SelectedItem == null || string.IsNullOrEmpty(nameTB.Text))
                saveHouseB.Enabled = false;
            else
                saveHouseB.Enabled = true;
        }

        private void statusCB_Validating(object sender, CancelEventArgs e)
        {
            statusRequiredL.Visible = statusCB.SelectedItem == null;
            if (statusCB.SelectedItem == null || string.IsNullOrEmpty(nameTB.Text))
                saveHouseB.Enabled = false;
            else
                saveHouseB.Enabled = true;
        }

        private void statusCB_DropDown(object sender, EventArgs e)
        {
            if (statusCB.Items.Contains(HouseStatuses.Building))
                return;
            statusCB.Items.Add(HouseStatuses.Building);
            statusCB.Items.Add(HouseStatuses.Built);
            statusCB.Items.Add(HouseStatuses.ReadForSale);
        }

        private void backB_Click(object sender, EventArgs e)
        {
            this.Hide();
            var startingForm = new StartingForm();
            startingForm.Show();
        }

        private void statusCB_SelectedValueChanged(object sender, EventArgs e)
        {
            statusRequiredL.Visible = statusCB.SelectedItem == null;
            if (statusCB.SelectedItem == null || string.IsNullOrEmpty(nameTB.Text))
                saveHouseB.Enabled = false;
            else
                saveHouseB.Enabled = true;
        }

        private void AddHouseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
