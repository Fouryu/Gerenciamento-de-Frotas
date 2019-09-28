using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DadosMotorista;
using DLLNegocioMotorista;


namespace Controle_de_Frotas
{
    public partial class FrmCadastrarMotorista : Form
    {
        public FrmCadastrarMotorista()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            //Tratativa de erros
            try
            {
                //Instanciando a classe Motorista e passando os atributos para o objeto instanciado
                Motorista motoobj = new Motorista();
                motoobj.Nome = TxtNome.Text;
                motoobj.RG = TxtRg.Text;
                motoobj.CPF = TxtCpf.Text;
                motoobj.DataNascimento = TxtDataNascimento.Text;
                motoobj.Email = TxtEmail.Text;
                motoobj.Telefone = TxtTelefone.Text;
                motoobj.Celular = TxtCelular.Text;
                motoobj.CNH = TxtCnh.Text;
                motoobj.ValCNH = TxtValidadeCnh.Text;
                motoobj.CategoriaCNH = TxtCategoria.Text;
                if (CboSexo.Text == "M")
                {
                    motoobj.Sexo = "M";
                }
                else if (CboSexo.Text == "F")
                {
                    motoobj.Sexo = "F";
                }
                else
                {
                    motoobj.Sexo = "O";
                }

                switch (CboRegiao.Text)
                {
                    case "Norte":
                        motoobj.Regiao = "Norte";
                        break;
                    case "Sul":
                        motoobj.Regiao = "Sul";
                        break;
                    case "Leste":
                        motoobj.Regiao = "Leste";
                        break;
                    case "Oeste":
                        motoobj.Regiao = "Oeste";
                        break;
                    case "Nordeste":
                        motoobj.Regiao = "Nordeste";
                        break;
                    case "Noroeste":
                        motoobj.Regiao = "Noroeste";
                        break;
                    case "Sudeste":
                        motoobj.Regiao = "Sudeste";
                        break;
                    case "Sudoeste":
                        motoobj.Regiao = "Sudoeste";
                        break;
                    case "Centro-Oeste":
                        motoobj.Regiao = "Centro-Oeste";
                        break;
                }
            
                int moto = new MotoristaBLL().InserirMotorista(motoobj);

                if (moto > 0)
                {
                    MessageBox.Show("Motorista cadastrado com sucesso!", "Cadastro de motorista", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Os dados desse motorista já estão cadastrados", "Cadastro de motorista", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
