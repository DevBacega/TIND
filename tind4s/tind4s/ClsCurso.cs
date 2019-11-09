using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace tind4s
{
    class ClsCurso: ClsManutencao
    {
        public int mId_Curso;
        public string mNm_Curso;
        public string mAbrev_Nm_Curso;
        public DataSet DsCurso { get; set; }

        public int Id_Curso
        {
            get { return mId_Curso; }//retorna o valor da variavel  
            set { mId_Curso = value; }//recebe um valor para variavel
        }
        public string Nm_Curso
        {
            get { return mNm_Curso; }//retorna o valor da variavel  
            set { mNm_Curso = value; }//recebe um valor para variavel
        }
        public string Abrev_Nm_Curso
        {
            get { return mAbrev_Nm_Curso; }//retorna o valor da variavel  
            set { mAbrev_Nm_Curso = value; }//recebe um valor para variavel
        }

        public override void Inserir()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Ins_Curso", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pNm_Curso", mNm_Curso);
            cmd.Parameters.AddWithValue("@pAbrev_Nm_Curso", mAbrev_Nm_Curso);
            cmd.ExecuteReader(CommandBehavior.SingleRow);
            conexao.desconectar();
        }
        public override void Atualizar()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Upd_Curso", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pNm_Curso", mNm_Curso);
            cmd.Parameters.AddWithValue("@pAbrev_Nm_Curso", mAbrev_Nm_Curso);
            cmd.Parameters.AddWithValue("@pId_Curso",mId_Curso);
            cmd.ExecuteReader(CommandBehavior.SingleRow);
            conexao.desconectar();
        }
        public override void Selecionar()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_SelectWr_Curso", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pId_Curso", mId_Curso);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
            Id_Curso = Convert.ToInt32(dr["id_curso"]);
            Nm_Curso = dr["nm_curso"].ToString();
            Nm_Curso = dr["abrev_nm_curso"].ToString();
            conexao.desconectar();
        }
        public override void Desativa()
        {
            throw new NotImplementedException();
        }
        public override void PreencheGrid()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Select_Curso", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet DSU = new DataSet();
            da.Fill(DSU);
            DsCurso = DSU;
            conexao.desconectar();
        }
    }
}
