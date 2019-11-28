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
    public partial class frmCurso : Form
    {
        public frmCurso()
        {
            InitializeComponent();
            CarregaGrid();
            dgvCurso.AllowUserToAddRows = false;
            dgvCurso.AllowUserToDeleteRows = false;
            dgvCurso.ReadOnly = true;
            lblResultado.Visible = false;
            lblIdCurso.Visible = false;
        }
        int aux = 1;

        public void Limpar()
        {
            txtCurso.Text = string.Empty;
            txtAbrev.Text = string.Empty;
            lblId_Curso.Text = string.Empty;
        }

        private void CarregaGrid()
        {
            ClsCurso mObjCurso = new ClsCurso();
            mObjCurso.PreencheGrid();
            dgvCurso.DataSource = mObjCurso.DsCurso;
            dgvCurso.DataMember = mObjCurso.DsCurso.Tables[0].TableName;
            dgvCurso.Columns[0].Visible = false;
            dgvCurso.Refresh();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            aux = 1;
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(Validador())
            { 
                ClsCurso mObjCurso = new ClsCurso()
                {
                    Id_Curso = Convert.ToInt32(0 + lblId_Curso.Text),
                    Nm_Curso = txtCurso.Text,
                    Abrev_Nm_Curso = txtAbrev.Text
                };

                if (aux == 1)
                {
                    try
                    {
                        mObjCurso.Inserir();
                        lblResultado.Text = "Curso Inserido com Sucesso!";
                        CarregaGrid();
                    }
                    catch(Exception ex)
                    {
                        lblResultado.Text = "Erro ao Inserir Curso";
                        MessageBox.Show("Erro: " + ex.ToString());
                    }
                }
                else if (aux == 2)
                {
                    try
                    {
                        mObjCurso.Atualizar();
                        lblResultado.Text = "Curso Atualuzado com Sucesso!";
                        CarregaGrid();
                    }
                    catch
                    {
                        MessageBox.Show("Errou Ao atualizar!");
                    }
                
                }
                Limpar();
            }
            else
            {
                MessageBox.Show("Campos Vazios!\nPreencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ClsCurso mObjCurso = new ClsCurso()
            {
                Id_Curso = Convert.ToInt32(0 + lblId_Curso.Text)
            };
            DialogResult resultado = MessageBox.Show("Você tem certeza que deseja desativar esse Curso?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    mObjCurso.Desativa();
                    lblResultado.Text = "Usuário Inativo com Sucesso";
                    CarregaGrid();
                    Limpar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                    CarregaGrid();

                }
            }
        }

        private void gridCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aux = 2;
            lblId_Curso.Text = dgvCurso.CurrentRow.Cells[0].Value.ToString();
            txtCurso.Text = dgvCurso.CurrentRow.Cells[1].Value.ToString();
            txtCurso.Refresh();
            txtAbrev.Text = dgvCurso.CurrentRow.Cells[2].Value.ToString();
            txtAbrev.Refresh();
        }

        private void SelecionarCurso(object sender, DataGridViewCellEventArgs e)
        {
            aux = 2;
            lblIdCurso.Text = dgvCurso.CurrentRow.Cells[0].Value.ToString();
            txtCurso.Text = dgvCurso.CurrentRow.Cells[1].Value.ToString();
            txtAbrev.Text = dgvCurso.CurrentRow.Cells[2].Value.ToString();
        }

        private bool Validador()
        {
            return (String.IsNullOrWhiteSpace(txtAbrev.Text) || String.IsNullOrWhiteSpace(txtCurso.Text) ? false : true);
        }

        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
            
            if (DialogResult.Yes == MessageBox.Show("Quer mesmo Excluir esse Curso?\nProcesso nao reversivel!","Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                ClsCurso mObjCurso = new ClsCurso
                {
                    Id_Curso = Convert.ToInt32(dgvCurso.CurrentRow.Cells[0].Value)
                };
                mObjCurso.Desativa();
                CarregaGrid();
            }
            Limpar();
        }
    }
}
