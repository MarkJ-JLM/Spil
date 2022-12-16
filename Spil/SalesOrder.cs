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
    public partial class SalesOrder : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.Demo2016ConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        ComboBox combo;
        decimal totalExcl;
        decimal totalTax;
        decimal totalIncl;
        public SalesOrder()
        {
            InitializeComponent();
        }

        private void SalesOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demo2016DataSet.StkItem' table. You can move, or remove it, as needed.
            this.stkItemTableAdapter.Fill(this.demo2016DataSet.StkItem);
            customerName.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Client";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                customerName.Items.Add(dr["Name"].ToString());
            }
            con.Close();
        }

        private void customerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from Client where Name = '" + customerName.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string Address1 = (string)dr["Physical1"].ToString();
                txtAddressOne.Text = Address1;

                string Address2 = (string)dr["Physical2"].ToString();
                txtAddressTwo.Text = Address2;

                string Address3 = (string)dr["Physical3"].ToString();
                txtAddressThree.Text = Address3;

                string Sub = (string)dr["Physical4"].ToString();
                txtSub.Text = Sub;

                string State = (string)dr["Physical5"].ToString();
                txtState.Text = State;

                string PostCode = (string)dr["PhysicalPC"].ToString();
                txtPostCode.Text = PostCode;
            }
            con.Close();
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            combo = e.Control as ComboBox;
            if(combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(combo_SelectedIndexChanged);

                combo.SelectedIndexChanged += combo_SelectedIndexChanged;
            }
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var description = (sender as ComboBox).SelectedValue;
            dataGridView1.CurrentRow.Cells[1].Value = description;
        }

        private void CalculationAmout(decimal qty,decimal price, decimal tax,int row)
        {
            decimal ExclAmount, TaxAmount, InclAmount;
            ExclAmount = qty * price;
            TaxAmount = ExclAmount * (tax / 100);
            InclAmount = ExclAmount + TaxAmount;

            var rows = dataGridView1.Rows[row];

            rows.Cells[6].Value = ExclAmount;
            rows.Cells[7].Value = TaxAmount;
            rows.Cells[8].Value = InclAmount;

        }

        private void CalculationTotal()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    totalExcl += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
                    totalTax += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);
                    totalIncl += Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value);
                }
                txtTotExcl.Text = totalExcl.ToString();
                txtTotTax.Text = totalTax.ToString();
                txtTotIncl.Text = totalIncl.ToString();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 ||
                           e.ColumnIndex == 4 ||
                           e.ColumnIndex == 5)
            {

                if (dataGridView1.Rows[e.RowIndex].Cells[3].Value != null
                    && dataGridView1.Rows[e.RowIndex].Cells[4].Value != null
                    )
                {

                    decimal tax = dataGridView1.CurrentRow.Cells[5].Value != null ? Convert.ToDecimal(dataGridView1.CurrentRow.Cells[5].Value) : 0;
                    CalculationAmout(Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value), Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value), tax, e.RowIndex);

                    CalculationTotal();
                }
            }
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customerName.Text))
            {
                MessageBox.Show("Enter Customer Name !!!");
                customerName.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtInvoiceNo.Text))
            {
                MessageBox.Show("Enter Invoice No !!!");
                txtInvoiceNo.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtInvoiceDate.Text))
            {
                MessageBox.Show("Enter Department !!!");
                txtInvoiceDate.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtReferenceNo.Text))
            {
                MessageBox.Show("Select Gender !!!");
                txtReferenceNo.Select();
            }
            else
            {
                try
                {
                    con.Open();
                    DataTable dtData = new DataTable();
                    cmd = new SqlCommand("spInsertMain", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InvoiceNo", txtInvoiceNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@InvoiceDate", txtInvoiceDate.Text.Trim());
                    cmd.Parameters.AddWithValue("@ReferenceNo", txtReferenceNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@Note", txtNote.Text);
                    cmd.Parameters.AddWithValue("@TotalExcel", txtTotExcl.Text);
                    cmd.Parameters.AddWithValue("@TotalTax", txtTotTax.Text);
                    cmd.Parameters.AddWithValue("@TotalIncl", txtTotIncl.Text);
                    cmd.Parameters.AddWithValue("@CustomerName", customerName.Text);
                    cmd.ExecuteNonQuery();
                   
                    int id = (int)cmd.ExecuteScalar();

                    if (dataGridView1.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand("spSalesOrder", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@HomeDet", dataGridView1.Rows[i].Cells[0].Value);
                            cmd.Parameters.AddWithValue("@ItemCod", dataGridView1.Rows[i].Cells[1].Value);
                            cmd.Parameters.AddWithValue("@Note", dataGridView1.Rows[i].Cells[2].Value);
                            cmd.Parameters.AddWithValue("@Quantity", dataGridView1.Rows[i].Cells[3].Value);
                            cmd.Parameters.AddWithValue("@Price", dataGridView1.Rows[i].Cells[4].Value);
                            cmd.Parameters.AddWithValue("@Tax", dataGridView1.Rows[i].Cells[5].Value);
                            cmd.Parameters.AddWithValue("@ExcelAmount", dataGridView1.Rows[i].Cells[6].Value);
                            cmd.Parameters.AddWithValue("@TaxAmount", dataGridView1.Rows[i].Cells[7].Value);
                            cmd.Parameters.AddWithValue("@InclAmount", dataGridView1.Rows[i].Cells[8].Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:- " + ex.Message);
                }
            }
        }
    
    }
}
