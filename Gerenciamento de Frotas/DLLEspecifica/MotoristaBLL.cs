using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLLComandosMotorista;
using DadosMotorista;


namespace DLLNegocioMotorista
{
    public class MotoristaBLL
    {

        //Regra de negócio que possui um método que retorna Motorista
        public int InserirMotorista(Motorista motoobj)
        {
            try
            {
                return new MotoristaDAL().InserirMotorista(motoobj);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}