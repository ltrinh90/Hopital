
namespace qlpk
{
    partial class Pharmacistqt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacistqt));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.makeAListOfSoldDrugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkTheListOfSoldDrugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeAListOfSoldDrugsToolStripMenuItem,
            this.checkTheListOfSoldDrugsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // makeAListOfSoldDrugsToolStripMenuItem
            // 
            this.makeAListOfSoldDrugsToolStripMenuItem.Name = "makeAListOfSoldDrugsToolStripMenuItem";
            this.makeAListOfSoldDrugsToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.makeAListOfSoldDrugsToolStripMenuItem.Text = "Make a list of sold drugs";
            this.makeAListOfSoldDrugsToolStripMenuItem.Click += new System.EventHandler(this.makeAListOfSoldDrugsToolStripMenuItem_Click);
            // 
            // checkTheListOfSoldDrugsToolStripMenuItem
            // 
            this.checkTheListOfSoldDrugsToolStripMenuItem.Name = "checkTheListOfSoldDrugsToolStripMenuItem";
            this.checkTheListOfSoldDrugsToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.checkTheListOfSoldDrugsToolStripMenuItem.Text = "Check the list of sold drugs";
            this.checkTheListOfSoldDrugsToolStripMenuItem.Click += new System.EventHandler(this.checkTheListOfSoldDrugsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 373);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Pharmacistqt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pharmacistqt";
            this.Text = "Pharmacistqt";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem makeAListOfSoldDrugsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkTheListOfSoldDrugsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}