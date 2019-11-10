using System;
using System.Data;
using System.Windows.Forms;

namespace tind4s
{
    public partial class frmProvaCadastro : Form
    {
        DataTable dt = new DataTable("Materia");
        public frmProvaCadastro()
        {
            InitializeComponent();
            Limpar();
            PreencherCurso();

        }

        public void Limpar()
        {
            txtProva.Text = string.Empty;
            cbCurso.SelectedItem = string.Empty;
            cbMateria.SelectedItem = string.Empty;
            CriarGrid();
        }

        public void PreencherCurso()
        {
            ClsCurso mObjCurso = new ClsCurso();
            mObjCurso.PreencheGrid();
            DataSet DSCurso = mObjCurso.DsCurso;
            cbCurso.DataSource = DSCurso.Tables[0];
            cbCurso.DisplayMember = "Nm_Curso";
            cbCurso.ValueMember = "Id_Curso";
            PreencherMateria();
        }

        public void PreencherMateria()
        {
            ClsProva mObjProva = new ClsProva()
            {
                Id_Curso = Convert.ToInt32(cbCurso.SelectedValue)
            };
            mObjProva.SelecionaCursoMateria();
            DataSet DSMateria = mObjProva.DSProva;
            cbMateria.DataSource = DSMateria.Tables[0];
            cbMateria.DisplayMember = "Nm_Materia";
            cbMateria.ValueMember = "Id_Materia";
        }

        private void CbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMateria.Text = string.Empty;
            PreencherMateria();
        }

        private void CriarGrid()
        {
            dt.Columns.Add("Id");

            dt.Columns.Add("Sigla");
            dt.Columns.Add("Qtd");
            dgvMateria.DataSource = dt;
            dgvMateria.Refresh();
            dgvMateria.Columns[0].Visible = false;
        }

        private void InserirMateria()
        {
            dt.Rows.Add(cbMateria.SelectedValue, cbMateria.Text, txtQtd.Text);
            dgvMateria.Refresh();
        }

        private void BtnInserirMateria_Click(object sender, EventArgs e)
        {
            InserirMateria();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            GerarProva();
        }

        private void GerarProva()
        {
            ClsProva mObjProva = new ClsProva()
            {
                Nm_Prova = txtProva.Text,
                Id_Prontuario = 1
            };
            int IdProva;
            mObjProva.Inserir();
            mObjProva.maxId();
            IdProva = mObjProva.Id_Prova;

            foreach(DataGridViewRow ROW in dgvMateria.Rows)
            {
                mObjProva.Qtd = Convert.ToInt32(ROW.Cells[2].Value);
                mObjProva.Id_Materia = Convert.ToInt32(ROW.Cells[0].Value);
                mObjProva.SelecionaQuestaoProva();
                DataSet TbTemp = mObjProva.DSProva;

                foreach(DataRow Line in TbTemp.Tables[0].Rows )
                {
                    mObjProva.Id_Questao = Convert.ToInt32(Line[0]);
                    mObjProva.Id_Prova = IdProva;
                    mObjProva.InserirQuestaoProva();
                }
            }
        }
    }
}
