namespace MunicipalServicesApp
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.btnReportIssue = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReportIssue
            // 
            this.btnReportIssue.AccessibleName = "btnReportIssue";
            this.btnReportIssue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReportIssue.Location = new System.Drawing.Point(193, 114);
            this.btnReportIssue.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportIssue.Name = "btnReportIssue";
            this.btnReportIssue.Size = new System.Drawing.Size(313, 50);
            this.btnReportIssue.TabIndex = 0;
            this.btnReportIssue.Text = "Report Issues";
            this.btnReportIssue.UseVisualStyleBackColor = false;
            this.btnReportIssue.Click += new System.EventHandler(this.btnReportIssue_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.AccessibleName = "btnEvents";
            this.btnEvents.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEvents.Enabled = false;
            this.btnEvents.Location = new System.Drawing.Point(365, 181);
            this.btnEvents.Margin = new System.Windows.Forms.Padding(4);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(313, 48);
            this.btnEvents.TabIndex = 1;
            this.btnEvents.Text = "Local Events and Announcements (Disabled)";
            this.btnEvents.UseVisualStyleBackColor = false;
            this.btnEvents.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.AccessibleName = "btnStatus";
            this.btnStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStatus.Enabled = false;
            this.btnStatus.Location = new System.Drawing.Point(193, 247);
            this.btnStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(313, 48);
            this.btnStatus.TabIndex = 2;
            this.btnStatus.Text = "Service Request Status (Disabled)";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Municipal Management Services";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(717, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnReportIssue);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenuForm";
            this.Text = "Municipal Services";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReportIssue;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Label label1;
    }
}