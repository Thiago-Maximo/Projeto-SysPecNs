using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SysPecNSLib
{
    public class Nivel
    {
        // iremos Ver atributos da Classe, propriedades, métodos construtores, métodos requisitos



        //propriedades
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }
        //Métodos de Acesso (get e set)
        //um jeito de criar um método de acesso: public int id { get => Id; set => Id = value; }

        //métodos construtores
        public Nivel() 
        {
        
        }

        public Nivel(string nome, string sigla) // Sobrecarga de de métodos, é preciso declarar métodos com parametros diferentes
        {
            Nome = nome;
            Sigla = sigla;
        }
        public Nivel(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        //métodos requisitos
        public void inserir() // método para inserir registro de nível na base de dados
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert niveis(nome,sigla) values('{Nome}','{Sigla}')";
            cmd.ExecuteNonQuery();
        }
        public static Nivel ObterPorId(int id)
        {
            Nivel nivel = new();
            //consulta do Banco e retornar o nível
             var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM syspecdb.niveis where id = {id};";
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                nivel.Id = dr.GetInt32(0);
                nivel.Nome = dr.GetString(1);
                nivel.Sigla = dr.GetString(2);
            }
            return nivel;
        }
        public static List<Nivel> ObterLista()
        {
            List<Nivel> lista = new();
            //consulta para retornar a lista de níveis
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from niveis";
            var dr =cmd.ExecuteReader();
            while (dr.Read())
            {
               lista.Add(new(dr.GetInt32(0),dr.GetString(1),dr.GetString(2)));
            }

            return lista;
        }
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update niveis" + $"set nome = '{Nome}','{Sigla} where id = {Id}";
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
        public void Excluir(int id)
        {

        }
    }
}
