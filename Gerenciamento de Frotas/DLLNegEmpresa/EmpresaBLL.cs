using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLLComandosEmpresa;
using DadosEmpresa;

namespace DLLNegocioEmpresa
{
    public class EmpresaBLL
    {
        public int InserirEmpresa(Empresa empresaobj)
        {
            try
            {
                return new EmpresaDAL().InserirEmpresa(empresaobj);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int DesativarEmpresa(Empresa empresaobj)
        {
            try
            {
                return new EmpresaDAL().DesativarEmpresa(empresaobj);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
