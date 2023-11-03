using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrado
{
    internal class Negocio
    {
        DBClass queries = new DBClass();

        public DataTable CarregaEstoqueDataGridView()
        {
            return queries.CarregaEstoqueDataGridView();
        }

        public void EditarMaterial(int produtoId, string produtoNome, decimal saldo,decimal entrada, decimal valorProduto, decimal valorTotal, DateTime dataUltimaEntrada)
        {
            queries.EditarMaterial(produtoId, produtoNome,saldo ,entrada, valorProduto, valorTotal, dataUltimaEntrada); 
        }

        public bool VerificarExistenciaMaterial(int produtoId)
        {
            return queries.VerificarExistenciaMaterial(produtoId);
        }
        public void IserirMaterial(string produtoNome, decimal entrada,decimal saldo,decimal valorProduto, decimal valorTotal, DateTime dataUltimaEntrada)
        {
            queries.IserirMaterial(produtoNome, entrada,saldo, valorProduto, valorTotal,dataUltimaEntrada);
        }

        public void BaixaDeMaterial(int produtoId, string produtoNome, decimal saida, decimal saldo,  decimal valorProduto, decimal valorTotal, DateTime dataUltimaSaida)
        {
            queries.BaixaDeMaterial(produtoId,produtoNome, saida, saldo, valorProduto, valorTotal, dataUltimaSaida);
        }




    }
}
