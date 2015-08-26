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
    public partial class GetAllWorkersForm : Form
    {
        public GetAllWorkersForm()
        {
            InitializeComponent();
        }

        private void GetAllWorkersForm_Load(object sender, EventArgs e)
        {
            //create the columns for the house data
            workerLV.View = View.Details;
            workerLV.Columns.Add("Name", -2, HorizontalAlignment.Left);
            workerLV.Columns.Add("Type", -2, HorizontalAlignment.Left);
            
            var workerDatas = new List<ListViewItem>();
            foreach (var worker in Data.Workers)
            {
                //add the individual data
                var workerData = new ListViewItem(worker.Name);
                workerData.SubItems.Add(worker.Type);
                workerData.SubItems.Add(worker.Id.ToString());
                workerDatas.Add(workerData);
            }

            workerLV.Items.AddRange(workerDatas.ToArray());
        }

        private void backB_Click(object sender, EventArgs e)
        {
            this.Hide();
            var startingForm = new StartingForm();
            startingForm.Show();
        }

        private void GetAllWorkersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
