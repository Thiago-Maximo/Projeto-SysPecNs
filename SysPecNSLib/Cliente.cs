
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{// declaração de variaveis
    public class Cliente
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public DateTime? DataNasc { get; set; }
        public DateTime? DataCad { get; set; }
        public bool? Ativo { get; set; }

    // métodos contrutores
        public Cliente()
        {

        }
        public Cliente(int? id, string? nome, string? cpf, string? telefone, string? email, DateTime? datanasc,DateTime? datacad, bool? ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = datanasc;
            DataCad = datacad;
            Ativo = ativo;
        }
        public Cliente( string? nome, string? cpf, string? telefone, string? email, DateTime? datanasc, DateTime? datacad, bool? ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = datanasc;
            DataCad = datacad;
            Ativo = ativo;
        }
        public Cliente( string? nome, string? cpf, string? telefone, string? email, DateTime? datanasc, DateTime? datacad)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = datanasc;
            DataCad = datacad;
        }
        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime? datanasc)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = datanasc;
        }

        public void Inserir() // Inserir cadastro de cliente
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue  ("spnome",Nome);
            cmd.Parameters.AddWithValue  ("spcpf", Cpf);
            cmd.Parameters.AddWithValue  ("sptelefone", Telefone);
            cmd.Parameters.AddWithValue  ("spemail",Email);
            cmd.Parameters.AddWithValue  ("spdatanasc",DataNasc);
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
        }
        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from clientes where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cliente = new(
                   dr.GetInt32(0),
                   dr.GetString(1),
                   dr.GetString(2),
                   dr.GetString(3),
                   dr.GetString(4),
                   dr.GetDateTime(5),
                   dr.GetDateTime(6),
                   dr.GetBoolean(7)
                    );
            }
            return cliente;
        }
        public static List<Cliente> ObterPorLista(string? nome = "")
        {
            List<Cliente> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (nome == "")
            {
                cmd.CommandText = "Select * from clientes order by nome";
            }
            else
            {
                cmd.CommandText = $"Select * from clientes where nome like '%{nome}%' order by nome";
            }

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                   dr.GetInt32(0),
                   dr.GetString(1),
                   dr.GetString(2),
                   dr.GetString(3),
                   dr.GetString(4),
                   dr.GetDateTime(5),
                   dr.GetDateTime(6),
                   dr.GetBoolean(7)
                        )
                    );
            }
            return lista;
        }
        public static Cliente ConsultaPedido(string? email,string? cpf)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"SELECT itempedido.id AS itempedido_id, itempedido.pedido_id, pedidos.cliente_id, clientes.id AS cliente_id, clientes.nome FROM itempedido INNER JOIN pedidos ON itempedido.pedido_id = pedidos.id INNER JOIN clientes ON pedidos.cliente_id = clientes.id;";
            return cliente;
        }
        public void Atualizar()
        {
            // cliente podera alterar seus dados
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
            cmd.Parameters.AddWithValue("spid",Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("sptelefone",Telefone);
            cmd.Parameters.AddWithValue("spdatanasc", DataNasc);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static void Arquivar(int Id)
        {
            //deixar o ativo do cliente para falso = Inativo no sistema
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update clientes set ativo = 0 where id {Id}";
            cmd.Connection.Close();
        }
        public static void Restaurar(int Id)
        {
            // restaurando o ativo do cliente ativo = Ativo no sistema
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update cliente set ativo = 1 where id = {Id}";
            cmd.Connection.Close();
        }
    }
}
