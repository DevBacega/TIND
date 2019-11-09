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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            //txtSenha.isPassword = true;
        }

        
        private void btnLogar_Click(object sender, EventArgs e)
        {
            ClsProfessor professor = new ClsProfessor()
            {
                Ds_Usuario = txtUsuario.Text,
                Ds_Senha = txtSenha.Text
            };
            if (professor.Login() == true)
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
