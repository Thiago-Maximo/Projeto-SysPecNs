using SysPecNSLib;
using System.Data;

internal static class EnderecoHelpers
{
    /// <summary>
    /// Obter por Id é um método estatico que retorna um objeto usuario completo baseado no id informado
    /// </summary>
    /// <param name="id">Id do Usuario Buscado </param>
    /// <returns>Objeto Usuario com todos os campos</returns>
    public static Endereco ObterPorId(int Id)
    {
        Endereco endereco = new();
        var cmd = Banco.Abrir();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = $"Select * from enderecos where id = {Id}";
    }
}