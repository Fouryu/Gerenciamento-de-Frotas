using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DLLConexao;
using DadosMotorista;

namespace DLLComandosMotorista
{
    public class MotoristaDAL
    {   
   
        //Comandos para inserir os dados do Motorista no banco de dados
        public int InserirMotorista(Motorista motoobj)
        {
            try
            {
                //Chamando o método para fazer a verificação. Se não houver o CPF digitado no Banco, o Insert será executado
                VerificarMotorista(motoobj.CPF);
                
                
                //DLL instanciada que possui a configuração da ConnectionString
                ConfigBanco conf = new ConfigBanco();

                string strConxao = conf.StrConfig;
                SqlConnection con = new SqlConnection(strConxao);
                con.ConnectionString = strConxao;
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = "INSERT INTO Motorista(Nome, RG, CPF, DataNascimento, Sexo, Email, Telefone, Celular, CNH, ValCNH, CategoriaCNH, Regiao)" +
                                         "VALUES(@Nome, @RG, @CPF, @DataNascimento, @Sexo, @Email, @Telefone, @Celular, @CNH, @ValCNH, @CategoriaCNH, @Regiao)";

                sqlCommand.Parameters.Add("Nome", System.Data.SqlDbType.VarChar).Value = motoobj.Nome;
                sqlCommand.Parameters.Add("RG", System.Data.SqlDbType.VarChar).Value = motoobj.RG;
                sqlCommand.Parameters.Add("CPF", System.Data.SqlDbType.VarChar).Value = motoobj.CPF;
                sqlCommand.Parameters.Add("DataNascimento", System.Data.SqlDbType.Date).Value = motoobj.DataNascimento;
                sqlCommand.Parameters.Add("Sexo", System.Data.SqlDbType.Char).Value = motoobj.Sexo;
                sqlCommand.Parameters.Add("Email", System.Data.SqlDbType.VarChar).Value = motoobj.Email;
                sqlCommand.Parameters.Add("Telefone", System.Data.SqlDbType.VarChar).Value = motoobj.Telefone;
                sqlCommand.Parameters.Add("Celular", System.Data.SqlDbType.VarChar).Value = motoobj.Celular;
                sqlCommand.Parameters.Add("CNH", System.Data.SqlDbType.VarChar).Value = motoobj.CNH;
                sqlCommand.Parameters.Add("ValCNH", System.Data.SqlDbType.Date).Value = motoobj.ValCNH;
                sqlCommand.Parameters.Add("CategoriaCNH", System.Data.SqlDbType.Char).Value = motoobj.CategoriaCNH;
                sqlCommand.Parameters.Add("Regiao", System.Data.SqlDbType.VarChar).Value = motoobj.Regiao;
                sqlCommand.Connection = con;
                con.Open();
                int moto = sqlCommand.ExecuteNonQuery();
                return moto;
            }

            //Caso aconteça algum erro na inserção de dados, será instanciado uma Exceção
            catch (Exception)
            {
                throw new Exception();
            }
        }
        
        
        //Método que verifica se o CPF que foi digitado já existe no Banco
        public void VerificarMotorista(string CPF)
        {
            ConfigBanco conf = new ConfigBanco();
            string Query = "SELECT CPF from Motorista WHERE CPF='" + CPF + "'";
            string strConxao = conf.StrConfig;
            SqlConnection con = new SqlConnection(strConxao);
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(Query, con);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (dr.Read())
            {
                string leitura = dr["CPF"].ToString();
                throw new Exception();
            }
            con.Close();
        }
    }
}
