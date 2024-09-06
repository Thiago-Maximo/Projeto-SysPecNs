using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SysPecNSLib
{
    public class Pedido
    {
       
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }
        public List<ItemPedido> Itens { get; set; }

        public Pedido()
        {

        }
        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime data, string status, double desconto)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
        }
        public Pedido(Usuario usuario, Cliente cliente, DateTime data, string status, double desconto)
        {
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
        }
        public Pedido( Usuario usuario, Cliente cliente, DateTime data, double desconto)
        {
 
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Desconto = desconto;
        }
        public Pedido( Usuario usuario, Cliente cliente, double desconto)
        {
            Usuario = usuario;
            Cliente = cliente;
            Desconto = desconto;
        }
        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime data, string status, double desconto,List<ItemPedido>itens)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
            Itens = itens;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_insert";
            cmd.Parameters.AddWithValue("spusuario_id",Usuario.Id);
            cmd.Parameters.AddWithValue("spcliente_id",Cliente.Id);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public void Alterar()
        {

        }
        public static Pedido ObterPorID(int id)
        {
            Pedido pedido = new();

            return pedido;
        }
        public static List<Pedido> ObterLista(int id)
        {
            List<Pedido> pedidos = new();

            return pedidos;
        }
        public static List<Pedido> ObterListaPorCliente(int IdCliente=0,int IdUsuario=0)
        {
            List<Pedido> pedidos = new();
               
            return pedidos;
        }
    }
}
