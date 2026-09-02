using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReportIssue_Click(object sender, EventArgs e)
        {
            ReportIssueForm reportForm = new ReportIssueForm();
            reportForm.MainMenu = this;
            reportForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Disabled - will be implemented in Part 2
            MessageBox.Show("Local Events and Announcements will be available in Part 2.", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Disabled - will be implemented in Part 3
            MessageBox.Show("Service Request Status will be available in Part 3.", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}