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
using System.Data;

namespace tind4s
{
    public partial class frmQuestao : Form
    {
        public frmQuestao()
        {
            InitializeComponent();
            lblId_Questao.Visible = true;
            PreencherDrop();
        }

        public void PreencherDrop()
        {
            ClsMateria mObjMateria = new ClsMateria();
            mObjMateria.PreencheGrid();
            DataSet DSMateria = mObjMateria.DSMateria;
            cboxMateria.DataSource = DSMateria.Tables[0];
            cboxMateria.DisplayMember = "Nm_Curso";
            cboxMateria.ValueMember = "Id_Curso";
        }
        int aux = 1;

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
            int codigo = 0;
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
                Id_Materia = Convert.ToInt32(cboxMateria.SelectedValue),
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

            }
            else if (aux == 2)
            {
                mObjQuestao.Atualizar();

                mObjAlternativa.Id_Questao = Convert.ToInt32(0 + lblId_Questao.Text);
                mObjAlternativa.St_Verificacao = Convert.ToInt32(chk1.CheckState);
                mObjAlternativa.Ds_Alternativa = txtAlternativa1.Text;
                mObjAlternativa.Atualizar();

                mObjAlternativa.Id_Questao = Convert.ToInt32(0 + lblId_Questao.Text);
                mObjAlternativa.St_Verificacao = Convert.ToInt32(chk2.CheckState);
                mObjAlternativa.Ds_Alternativa = txtAlternativa2.Text;
                mObjAlternativa.Atualizar();

                mObjAlternativa.Id_Questao = Convert.ToInt32(0 + lblId_Questao.Text);
                mObjAlternativa.St_Verificacao = Convert.ToInt32(chk3.CheckState);
                mObjAlternativa.Ds_Alternativa = txtAlternativa3.Text;
                mObjAlternativa.Atualizar();

                mObjAlternativa.Id_Questao = Convert.ToInt32(0 + lblId_Questao.Text);
                mObjAlternativa.St_Verificacao = Convert.ToInt32(chk4.CheckState);
                mObjAlternativa.Ds_Alternativa = txtAlternativa4.Text;
                mObjAlternativa.Atualizar();

                mObjAlternativa.Id_Questao = Convert.ToInt32(0 + lblId_Questao.Text);
                mObjAlternativa.St_Verificacao = Convert.ToInt32(chk5.CheckState);
                mObjAlternativa.Ds_Alternativa = txtAlternativa5.Text;
                mObjAlternativa.Atualizar();

            }
            lblId_Questao.Text = string.Empty;

        }
    }



}
