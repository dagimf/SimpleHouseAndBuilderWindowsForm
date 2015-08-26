using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_selling_desktop_application
{
    public partial class GetAllHouseForm : Form
    {
        public GetAllHouseForm()
        {
            InitializeComponent();
        }

        private void GetAllHouseForm_VisibleChanged(object sender, EventArgs e)
        {
            //create the columns for the house data
            houseLV.View = View.Details;
            houseLV.Columns.Add("Name", -2, HorizontalAlignment.Left);
            houseLV.Columns.Add("Price", -2, HorizontalAlignment.Left);
            houseLV.Columns.Add("Status", -2, HorizontalAlignment.Left);
            houseLV.Columns.Add("Building End Date", -2, HorizontalAlignment.Center);
            
            var houseDatas = new List<ListViewItem> ();
            foreach (var house in Data.Houses)
            {
                //add the individual data
                var houseData = new ListViewItem(house.Name);
                houseData.SubItems.Add(house.Price.ToString());
                houseData.SubItems.Add(house.Status);
                houseData.SubItems.Add(house.BuildingEndDate.ToShortDateString());
                houseData.SubItems.Add(house.Id.ToString());
                houseDatas.Add(houseData);
            }

            houseLV.Items.AddRange(houseDatas.ToArray());
        }

        private void backB_Click(object sender, EventArgs e)
        {
            this.Hide();
            var startingForm = new StartingForm();
            startingForm.Show();
        }

        private void updateB_Click(object sender, EventArgs e)
        {
            //get the selected house
            var selectedItem = houseLV.SelectedItems[0];
            var selectedID = selectedItem.SubItems[4];

            //get the selected House in the database
            var dbHouse = Data.Houses.Where(house => house.Id == Guid.Parse(selectedID.Text)).ToList().FirstOrDefault();

            this.Hide();
            //send the selected house
            var updateForm = new HouseUpdateForm(dbHouse);
            updateForm.Show();
            
        }

        private void GetAllHouseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void assigneWorkerB_Click(object sender, EventArgs e)
        {

            //get the selected house
            var selectedItem = houseLV.SelectedItems[0];
            var selectedID = selectedItem.SubItems[4];

            //get the selected House in the database
            var dbHouse = Data.Houses.Where(house => house.Id == Guid.Parse(selectedID.Text)).ToList().FirstOrDefault();

            this.Hide();
            //send the selected house
            var updateForm = new AssignWorkerForm(dbHouse);
            updateForm.Show();

        }

        private void houseLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            assigneWorkerB.Enabled = true;
        }
    }
}
