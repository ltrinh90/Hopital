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
    public partial class Pharmacistqt : Form
    {
        public Pharmacistqt()
        {
            InitializeComponent();
        }

        private void makeAListOfSoldDrugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_make_a_list_of_sold_drugs frm7 = new frm_make_a_list_of_sold_drugs();
            frm7.ShowDialog();
        }

        private void checkTheListOfSoldDrugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_check_the_list_of_sold_drugs frm8 = new frm_check_the_list_of_sold_drugs();
            frm8.ShowDialog();
        }
    }
}
