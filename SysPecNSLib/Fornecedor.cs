using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SysPecNSLib
{
    public class Fornecedor
    {
        //Declaração das Variaveis
        public int? Id { get; set; }
        public string? Razao_Social { get; set; }
        public string? Fantasia { get; set; }
        public string? Cnpj { get; set; }
        public string? Contato { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public Fornecedor? Categoria { get; set; }

        //Métodos Construtores
        public Fornecedor(int? id, string? razao_Social, string? fantasia, string? cnpj, string? contato, string? telefone, string? email)
        {
            Id = id;
            Razao_Social = razao_Social;
            Fantasia = fantasia;
            Cnpj = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }
        public Fornecedor(int? id, string? razao_Social, string? fantasia, string? cnpj, string? contato, string? telefone, string? email,Fornecedor? categoria)
        {
            Id = id;
            Razao_Social = razao_Social;
            Fantasia = fantasia;
            Cnpj = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
            Categoria = categoria;
        }
        public Fornecedor( string? razao_Social, string? fantasia, string? cnpj, string? contato, string? telefone, string? email)
        {
            Razao_Social = razao_Social;
            Fantasia = fantasia;
            Cnpj = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }
        public Fornecedor(string? razao_Social, string? fantasia, string? cnpj, string? contato, string? telefone, string? email,Fornecedor? categoria)
        {
            Razao_Social = razao_Social;
            Fantasia = fantasia;
            Cnpj = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
            Categoria = categoria;
        }
        public Fornecedor()
        {
            
        }

        //Criando as Funcionalidades
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fornecedores_insert";
            cmd.Parameters.AddWithValue("sprazao_social",Razao_Social);
            cmd.Parameters.AddWithValue("spfantasia", Fantasia);
            cmd.Parameters.AddWithValue("spcnpj", Cnpj);
            cmd.Parameters.AddWithValue("spcontato", Contato);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            Id = Convert.ToInt32( cmd.ExecuteScalar());
            
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("spid",Id);
            cmd.CommandText = "sp_fornecedores_update";
            cmd.Parameters.AddWithValue("sprazao_social", Razao_Social);
            cmd.Parameters.AddWithValue("spfantasia", Fantasia );
            cmd.Parameters.AddWithValue("spcnpj", Cnpj);
            cmd.Parameters.AddWithValue("spcontato", Contato);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.ExecuteNonQuery();
        }
        public static Fornecedor ObterPorID(int Id)
        {
            Fornecedor fornecedor = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"Select * from fornecedores where id = {Id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fornecedor = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6)
                    );
            }
            return fornecedor;
        }
        public static List<Fornecedor> ObterPorLista(string? Razao_Social)
        {
            List<Fornecedor> lista = new();
            var cmd = Banco.Abrir();
            if (Razao_Social == "")
            {
                cmd.CommandText = "Select * from fornecedores order by razao_social";
            }
            else
            {
                cmd.CommandText = $"Select * from fornecedores where razao_social like '%{Razao_Social}%' order by razao_social";
            }
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6)
                    ));
            }
            return lista;
        }

    }
}
