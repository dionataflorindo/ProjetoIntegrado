using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProjetoIntegrado
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
            ListaEstoque();
        }

        public void ListaEstoque()
        {
            DataTable dataTable = new DataTable();
            Negocio negocio = new Negocio();
            dataTable = negocio.CarregaEstoqueDataGridView();
            dataGridViewEstoque.DataSource = dataTable;
            configuraGrid();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            TelaMaterial telaMaterial = new TelaMaterial();
            if (dataGridViewEstoque.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridViewEstoque.SelectedRows[0];
                int produtoId = Convert.ToInt32(linhaSelecionada.Cells["ProdutoId"].Value);
                string produtoNome = linhaSelecionada.Cells["ProdutoNome"].Value.ToString();
                int saldo = Convert.ToInt32(linhaSelecionada.Cells["Saldo"].Value.ToString());
                decimal valor = Convert.ToDecimal(linhaSelecionada.Cells["ValorProduto"].Value.ToString());
                decimal valorTotal = Convert.ToDecimal(linhaSelecionada.Cells["ValorTotal"].Value.ToString());


                telaMaterial.txtIdProduto.Text = produtoId.ToString();
                telaMaterial.txtProdutoNome.Text = produtoNome;
                telaMaterial.txtValorMaterial.Text = valor.ToString();
                telaMaterial.txtSaldo.Text = saldo.ToString();
                telaMaterial.txtValorTotalMaterial.Text = valorTotal.ToString();

                telaMaterial.Show();
            }

        }
        void configuraGrid()
        {
            dataGridViewEstoque.Columns["ProdutoId"].Visible = false;
        }

        private void bntInserir_Click(object sender, EventArgs e)
        {
            TelaMaterial telaMaterial = new TelaMaterial();
            telaMaterial.Show();

        }

        private void btnBaixaMaterial_Click(object sender, EventArgs e)
        {
            BaixaMaterialcs baixaMaterialcs = new BaixaMaterialcs();
            if (dataGridViewEstoque.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridViewEstoque.SelectedRows[0];
                int produtoId = Convert.ToInt32(linhaSelecionada.Cells["ProdutoId"].Value);
                string produtoNome = linhaSelecionada.Cells["ProdutoNome"].Value.ToString();
                int saldo = Convert.ToInt32(linhaSelecionada.Cells["Saldo"].Value.ToString());
                decimal valor = Convert.ToDecimal(linhaSelecionada.Cells["ValorProduto"].Value.ToString());



                baixaMaterialcs.txtIdProduto.Text = produtoId.ToString();
                baixaMaterialcs.txtProdutoNome.Text = produtoNome;
                baixaMaterialcs.txtValorMaterial.Text = valor.ToString();
                baixaMaterialcs.txtSaldo.Text = saldo.ToString();

                baixaMaterialcs.Show();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ListaEstoque();
        }
    }
}