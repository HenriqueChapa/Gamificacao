using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entidade.Model;

namespace Entidade.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly string connectionString = "Data Source=DESKTOP-8MT30BF\\MSSQLSERVER01;Initial Catalog=gamificacao3;Integrated Security=True";

        public PedidoRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Pedido ObterPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Pedido WHERE ID_Pedido = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Pedido pedido = new Pedido
                    {
                        IdPedido = Convert.ToInt32(reader["ID_Pedido"]),
                        DataPedido = Convert.ToDateTime(reader["DataPedido"]),
                        NomeCliente = reader["NomeCliente"].ToString(),
                        StatusPedido = reader["StatusPedido"].ToString()
                    };

                    return pedido;
                }

                return null;
            }
        }

        public IEnumerable<Pedido> ObterTodos()
        {
            List<Pedido> pedidos = new List<Pedido>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Pedido";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Pedido pedido = new Pedido
                    {
                        IdPedido = Convert.ToInt32(reader["ID_Pedido"]),
                        DataPedido = Convert.ToDateTime(reader["DataPedido"]),
                        NomeCliente = reader["NomeCliente"].ToString(),
                        StatusPedido = reader["StatusPedido"].ToString()
                    };

                    pedidos.Add(pedido);
                }
            }

            return pedidos;
        }

        public void Inserir(Pedido pedido)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Pedido (DataPedido, NomeCliente, StatusPedido) VALUES (@DataPedido, @NomeCliente, @StatusPedido)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DataPedido", pedido.DataPedido);
                command.Parameters.AddWithValue("@NomeCliente", pedido.NomeCliente);
                command.Parameters.AddWithValue("@StatusPedido", pedido.StatusPedido);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Atualizar(Pedido pedido)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Pedido SET DataPedido = @DataPedido, NomeCliente = @NomeCliente, StatusPedido = @StatusPedido WHERE ID_Pedido = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DataPedido", pedido.DataPedido);
                command.Parameters.AddWithValue("@NomeCliente", pedido.NomeCliente);
                command.Parameters.AddWithValue("@StatusPedido", pedido.StatusPedido);
                command.Parameters.AddWithValue("@Id", pedido.IdPedido);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Excluir(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Pedido WHERE ID_Pedido = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    public class ItemPedidoRepository : IItemPedidoRepository
    {
        private readonly string connectionString;

        public ItemPedidoRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public ItemPedido ObterPorId(long id

)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ItemPedido WHERE ID_Item = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                java
            
            connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ItemPedido itemPedido = new ItemPedido
                    {
                        IdItem = Convert.ToInt64(reader["ID_Item"]),
                        Quantidade = Convert.ToInt32(reader["Quantidade"]),
                        Preco = Convert.ToDouble(reader["PrecoUnitario"]),
                        ProdutoPedido = null
                    };

                    return itemPedido;
                }

                return null;
            }
        }

        public IEnumerable<ItemPedido> ObterTodos()
        {
            List<ItemPedido> itensPedido = new List<ItemPedido>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ItemPedido";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ItemPedido itemPedido = new ItemPedido
                    {
                        IdItem = Convert.ToInt64(reader["ID_Item"]),
                        Quantidade = Convert.ToInt32(reader["Quantidade"]),
                        Preco = Convert.ToDouble(reader["PrecoUnitario"]),
                        ProdutoPedido = null
                    };

                    itensPedido.Add(itemPedido);
                }
            }

            return itensPedido;
        }

        public void Inserir(ItemPedido itemPedido)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ItemPedido (Quantidade, PrecoUnitario, ID_Pedido, ID_Produto) VALUES (@Quantidade, @PrecoUnitario, @IdPedido, @IdProduto)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Quantidade", itemPedido.Quantidade);
                command.Parameters.AddWithValue("@PrecoUnitario", itemPedido.Preco);
                command.Parameters.AddWithValue("@IdPedido", itemPedido.Pedido.IdPedido);
                command.Parameters.AddWithValue("@IdProduto", itemPedido.ProdutoPedido.ProdutoID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Atualizar(ItemPedido itemPedido)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE ItemPedido SET Quantidade = @Quantidade, PrecoUnitario = @PrecoUnitario, ID_Pedido = @IdPedido, ID_Produto = @IdProduto WHERE ID_Item = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Quantidade", itemPedido.Quantidade);
                command.Parameters.AddWithValue("@PrecoUnitario", itemPedido.Preco);
                command.Parameters.AddWithValue("@IdPedido", itemPedido.Pedido.IdPedido);
                command.Parameters.AddWithValue("@IdProduto", itemPedido.ProdutoPedido.ProdutoID);
                command.Parameters.AddWithValue("@Id", itemPedido.IdItem);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Excluir(long id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM ItemPedido WHERE ID_Item = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

}
