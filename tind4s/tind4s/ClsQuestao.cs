using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace tind4s
{
    class ClsQuestao: ClsManutencao
    {
        private int mId_Questao;
        private int mId_Prontuario;
        private int mId_Materia;
        private int mId_Curso;
        private int mSt_Pergunta;
        private string mDs_Pergunta;
        private string mDs_Justificativa;

        public DataSet DSQuestao { get; set; }

        public int Id_Curso
        {
            get { return mId_Curso; }//retorna o valor da variavel  
            set { mId_Curso = value; }//recebe um valor para variavel
        }

        public int Id_Questao
        {
            get { return mId_Questao; }//retorna o valor da variavel  
            set { mId_Questao = value; }//recebe um valor para variavel
        }
        public int Id_Prontuario
        {
            get { return mId_Prontuario; }//retorna o valor da variavel  
            set { mId_Prontuario = value; }//recebe um valor para variavel
        }
        public int Id_Materia
        {
            get { return mId_Materia; }//retorna o valor da variavel  
            set { mId_Materia = value; }//recebe um valor para variavel
        }
        public int St_Pergunta
        {
            get { return mSt_Pergunta; }//retorna o valor da variavel  
            set { mSt_Pergunta = value; }//recebe um valor para variavel
        }
        public string Ds_Pergunta
        {
            get { return mDs_Pergunta; }//retorna o valor da variavel  
            set { mDs_Pergunta = value; }//recebe um valor para variavel
        }
        public string Ds_Justificativa
        {
            get { return mDs_Justificativa; }//retorna o valor da variavel  
            set { mDs_Justificativa = value; }//recebe um valor para variavel
        }


        public override void Inserir()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Ins_Questao",conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pDs_Pergunta     ",mDs_Pergunta);
            cmd.Parameters.AddWithValue("@pDs_Justificativa",mDs_Justificativa);
            cmd.Parameters.AddWithValue("@pId_Materia      ",mId_Materia );
            cmd.Parameters.AddWithValue("@pId_Prontuario   ",mId_Prontuario);
            cmd.Parameters.AddWithValue("@pSt_Pergunta     ", 1);
            cmd.ExecuteReader(CommandBehavior.SingleRow);
            conexao.desconectar();

        }

        public override void Atualizar()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Upd_Questao", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pId_Questao      ", mId_Questao);
            cmd.Parameters.AddWithValue("@pDs_Pergunta     ", mDs_Pergunta);
            cmd.Parameters.AddWithValue("@pDs_Justificativa", mDs_Justificativa);
            cmd.Parameters.AddWithValue("@pId_Prontuario   ", mId_Materia);
            cmd.Parameters.AddWithValue("@pId_Materia      ", mId_Prontuario);
            cmd.Parameters.AddWithValue("@pSt_Pergunta     ", 1);
            cmd.ExecuteReader(CommandBehavior.SingleRow);
            conexao.desconectar();
        }

        public override void Selecionar()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_SelectWr_Questao", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pId", mId_Questao);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
            dr.Read();
            Id_Questao = Convert.ToInt32(dr[0]);
            Ds_Pergunta = dr[1].ToString();
            Ds_Justificativa = dr[2].ToString();
            Id_Prontuario = Convert.ToInt32(dr[3]);
            conexao.desconectar();
        }

        public override void Desativa()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Inativo_Questao", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pId", mId_Questao);
            cmd.ExecuteReader(CommandBehavior.SingleRow);
            conexao.desconectar();
        }

        public override void PreencheGrid()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Select_Questao", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet DSU = new DataSet();
            da.Fill(DSU);
            DSQuestao = DSU;
            conexao.desconectar();
        }

        public void SelecionaCursoMateria()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("Sp_Selecionar_Curso_Materia", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pIdCurso", mId_Curso);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet DSU = new DataSet();
            da.Fill(DSU);
            DSQuestao = DSU;
            conexao.desconectar();
        }
    }
}
