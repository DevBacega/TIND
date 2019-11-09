using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tind4s
{
    public partial class frmMateria : Form
    {
        public frmMateria()
        {
            InitializeComponent();
            
        }
        int aux = 1;
        private void FrmMateria_Load(object sender, EventArgs e)
        {

        }

        public void Limpar()
        {
            txtMateria.Text = string.Empty;
            txtSigla.Text = string.Empty;
        }

        private void CarregaGrid()
        {
            ClsMateria mObjMateria = new ClsMateria();
            mObjMateria.PreencheGrid();
            gridMateria.DataSource = mObjMateria.DSMateria;
            gridMateria.DataMember = mObjMateria.DSMateria.Tables[0].TableName;
            gridMateria.Refresh();
            gridMateria.Columns[3].Visible = false;

        }

        private void SelecionaMateria(object sender, DataGridViewCellEventArgs e)
        {
            aux = 2;
            lblIdMateria.Text = gridMateria.CurrentRow.Cells[0].Value.ToString();
            txtSigla.Text = gridMateria.CurrentRow.Cells[1].Value.ToString();
            txtMateria.Text = gridMateria.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            ClsMateria mObjMateria = new ClsMateria
            {
                Id_Materia = Convert.ToInt32(0 + lblIdMateria.Text),
                Nm_Materia = txtMateria.Text,
                Sg_Materia = txtSigla.Text,
                Id_Curso = Convert.ToInt32(dropCurso.selectedValue)
                
            };
        }
    }
}
