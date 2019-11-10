using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace tind4s
{
    class ClsAlternativa: ClsManutencao
    {
        private int mId_Alternativas;
        private int mId_Questao;
        private int mSt_Verificacao;
        private string mDs_Alternativa;

        public DataSet DSAlternariva { get; set; }

        public int Id_Questao
        {
            get { return mId_Questao; }//retorna o valor da variavel  
            set { mId_Questao = value; }//recebe um valor para variavel
        }
        public int Id_Alternativas
        {
            get { return mId_Alternativas; }//retorna o valor da variavel  
            set { mId_Alternativas = value; }//recebe um valor para variavel
        }
        public int St_Verificacao
        {
            get { return mSt_Verificacao; }//retorna o valor da variavel  
            set { mSt_Verificacao = value; }//recebe um valor para variavel
        }
        public string Ds_Alternativa
        {
            get { return mDs_Alternativa; }//retorna o valor da variavel  
            set { mDs_Alternativa = value; }//recebe um valor para variavel
        }

        public override void Inserir()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Ins_Alternarivas", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pDs_Alternativa",mDs_Alternativa);
            cmd.Parameters.AddWithValue("@pVerificacao",mSt_Verificacao);
            cmd.Parameters.AddWithValue("@pId_Questao",mId_Questao);
            cmd.ExecuteReader(CommandBehavior.SingleRow);
            conexao.desconectar();
        }

        public override void Atualizar()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Upd_Alternativas", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pId_Alternativas", mId_Alternativas);
            cmd.Parameters.AddWithValue("@pDs_Alternativa", mDs_Alternativa);
            cmd.Parameters.AddWithValue("@pSt_Verificacao", mSt_Verificacao);
            cmd.ExecuteReader(CommandBehavior.SingleRow);
            conexao.desconectar();
        }

        public override void Selecionar()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_SelectWr_Alternativa", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pId", mId_Questao);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet DSU = new DataSet();
            da.Fill(DSU);
            DSAlternariva = DSU;
            conexao.desconectar();
        }

        public override void Desativa()
        {
            throw new NotImplementedException();
        }

        public override void PreencheGrid()
        {
            throw new NotImplementedException();
        }
    }
}
