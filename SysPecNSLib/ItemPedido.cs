using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SysPecNSLib
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public Produto Produto { get; set; }
        public double ValorUnit { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }

        public ItemPedido()
        {
          
        }

        public ItemPedido(int id, int idPedido, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            Id = id;
            IdPedido = idPedido;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public ItemPedido(int idPedido, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            IdPedido = idPedido;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        //sp_itempedido_insert`(sppedido_id int, spproduto_id int, spquantidade decimal (10,2), spdesconto decimal(10,2))

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_insert";
            cmd.Parameters.AddWithValue("sppedido_id",Id);
            cmd.Parameters.AddWithValue("spproduto_id", Produto.Id) ;
            cmd.Parameters.AddWithValue("spquantidade",Quantidade );
            cmd.Parameters.AddWithValue("spdesconto",Desconto );
            Id = Convert.ToInt32( cmd.ExecuteScalar());
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_update";
            cmd.Parameters.AddWithValue("sppedido_id", Id);
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);
            cmd.ExecuteNonQuery();
        }
        public static List<ItemPedido> ObterListaPorPedido(int id)
        {
            List<ItemPedido> Itens = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from itempedido where pedido_id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Itens.Add(new(
                    dr.GetInt32(0),
                    dr.GetInt32(1),
                    Produto.ObterPorId(dr.GetInt32(2)),
                    dr.GetDouble(3),
                    dr.GetDouble(4),
                    dr.GetDouble(5)
                    ));
            }
            return Itens;
        }

    }
}
