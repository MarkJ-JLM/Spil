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


namespace Spil
{
    public partial class frmHome : Form
    {

        SqlConnection con = new SqlConnection(Properties.Settings.Default.Demo2016ConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        SalesOrder f2 = new SalesOrder();
        string id;
        public frmHome()
        {
            InitializeComponent();

        }

        private void frmHome_Load(object sender, EventArgs e)
        {

            con.Open();
            da = new SqlDataAdapter("SELECT CustomerName,InvoiceNo,InvoiceDate,ReferenceNo,Note,TotalExcel,TotalTax,TotalIncl,Id FROM HomeDetails ORDER BY id DESC", con);
            con.Close();

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHome.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvHome_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            f2.customerName.Text = this.dgvHome.CurrentRow.Cells[0].Value.ToString();
            LoadAddress();

            f2.txtInvoiceNo.Text = this.dgvHome.CurrentRow.Cells[1].Value.ToString();
            f2.txtInvoiceDate.Text = this.dgvHome.CurrentRow.Cells[2].Value.ToString();
            f2.txtReferenceNo.Text = this.dgvHome.CurrentRow.Cells[3].Value.ToString();
            f2.txtNote.Text = this.dgvHome.CurrentRow.Cells[4].Value.ToString();
            f2.txtTotExcl.Text = this.dgvHome.CurrentRow.Cells[5].Value.ToString();
            f2.txtTotTax.Text = this.dgvHome.CurrentRow.Cells[6].Value.ToString();
            f2.txtTotIncl.Text = this.dgvHome.CurrentRow.Cells[7].Value.ToString();
            id = this.dgvHome.CurrentRow.Cells[8].Value.ToString();
            LoadGrid();
            f2.ShowDialog();
        }

        public void LoadAddress()
        {
            cmd = new SqlCommand("select * from Client where Name = '" + f2.customerName.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Address1 = (string)dr["Physical1"].ToString();
                f2.txtAddressOne.Text = Address1;

                string Address2 = (string)dr["Physical2"].ToString();
                f2.txtAddressTwo.Text = Address2;

                string Address3 = (string)dr["Physical3"].ToString();
                f2.txtAddressThree.Text = Address3;

                string Sub = (string)dr["Physical4"].ToString();
                f2.txtSub.Text = Sub;

                string State = (string)dr["Physical5"].ToString();
                f2.txtState.Text = State;

                string PostCode = (string)dr["PhysicalPC"].ToString();
                f2.txtPostCode.Text = PostCode;
            }
            con.Close();
        }

        public void LoadGrid()
        {
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM SalesOrder where Name = '" + id + "'", con);
            con.Close();

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            da.Fill(dt);
            f2.dataGridView1.DataSource = dt;
        }
    }
}
