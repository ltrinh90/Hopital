
namespace qlpk
{
    partial class Doctorqt
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctorqt));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lookUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAPrecescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAppointmentScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prepareMedicalRecordsForPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lookUpToolStripMenuItem,
            this.makeToolStripMenuItem,
            this.makeAPrecescriptionToolStripMenuItem,
            this.updateAppointmentScheduleToolStripMenuItem,
            this.prepareMedicalRecordsForPatientsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lookUpToolStripMenuItem
            // 
            this.lookUpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientListToolStripMenuItem,
            this.patientInformationToolStripMenuItem});
            this.lookUpToolStripMenuItem.Name = "lookUpToolStripMenuItem";
            this.lookUpToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.lookUpToolStripMenuItem.Text = "Look up";
            // 
            // patientListToolStripMenuItem
            // 
            this.patientListToolStripMenuItem.Name = "patientListToolStripMenuItem";
            this.patientListToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.patientListToolStripMenuItem.Text = "Patient list";
            this.patientListToolStripMenuItem.Click += new System.EventHandler(this.patientListToolStripMenuItem_Click);
            // 
            // patientInformationToolStripMenuItem
            // 
            this.patientInformationToolStripMenuItem.Name = "patientInformationToolStripMenuItem";
            this.patientInformationToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.patientInformationToolStripMenuItem.Text = "Patient information";
            this.patientInformationToolStripMenuItem.Click += new System.EventHandler(this.patientInformationToolStripMenuItem_Click);
            // 
            // makeToolStripMenuItem
            // 
            this.makeToolStripMenuItem.Name = "makeToolStripMenuItem";
            this.makeToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.makeToolStripMenuItem.Text = "Make a lits of diagnoses";
            this.makeToolStripMenuItem.Click += new System.EventHandler(this.makeToolStripMenuItem_Click);
            // 
            // makeAPrecescriptionToolStripMenuItem
            // 
            this.makeAPrecescriptionToolStripMenuItem.Name = "makeAPrecescriptionToolStripMenuItem";
            this.makeAPrecescriptionToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.makeAPrecescriptionToolStripMenuItem.Text = "Make a precescription";
            this.makeAPrecescriptionToolStripMenuItem.Click += new System.EventHandler(this.makeAPrecescriptionToolStripMenuItem_Click);
            // 
            // updateAppointmentScheduleToolStripMenuItem
            // 
            this.updateAppointmentScheduleToolStripMenuItem.Name = "updateAppointmentScheduleToolStripMenuItem";
            this.updateAppointmentScheduleToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.updateAppointmentScheduleToolStripMenuItem.Text = "Update appointment schedule";
            this.updateAppointmentScheduleToolStripMenuItem.Click += new System.EventHandler(this.updateAppointmentScheduleToolStripMenuItem_Click);
            // 
            // prepareMedicalRecordsForPatientsToolStripMenuItem
            // 
            this.prepareMedicalRecordsForPatientsToolStripMenuItem.Name = "prepareMedicalRecordsForPatientsToolStripMenuItem";
            this.prepareMedicalRecordsForPatientsToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.prepareMedicalRecordsForPatientsToolStripMenuItem.Text = "Prepare medical records for patients";
            this.prepareMedicalRecordsForPatientsToolStripMenuItem.Click += new System.EventHandler(this.prepareMedicalRecordsForPatientsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(985, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "DOCTOR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(137, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(787, 427);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Doctorqt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Doctorqt";
            this.Text = "Doctorqt";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lookUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAPrecescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAppointmentScheduleToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem prepareMedicalRecordsForPatientsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}