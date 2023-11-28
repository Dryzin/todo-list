using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace WinForm_todolist_2nd_try
{
    internal class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=;database=todo");
        public string mensagem;

        public bool insertTodo(Todo newTodo)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("sp_insertTodo", conexao);
                Console.WriteLine(newTodo);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("title", newTodo.Title);
                cmd.Parameters.AddWithValue("category_id", newTodo.Category);   
                cmd.ExecuteNonQuery();//executar no banco
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
        }

        public DataTable listTodo()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listTodo", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }

        public DataTable listCategories()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listCategories", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
