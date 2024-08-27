using System;
using System.Collections.Generic;
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

    // métodos contrutores
        public Cliente()
        {

        }
        public Cliente(int? id, string? nome, string? cpf, string? telefone, string? email, DateTime? datanasc,DateTime? datacad)
        {

        }
        public Cliente(int id)
        {

        }
    }
}
