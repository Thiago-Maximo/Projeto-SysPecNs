using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SysPecNSLib
{
    public class Usuario
    {
       // Variaveis
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public Nivel Nivel { get; set; }
        public bool Ativo { get; set; }

    // construttores
    public Usuario(int id, string? nome, string? email, string? senha,Nivel nivel, bool ativo)
     {
        Id = id;
        Nome = nome;
        Email = email;
        Senha = senha;
        Nivel = nivel;
        Ativo = ativo;
     }
    public Usuario( string? nome, string? email, string? senha,Nivel nivel, bool ativo)
     {
            
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
     }
    public Usuario(string? nome, string? email, string? senha,Nivel nivel)
     {
            
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            
     }
    public Usuario()
     {
            Nivel = new();
     }

        public void Inserir() // Inserir usuario
        {
            Banco.Abrir();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
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
        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4)),
                    dr.GetBoolean(5)
                    );

            }
            return usuario;
        }
        /// <summary>
        /// é possivel utilizar o if no lugar do while, while é mais utilizado para lista de informações
        /// </summary>
        /// <returns></returns>
        public static List<Usuario> ObterLista()
        {
            List<Usuario> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from usarios order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4)),
                    dr.GetBoolean(5)
                        )
                    );
            }
            return lista;
        }
        public static Usuario EfetuarLogin(string Email,string Senha)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where email = '{Email}' and senha = md5('{Senha}')";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4)),
                    dr.GetBoolean(5)
                    );
            }
            return usuario;
        }
        public void Atualizar()
        {
            // usuario podera atualizar o nome, senha, nivel, email...
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = $"sp_usuario_altera";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static void Arquivar(int id)
        {
            // Deixar o ativo do usuario para falso = Inativo no sistema
            var cmd = Banco.Abrir();
            cmd.CommandText = $"update usuarios set ativo = 0 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static void Restaurar(int id)
        {
            // Deixar o ativo do usuario pata verdadeiro = Ativo no sistema
            var cmd = Banco.Abrir();
            cmd.CommandText = $"update usuarios set ativo = 1 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}
