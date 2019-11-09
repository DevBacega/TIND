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
    public partial class frmLoginn : Form
    {
        public frmLoginn()
        {
            InitializeComponent();
            //txtSenha.isPassword = true;
        }

        ClsProfessor professor = new ClsProfessor();
        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (professor.verificacao(txtUsuario.Text, txtSenha.Text) == true)
            {
                /*frmUsuario frm = new frmUsuario();
                this.Hide();
                frm.ShowDialog();*/
                frmMenu frm = new frmMenu();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário Inválido");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.Text = "";
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
        }
    }
}
