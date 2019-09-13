using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using Classes.DB;
using Classes.Forms;
namespace tposDesktop
{
    public partial class AddRealize : DesignedForm
    {
        float pack;

        public AddRealize(string barcode)
        {

            InitializeComponent();
            tbxPack.isFloat = true;
            tbxSoldPrice.isFloat = true;
            tbxPricePrixod.isFloat = true;
            if (barcode != null)
                tbxShtrix.Text = barcode;
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;

        }
        public AddRealize(DataSetTpos.productRow productRow, DataSetTpos.fakturaRow faktRow)
        {
            prRow = productRow;
            fkRow = faktRow;
            
            InitializeComponent();
            string sum  ="0";
            //tbxPack.isFloat = true;
            tbxSoldPrice.isFloat = true;
            tbxPricePrixod.isFloat = true;

            if (DBclass.DS.balanceview.Rows.Count>0)
            {
                DataRow[] blncs = DBclass.DS.balanceview.Select("prodId = " + prRow.productId);
                if (blncs.Length > 0)
                {
                    sum =  ((DataSetTpos.balanceviewRow) blncs[0]).endCount;
 
                }
            }

            lblAllCount.Text = sum;
            DataView dv = new DataView(DBclass.DS.provider);
            dv.RowFilter = "providerId = " + fkRow.providerId.ToString();
            providerLbl.Text = dv[0]["orgName"].ToString();
            tbxPack.isFloat = true;
            tbxName.Text = productRow.name;
            tbxPack.Text = 1.ToString();

            pack = productRow.pack;
            
            tbxPricePrixod.Text = "0";
            tbxShtrix.Text = productRow.barcode;
            //tbxSoldPrice.Text = productRow.price.ToString();

            DataSetTposTableAdapters.realizeviewTableAdapter rlvda = new DataSetTposTableAdapters.realizeviewTableAdapter();
            DataSetTpos.realizeviewDataTable tablerlv = new DataSetTpos.realizeviewDataTable();
            rlvda.FillByID(tablerlv, productRow.productId);
            tbxPricePrixod.Text = (tablerlv.Rows.Count > 0 ? (tablerlv.Rows[0] as DataSetTpos.realizeviewRow).fakturaPrice.ToString() : "0");


            if (productRow.barcode != null)
                tbxShtrix.Text = productRow.barcode;
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            if (productRow.pack == 0 || productRow.pack == 1)
            {
                tbxKol.Visible = false;
                lblKol.Visible = false;
            }


        }
        bool isEdit = false;
        public AddRealize(DataSetTpos.realizeRow rlzRow, DataSetTpos.realizeviewRow rlvRow, DataSetTpos.productRow productRow)
        {
            prRow = productRow;
            //prRow = productRow;
            //fkRow = faktRow;
            isEdit = true;
            InitializeComponent();
            string sum = "0";


            if (DBclass.DS.balanceview.Rows.Count > 0)
            {
                DataRow[] blncs = DBclass.DS.balanceview.Select("prodId = " + rlvRow.productId);
                if (blncs.Length > 0)
                {
                    sum = ((DataSetTpos.balanceviewRow)blncs[0]).endCount;

                }
            }
            btnAdd.Text = "Изменить";
            lblSoldPrice.Visible = true;
            tbxSoldPrice.Visible = true;
            lblAllCount.Text = sum;
            DataView dv = new DataView(DBclass.DS.provider);
            dv.RowFilter = "providerId = " + rlvRow.providerId.ToString();
            providerLbl.Text = dv[0]["orgName"].ToString();
            tbxPack.isFloat = true;
            tbxName.Text = rlvRow.name;
            tbxPack.Text = 1.ToString();
            if (rlvRow.count.Contains('/'))
                pack = float.Parse(rlvRow.count.Split(new char[] { '/' })[0]);
            else
            pack = float.Parse(rlvRow.count);

            tbxPricePrixod.Text = rlzRow.price.ToString();
            tbxShtrix.Text = rlvRow.barcode;
            tbxSoldPrice.Text = rlzRow.soldPrice.ToString();
            //tbxSoldPrice.Text = productRow.price.ToString();

            DataSetTposTableAdapters.realizeviewTableAdapter rlvda = new DataSetTposTableAdapters.realizeviewTableAdapter();
            DataSetTpos.realizeviewDataTable tablerlv = new DataSetTpos.realizeviewDataTable();
            rlvda.FillByID(tablerlv, rlvRow.productId);
            tbxPricePrixod.Text = (tablerlv.Rows.Count > 0 ? (tablerlv.Rows[0] as DataSetTpos.realizeviewRow).fakturaPrice.ToString() : "0");


            if (rlvRow.barcode != null)
                tbxShtrix.Text = rlvRow.barcode;
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            
            tbxKol.Text= rlzRow.count.ToString();

            tbxPack.Enabled = false;
            tbxPricePrixod.Enabled = false;
            
            rlviewRow = rlvRow;
            rlRow = rlzRow;
        }


