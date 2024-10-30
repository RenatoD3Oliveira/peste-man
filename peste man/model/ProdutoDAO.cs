using peste_man.controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace peste_man.model
{
    internal class ProdutoDAO
    {
        private Connection Con { get; set; }
        private SqlCommand Cmd { get; set; }

        public ProdutoDAO()
        {
            Con = new Connection();
            Cmd = new SqlCommand();
        }

        public void Insert(Produto produto)
        {
            Cmd.Connection = Con.ReturnConnect();
            Cmd.CommandText = @"INSERT INTO Produto VALUES (@Id, @NomeProduto, @Preco, @Quantidade)";
            Cmd.Parameters.AddWithValue("@Id", produto.Id);
            Cmd.Parameters.AddWithValue("@NomeProduto", produto.NomeProduto);
            Cmd.Parameters.AddWithValue("@Preco", produto.Preco); 
            Cmd.Parameters.AddWithValue("@Quantidade", produto.Quantidade);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir Produto.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnect();
            }
        }

        public void Excluir(int idUsuario)
        {
            Cmd.Connection = Con.ReturnConnect();
            Cmd.CommandText = @"DELETE FROM Usuarios WHERE Id = @id";
            Cmd.Parameters.AddWithValue("@id", idUsuario);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnect();
            }
        }

        public List<Produto> ListALLProdutos()
        {
            Cmd.Connection = Con.ReturnConnect();
            Cmd.CommandText = "SELECT * FROM Usuarios"; // oq é mostrado
            List<Produto> listaDeProduto = new List<Produto>();

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    Produto produto = new Produto(
                        (int)rd["Id"],
                        (string)rd["NomeProduto"],
                        (float)rd["Preco"],
                        (int)rd["Quantidade"]
                    );
                    listaDeProduto.Add(produto);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnect();
            }

            return listaDeProduto;
        }
    }
}
