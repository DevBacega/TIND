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
    }
}