        DataSetTpos.productRow prRow;
        DataSetTpos.fakturaRow fkRow;
        DataSetTpos.realizeRow rlRow;
        DataSetTpos.realizeviewRow rlviewRow;
        private void AddOrEdit(object sender, EventArgs e)
        {
            DataSetTposTableAdapters.realizeTableAdapter daReal = new DataSetTposTableAdapters.realizeTableAdapter();
            DataSetTposTableAdapters.realizeviewTableAdapter daRealV = new DataSetTposTableAdapters.realizeviewTableAdapter();
            if (!isEdit)
            {

                if (!string.IsNullOrEmpty(tbxName.Text))
                {

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;

                    DBclass db = new DBclass();
                    DataSetTpos.realizeRow[] rlRows = (DataSetTpos.realizeRow[])DBclass.DS.realize.Select("prodid = " + prRow.productId + " and fakturaId = " + fkRow.fakturaId);
                    DataSetTpos.realizeRow rlRow;
                    if (rlRows.Length > 0)
                    {
                        float cnt;
                        rlRow = rlRows[0];
                        if (pack != 0)
                        {
                            cnt = Convert.ToInt32(tbxPack.Text) * pack + Convert.ToInt32(tbxKol.Text);
                        }
                        else
                        {
                            System.Globalization.NumberFormatInfo format = new System.Globalization.NumberFormatInfo();
                            cnt = Convert.ToSingle(tbxPack.Text.Replace(",", format.CurrencyDecimalSeparator).Replace(".", format.CurrencyDecimalSeparator), format);
                        }
                        rlRow.count += cnt;
                        rlRow.price = Convert.ToSingle(tbxPricePrixod.Text);
                        rlRow.soldPrice = 0;

                        //db.triggerExecute()
                        db.calcProc("plus", prRow.productId, cnt);

                    }
                    else
                    {
                        float cnt;
                        rlRow = DBclass.DS.realize.NewrealizeRow();
                        if (pack != 0)
                        {
                            cnt = Convert.ToInt32(Math.Round(Convert.ToDouble(tbxPack.Text) * pack, 2) + Convert.ToInt32(tbxKol.Text));
                        }
                        else
                        {
                            System.Globalization.NumberFormatInfo format = new System.Globalization.NumberFormatInfo();
                            cnt = Convert.ToSingle(tbxPack.Text.Replace(",", format.CurrencyDecimalSeparator).Replace(".", format.CurrencyDecimalSeparator), format);
                        }
                        rlRow.count = cnt;
                        rlRow.price = Convert.ToSingle(tbxPricePrixod.Text);
                        rlRow.soldPrice = 0;
                        rlRow.fakturaId = fkRow.fakturaId;
                        rlRow.prodId = prRow.productId;
                        DBclass.DS.realize.AddrealizeRow(rlRow);
                        db.calcProc("plus", prRow.productId, cnt);

                    }
                    //if(prRow.price==0)



                    daReal.Update(DBclass.DS.realize);
                    daReal.Fill(DBclass.DS.realize);
                    
                }
            }
            else 
            {
                rlRow.soldPrice = float.Parse(tbxSoldPrice.Text);
                if(UserValues.role=="admin")prRow.price = rlRow.soldPrice;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                daReal.Update(rlRow);
                daReal.Fill(DBclass.DS.realize);

                
                //daRealV.Update(rlviewRow);
                daRealV.FillByFaktura(DBclass.DS.realizeview, rlviewRow.fakturaId);
            }
        }

        private void AddRealize_Load(object sender, EventArgs e)
        {
            tbxPack.Focus();
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {

            //printForm pr = new printForm(tbxName.Text, tbxSoldPrice.Text, tbxShtrix.Text);
            //pr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //if (tbxName.Text == "")
            //{
            //    MessageBox.Show("Не указано название товара или цена");
            //}
            //else
            //{
            //    AddForm adF = new AddForm(prRow);
                
            //    adF.forPrinting(prRow.productId.ToString(), tbxName.Text, tbxSoldPrice.Text, prRow.productId.ToString());


            //}
        }

        private void tbxPercent_TextChanged(object sender, EventArgs e)
        {
            //if (tbxPercent.Text != "" && tbxPricePrixod.Text!="")
            //{
            //    double priceF = double.Parse(tbxPricePrixod.Text);
            //    double percent = double.Parse(tbxPercent.Text);
            //    double itog = (priceF != 0 ? priceF / 100 * percent : 0);
            //    lblPricePercent.Text = ((int)(priceF + itog)).ToString();
            //}
        }

        private void tbxSoldPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AddOrEdit(btnAdd, new EventArgs());
            }
        }


    }
}
