using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DLLConexao
{
    //Classe criada para configurar a ConnectionString
    public class ConfigBanco
    {
        public string StrConfig { get; set; }

        public ConfigBanco()
        {
            StrConfig = ConfigurationManager.ConnectionStrings["GerenciamentoFrotas"].ConnectionString;
        }
    }
}
