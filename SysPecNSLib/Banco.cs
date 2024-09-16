using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SysPecNSLib
{
    /// <summary>
    /// Classe estática que fornece métodos para manipulação de conexão com o banco de dados.
    /// </summary>
    public static class Banco
    {
        /// <summary>
        /// Método que abre uma conexão com o banco de dados e retorna um objeto MySqlCommand.
        /// </summary>
        /// <returns>Um objeto MySqlCommand que pode ser usado para executar comandos SQL na conexão informada.</returns>
        public static MySqlCommand Abrir()
        {
            // Dados da conexão
            string strconn = @"server=10.91.46.26;database=syspecdb;user=root;password=root";
            //string strconn = @"server=127.0.0.1;database=syspecdb;user=root;password=";

            // Criação da conexão e comando
            MySqlConnection cn = new MySqlConnection(strconn);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (MySqlException ex)
            {
                // Registrar ou tratar a exceção adequadamente
                Console.WriteLine("Erro ao conectar-se ao banco de dados: " + ex.Message);
                throw; // Re-levanta a exceção para que o chamador possa tratá-la
            }

            return cmd;
        }
    }
}
