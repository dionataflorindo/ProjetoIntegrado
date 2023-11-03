using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrado
{
    public partial class TelaMaterial : Form
    {
        public TelaMaterial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Negocio negocio = new Negocio();

            int produtoId = Convert.ToInt32(txtIdProduto.Text);
            string produtoNome = txtProdutoNome.Text;
            decimal entrada = Convert.ToDecimal(txtQtdEntrada.Text);
            decimal valorProduto = Convert.ToDecimal(txtValorMaterial.Text);
            decimal saldoAtual = Convert.ToDecimal(txtSaldo.Text);

            DateTime dataUltimaEntrada = DateTime.Now;
            bool verificaMaterial = negocio.VerificarExistenciaMaterial(produtoId);

            decimal saldo = saldoAtual + entrada;
            decimal valorTotal = saldo * valorProduto;

            if (verificaMaterial)
            {
                negocio.EditarMaterial(produtoId, produtoNome, saldo, entrada, valorProduto, valorTotal, dataUltimaEntrada);
                MessageBox.Show("Material editado com sucesso");
            }
            else
            {
                negocio.IserirMaterial(produtoNome, entrada, saldo, valorProduto, valorTotal, dataUltimaEntrada);
                MessageBox.Show("Material inserido com sucesso");
            }
            this.Close();
        }
    }
}
