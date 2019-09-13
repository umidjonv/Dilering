using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes.DB;
namespace tposDesktop.SubForms.frontEnd
{
    public partial class FormPay : Classes.Forms.DesignedForm
    {
        public int contragId;
        public DataTable dataTable;
        RadioButton selectedRbt;
        int lastPverflow = 0;
        public FormPay(int contrId, int lastOverflowSum)
        {
            lastPverflow = lastOverflowSum;
            contragId = contrId;
            InitializeComponent();
            dataTable = new DataTable();
            string cmd = "SELECT expense.expenseDate, expense.debt, expense.expSum, expense.expenseId, expense.expType,  " +
                "(case when expense.expType = 1 then (select 'Возврат') else (Select 'Продажа') end) as exType " +
                " FROM expense WHERE expense.contragentId = " + contrId + " AND (expense.debt > 0 or (status=1 and expType=1))";
            using (MySql.Data.MySqlClient.MySqlConnection connect = new MySql.Data.MySqlClient.MySqlConnection(tposDesktop.Properties.Settings.Default.testConnectionString))
            {
                MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(cmd, connect);
                DataTable dt = new DataTable();
                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(command);
                adapter.Fill(dt);
                //dt = dataTable;
                dgvExp.DataSource = dt;
                dgvExp.Columns["expSum"].HeaderText = "Сумма";
                dgvExp.Columns["expenseDate"].HeaderText = "Дата";
                dgvExp.Columns["debt"].HeaderText = "Долг";
                dgvExp.Columns["expenseDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvExp.Columns["expenseId"].Visible = false;
                dgvExp.Columns["debt"].Width = 200;
                dgvExp.Columns["expSum"].Width = 200;
                dgvExp.Columns["expType"].Visible = false;
                dgvExp.Columns["exType"].HeaderText = "Тип";

                dataTable = dt;
            }
            rbtnCash.Checked = true;
            lblError.Visible = false;
        }
        public void pay(int expenseId, int transferId)
        {
            DataSetTpos.transferexpenseRow trexpRow = DBclass.DS.transferexpense.NewtransferexpenseRow();
            trexpRow.expenseId = expenseId;
            trexpRow.transferId = transferId;
            DBclass.DS.transferexpense.AddtransferexpenseRow(trexpRow);
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            string str = "";
            if (!string.IsNullOrEmpty(txbPay.Text))
            {
                if (rbtnCash.Checked ||
                    rbtnTerminal.Checked ||
                    rbtnTransfer.Checked)
                {
                    DataSetTpos.transferRow trRow = Classes.DB.DBclass.DS.transfer.NewtransferRow();

                    trRow.summ = Convert.ToInt32(txbPay.Text);
                    switch ((selectedRbt).Name)
                    {
                        case "rbtnCash":
                            trRow.transferType = 1;
                            break;
                        case "rbtnTerminal":
                            trRow.transferType = 2;
                            break;
                        case "rbtnTransfer":
                            trRow.transferType = 3;
                            break;
                    }
                    trRow.contragentId = contragId;
                    //trRow.comment = "Оплата за товары";
                    int sum = Convert.ToInt32(txbPay.Text) + lastPverflow;
                      

                    trRow.dataTransfer = DateTime.Now.Date;

                    Classes.DB.DBclass.DS.transfer.AddtransferRow(trRow);
                    DataSetTposTableAdapters.transferTableAdapter trTA = new DataSetTposTableAdapters.transferTableAdapter();
                    trTA.Update(Classes.DB.DBclass.DS.transfer);
                    trTA.Fill(Classes.DB.DBclass.DS.transfer);

                    DataSetTposTableAdapters.expenseTableAdapter expenseDa = new DataSetTposTableAdapters.expenseTableAdapter();
                    expenseDa.FillByContragent(DBclass.DS.expense, contragId);
                    DataSetTposTableAdapters.transferexpenseTableAdapter trexDa = new DataSetTposTableAdapters.transferexpenseTableAdapter();
                    int lastIndexTransfer = (int)trTA.GetLast();
                    foreach (DataRow row in dataTable.Select("expType = 1"))
                    {
                        sum += Convert.ToInt32(row["expSum"]);
                    }
                    foreach (DataRow row in dataTable.Rows)
                    {
                        DataSetTpos.expenseRow expRow = DBclass.DS.expense.FindByexpenseId(Convert.ToInt32(row["expenseId"]));


                        if (expRow.expType != 1)
                        {
                            int debt = Convert.ToInt32(row["debt"]);
                            int payedSum = 0;
                            if (sum > 0 && expRow != null)
                            {
                                if (debt <= sum)
                                {
                                    sum = sum - debt;
                                    payedSum = debt;

                                    debt = 0;
                                    expRow.status = 0;

                                }
                                else if (debt > sum)
                                {
                                    debt = debt - sum;
                                    payedSum = sum;
                                    sum = 0;

                                }
                                DataSetTpos.transferexpenseRow trexpRow = DBclass.DS.transferexpense.NewtransferexpenseRow();
                                trexpRow.expenseId = expRow.expenseId;
                                trexpRow.transferId = lastIndexTransfer;
                                DBclass.DS.transferexpense.AddtransferexpenseRow(trexpRow);


                            }

                            switch ((selectedRbt).Name)
                            {
                                case "rbtnCash":
                                    expRow.inCash += payedSum;
                                    break;
                                case "rbtnTerminal":
                                    expRow.terminal += payedSum;
                                    break;
                                case "rbtnTransfer":
                                    expRow.transfer += payedSum;
                                    break;
                            }
                            expRow.debt = debt;
                        }
                        else
                        {
                            //sum = sum + expRow.expSum;
                            expRow.status = 0;
                        }
                        expenseDa.Update(expRow);
                    }
                    trexDa.Update(DBclass.DS.transferexpense);
                    DataSetTpos.transferRow trRow1 = Classes.DB.DBclass.DS.transfer.Last<DataSetTpos.transferRow>();
                    if (sum > 0)
                    {
                        trRow1.overflow = sum;
                    }
                    else 
                    { trRow1.overflow = 0; }
                    trTA.Update(trRow1);
                }
                else
                {
                    lblError.Text = "Выберите вид оплаты!";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Введите сумму оплаты!";
                lblError.Visible = true;
            }
        }
        
        private void txbPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbt = sender as RadioButton;
            if (rbt.Checked)
            {
                selectedRbt = rbt;

            }

        }
    }
}
