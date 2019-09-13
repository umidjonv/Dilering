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
    public partial class FormChangeAgents : Classes.Forms.DesignedForm
    {
        DataSetTpos.agentsRow agRow;
        bool isEdit = false;
        public FormChangeAgents(DataSetTpos.agentsRow agentsRow, bool is_Edit)
        {
            agRow = agentsRow;
            isEdit = is_Edit;
            InitializeComponent();
            if (isEdit)
            {
                txbName.Text = agRow.Name;
                txbTelephone.Text = agRow.Telephone;
                isEdit = true;
                lblCaption.Text = "Изменение информации об агентах";
                btnChange.Text = "Изменить";
                txbName.Enabled = false;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                agRow.Name = txbName.Text;
                agRow.Telephone = txbTelephone.Text;
            }
            else
            {
                agRow.Telephone = txbTelephone.Text;

            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
