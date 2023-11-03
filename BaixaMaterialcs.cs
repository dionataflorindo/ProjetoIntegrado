using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrado
{
    public partial class BaixaMaterialcs : Form
    {
        public BaixaMaterialcs()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();

            int produtoId = Convert.ToInt32(txtIdProduto.Text);
            string produtoNome = txtProdutoNome.Text;
            decimal saida = Convert.ToDecimal(txtSaida.Text);
            decimal valorProduto = Convert.ToDecimal(txtValorMaterial.Text);
            decimal saldo;
            decimal saldoAtual = Convert.ToDecimal(txtSaldo.Text);
            decimal calculaSaldoAtual = saldoAtual - saida;

            DateTime dataUltimaEntrada = DateTime.Now;
            bool verificaMaterial = negocio.VerificarExistenciaMaterial(produtoId);
            saldo = calculaSaldoAtual;
            decimal valorTotal = valorProduto * saldo;


            if (verificaMaterial)
            {
                negocio.BaixaDeMaterial(produtoId, produtoNome, saida,saldo, valorProduto, valorTotal, dataUltimaEntrada);
                MessageBox.Show("Baixa de material realizada com sucesso");
            }
            else
            {

            }

            this.Close();
        }
    }
}
