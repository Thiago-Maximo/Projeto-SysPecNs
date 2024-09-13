using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace SysPecNSLib
{
    public class Estoque
    {
        //Declaração das Propriedades 
        public int? Produto_Id { get; set; }
        public double? Quantidade { get; set; }
        public DateTime? Data_Ultimo_Movimento { get; set; }

        //Métodos Construtores
        public Estoque()
        {

        }
        public Estoque(int? produto_Id, double? quantidade, DateTime? data_Ultimo_Movimento)
        {
            Produto_Id = produto_Id;
            Quantidade = quantidade;
            Data_Ultimo_Movimento = data_Ultimo_Movimento;
        }
        public Estoque(double? quantidade, DateTime? data_Ultimo_Movimento)
        {
            Quantidade = quantidade;
            Data_Ultimo_Movimento = data_Ultimo_Movimento;
        }
        public Estoque(int? produto_Id, double? quantidade)
        {
            Produto_Id = produto_Id;
            Quantidade = quantidade;
        }
        public Estoque(double? quantidade)
        {
            Quantidade = quantidade;
        }

        //Declaração das Funções

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO estoques (produto_id, quantidade) VALUES (@produto_id, @quantidade)";

            cmd.Parameters.AddWithValue("@produto_id", Produto_Id);
            cmd.Parameters.AddWithValue("@quantidade", Quantidade);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void Alterar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update estoques set produto_id = {Produto_Id}, quantidade= {Quantidade}, data_ultimo_movimento={Data_Ultimo_Movimento};";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static Estoque ObterPorID(int id)
        {
            Estoque estoque = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from estoques where produto_id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                estoque = new(
                    dr.GetInt32(0),
                    dr.GetDouble(1),
                    dr.GetDateTime(2)
                    );
            }
            cmd.Connection.Close();
            return estoque;
        }
        /*public static Estoque ObterPorIDString(string id)
        {
            Estoque estoque = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from estoques where produto_id = '{id}'";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                estoque = new(
                    dr.GetInt32(0),
                    dr.GetDouble(1),
                    dr.GetDateTime(2)
                    );
            }
            cmd.Connection.Close();
            return estoque;
        }*/
        public static List<Estoque> ObterPorLista()
        {
            List<Estoque> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from estoques order by produto_id";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                    dr.GetInt32(0),
                    dr.GetDouble(1),
                    dr.GetDateTime(2)
                    ));
            }
            cmd.Connection.Close();
            return lista;
        }
        /*public static List<Estoque> ObterProdutoPorLista(string? id = "")
        {
            List<Estoque> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (id == "")
            {
                cmd.CommandText = "Select * from estoques order by produto_id";
            }
            else
            {
                cmd.CommandText = $"Select * from estoques where produto_id like '%{id}%' order by produto_id";
            }
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                    dr.GetInt32(0),
                    dr.GetDouble(1),
                    dr.GetDateTime(2)
                    ));
            }
            cmd.Connection.Close();
            return lista;
        }*/
    }
}
