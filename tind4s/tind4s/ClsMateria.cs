using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace tind4s
{
    class ClsMateria : ClsManutencao
    {
        private int      mId_Materia;
        private string   mNm_Materia;
        private string   mSg_Materia;
        private int      mId_Curso;

        public DataSet DSMateria { get; set; }

        public int Id_Materia
        {
            get { return mId_Materia; }
            set { mId_Materia = value; }
        }

        public string Nm_Materia
        {
            get { return mNm_Materia; }
            set { mNm_Materia = value; }
        }

        public string Sg_Materia
        {
            get { return mSg_Materia; }
            set { mSg_Materia = value; }
        }
        public int Id_Curso
        {
            get { return mId_Curso; }
            set { mId_Curso = value; }
        }

        public override void Inserir()
        {
            ClsConexao mObjconexao = new ClsConexao();

            mObjconexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Ins_Materia", mObjconexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pId_Curso", mId_Curso);
            cmd.Parameters.AddWithValue("@pNm_Materia",mNm_Materia);
            cmd.Parameters.AddWithValue("@pAbrev_Nm_Materia",mSg_Materia);
            cmd.ExecuteReader(CommandBehavior.SingleRow);
            mObjconexao.desconectar();
        }

        public override void Atualizar()
        {
            ClsConexao mObjconexao = new ClsConexao();

            mObjconexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Upd_Materia", mObjconexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pId_Curso", mId_Curso);
            cmd.Parameters.AddWithValue("@pId_Materia", mId_Materia);
            cmd.Parameters.AddWithValue("@pNm_Materia", mNm_Materia);
            cmd.Parameters.AddWithValue("@pAbrev_Nm_Materia", mSg_Materia);
            cmd.ExecuteReader(CommandBehavior.SingleRow);
            mObjconexao.desconectar();
        }

        public override void Selecionar()
        {
            ClsConexao mObjconexao = new ClsConexao();
            mObjconexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Upd_Materia", mObjconexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pId_Materia", mId_Materia);
            SqlDataReader DR = cmd.ExecuteReader(CommandBehavior.SingleRow);
            DR.Read();
            Id_Materia = Convert.ToInt32(DR["Id_Materia"]);
            Nm_Materia = DR["Nm_Materia"].ToString();
            Sg_Materia = DR["Abrev_Nm_Materia"].ToString();
            Id_Curso = Convert.ToInt32(DR["Id_Curso"]);
            mObjconexao.desconectar();
        }

        public override void PreencheGrid()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Select_Materia", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet DSU = new DataSet();
            da.Fill(DSU);
            DSMateria = DSU;
            conexao.desconectar();
        }

        public override void Desativa()
        {
            throw new NotImplementedException();
        }
    }
}
