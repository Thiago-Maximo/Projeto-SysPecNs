using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SysPecNSLib
{
    /// <summary>
    /// Classe estatica (Não precisa de declaração de instancia) de Conexão de Banco de Dados
    /// </summary>
    public static class Banco //Classe de conexão de banco de dados
    
    {
        /// <summary>
        /// Método abrir da classe Banco utilizado para representar comnados sql
        /// no servidor, cujo os dados foram informados na string de conexão (strcon)
        /// </summary>
        /// <returns>Entrega um objeto de comandos SQL, que serão exexutados na conexão informada</returns>
        public static MySqlCommand Abrir() //método de conexão
        {
            //dados da conexão
            string strconn = @"server=127.0.0.1;database=syspecdb;user=root;password";
            MySqlConnection cn = new MySqlConnection(strconn);
            MySqlCommand cmd = new();
            try //tratamento de conexão
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (Exception) 
            {
                throw;
            }
            return cmd;
            
        }
    }
}
