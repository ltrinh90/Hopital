
namespace qlpk
{
    partial class frmlook_up_patient_list
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
            this.label1 = new System.Windows.Forms.Label();
            this.dsbenhnhan = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Customername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsbenhnhan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter keywords";
            // 
            // dsbenhnhan
            // 
            this.dsbenhnhan.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dsbenhnhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsbenhnhan.Location = new System.Drawing.Point(44, 319);
            this.dsbenhnhan.Name = "dsbenhnhan";
            this.dsbenhnhan.RowHeadersWidth = 51;
            this.dsbenhnhan.RowTemplate.Height = 24;
            this.dsbenhnhan.Size = new System.Drawing.Size(869, 347);
            this.dsbenhnhan.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = " Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "MANAGER CLINIC MANAGEMENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Email";
            // 
            // Customername
            // 
            this.Customername.Location = new System.Drawing.Point(299, 227);
            this.Customername.Multiline = true;
            this.Customername.Name = "Customername";
            this.Customername.Size = new System.Drawing.Size(269, 44);
            this.Customername.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 35);
            this.label6.TabIndex = 16;
            this.label6.Text = "LOOK UP PATIENT LIST";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(407, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 30);
            this.label7.TabIndex = 17;
            this.label7.Text = "  Website: ";
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(644, 227);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 50);
            this.SearchBtn.TabIndex = 18;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshBtn.Location = new System.Drawing.Point(764, 227);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 50);
            this.RefreshBtn.TabIndex = 19;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // frmlook_up_patient_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 690);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Customername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dsbenhnhan);
            this.Controls.Add(this.label1);
            this.Name = "frmlook_up_patient_list";
            this.Text = "frmlook_up_patient_list";
            this.Load += new System.EventHandler(this.frmlook_up_patient_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsbenhnhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dsbenhnhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Customername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button RefreshBtn;
    }
}