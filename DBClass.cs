using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrado
{
    internal class DBClass:ConectaDB
    {
        public DataTable CarregaEstoqueDataGridView()
        {
            DataTable dataTable = new DataTable();
            using (var conexao = ConectarBanco())
            {
                conexao.Open();
                using (var cmdSql = new SqlCommand())
                {
                    cmdSql.Connection = conexao;
                    cmdSql.CommandText = "select * from Estoque";
                    cmdSql.CommandType = CommandType.Text;

                    SqlDataReader reader = cmdSql.ExecuteReader();

                    dataTable.Load(reader);
                }
            }
            return dataTable;
        }

        public void BaixaDeMaterial(int produtoId, string produtoNome, decimal saida, decimal saldo, decimal valorProduto, decimal valorTotal, DateTime dataUltimaSaida)
        {
            using (var conexao = ConectarBanco())
            {
                conexao.Open();
                using (var cmdSql = new SqlCommand())
                {
                    cmdSql.Connection = conexao;
                    cmdSql.CommandText = "update Estoque set ProdutoNome = @produtoNome ,Saida = @saida, Saldo = @saldo,ValorProduto = @valorProduto, ValorTotal = @valorTotal, DataUltimaSaida = @dataUltimaSaida where ProdutoId = @produtoId";
                    cmdSql.Parameters.AddWithValue("@produtoId", produtoId);
                    cmdSql.Parameters.AddWithValue("@produtoNome", produtoNome);
                    cmdSql.Parameters.AddWithValue("@saida", saida);
                    cmdSql.Parameters.AddWithValue("@saldo", saldo);
                    cmdSql.Parameters.AddWithValue("@valorProduto", valorProduto);
                    cmdSql.Parameters.AddWithValue("@valorTotal", valorTotal);
                    cmdSql.Parameters.AddWithValue("@dataUltimaSaida", dataUltimaSaida);
                    cmdSql.CommandType = CommandType.Text;
                    cmdSql.ExecuteNonQuery();
                }
            }
        }

        public void IserirMaterial(string produtoNome,decimal entrada,decimal saldo, decimal valorProduto,decimal valorTotal, DateTime dataUltimaEntrada)
        {
            using (var conexao = ConectarBanco())
            {
                conexao.Open();
                using (var cmdSql = new SqlCommand())
                {
                    cmdSql.Connection = conexao;
                    cmdSql.CommandText = "insert into Estoque(ProdutoNome, Entrada, Saldo, ValorProduto, ValorTotal, DataUltimaEntrada) values (@produtoNome, @entrada, @saldo, @valorProduto, @valorTotal, @dataUltimaEntrada)";
                    cmdSql.Parameters.AddWithValue("@produtoNome", produtoNome);
                    cmdSql.Parameters.AddWithValue("@entrada", entrada);
                    cmdSql.Parameters.AddWithValue("@saldo", saldo);
                    cmdSql.Parameters.AddWithValue("@valorProduto", valorProduto);
                    cmdSql.Parameters.AddWithValue("@valorTotal", valorTotal);
                    cmdSql.Parameters.AddWithValue("@dataUltimaEntrada", dataUltimaEntrada);
                    cmdSql.CommandType = CommandType.Text;
                    cmdSql.ExecuteNonQuery();
                }
            }
        }

        public void EditarMaterial(int produtoId, string produtoNome,decimal saldo, decimal entrada, decimal valorProduto, decimal valorTotal, DateTime dataUltimaEntrada)
        {
               
            using (var conexao = ConectarBanco())
            {
                conexao.Open();
                using(var cmdSql = new SqlCommand())
                {
                    cmdSql.Connection = conexao;
                    cmdSql.CommandText = "update Estoque set ProdutoNome = @produtoNome, Entrada = @entrada,Saldo = @saldo, ValorProduto = @valorProduto, ValorTotal = @valorTotal, DataUltimaEntrada = @dataUltimaEntrada where ProdutoId = @produtoId";
                    cmdSql.Parameters.AddWithValue("@produtoId", produtoId);
                    cmdSql.Parameters.AddWithValue("@produtoNome", produtoNome);
                    cmdSql.Parameters.AddWithValue("@entrada", entrada);
                    cmdSql.Parameters.AddWithValue("@saldo", saldo);
                    cmdSql.Parameters.AddWithValue("@valorProduto", valorProduto);
                    cmdSql.Parameters.AddWithValue("@valorTotal", valorTotal);
                    cmdSql.Parameters.AddWithValue("@dataUltimaEntrada", dataUltimaEntrada);



                    cmdSql.CommandType = CommandType.Text;
                    cmdSql.ExecuteNonQuery();
                }
            }
        }

        public bool VerificarExistenciaMaterial(int produtoId)
        {
            bool produtoExiste = false;

            using (var conexao = ConectarBanco())
            {
                conexao.Open();

                using (var cmdSql = new SqlCommand())
                {
                    cmdSql.Connection = conexao;
                    cmdSql.CommandText = "select count(*) from Estoque where ProdutoId = @produtoId";
                    cmdSql.Parameters.AddWithValue("@produtoId", produtoId);
                    cmdSql.CommandType = CommandType.Text;

                    int count = (int)cmdSql.ExecuteScalar();

                    produtoExiste = count > 0;
                }
            }

            return produtoExiste;
        }
    }
}
