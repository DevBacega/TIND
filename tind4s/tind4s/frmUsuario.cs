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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
            gridUsuario.AllowUserToAddRows = false;
            gridUsuario.AllowUserToDeleteRows = false;
            gridUsuario.ReadOnly = true;
            lblId_Prontuario.Visible = false;
            txtProfessor.Enabled = false;
            txtSenha.Enabled = false;
            txtUsuario.Enabled = false;
            lblInativo.Visible = false;
        }
        int aux;

        ClsProfessor mObjprofessor = new ClsProfessor();


        private void loadGrid()
        {
                CarregaGrid();
                gridUsuario.DataSource = mObjprofessor.DSUsuario.Tables[0];
                gridUsuario.ReadOnly = true;
                //gridUsuario.Columns[0].HeaderText = "Prontuario";
                //gridUsuario.Columns[1].HeaderText = "Nome";

                gridUsuario.AutoResizeColumns();

                gridUsuario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            aux = 1;
            txtProfessor.Enabled = true;
            txtSenha.Enabled = true;
            txtUsuario.Enabled = true;
            gridUsuario.Enabled = false;
            txtProfessor.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtUsuario.Text = string.Empty;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (aux == 1)
            {
                mObjprofessor.Nm_Usuario = txtProfessor.Text;
                mObjprofessor.Ds_Senha = txtSenha.Text;
                mObjprofessor.Ds_Usuario = txtUsuario.Text;

                if (mObjprofessor.InserirProfessor() == "true")
                {
                    lblResultado.Text = "Cadastro feito com Sucesso";
                    gridUsuario.Enabled = true;
                    this.tB_UsuarioTableAdapter.Fill(this.tind4sDataSet1.TB_Usuario);
                }
                else
                {
                    lblResultado.Text = "Erro ao cadastrar";
                    MessageBox.Show("Erro: " + mObjprofessor.InserirProfessor());
                }
            }
            else if (aux == 2)
            {
                mObjprofessor.Nm_Usuario = txtProfessor.Text;
                mObjprofessor.Ds_Senha = txtSenha.Text;
                mObjprofessor.Ds_Usuario = txtUsuario.Text;
                mObjprofessor.Id_Prontuario = Convert.ToInt32(lblId_Prontuario.Text);
                mObjprofessor.St_Usuario = 1;
                if (mObjprofessor.UpdateProfessor() == "true")
                {
                    lblResultado.Text = "Usuario Atualizado";
                    gridUsuario.Enabled = true;
                    this.tB_UsuarioTableAdapter.Fill(this.tind4sDataSet1.TB_Usuario);
                }
                else
                {
                    lblResultado.Text = "Erro ao Atualizar";
                    MessageBox.Show("Erro: " + mObjprofessor.UpdateProfessor());
                }
            }
            lblId_Prontuario.Text = string.Empty;
            txtProfessor.Enabled = false;
            txtSenha.Enabled = false;
            txtUsuario.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            aux = 2;
            txtProfessor.Enabled = true;
            txtSenha.Enabled = true;
            txtUsuario.Enabled = true;
            gridUsuario.Enabled = false;

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você tem certeza que deseja desativar esse Usuario?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                mObjprofessor.Nm_Usuario = txtProfessor.Text;
                mObjprofessor.Ds_Senha = txtSenha.Text;
                mObjprofessor.Ds_Usuario = txtUsuario.Text;
                mObjprofessor.Id_Prontuario = Convert.ToInt32(lblId_Prontuario.Text);
                mObjprofessor.St_Usuario = 0;

                if (mObjprofessor.AfastarProfessor() == "true")
                {
                    lblResultado.Text = "Usuário Inativo com Sucesso";
                    this.tB_UsuarioTableAdapter.Fill(this.tind4sDataSet1.TB_Usuario);
                }
                else
                {
                    MessageBox.Show("Erro: " + mObjprofessor.UpdateProfessor());
                    this.tB_UsuarioTableAdapter.Fill(this.tind4sDataSet1.TB_Usuario);
                    
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLoginn frm = new frmLoginn();
            this.Hide();
            frm.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblInativo.Visible = false;
            lblId_Prontuario.Text = gridUsuario.CurrentRow.Cells[0].Value.ToString();
            txtUsuario.Text = gridUsuario.CurrentRow.Cells[1].Value.ToString();
            txtUsuario.Refresh();
            txtSenha.Text = gridUsuario.CurrentRow.Cells[2].Value.ToString();
            txtProfessor.Refresh(); 
            txtProfessor.Text = gridUsuario.CurrentRow.Cells[3].Value.ToString();
            txtSenha.Refresh();
            if (gridUsuario.CurrentRow.Cells[4].Value.ToString() == "0")
            {
                lblInativo.Visible = true;
                lblInativo.Text = "Usuário Inativo";
            }
        }


        private void CarregaGrid()
        {
            mObjprofessor.Grid();
            gridUsuario.DataSource = mObjprofessor.DSUsuario;
            gridUsuario.DataMember = mObjprofessor.DSUsuario.Tables[0].TableName;
        }

    }
}
