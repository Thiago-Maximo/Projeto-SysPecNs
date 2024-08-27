using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{//declaração das variaveis
    public class Endereco
    {
        public int Id { get; set; }
        public int? ClienteId { get; set; }
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero  { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public string? TipoEndereco { get; set; }


        //Métodos Construtores

        public Endereco()
        {
            Id = new();
        }
        public Endereco(int id,int? clienteId, string? cep, string? logradrouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipoEndereco)
        {
            Id = id;
            ClienteId = clienteId;
            Cep = cep;
            Logradouro = logradrouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }
        public void Inserir() // Inserir Endereco de cliente
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = $"sp_endereco_insert";
            cmd.Parameters.AddWithValue("spcliente_id",ClienteId );
            cmd.Parameters.AddWithValue("spcep",Cep );
            cmd.Parameters.AddWithValue("spnumero", Numero );
            cmd.Parameters.AddWithValue("spcomplemento",Complemento );
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo_endereco",TipoEndereco );

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
        }
        /// <summary>
        /// Obter por Id é um método estatico que retorna um objeto usuario completo baseado no id informado
        /// </summary>
        /// <param name="id">Id do Usuario Buscado </param>
        /// <returns>Objeto Usuario com todos os campos</returns>
        /// 
        public static Endereco ObterPorId(int Id)
        {
            Endereco endereco = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from enderecos where id = {Id}";
            return endereco;
        }

    }

}
