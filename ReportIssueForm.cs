using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MunicipalServicesApp
{
    public partial class ReportIssueForm : Form
    {
        // Data structure to store reported issues
        private List<ReportedIssue> reportedIssues = new List<ReportedIssue>();
        private int attachmentCount = 0;
        private const int MAX_ATTACHMENTS = 5;

        // Property to reference the main menu form for navigation back
        public MainMenuForm MainMenu { get; set; }

        public ReportIssueForm()
        {
            InitializeComponent();
        }

        private void ReportIssueForm_Load(object sender, EventArgs e)
        {
            InitializeCategories();
            InitializeGender(); // FIXED: Added this line
            UpdateEngagementMessage();
        }

        private void InitializeCategories()
        {
            // Clear any existing items and populate category dropdown
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("Sanitation");
            cmbCategory.Items.Add("Roads");
            cmbCategory.Items.Add("Utilities");
            cmbCategory.Items.Add("Public Safety");
            cmbCategory.Items.Add("Other");
            cmbCategory.SelectedIndex = 0;
        }

        private void InitializeGender()
        {
            // Clear any existing items and populate gender dropdown
            cmbGender.Items.Clear();
            cmbGender.Items.Add("-- Select Gender --"); // Placeholder option
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Non-binary");
            cmbGender.Items.Add("Prefer to self-describe");
            cmbGender.Items.Add("Prefer not to say");

            // Set the default selection to the placeholder
            cmbGender.SelectedIndex = 0;
        }

        // Attach File button
        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (attachmentCount >= MAX_ATTACHMENTS)
            {
                MessageBox.Show($"Maximum {MAX_ATTACHMENTS} attachments allowed.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif|Documents|*.pdf;*.doc;*.docx|All Files|*.*";
                openFileDialog.Multiselect = true;
                openFileDialog.Title = "Select files to attach";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        if (attachmentCount < MAX_ATTACHMENTS)
                        {
                            // Add only the file name to the list box
                            lstAttachments.Items.Add(Path.GetFileName(fileName));
                            attachmentCount++;
                        }
                        else
                        {
                            MessageBox.Show($"Only {MAX_ATTACHMENTS} attachments are allowed.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    }
                    UpdateEngagementMessage();
                }
            }
        }

        // Submit Report button - FIXED: Correct event handler connected
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate inputs - User MUST fill in these fields
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter a location. This field is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLocation.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Please provide a description of the issue. This field is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtbDescription.Focus();
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category. This field is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCategory.Focus();
                return;
            }

            // Validate Name (optional but good practice)
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter your name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            // Validate Surname (optional but good practice)
            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Please enter your surname.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSurname.Focus();
                return;
            }

            // Validate Gender
            if (cmbGender.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select your gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGender.Focus();
                return;
            }

            // Create new issue object
            ReportedIssue newIssue = new ReportedIssue
            {
                Name = txtName.Text.Trim(),
                Surname = txtSurname.Text.Trim(),
                Gender = cmbGender.SelectedItem.ToString(),
                Location = txtLocation.Text.Trim(),
                Category = cmbCategory.SelectedItem.ToString(),
                Description = rtbDescription.Text.Trim(),
                Attachments = new List<string>(lstAttachments.Items.Cast<string>()),
                ReportDate = DateTime.Now,
                Status = "Pending" // Added status tracking
            };

            // Add to collection
            reportedIssues.Add(newIssue);

            // Show success message
            MessageBox.Show($"Issue submitted successfully!\nReference: {DateTime.Now.Ticks.ToString().Substring(0, 8)}\nThank you for helping improve our community.",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset form
            ResetForm();
        }

        // Back to Main Menu button
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Show the main menu form and close this form
            if (MainMenu != null)
            {
                MainMenu.Show();
            }
            this.Close();
        }

        private void UpdateEngagementMessage()
        {
            // Dynamic engagement messages based on user progress
            string[] messages = {
                "Thank you for helping improve our community!",
                "Your report makes a difference!",
                "Together we can make our municipality better!",
                "Community participation leads to better services!",
                "Your voice matters in local governance!",
                "Every report helps build a better South Africa!",
                "Your engagement is valued and appreciated!"
            };

            // Update progress bar based on form completion
            int progress = 0;
            if (!string.IsNullOrWhiteSpace(txtLocation.Text)) progress += 20;
            if (!string.IsNullOrWhiteSpace(rtbDescription.Text)) progress += 20;
            if (cmbCategory.SelectedIndex >= 0) progress += 20;
            if (attachmentCount > 0) progress += 20;
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtSurname.Text)) progress += 20;

            progressBar1.Value = Math.Min(progress, 100); // Cap at 100%

            // Random encouraging message
            Random rnd = new Random();
            lblEngagementMessage.Text = messages[rnd.Next(messages.Length)];
        }

        private void ResetForm()
        {
            txtLocation.Clear();
            rtbDescription.Clear();
            cmbCategory.SelectedIndex = 0;
            txtName.Clear();
            txtSurname.Clear();
            cmbGender.SelectedIndex = 0;
            lstAttachments.Items.Clear();
            attachmentCount = 0;
            UpdateEngagementMessage();
            txtLocation.Focus();
        }

        // Event handlers for real-time engagement updates
        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            UpdateEngagementMessage();
        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            UpdateEngagementMessage();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEngagementMessage();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            UpdateEngagementMessage();
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            UpdateEngagementMessage();
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEngagementMessage();
        }

        private void lstAttachments_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEngagementMessage();
        }
    }

    // Data class for reported issues
    public class ReportedIssue
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<string> Attachments { get; set; }
        public DateTime ReportDate { get; set; }
        public string Status { get; set; } // Added for future use

        public ReportedIssue()
        {
            Attachments = new List<string>();
            Status = "Pending";
        }
    }
}