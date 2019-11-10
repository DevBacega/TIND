using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace tind4s
{
    public partial class frmQuestao : Form
    {
        public frmQuestao()
        {
            InitializeComponent();
            PreencherCurso();
            lblId_Questao.Visible = true;
            lblId_Alternativa1.Visible = false;
            lblId_Alternativa1.Text = string.Empty;
            lblId_Alternativa2.Visible = false;
            lblId_Alternativa2.Text = string.Empty;
            lblId_Alternativa3.Visible = false;
            lblId_Alternativa3.Text = string.Empty;
            lblId_Alternativa4.Visible = false;
            lblId_Alternativa4.Text = string.Empty;
            lblId_Alternativa5.Visible = false;
            lblId_Alternativa5.Text = string.Empty;
        }
        public int aux = 1;

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1.Checked == true)
            {
                chk2.Checked = false;
                chk3.Checked = false;
                chk4.Checked = false;
                chk5.Checked = false;
            }
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2.Checked == true)
            {
                chk1.Checked = false;
                chk3.Checked = false;
                chk4.Checked = false;
                chk5.Checked = false;
            }
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3.Checked == true)
            {
                chk2.Checked = false;
                chk1.Checked = false;
                chk4.Checked = false;
                chk5.Checked = false;
            }
        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4.Checked == true)
            {
                chk2.Checked = false;
                chk3.Checked = false;
                chk1.Checked = false;
                chk5.Checked = false;
            }
        }

        private void chk5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5.Checked == true)
            {
                chk2.Checked = false;
                chk3.Checked = false;
                chk4.Checked = false;
                chk1.Checked = false;
            }
        }

        public int maxID()
        {
            int codigo;
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand("sp_MAX_Questao", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

            try
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    codigo = Convert.ToInt32(dr["IDNOVO"].ToString());
                    return codigo;
                }
                else
                    return codigo = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
                return 0;
            }
            finally
            {
                conexao.desconectar();
            }

        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ClsQuestao mObjQuestao = new ClsQuestao()
            {
                Id_Questao = Convert.ToInt32(0 + lblId_Questao.Text),
                Id_Materia = Convert.ToInt32(cbMateria.SelectedValue),
                Ds_Pergunta = txtPergunta.Text,
                Ds_Justificativa = txtJustificativa.Text,
                Id_Prontuario = 1
            };
            ClsAlternativa mObjAlternativa = new ClsAlternativa();
            if (aux == 1)
            {
                mObjQuestao.Inserir();

                mObjAlternativa.Id_Questao = maxID();
                mObjAlternativa.St_Verificacao = Convert.ToInt32(chk1.CheckState);
                mObjAlternativa.Ds_Alternativa = txtAlternativa1.Text;
                mObjAlternativa.Inserir();

                mObjAlternativa.Id_Questao = maxID();
                mObjAlternativa.St_Verificacao = Convert.ToInt32(chk2.CheckState);
                mObjAlternativa.Ds_Alternativa = txtAlternativa2.Text;
                mObjAlternativa.Inserir();

                mObjAlternativa.Id_Questao = maxID();
                mObjAlternativa.St_Verificacao = Convert.ToInt32(chk3.CheckState);
                mObjAlternativa.Ds_Alternativa = txtAlternativa3.Text;
                mObjAlternativa.Inserir();

                mObjAlternativa.Id_Questao = maxID();
                mObjAlternativa.St_Verificacao = Convert.ToInt32(chk4.CheckState);
                mObjAlternativa.Ds_Alternativa = txtAlternativa4.Text;
                mObjAlternativa.Inserir();

                mObjAlternativa.Id_Questao = maxID();
                mObjAlternativa.St_Verificacao = Convert.ToInt32(chk5.CheckState);
                mObjAlternativa.Ds_Alternativa = txtAlternativa5.Text;
                mObjAlternativa.Inserir();

                MessageBox.Show("Inserido com sucesso!");
                this.Close();

            }
            else if (aux == 2)
            {
                mObjQuestao.Atualizar();

                mObjAlternativa.Id_Questao = Convert.ToInt32(0 + lblId_Questao.Text);
                mObjAlternativa.Id_Alternativas = Convert.ToInt32(0 + lblId_Alternativa1.Text);
                mObjAlternativa.St_Verificacao = Convert.ToInt32(chk1.CheckState);
                mObjAlternativa.Ds_Alternativa = txtAlternativa1.Text;
                mObjAlternativa.Atualizar();

                mObjAlternativa.Id_Questao = Convert.ToInt32(0 + lblId_Questao.Text);
                mObjAlternativa.Id_Alternativas = Convert.ToInt32(0 + lblId_Alternativa2.Text);
                mObjAlternativa.St_Verificacao = Convert.ToInt32(chk2.CheckState);
                mObjAlternativa.Ds_Alternativa = txtAlternativa2.Text;
                mObjAlternativa.Atualizar();

                mObjAlternativa.Id_Questao = Convert.ToInt32(0 + lblId_Questao.Text);
                mObjAlternativa.Id_Alternativas = Convert.ToInt32(0 + lblId_Alternativa3.Text);
                mObjAlternativa.St_Verificacao = Convert.ToInt32(chk3.CheckState);
                mObjAlternativa.Ds_Alternativa = txtAlternativa3.Text;
                mObjAlternativa.Atualizar();

                mObjAlternativa.Id_Questao = Convert.ToInt32(0 + lblId_Questao.Text);
                mObjAlternativa.Id_Alternativas = Convert.ToInt32(0 + lblId_Alternativa4.Text);
                mObjAlternativa.St_Verificacao = Convert.ToInt32(chk4.CheckState);
                mObjAlternativa.Ds_Alternativa = txtAlternativa4.Text;
                mObjAlternativa.Atualizar();

                mObjAlternativa.Id_Questao = Convert.ToInt32(0 + lblId_Questao.Text);
                mObjAlternativa.Id_Alternativas = Convert.ToInt32(0 + lblId_Alternativa5.Text);
                mObjAlternativa.St_Verificacao = Convert.ToInt32(chk5.CheckState);
                mObjAlternativa.Ds_Alternativa = txtAlternativa5.Text;
                mObjAlternativa.Atualizar();
                MessageBox.Show("Atualizado com sucesso!");
                this.Close();

            }
            lblId_Questao.Text = string.Empty;

        }

        public void PreencherCurso()
        {
            ClsCurso mObjCurso = new ClsCurso();
            mObjCurso.PreencheGrid();
            DataSet DSCurso = mObjCurso.DsCurso;
            cbCurso.DataSource = DSCurso.Tables[0];
            cbCurso.DisplayMember = "Abrev_Nm_Curso";
            cbCurso.ValueMember = "Id_Curso";
            PreencherMateria();
        }

        public void PreencherMateria()
        {
            ClsQuestao mObjQuestao = new ClsQuestao()
            {
                Id_Curso = Convert.ToInt32(cbCurso.SelectedValue)
            };
            mObjQuestao.SelecionaCursoMateria();
            DataSet DSMateria = mObjQuestao.DSQuestao;
            cbMateria.DataSource = DSMateria.Tables[0];
            cbMateria.DisplayMember = "Nm_Materia";
            cbMateria.ValueMember = "Id_Materia";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMateria.Text = string.Empty;
            PreencherMateria();
        }

        private void LblNmCurso_Click(object sender, EventArgs e)
        {

        }
    }



}
