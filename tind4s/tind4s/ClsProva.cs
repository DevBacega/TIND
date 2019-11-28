using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace tind4s
{
    class ClsProva : ClsManutencao
    {
        private int mId_Prova;
        private int mId_Materia;
        private int mId_Curso;
        private int mId_Prontuario;
        private string mNm_Prova;
        private int mST_Prova;
        private int mQtd;
        private int mId_Questao;

        public DataSet DSProva { get; set; }
        public int Qtd
        {
            get {return mQtd; }
            set {mQtd = value; }
        }

        public int Id_Prova
        {
            get { return mId_Prova; }
            set { mId_Prova = value; }
        }

        public int Id_Materia
        {
            get { return mId_Materia; }
            set { mId_Materia = value; }
        }

        public int Id_Curso
        {
            get { return mId_Curso; }
            set { mId_Curso = value; }
        }

        public int Id_Questao
        {
            get { return mId_Questao; }
            set { mId_Questao = value; }
        }

        public int Id_Prontuario
        {
            get { return mId_Prontuario; }
            set { mId_Prontuario = value; }
        }

        public string Nm_Prova
        {
            get { return mNm_Prova; }
            set { mNm_Prova = value; }
        }

        public int ST_Prova
        {
            get { return mST_Prova; }
            set { mST_Prova = value; }
        }

        public override void Inserir()
        {
            ClsConexao mObjconexao = new ClsConexao();

            mObjconexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Ins_Prova", mObjconexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pNm_Prova", mNm_Prova);
            cmd.Parameters.AddWithValue("@pSt_Prova", 1);
            cmd.Parameters.AddWithValue("@pId_Prontuario", 1);
            cmd.ExecuteReader(CommandBehavior.SingleRow);
            mObjconexao.desconectar();
        }

        public override void Atualizar()
        {
            ClsConexao mObjconexao = new ClsConexao();

            mObjconexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Upd_Prova", mObjconexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pNm_Prova	", mNm_Prova);
            cmd.Parameters.AddWithValue("@pSt_Prova", mST_Prova);
            cmd.Parameters.AddWithValue("@pId_Prova", mId_Prova);
            cmd.ExecuteReader(CommandBehavior.SingleRow);
            mObjconexao.desconectar();
        }

        public override void Desativa()
        {
            ClsConexao mObjconexao = new ClsConexao();

            mObjconexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Inativo_Prova", mObjconexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pId", mId_Prova);
            cmd.ExecuteReader(CommandBehavior.SingleRow);
            mObjconexao.desconectar();
        }

        public override void PreencheGrid()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Select_Prova", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet DSU = new DataSet();
            da.Fill(DSU);
            DSProva = DSU;
            conexao.desconectar();
        }

        public override void Selecionar()
        {
            ClsConexao mObjconexao = new ClsConexao();

            mObjconexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_SelectWr_Prova", mObjconexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pId", mId_Prova);
            SqlDataReader DR =  cmd.ExecuteReader(CommandBehavior.SingleRow);
            DR.Read();
            Nm_Prova = DR[1].ToString();
            Id_Prontuario = Convert.ToInt32(DR[3]);
            mObjconexao.desconectar();
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
            DSProva = DSU;
            conexao.desconectar();
        }

        public void maxId()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_MAX_Prova", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
            if(dr.HasRows)
            {
                dr.Read();
                Id_Prova = Convert.ToInt32(dr["ID"].ToString());
            }
            else
            {
                Id_Prova = 1;
            }
            conexao.desconectar();
        }

        public void ImprimiQuestaoProva()
        {
            ClsConexao mObjconexao = new ClsConexao();
            mObjconexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_SelectWr_QsProva", mObjconexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pId", mId_Prova);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet DSU = new DataSet();
            da.Fill(DSU);
            DSProva = DSU;
            mObjconexao.desconectar();
        }

        public void ImprimiGabarito()
        {
            ClsConexao mObjconexao = new ClsConexao();
            mObjconexao.conectar();
            SqlCommand cmd = new SqlCommand("Sp_Gabarito", mObjconexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pIdProva", mId_Prova);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet DSU = new DataSet();
            da.Fill(DSU);
            DSProva = DSU;
            mObjconexao.desconectar();
        }

        public void SelecionaQuestaoProva()
        {
            ClsConexao mObjconexao = new ClsConexao();
            mObjconexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Select_Gprova", mObjconexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pId_Materia", mId_Materia);
            cmd.Parameters.AddWithValue("@pQnt", mQtd);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet DSU = new DataSet();
            da.Fill(DSU);
            DSProva = DSU;
            mObjconexao.desconectar();
        }

        public void InserirQuestaoProva()
        {
            ClsConexao mObjconexao = new ClsConexao();
            mObjconexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Ins_Questao_Prova", mObjconexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pId_Prova", mId_Prova);
            cmd.Parameters.AddWithValue("@pId_Questao", mId_Questao);
            cmd.ExecuteReader(CommandBehavior.SingleRow);
            mObjconexao.desconectar();
        }

        
    }
}
