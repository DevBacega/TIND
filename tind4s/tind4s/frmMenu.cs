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
    public partial class frmMenu : Form
    {

        public frmMenu()
        {
            InitializeComponent();
            lblTitulo.Visible = false;

        }
        frmUsuario frmUser = new frmUsuario();

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if(pnlMenu.Width == 52)
            {
                pnlMenu.Width = 255;
                MenuConteudo.Width = 1064;
                frmUser.Width = 800;
                imgLogo.Visible = true;
            }
            else
            {
                pnlMenu.Width = 52;
                MenuConteudo.Width = 1000;
                frmUser.Width = 1000;
                imgLogo.Visible = false;
            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            EncerrarForm();
            frmUser.TopLevel = false;
            frmUser.AutoScroll = true;
            this.MenuConteudo.Controls.Add(frmUser);
            frmUser.Dock = DockStyle.Left;
            frmUser.Show();
            lblTitulo.Visible = true;
            lblTitulo.Text = "Controle de Usuários";
        }

        private void btnProva_Click(object sender, EventArgs e)
        {
            EncerrarForm();
            frmProvaCadastro frm = new frmProvaCadastro();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            this.MenuConteudo.Controls.Add(frm);
            frm.Dock = DockStyle.Left;
            frm.Show();
            lblTitulo.Visible = true;
            lblTitulo.Text = "Controle de Prova";
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            EncerrarForm();
            frmCurso frm = new frmCurso();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            this.MenuConteudo.Controls.Add(frm);
            frm.Dock = DockStyle.Left;
            frm.Show();
            lblTitulo.Visible = true;
            lblTitulo.Text = "Controle de Curso";
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            EncerrarForm();
            frmMateria frm = new frmMateria();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            this.MenuConteudo.Controls.Add(frm);
            frm.Dock = DockStyle.Left;
            frm.Show();
            lblTitulo.Visible = true;
            lblTitulo.Text = "Controle de Materia";
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Maximized)
            { 
                this.WindowState = FormWindowState.Maximized;
                
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        public void EncerrarForm()
        {
            this.MenuConteudo.Controls.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            EncerrarForm();
            frmViewQuestao frm = new frmViewQuestao();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            this.MenuConteudo.Controls.Add(frm);
            frm.Dock = DockStyle.Left;
            frm.Show();
            lblTitulo.Visible = true;
            lblTitulo.Text = "Controle de Questões";
        }
    }
}
