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
namespace tposDesktop
{
    public partial class PriceForm : DesignedForm
    {
        public PriceForm()
        {
            InitializeComponent();
            tbxNal.Text = Configs.GetConfig("CashCharge");
            tbxTerminal.Text = Configs.GetConfig("TerminalCharge");
            tbxPerevod.Text = Configs.GetConfig("TransferCharge");
            tbxDrugoy.Text = Configs.GetConfig("OtherCharge");
            
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Configs cfgs = new Configs();
            try
            {
                int nal = Convert.ToInt32(tbxNal.Text);
                int terminal = Convert.ToInt32(tbxTerminal.Text);
                int perevod = Convert.ToInt32(tbxPerevod.Text);
                int drugoy = Convert.ToInt32(tbxDrugoy.Text);
                Configs.SetConfig("CashCharge", nal.ToString());
                Configs.SetConfig("TerminalCharge", terminal.ToString());
                Configs.SetConfig("TransferCharge", perevod.ToString());
                Configs.SetConfig("OtherCharge", drugoy.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
            

        }
    }
}
