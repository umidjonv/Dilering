using Classes.Forms;
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

namespace tposDesktop
{
    public partial class debtPaid : DesignedForm
    {
        public int paidSumm;
        public int chargedSumm;
        public bool terminal = false;
        public int charge = 0;
        public int agentID = 0;
        public debtPaid(int summ, bool roznica)
        {
            InitializeComponent();
            paidSumm = summ;
            tbxSum.Text = summ.ToString();
            if (roznica)
            {
                rbtPerevod.Visible = false;
                rbtOther.Visible = false;
            }
            //Вывод в ComboBox имен агентов
            string cmd = "SELECT * FROM agents";
            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(tposDesktop.Properties.Settings.Default.testConnectionString))
            {
                MySql.Data.MySqlClient.MySqlCommand com = new MySql.Data.MySqlClient.MySqlCommand(cmd, conn);
                DataTable dt = new DataTable();
                MySql.Data.MySqlClient.MySqlDataAdapter da = new MySql.Data.MySqlClient.MySqlDataAdapter(com);
                da.Fill(dt);
                cmbNameAg.DataSource = dt;
                cmbNameAg.DisplayMember = "Name";
                cmbNameAg.ValueMember = "ID";
                //cmbNameAg.SelectedIndex = -1;
            }
        }

        public debtPaid(int summ)
        {
            InitializeComponent();
            paidSumm = summ;
            tbxSum.Text = summ.ToString();
            
            //Вывод в ComboBox имен агентов
            string cmd = "SELECT * FROM agents";
            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(tposDesktop.Properties.Settings.Default.testConnectionString))
            {
                MySql.Data.MySqlClient.MySqlCommand com = new MySql.Data.MySqlClient.MySqlCommand(cmd, conn);
                DataTable dt = new DataTable();
                MySql.Data.MySqlClient.MySqlDataAdapter da = new MySql.Data.MySqlClient.MySqlDataAdapter(com);
                da.Fill(dt);
                cmbNameAg.DataSource = dt;
                cmbNameAg.DisplayMember = "Name";
                cmbNameAg.ValueMember = "ID";
                //cmbNameAg.SelectedIndex = -1;
            }
        }
        public int paidType = 0; //1 - terminal, 2 - perevod, 3 - drugiye
        private void btnOK_Click(object sender, EventArgs e)
        {
            paidSumm = Convert.ToInt32(tbxSum.Text);
            agentID = (int)cmbNameAg.SelectedValue;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void tbxSumma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOK_Click(null, null);
            }
        }

        private void rbt_checked(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                switch ((sender as RadioButton).Name)
                {
                    case "rbtNal":
                        charge = Convert.ToInt32(Configs.GetConfig("CashCharge"));

                        paidType = 0;
                        break;
                    case "rbtTerminal":
                        charge = Convert.ToInt32(Configs.GetConfig("TerminalCharge"));

                        paidType = 1;
                        break;
                    case "rbtPerevod":
                        charge = Convert.ToInt32(Configs.GetConfig("TransferCharge"));

                        paidType = 2;
                        break;
                    case "rbtOther":
                        charge = Convert.ToInt32(Configs.GetConfig("OtherCharge"));
                        paidType = 3;
                        break;
                }
                tbxChargeSum.Text = ((int)(paidSumm + ((double)paidSumm / 100 * (double)charge))).ToString();
            }
        }
        public string indexAg;
        public string nameAg;
        private void cmbNameAg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNameAg.SelectedText != "")
            {
                indexAg = cmbNameAg.SelectedValue.ToString();
                nameAg = cmbNameAg.SelectedText.ToString();
            }
        }
    }
}
