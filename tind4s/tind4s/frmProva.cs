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
    public partial class frmProva : Form
    {
        public frmProva()
        {
            InitializeComponent();
            CarregaGrid();
        }


        private void CarregaGrid()
        {
            ClsProva mObjProva = new ClsProva();
            mObjProva.PreencheGrid();
            dgvProva.DataSource = mObjProva.DSProva;
            dgvProva.DataMember = mObjProva.DSProva.Tables[0].TableName;
            dgvProva.Refresh();
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmProvaCadastro frm = new frmProvaCadastro();
            frm.ShowDialog();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            ClsProva mObjProva = new ClsProva()
            {
                Id_Prova = Convert.ToInt32(dgvProva.CurrentRow.Cells[0].Value)
            };

            DialogResult resultado = MessageBox.Show("Você tem certeza que deseja excluir essa Prova?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    mObjProva.Desativa();
                    CarregaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                    CarregaGrid();
                }
            }
        }
    }
}
