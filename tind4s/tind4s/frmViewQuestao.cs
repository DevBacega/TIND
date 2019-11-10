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
    public partial class frmViewQuestao : Form
    {
        public frmViewQuestao()
        {

            InitializeComponent();
            CarregaGrid();
            gridQuestao.AllowUserToAddRows = false;
            gridQuestao.AllowUserToDeleteRows = false;
            gridQuestao.ReadOnly = true;
        }

        private void CarregaGrid()
        {
            ClsQuestao mObjQuestao = new ClsQuestao();
            mObjQuestao.PreencheGrid();
            gridQuestao.DataSource = mObjQuestao.DSQuestao;
            gridQuestao.DataMember = mObjQuestao.DSQuestao.Tables[0].TableName;
            gridQuestao.Refresh();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmQuestao frm = new frmQuestao();
            frm.ShowDialog();
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ClsAlternativa mObjAlternativa = new ClsAlternativa()
            {
                Id_Questao = Convert.ToInt32(gridQuestao.CurrentRow.Cells[0].Value)
            };
            mObjAlternativa.Selecionar();

            DataSet Ds = new DataSet();
            Ds = mObjAlternativa.DSAlternariva;

            frmQuestao frm = new frmQuestao() 
            {
                aux = 2
            };

            frm.lblId_Questao.Text = gridQuestao.CurrentRow.Cells[0].Value.ToString();
            frm.txtPergunta.Text = gridQuestao.CurrentRow.Cells[1].Value.ToString();

            frm.lblId_Alternativa1.Text = Ds.Tables[0].Rows[0][0].ToString();
            frm.txtAlternativa1.Text = Ds.Tables[0].Rows[0]["Ds_Alternativa"].ToString();
            frm.chk1.Checked = Convert.ToBoolean(Ds.Tables[0].Rows[0]["St_Verificacao"]);

            frm.lblId_Alternativa2.Text = Ds.Tables[0].Rows[1][0].ToString();
            frm.txtAlternativa2.Text = Ds.Tables[0].Rows[1]["Ds_Alternativa"].ToString();
            frm.chk2.Checked = Convert.ToBoolean(Ds.Tables[0].Rows[1]["St_Verificacao"]);

            frm.lblId_Alternativa3.Text = Ds.Tables[0].Rows[2][0].ToString();
            frm.txtAlternativa3.Text = Ds.Tables[0].Rows[2]["Ds_Alternativa"].ToString();
            frm.chk3.Checked = Convert.ToBoolean(Ds.Tables[0].Rows[2]["St_Verificacao"]);

            frm.lblId_Alternativa4.Text = Ds.Tables[0].Rows[3][0].ToString();
            frm.txtAlternativa4.Text = Ds.Tables[0].Rows[3]["Ds_Alternativa"].ToString();
            frm.chk4.Checked = Convert.ToBoolean(Ds.Tables[0].Rows[3]["St_Verificacao"]);

            frm.lblId_Alternativa5.Text = Ds.Tables[0].Rows[4][0].ToString();
            frm.txtAlternativa5.Text = Ds.Tables[0].Rows[4]["Ds_Alternativa"].ToString();
            frm.chk5.Checked = Convert.ToBoolean(Ds.Tables[0].Rows[4]["St_Verificacao"]);

            frm.txtJustificativa.Text = gridQuestao.CurrentRow.Cells[2].Value.ToString();
                

            frm.Show();
        }




    }
}
