using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace tind4s
{
    public class ClsProfessor: ClsManutencao 
    {


        public int mId_Prontuario;
        public string mNm_Usuario;
        public int mSt_Usuario;
        public string mDs_Usuario;
        public string mDs_Senha;
        public DataSet DSUsuario { get; set; }

        public string Ds_Usuario
        {
            get { return mDs_Usuario; }
            set { mDs_Usuario = value; }
        }

        public string Ds_Senha
        {
            get { return mDs_Senha; }
            set { mDs_Senha = value; }
        }

        public int Id_Prontuario
        {
            get { return mId_Prontuario; }//retorna o valor da variavel  
            set { mId_Prontuario = value; }//recebe um valor para variavel
        }

        public string Nm_Usuario
        {
            get { return mNm_Usuario; }//retorna o valor da variavel  
            set { mNm_Usuario = value; }//recebe um valor para variavel
        }

        public int St_Usuario
        {
            get { return mSt_Usuario; }//retorna o valor da variavel  
            set { mSt_Usuario = value; }//recebe um valor para variavel
        }

        public override string InserirProfessor()
        {
            ClsConexao conexao = new ClsConexao();
            try
            {
                conexao.conectar();
                SqlCommand cmd = new SqlCommand("sp_Ins_Usuario", conexao.conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNm_Usuario", mNm_Usuario);
                cmd.Parameters.AddWithValue("@pDs_Usuario", mDs_Usuario);
                cmd.Parameters.AddWithValue("@pDs_Senha", mDs_Senha);
                cmd.Parameters.AddWithValue("@pSt_Usuario", 1);
                cmd.ExecuteReader(CommandBehavior.SingleRow);
                return ("true");
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                conexao.desconectar();
            }
        }
        public override string UpdateProfessor() 
        {
            ClsConexao conexao = new ClsConexao();
            try
            {
                conexao.conectar();
                SqlCommand cmd = new SqlCommand("sp_Upd_Usuario", conexao.conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNm_Usuario", mNm_Usuario);
                cmd.Parameters.AddWithValue("@pDs_Usuario", mDs_Usuario);
                cmd.Parameters.AddWithValue("@pDs_Senha", mDs_Senha);
                cmd.Parameters.AddWithValue("@pSt_Usuario", mSt_Usuario);
                cmd.Parameters.AddWithValue("@pId_Prontuario", mId_Prontuario);
                cmd.ExecuteReader(CommandBehavior.SingleRow);
                return ("true");
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                conexao.desconectar();
            }
        }
        public override string VizualizarProfessor(int Id)
        {
            ClsConexao conexao = new ClsConexao();
            try
            {
                conexao.conectar();
                SqlCommand cmd = new SqlCommand("sp_Vizualizar_Usuario", conexao.conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pId_Prontuario", Id);
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (dr.Read())
                {
                    ClsProfessor professor = new ClsProfessor();
                    professor.Id_Prontuario = Id;
                    professor.Nm_Usuario = dr["nm_usuario"].ToString();
                    professor.St_Usuario = Convert.ToInt32(dr["St_Usuario"].ToString());
                    return ("true");
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                conexao.desconectar();
            }
        }
        public override string AfastarProfessor()
        {
            ClsConexao conexao = new ClsConexao();
            try
            {
                conexao.conectar();
                SqlCommand cmd = new SqlCommand("sp_Upd_Usuario", conexao.conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNm_Usuario", mNm_Usuario);
                cmd.Parameters.AddWithValue("@pDs_Usuario", mDs_Usuario);
                cmd.Parameters.AddWithValue("@pDs_Senha", mDs_Senha);
                cmd.Parameters.AddWithValue("@pSt_Usuario", mSt_Usuario);
                cmd.Parameters.AddWithValue("@pId_Prontuario", mId_Prontuario);
                cmd.ExecuteReader(CommandBehavior.SingleRow);
                return ("true");
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                conexao.desconectar();

            }
        }
        public override bool verificacao(string Usuario, string Senha)
        {
            ClsConexao conexao = new ClsConexao();
            try
            {
                conexao.conectar();
                SqlCommand cmd = new SqlCommand("sp_Vizualizar_Usuario", conexao.conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pDs_Usuario", Usuario);
                cmd.Parameters.AddWithValue("@pDs_Senha", Senha);
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (dr.Read())
                {
                    Ds_Usuario = dr["Ds_Usuario"].ToString();
                    Ds_Senha = dr["Ds_Senha"].ToString();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conexao.desconectar();
            }
        }


        public void Grid()
        {
            ClsConexao conexao = new ClsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Grid_Usuario", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet DSU = new DataSet();
            da.Fill(DSU);
            DSUsuario = DSU;
            conexao.desconectar();

        }
    }
}
