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
            PreencherDrop();
            CarregaGrid();
        }

        public void Limpar()
        {
            txtMateria.Text = string.Empty;
            txtSigla.Text = string.Empty;
            cbCurso.SelectedIndex = 0;
            aux = 1;
            lblIdMateria.Text = string.Empty;
        }

        public void PreencherDrop()
        {
            ClsCurso mObjCurso = new ClsCurso();
            mObjCurso.PreencheGrid();
            DataSet DSCurso = mObjCurso.DsCurso;
            cbCurso.DataSource = DSCurso.Tables[0];
            cbCurso.DisplayMember = "Nm_Curso";
            cbCurso.ValueMember = "Id_Curso";
        }

        private void CarregaGrid()
        {
            ClsMateria mObjMateria = new ClsMateria();
            mObjMateria.PreencheGrid();
            gridMateria.DataSource = mObjMateria.DSMateria;
            gridMateria.DataMember = mObjMateria.DSMateria.Tables[0].TableName;
            gridMateria.Columns[0].Visible = false;
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
                Id_Curso = Convert.ToInt32(cbCurso.SelectedValue)
            };

            if (aux == 1)
            {
                try
                {
                    mObjMateria.Inserir();
                    lblResultado.Text = "Cadastro feito com Sucesso";
                    CarregaGrid();
                }
                catch (Exception ex)
                {
                    lblResultado.Text = "Erro ao cadastrar";
                    MessageBox.Show("Erro: " + ex.ToString());
                }
            }
            else if (aux == 2)
            {
                try
                {
                    mObjMateria.Atualizar();
                    lblResultado.Text = "Materia Atualizada";
                    CarregaGrid();
                }
                catch (Exception ex)
                {
                    lblResultado.Text = "Erro ao Atualizar";
                    MessageBox.Show("Erro: " + ex.ToString());
                }
            }
            Limpar();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            //ClsProfessor mObjprofessor = new ClsProfessor()
            //{
            //    Id_Prontuario = Convert.ToInt32(lblId_Prontuario.Text)
            //};
            //DialogResult resultado = MessageBox.Show("Você tem certeza que deseja desativar esse Usuario?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //if (resultado == DialogResult.Yes)
            //{
            //    try
            //    {
            //        mObjprofessor.Desativa();
            //        lblResultado.Text = "Usuário Inativo com Sucesso";
            //        CarregaGrid();
            //        limpar();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Erro: " + ex.ToString());
            //        CarregaGrid();

            //    }
            //}
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Redimensionar(object sender, EventArgs e)
        {
            this.Size = this.Parent.Size;
        }
    }
}
