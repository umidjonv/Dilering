using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tposDesktop.SubForms.frontEnd
{
    public partial class FormDebt : Classes.Forms.DesignedForm
    {
        public FormDebt()
        {
            InitializeComponent();
        }

        private void FormDebt_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            string cmd = "select ex.contragentId, c.name, ctr.overflow as overflow, ex.debt, " +
                            "(case when expe.vozvrat is null then(select 0) else expe.vozvrat end) as vozvrat "+
                            
                            "from (select expense.contragentId, (sum(expense.debt)) as debt from expense group by expense.contragentId) as ex "+
                            "left join "+
                            "(select summ, overflow, contragentId from (select* from transfer "+
                            "order by transferId desc) as t group by contragentId) as ctr "+
                            "on ctr.contragentId = ex.contragentId "+
                            "left join contragent as c on ex.contragentId = c.contragentId "+
                            "left join   (select ex.contragentId, sum(ex.expSum) as vozvrat from expense as ex where ex.status = 1 and ex.expType = 1 group by ex.contragentId) as expe "+
                            "    on expe.contragentId = c.contragentId";
                //"select ex.contragentId, c.name, ex.debt, ctr.overflow" +
                //" from (select expense.contragentId, sum(expense.debt) as debt from expense group by expense.contragentId) as ex"+
                //            " left join"+
                //            " (select summ, overflow, contragentId from (select* from transfer"+
                //            " order by transferId desc) as t group by contragentId) as ctr"+
                //            " on ctr.contragentId = ex.contragentId"+
                //            " left join contragent as c on ex.contragentId = c.contragentId";


            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(tposDesktop.Properties.Settings.Default.testConnectionString))
            {
                MySql.Data.MySqlClient.MySqlCommand com = new MySql.Data.MySqlClient.MySqlCommand(cmd, conn);
                DataTable dt = new DataTable();
            
                MySql.Data.MySqlClient.MySqlDataAdapter da = new MySql.Data.MySqlClient.MySqlDataAdapter(com);
                da.Fill(dt);

                dgvDebt.DataSource = new DataView(dt);
                //dgvDebt.Columns["summ"].Visible = false;
                dgvDebt.Columns["contragentId"].HeaderText = "#";
                dgvDebt.Columns["name"].HeaderText = "Получатель";
                dgvDebt.Columns["vozvrat"].HeaderText = "Возврат";
                dgvDebt.Columns["overflow"].HeaderText = "На счету";
                dgvDebt.Columns["debt"].HeaderText = "Долг";
                dgvDebt.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvDebt.Columns["debt"].Width = 150;
                dgvDebt.Columns["vozvrat"].Width = 150;
                dgvDebt.Columns["overflow"].Width = 150;

            }
        }
        private void dgvDebt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int contrId = (int)(dgvDebt.Rows[e.RowIndex].Cells["contragentId"].Value!=DBNull.Value? dgvDebt.Rows[e.RowIndex].Cells["contragentId"].Value:0);

                int overflow = dgvDebt.Rows[e.RowIndex].Cells["overflow"].Value!=DBNull.Value? Convert.ToInt32(dgvDebt.Rows[e.RowIndex].Cells["overflow"].Value):0;
                FormPay fp = new FormPay(contrId, overflow);
                fp.ShowDialog();
                LoadGrid();
            }
        }

        private void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            if (tbxFilter.Text != "Поиск")
            {
                DataView dv = dgvDebt.DataSource as DataView;
                if (tbxFilter.Text.Length > 0)
                { dv.RowFilter = "name like '%" + tbxFilter.Text + "%'"; }
                else
                { dv.RowFilter = ""; }
            }
        }

        private void tbxFilter_Leave(object sender, EventArgs e)
        {
            if (tbxFilter.Text == "")
            {
                tbxFilter.Text = "Поиск";
                tbxFilter.ForeColor = Color.Silver;
            }

        }
        private void tbxFilter_Enter(object sender, EventArgs e)
        {
           
            if (tbxFilter.Text == "Поиск")
            {
                tbxFilter.Text = "";
                tbxFilter.ForeColor = Color.Black;

            }
        }

    }
}
