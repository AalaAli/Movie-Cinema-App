using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ui
{
    public partial class ManageShowTimes : Form
    {
        public ManageShowTimes()
        {
            InitializeComponent();
        }

        private void ManageShowTimes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moviesDBDataSet1.ShowTimes' table. You can move, or remove it, as needed.
            this.showTimesTableAdapter.Fill(this.moviesDBDataSet1.ShowTimes);

        }
    }
}
