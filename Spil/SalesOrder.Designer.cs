
namespace Spil
{
    partial class SalesOrder
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
            this.lblCN = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddressOne = new System.Windows.Forms.TextBox();
            this.txtAddressThree = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddressTwo = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInvoiceDate = new System.Windows.Forms.TextBox();
            this.txtReferenceNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.txtTotTax = new System.Windows.Forms.TextBox();
            this.txtTotIncl = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotExcl = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stkItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demo2016DataSet = new Spil.Demo2016DataSet();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExclAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InclAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stkItemTableAdapter = new Spil.Demo2016DataSetTableAdapters.StkItemTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stkItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demo2016DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCN
            // 
            this.lblCN.AutoSize = true;
            this.lblCN.Location = new System.Drawing.Point(12, 66);
            this.lblCN.Name = "lblCN";
            this.lblCN.Size = new System.Drawing.Size(82, 13);
            this.lblCN.TabIndex = 0;
            this.lblCN.Text = "Customer Name";
            // 
            // customerName
            // 
            this.customerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.customerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.customerName.FormattingEnabled = true;
            this.customerName.Location = new System.Drawing.Point(100, 58);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(174, 21);
            this.customerName.TabIndex = 1;
            this.customerName.SelectedIndexChanged += new System.EventHandler(this.customerName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Address 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address 2";
            // 
            // txtAddressOne
            // 
            this.txtAddressOne.Location = new System.Drawing.Point(100, 88);
            this.txtAddressOne.Name = "txtAddressOne";
            this.txtAddressOne.Size = new System.Drawing.Size(170, 20);
            this.txtAddressOne.TabIndex = 4;
            // 
            // txtAddressThree
            // 
            this.txtAddressThree.Location = new System.Drawing.Point(100, 145);
            this.txtAddressThree.Name = "txtAddressThree";
            this.txtAddressThree.Size = new System.Drawing.Size(170, 20);
            this.txtAddressThree.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address 3";
            // 
            // txtAddressTwo
            // 
            this.txtAddressTwo.Location = new System.Drawing.Point(100, 118);
            this.txtAddressTwo.Name = "txtAddressTwo";
            this.txtAddressTwo.Size = new System.Drawing.Size(170, 20);
            this.txtAddressTwo.TabIndex = 8;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(100, 202);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(170, 20);
            this.txtState.TabIndex = 14;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(100, 231);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(170, 20);
            this.txtPostCode.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Post Code";
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(100, 171);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(170, 20);
            this.txtSub.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sub";
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.Location = new System.Drawing.Point(758, 90);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.Size = new System.Drawing.Size(170, 20);
            this.txtInvoiceDate.TabIndex = 20;
            // 
            // txtReferenceNo
            // 
            this.txtReferenceNo.Location = new System.Drawing.Point(758, 119);
            this.txtReferenceNo.Name = "txtReferenceNo";
            this.txtReferenceNo.Size = new System.Drawing.Size(170, 20);
            this.txtReferenceNo.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(670, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Reference No";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(758, 59);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(170, 20);
            this.txtInvoiceNo.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(670, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Invoice Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(670, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Invoice No.";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(758, 145);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(170, 71);
            this.txtNote.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(670, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Note";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 44);
            this.panel1.TabIndex = 23;
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(12, 12);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(103, 26);
            this.btnSaveOrder.TabIndex = 0;
            this.btnSaveOrder.Text = "Save Order";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // txtTotTax
            // 
            this.txtTotTax.Location = new System.Drawing.Point(758, 475);
            this.txtTotTax.Name = "txtTotTax";
            this.txtTotTax.Size = new System.Drawing.Size(170, 20);
            this.txtTotTax.TabIndex = 29;
            // 
            // txtTotIncl
            // 
            this.txtTotIncl.Location = new System.Drawing.Point(758, 504);
            this.txtTotIncl.Name = "txtTotIncl";
            this.txtTotIncl.Size = new System.Drawing.Size(170, 20);
            this.txtTotIncl.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(670, 511);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Total Incl";
            // 
            // txtTotExcl
            // 
            this.txtTotExcl.Location = new System.Drawing.Point(758, 444);
            this.txtTotExcl.Name = "txtTotExcl";
            this.txtTotExcl.Size = new System.Drawing.Size(170, 20);
            this.txtTotExcl.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(670, 482);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Total Tax";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(670, 451);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Total Excl";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.Description,
            this.Note,
            this.Quantity,
            this.Price,
            this.Tax,
            this.ExclAmount,
            this.TaxAmount,
            this.InclAmount});
            this.dataGridView1.Location = new System.Drawing.Point(15, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 153);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // ItemCode
            // 
            this.ItemCode.DataSource = this.stkItemBindingSource;
            this.ItemCode.DisplayMember = "Code";
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ValueMember = "Description_1";
            // 
            // stkItemBindingSource
            // 
            this.stkItemBindingSource.DataMember = "StkItem";
            this.stkItemBindingSource.DataSource = this.demo2016DataSet;
            // 
            // demo2016DataSet
            // 
            this.demo2016DataSet.DataSetName = "Demo2016DataSet";
            this.demo2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Tax
            // 
            this.Tax.HeaderText = "Tax";
            this.Tax.Name = "Tax";
            // 
            // ExclAmount
            // 
            this.ExclAmount.HeaderText = "Excl Amount";
            this.ExclAmount.Name = "ExclAmount";
            // 
            // TaxAmount
            // 
            this.TaxAmount.HeaderText = "Tax Amount";
            this.TaxAmount.Name = "TaxAmount";
            // 
            // InclAmount
            // 
            this.InclAmount.HeaderText = "Incl Amount";
            this.InclAmount.Name = "InclAmount";
            // 
            // stkItemTableAdapter
            // 
            this.stkItemTableAdapter.ClearBeforeFill = true;
            // 
            // SalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 538);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTotTax);
            this.Controls.Add(this.txtTotIncl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotExcl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtInvoiceDate);
            this.Controls.Add(this.txtReferenceNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddressTwo);
            this.Controls.Add(this.txtAddressThree);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddressOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.lblCN);
            this.Name = "SalesOrder";
            this.Text = "SalesOrder";
            this.Load += new System.EventHandler(this.SalesOrder_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stkItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demo2016DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveOrder;
        public System.Windows.Forms.ComboBox customerName;
        public System.Windows.Forms.TextBox txtAddressOne;
        public System.Windows.Forms.TextBox txtAddressThree;
        public System.Windows.Forms.TextBox txtAddressTwo;
        public System.Windows.Forms.TextBox txtState;
        public System.Windows.Forms.TextBox txtPostCode;
        public System.Windows.Forms.TextBox txtSub;
        public System.Windows.Forms.TextBox txtInvoiceDate;
        public System.Windows.Forms.TextBox txtReferenceNo;
        public System.Windows.Forms.TextBox txtInvoiceNo;
        public System.Windows.Forms.TextBox txtNote;
        public System.Windows.Forms.TextBox txtTotTax;
        public System.Windows.Forms.TextBox txtTotIncl;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtTotExcl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Demo2016DataSet demo2016DataSet;
        private System.Windows.Forms.BindingSource stkItemBindingSource;
        private Demo2016DataSetTableAdapters.StkItemTableAdapter stkItemTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExclAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn InclAmount;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}