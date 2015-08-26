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
    public partial class AssignWorkerForm : Form
    {
        public AssignWorkerForm(House selectedHouse)
        {
            InitializeComponent();
            
            //store the house id
            houseIdL.Text = selectedHouse.Id.ToString();
            nameL.Text += selectedHouse.Name;

            //get any previously assigned workers
            GetAssignedWorkers();
        }

        private void AssignWorkerForm_Load(object sender, EventArgs e)
        {
            //create the columns for the house data
            allWorkerLB.View = View.Details;
            allWorkerLB.Columns.Add("Name", -2, HorizontalAlignment.Left);
            allWorkerLB.Columns.Add("Type", -2, HorizontalAlignment.Left);

            var workerDatas = new List<ListViewItem>();
            foreach (var worker in Data.Workers)
            {
                //add the individual data
                var workerData = new ListViewItem(worker.Name);
                workerData.SubItems.Add(worker.Type);
                workerData.SubItems.Add(worker.Id.ToString());
                workerDatas.Add(workerData);
            }

            allWorkerLB.Items.AddRange(workerDatas.ToArray());
        }

        private void backB_Click(object sender, EventArgs e)
        {
            this.Hide();
            var houseForm = new GetAllHouseForm();
            houseForm.Show();
        }

        private void removeB_Click(object sender, EventArgs e)
        {
            //get the house assignement data
            var houseAssignment =
                Data.Assignements.Where(assignment => assignment.HouseIdGuid == Guid.Parse(houseIdL.Text)).ToList().FirstOrDefault();
            if (houseAssignment == null)
                return;

            //get the selected workers
            var removedWorkersItems = assignedWorkerLB.SelectedItems;
            foreach (var removedWorkerItem in removedWorkersItems)
            {
                var workerViewItem = (ListViewItem)removedWorkerItem;
                var workerId = Guid.Parse(workerViewItem.SubItems[2].Text);

                //check to see if the worker is new remove it
                if (houseAssignment.WorkerIds.Contains(workerId))
                    houseAssignment.WorkerIds.Remove(workerId);
            }

            //update the assignment data
            Data.Assignements.Remove(houseAssignment);
            Data.Assignements.Add(houseAssignment);

            //update the ui with the new assigned assets
            GetAssignedWorkers();
        }

        private void addB_Click(object sender, EventArgs e)
        {
            //get the house assignement data
            var houseAssignment =
                Data.Assignements.Where(assignment => assignment.HouseIdGuid == Guid.Parse(houseIdL.Text)).ToList().FirstOrDefault();
            if (houseAssignment == null)
                houseAssignment = new HouseAssignement { HouseIdGuid = Guid.Parse(houseIdL.Text) };

            //get the selected workers
            var addedWorkerItems = allWorkerLB.SelectedItems;
            foreach (var addedWorkerItem in addedWorkerItems)
            {
                var workerViewItem = (ListViewItem) addedWorkerItem;
                var workerId = Guid.Parse(workerViewItem.SubItems[2].Text);
                
                //check to see if the worker is new if it is add it to the house
                if(!houseAssignment.WorkerIds.Contains(workerId))
                    houseAssignment.WorkerIds.Add(workerId);
            }

            //update the assignment data
            Data.Assignements.Remove(houseAssignment);
            Data.Assignements.Add(houseAssignment);

            //update the ui with the new assigned assets
            GetAssignedWorkers();
        }

        public void GetAssignedWorkers()
        {
            //get the house assignement data
            var houseAssignment =
                Data.Assignements.Where(assignment => assignment.HouseIdGuid == Guid.Parse(houseIdL.Text)).ToList().FirstOrDefault();
            if (houseAssignment == null)
                return;

            //get the assigned workers
            var assignedWorkers = Data.Workers.Where(worker => houseAssignment.WorkerIds.Contains(worker.Id));
            
            //create the columns for the house data
            assignedWorkerLB.Clear();
            assignedWorkerLB.View = View.Details;
            assignedWorkerLB.Columns.Add("Name", -2, HorizontalAlignment.Left);
            assignedWorkerLB.Columns.Add("Type", -2, HorizontalAlignment.Left);

            var workerDatas = new List<ListViewItem>();
            foreach (var worker in assignedWorkers)
            {
                //add the individual data
                var workerData = new ListViewItem(worker.Name);
                workerData.SubItems.Add(worker.Type);
                workerData.SubItems.Add(worker.Id.ToString());
                workerDatas.Add(workerData);
            }
            assignedWorkerLB.Items.AddRange(workerDatas.ToArray());
        }

        private void AssignWorkerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
