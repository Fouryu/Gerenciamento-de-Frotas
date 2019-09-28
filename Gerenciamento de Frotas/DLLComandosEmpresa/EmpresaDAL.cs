using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DadosEmpresa;
using DLLConexao;

namespace DLLComandosEmpresa
{
    public class EmpresaDAL
    {
        public int InserirEmpresa(Empresa empresaobj)
        {
            //Chamando o método para fazer a verificação. Se não houver o CNPJ digitado no Banco, o Insert será executado
            VerificarEmpresa(empresaobj.CNPJ);


            //DLL instanciada que possui a configuração da ConnectionString
            ConfigBanco conf = new ConfigBanco();

            string strConxao = conf.StrConfig;
            SqlConnection con = new SqlConnection(strConxao);
            con.ConnectionString = strConxao;
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "INSERT INTO Empresa(CNPJ, Nome, Endereco, Telefone, Email, RC)VALUES(@CNPJ, @Nome, @Endereco, @Telefone, @Email, @RC)";

            sqlCommand.Parameters.Add("CNPJ", System.Data.SqlDbType.VarChar).Value = empresaobj.CNPJ;
            sqlCommand.Parameters.Add("Nome", System.Data.SqlDbType.VarChar).Value = empresaobj.Nome;
            sqlCommand.Parameters.Add("Endereco", System.Data.SqlDbType.VarChar).Value = empresaobj.Endereco;
            sqlCommand.Parameters.Add("Telefone", System.Data.SqlDbType.VarChar).Value = empresaobj.Telefone;
            sqlCommand.Parameters.Add("Email", System.Data.SqlDbType.VarChar).Value = empresaobj.Email;
            sqlCommand.Parameters.Add("RC", System.Data.SqlDbType.VarChar).Value = empresaobj.RC;
            sqlCommand.Connection = con;
            con.Open();
            int emp = sqlCommand.ExecuteNonQuery();
            return emp;
        }

        public int DesativarEmpresa(Empresa empresaobj)
        {
            try
            {
                ConfigBanco conf = new ConfigBanco();

                string strConxao = conf.StrConfig;
                SqlConnection con = new SqlConnection(strConxao);
                con.ConnectionString = strConxao;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = "DELETE Empresa WHERE CNPJ = @CNPJ";
                sqlCommand.Parameters.Add("CNPJ", System.Data.SqlDbType.VarChar).Value = empresaobj.CNPJ;
                sqlCommand.Connection = con;
                con.Open();
                int emp = sqlCommand.ExecuteNonQuery();
                return emp;
            }

            //Caso aconteça algum erro no processo, é instanciado uma Exception
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //Método que verifica se o CNPJ que foi digitado já existe no Banco
        public void VerificarEmpresa(string CNPJ)
        {
            ConfigBanco conf = new ConfigBanco();
            string Query = "SELECT CNPJ from Empresa WHERE CNPJ='" + CNPJ + "'";
            string strConxao = conf.StrConfig;
            SqlConnection con = new SqlConnection(strConxao);
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(Query, con);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (dr.Read())
            {
                string leitura = dr["CNPJ"].ToString();
                throw new Exception();
            }
            con.Close();
        }
    }
}

