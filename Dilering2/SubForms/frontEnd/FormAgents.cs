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
    public partial class FormAgents : Classes.Forms.DesignedForm
    {
        public FormAgents()
        {
            InitializeComponent();
            this.agentsTableAdapter1.Fill(Classes.DB.DBclass.DS.agents);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            DataSetTpos.agentsRow agRow = Classes.DB.DBclass.DS.agents.NewagentsRow();
            frontEnd.FormChangeAgents agentsForm = new FormChangeAgents(agRow, false);
            if (agentsForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Classes.DB.DBclass.DS.agents.AddagentsRow(agRow);
                DataSetTposTableAdapters.agentsTableAdapter ata = new DataSetTposTableAdapters.agentsTableAdapter();
                ata.Update(Classes.DB.DBclass.DS.agents);
                ata.Fill(Classes.DB.DBclass.DS.agents);
            }
        }

        private void FormAgents_Load(object sender, EventArgs e)
        {
            refBtn();
            DataGridViewButtonColumn dgvBtnDel = new DataGridViewButtonColumn();
            dgvBtnDel.HeaderText = "";
            dgvBtnDel.Name = "btnDelAg";
            dgvBtnDel.Width = 70;
            dgvAgents.Columns.Add(dgvBtnDel);
        }

        public void refBtn()
        {
            DataSetTposTableAdapters.agentsTableAdapter ata = new DataSetTposTableAdapters.agentsTableAdapter();
            ata.Fill(Classes.DB.DBclass.DS.agents);
            dgvAgents.DataSource = new DataView(Classes.DB.DBclass.DS.agents);
            dgvAgents.Columns["ID"].Visible = false;
            dgvAgents.Columns["Name"].HeaderText = "Имя агента";
            dgvAgents.Columns["Telephone"].HeaderText = "Телефон агента";
            dgvAgents.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAgents.Columns["Telephone"].Width = 200;
        }

        private void dgvAgents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int Id = (int)dgvAgents.Rows[e.RowIndex].Cells["ID"].Value;
                DataSetTpos.agentsRow agRow = Classes.DB.DBclass.DS.agents.Single<DataSetTpos.agentsRow>(crId => crId.ID == Id);
                SubForms.frontEnd.FormChangeAgents fcha = new FormChangeAgents(agRow, true);
                if (fcha.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DataSetTposTableAdapters.agentsTableAdapter ata = new DataSetTposTableAdapters.agentsTableAdapter();
                    ata.Update(Classes.DB.DBclass.DS.agents);
                    ata.Fill(Classes.DB.DBclass.DS.agents);
                }
            }
        }

        private void dgvAgents_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewButtonCell dgvCell = (DataGridViewButtonCell)grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                switch (grid.Columns[e.ColumnIndex].Name)
                {
                    case "btnDelAg":
                        dgvCell.Value = "X";
                        break;
                }
            }
        }

        private void dgvAgents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                DataRow[] dr = Classes.DB.DBclass.DS.agents.Select("ID = " + dgv.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                if (dgv.Columns[e.ColumnIndex].Name == "btnDelAg")
                {
                    if (MessageBox.Show("Удалить пользователя?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        dr[0].Delete();
                        this.agentsTableAdapter1.Update(Classes.DB.DBclass.DS.agents);
                        this.agentsTableAdapter1.Fill(Classes.DB.DBclass.DS.agents);
                    }
                }
            }
        }
    }
}
