using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DadosEmpresa;
using DLLNegocioEmpresa;

namespace Controle_de_Frotas
{
    public partial class FrmGerenciarEmpresas : Form
    {
        public FrmGerenciarEmpresas()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Empresa empresaobj = new Empresa();
                empresaobj.CNPJ = TxtCNPJ.Text;
                empresaobj.Nome = TxtNome.Text;
                empresaobj.Endereco = TxtEndereco.Text;
                empresaobj.Telefone = TxtTelefone.Text;
                empresaobj.Email = TxtEmail.Text;
                empresaobj.RC = TxtRC.Text;

                int emp = new EmpresaBLL().InserirEmpresa(empresaobj);

                if(emp > 0)
                {
                    MessageBox.Show("Empresa cadastrada com sucesso!", "Cadastro de empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Esta empresa já foi cadastrada", "Cadastro de empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDesativar_Click(object sender, EventArgs e)
        {
            Empresa empresaobj = new Empresa();
            empresaobj.CNPJ = TxtCNPJ.Text;
            int emp = new EmpresaBLL().DesativarEmpresa(empresaobj);

            if(emp > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Voce deseja desativar esta empresa?", "Desativar empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DialogResult dialogResult2 = MessageBox.Show("Todos os dados desta empresa serao apagados", "Desativar empresa", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (dialogResult2 == DialogResult.OK)
                    {
                        MessageBox.Show("A empresa foi desativada!", "Desativar empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Desativacao cancelada", "Desativar empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
