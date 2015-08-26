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
    public partial class HouseUpdateForm : Form
    {
        public HouseUpdateForm(House selectedHouse)
        {
            InitializeComponent();

            //add the status lists
            if (statusCB.Items.Contains(HouseStatuses.Building))
                return;
            statusCB.Items.Add(HouseStatuses.Building);
            statusCB.Items.Add(HouseStatuses.Built);
            statusCB.Items.Add(HouseStatuses.ReadForSale);


            //setup the preexsisting house
            IdL.Text = selectedHouse.Id.ToString();
            nameTB.Text = selectedHouse.Name;
            priceNB.Value = (decimal)selectedHouse.Price;
            statusCB.SelectedItem = selectedHouse.Status;
            buildingEndDateDP.Value = selectedHouse.BuildingEndDate;
        }

        private void updateHouseB_Click(object sender, EventArgs e)
        {
            //get the selected House in the database
            var dbHouse = Data.Houses.Where(house => house.Id == Guid.Parse(IdL.Text)).ToList().FirstOrDefault();

            //check to see if the house exsists
            if (dbHouse == null)
                return;

            //update the house info
            dbHouse.Name = nameTB.Text;
            dbHouse.Price = (double)priceNB.Value;
            dbHouse.Status = statusCB.SelectedItem.ToString();
            dbHouse.BuildingEndDate = buildingEndDateDP.Value;

            //remove the old version and add the latest
            Data.Houses.Remove(dbHouse);
            Data.Houses.Add(dbHouse);
            
            //create a popup
            MessageBox.Show("House Adding Successfull");
        }

        private void backB_Click(object sender, EventArgs e)
        {
            this.Hide();
            var startingForm = new StartingForm();
            startingForm.Show();
        }

        private void statusCB_Validating(object sender, CancelEventArgs e)
        {
            statusRequiredL.Visible = statusCB.SelectedItem == null;
            if (statusCB.SelectedItem == null || string.IsNullOrEmpty(nameTB.Text))
                updateHouseB.Enabled = false;
            else
                updateHouseB.Enabled = true;
        }

        private void nameTB_Validating(object sender, CancelEventArgs e)
        {
            statusRequiredL.Visible = statusCB.SelectedItem == null;
            if (statusCB.SelectedItem == null || string.IsNullOrEmpty(nameTB.Text))
                updateHouseB.Enabled = false;
            else
                updateHouseB.Enabled = true;
        }

        private void HouseUpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void HouseUpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
