using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Nivel
    {
        // iremos Ver atributos da Classe, propriedades, métodos construtores, métodos requisitos

       

        //propriedades
            public int Id {  get; set; }
            public string? Nome { get; set; }
            public string? Sigla { get; set; }
        //Métodos de Acesso (get e set)
            //um jeito de criar um método de acesso: public int id { get => Id; set => Id = value; }

        //métodos construtores
        public Nivel() { }

        public Nivel(string nome, string sigla) // Sobrecarga de de métodos, é preciso declarar métodos com parametros diferentes
        {
            Nome = nome;
        }
        //métodos requisitos
        public void inserir() // método para inserir registro de nível na base de dados
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert niveis(id,nome,sigla) values({Nome},{Sigla})";
            cmd.ExecuteNonQuery();
        }
        public static Nivel ObterPorId(int id)
        {
            Nivel nivel = new();
            //consulta do Banco e retornar o nível
            return nivel;
        }
        public static List<Nivel>ObterLista()
        {
            List<Nivel> lista = new();
            //consulta para retornar a lista de níveis
            return lista;
        }
        public bool Atualizar()
        {
            return true;
        }
        public void ExcluirNivel(int id)
        {

        }
    }
}
