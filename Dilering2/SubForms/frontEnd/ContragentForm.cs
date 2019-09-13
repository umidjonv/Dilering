using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes.Forms;
using Classes;
using Classes.DB;
namespace tposDesktop
{
    public partial class ContragentForm : DesignedForm 
    {
        DataSetTpos.contragentRow contRow;
        bool isEdit = false;
        public ContragentForm(DataSetTpos.contragentRow contragentRow, bool is_Edit)
        {
            contRow = contragentRow;
            isEdit = is_Edit;
            InitializeComponent();
            if (isEdit)
            {
                tbxName.Text = contRow.name;
                tbxPerson.Text = contRow.person;
                tbxAddress.Text = contRow.address;
                tbxBankAccount.Text = contRow.bankAccount;
                tbxPhone.Text = contRow.phone;
                isEdit = true;
                btnOK.Text = "Изменить";
                //tbxName.Enabled = false;
            }
        }

        

        private void btnOK_Click(object sender, EventArgs e)
        {
           
            if (!isEdit)
            {
                //contRow = DBclass.DS.contragent.NewcontragentRow();
                contRow.name = tbxName.Text;
                contRow.person = tbxPerson.Text;
                contRow.address = tbxAddress.Text;
                contRow.bankAccount = tbxBankAccount.Text;
                contRow.phone = tbxPhone.Text;
 
            }
            else
            {
                contRow.name = tbxName.Text;
                contRow.person = tbxPerson.Text;
                contRow.address = tbxAddress.Text;
                contRow.bankAccount = tbxBankAccount.Text;
                contRow.phone = tbxPhone.Text;
            
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }



    }
}
