using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace qlpk
{
    public partial class frmlook_up_patient_list : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-1FK03R5\SQLEXPRESS;Initial Catalog=bv2;Integrated Security=True");
        public frmlook_up_patient_list()
        {
            InitializeComponent();
        }
        public void popularGrid()
        {
            Con.Open();
            string query = "select* from Patientinformation";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dsbenhnhan.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void TextboxFilter()
        {
            Con.Open();
            string query = "select* from Patientinformation where Customername= '" + Customername.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dsbenhnhan.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void frmlook_up_patient_list_Load(object sender, EventArgs e)
        {
            popularGrid();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            TextboxFilter();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            popularGrid();
        }
    }
}
