﻿using System;
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
            lblInativo.Visible = false;
            lblResultado.Visible = false;
        }
        int aux = 1;

        public void limpar()
        {
            txtProfessor.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            lblId_Prontuario.Text = string.Empty;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            aux = 1;
            limpar();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (Validador())
            {
                ClsProfessor mObjProfessor = new ClsProfessor()
                {
                    Nm_Usuario = txtProfessor.Text,
                    Ds_Senha = txtSenha.Text,
                    Ds_Usuario = txtUsuario.Text,
                    Id_Prontuario = Convert.ToInt32(0 + lblId_Prontuario.Text),
                    St_Usuario = 1
                };

                if (aux == 1)
                {
                    try
                    {
                        mObjProfessor.Inserir();
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
                        mObjProfessor.Atualizar();
                        lblResultado.Text = "Usuario Atualizado";
                        CarregaGrid();
                    }
                    catch (Exception ex)
                    {
                        lblResultado.Text = "Erro ao Atualizar";
                        MessageBox.Show("Erro: " + ex.ToString());
                    }
                }
                lblId_Prontuario.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Campos vazios!\nPor favor cheque todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ClsProfessor mObjprofessor = new ClsProfessor()
            {
                Id_Prontuario = Convert.ToInt32(lblId_Prontuario.Text)
            };
            DialogResult resultado = MessageBox.Show("Você tem certeza que deseja desativar esse Usuario?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    mObjprofessor.Desativa();
                    lblResultado.Text = "Usuário Inativo com Sucesso";
                    CarregaGrid();
                    limpar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                    CarregaGrid();

                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aux = 2;
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
            ClsProfessor mObjProfessor = new ClsProfessor();
            mObjProfessor.PreencheGrid();
            gridUsuario.DataSource = mObjProfessor.DSUsuario;
            gridUsuario.DataMember = mObjProfessor.DSUsuario.Tables[0].TableName;
            gridUsuario.Refresh();
        }
        private void Redimensionar(object sender, EventArgs e)
        {
            this.Size = this.Parent.Size;
        }

        private void Numerico(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar));
        }

        private void txtProfessor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (Char.IsNumber(e.KeyChar));
        }

        private bool Validador()
        {
            return (String.IsNullOrEmpty(txtProfessor.Text) || String.IsNullOrEmpty(txtSenha.Text) || String.IsNullOrEmpty(txtUsuario.Text)) ? false : true;
        }
    }
}
