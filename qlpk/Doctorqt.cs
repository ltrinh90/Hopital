using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlpk
{
    public partial class Doctorqt : Form
    {
        public Doctorqt()
        {
            InitializeComponent();
        }

        private void patientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlook_up_patient_list frm = new frmlook_up_patient_list();
            frm.ShowDialog();
        }

        private void patientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlook_up_patient_information frm2 = new frmlook_up_patient_information();
            frm2.ShowDialog();
        }

        private void makeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Make_a_lits_of_diagnoses frm3 = new frm_Make_a_lits_of_diagnoses();
            frm3.ShowDialog();
        }

        private void makeAPrecescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Make_a_precescription frm4 = new frm_Make_a_precescription();
            frm4.ShowDialog();
        }

        private void updateAppointmentScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_appointment_schedule frm5 = new frm_Update_appointment_schedule();
            frm5.ShowDialog();
        }

        private void prepareMedicalRecordsForPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_prepare_medical_records_for_patients frm6 = new frm_prepare_medical_records_for_patients();
            frm6.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
