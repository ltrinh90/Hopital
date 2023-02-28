
namespace qlpk
{
    partial class Receptionistqt
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.makeAListOfCustomerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerOnTheAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerOnTheWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicalExaminationFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeAListOfCustomerInformationToolStripMenuItem,
            this.medicalExaminationFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1333, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // makeAListOfCustomerInformationToolStripMenuItem
            // 
            this.makeAListOfCustomerInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerOnTheAppToolStripMenuItem,
            this.registerOnTheWebToolStripMenuItem});
            this.makeAListOfCustomerInformationToolStripMenuItem.Name = "makeAListOfCustomerInformationToolStripMenuItem";
            this.makeAListOfCustomerInformationToolStripMenuItem.Size = new System.Drawing.Size(259, 24);
            this.makeAListOfCustomerInformationToolStripMenuItem.Text = "Make a list of customer information";
            // 
            // registerOnTheAppToolStripMenuItem
            // 
            this.registerOnTheAppToolStripMenuItem.Name = "registerOnTheAppToolStripMenuItem";
            this.registerOnTheAppToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registerOnTheAppToolStripMenuItem.Text = "Register on the app";
            // 
            // registerOnTheWebToolStripMenuItem
            // 
            this.registerOnTheWebToolStripMenuItem.Name = "registerOnTheWebToolStripMenuItem";
            this.registerOnTheWebToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registerOnTheWebToolStripMenuItem.Text = "Register on the web";
            // 
            // medicalExaminationFormToolStripMenuItem
            // 
            this.medicalExaminationFormToolStripMenuItem.Name = "medicalExaminationFormToolStripMenuItem";
            this.medicalExaminationFormToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.medicalExaminationFormToolStripMenuItem.Text = "Medical examination form";
            // 
            // Receptionistqt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 633);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Receptionistqt";
            this.Text = "Receptionistqt";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem makeAListOfCustomerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerOnTheAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerOnTheWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicalExaminationFormToolStripMenuItem;
    }
}