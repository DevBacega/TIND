using System;
using System.Data;
using System.Windows.Forms;

namespace tind4s
{
    public partial class frmProvaCadastro : Form
    {
        DataTable dt = new DataTable("Materia");
        public int IdProva;
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
           if(ValidadorGrid())
            { 
              InserirMateria();
            }
           else
            {
                MessageBox.Show("Materia ja inserida!\nSelecione outra materia ou exclua da lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(Validador())
            { 
                if(GerarProva())
                { 
                    if (DialogResult.Yes == MessageBox.Show("Prova Gerada com Sucesso!\nGostaria de Imprimir a prova?", "Prova", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                    {
                        frmProva frmProva = new frmProva();
                        frmProva.ImprimirProva(IdProva);
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao Gerar a Prova!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campos Vazios, checar se contem Questoes no Formulario.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool GerarProva()
        {
            ClsProva mObjProva = new ClsProva()
            {
                Nm_Prova = txtProva.Text,
                Id_Prontuario = 1
            };

            try { 
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
                return true;
            }
            catch
            {
                mObjProva.Desativa();
                return false;
            }
            
        }

        private void BtnExcluirMateria_Click(object sender, EventArgs e)
        {
            int row = dgvMateria.CurrentCell.RowIndex;
            dgvMateria.Rows.RemoveAt(row);
            dgvMateria.Refresh();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private bool Validador()
        {
          return (String.IsNullOrWhiteSpace(txtProva.Text) || dgvMateria.Rows.Count <= 0) ?  false :  true;
        }

        private void Numerico(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) && txtQtd.Text.Length < 2);
        }

        public bool ValidadorGrid()
        {
            bool status = true;
            foreach(DataGridViewRow Linha in dgvMateria.Rows)
            {
                if(Convert.ToInt32(cbMateria.SelectedValue) == Convert.ToInt32(Linha.Cells[0].Value))
                {
                    status = false;
                }
            }
            return status;
        }
    }
}
