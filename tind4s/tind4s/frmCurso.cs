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
            gridCurso.AllowUserToAddRows = false;
            gridCurso.AllowUserToDeleteRows = false;
            gridCurso.ReadOnly = true;
            lblId_Curso.Visible = false;
            lblResultado.Visible = false;
        }
        int aux = 1;

        public void limpar()
        {
            txtCurso.Text = string.Empty;
            txtAbrev.Text = string.Empty;
        }

        private void CarregaGrid()
        {
            ClsCurso mObjCurso = new ClsCurso();
            mObjCurso.PreencheGrid();
            gridCurso.DataSource = mObjCurso.DsCurso;
            gridCurso.DataMember = mObjCurso.DsCurso.Tables[0].TableName;
            gridCurso.Refresh();
        }

        private void frmCurso_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            aux = 1;
            limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ClsCurso mObjCurso = new ClsCurso()
            {
                Id_Curso = Convert.ToInt32(0 + lblId_Curso.Text),
                Nm_Curso = txtCurso.Text,
                Abrev_Nm_Curso = txtAbrev.Text
            };

            if (aux == 1)
            {
 
            }
            else if (aux == 2)
            {
 
            }

        }

    }
}
