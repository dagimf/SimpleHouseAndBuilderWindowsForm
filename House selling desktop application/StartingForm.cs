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
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
        }

        private void addHouseB_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addHouseForm = new AddHouseForm();
            addHouseForm.Show();
        }

        private void getHousesB_Click(object sender, EventArgs e)
        {
            this.Hide();
            var getHouseForm = new GetAllHouseForm();
            getHouseForm.Show();
        }

        private void getWorkersB_Click(object sender, EventArgs e)
        {
            this.Hide();
            var getWorkerForm = new GetAllWorkersForm();
            getWorkerForm.Show();
        }
    }
}
