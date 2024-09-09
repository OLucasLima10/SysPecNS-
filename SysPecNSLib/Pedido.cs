using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Pedido(Usuario usuario, Cliente cliente, DateTime data, string status, double desconto)
        {
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
        }
        public Pedido( Usuario usuario, Cliente cliente, double desconto)
        {
            Usuario = usuario;
            Cliente = cliente;
            Desconto = desconto;
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
        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime data, string status, double desconto, List<ItemPedido> itens)
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
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_insert";
            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id);
            cmd.Parameters.AddWithValue("spusuario_id", Usuario.Id);
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }
        public void AlterarStatus() 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update pedidos set status = {Status} where id = {Id}";
            cmd.ExecuteNonQuery();

        }
        public void AtualizarDesconto()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update pedidos set desconto = {Desconto} where id = {Id}";
            cmd.ExecuteNonQuery();
        }
        public static Pedido ObterPorId(int id) 
        {
            Pedido pedido = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from pedidos where id = {id}";
            var dr = cmd.ExecuteReader();
            // retorna 1 registro ou nenhum registro
            if (dr.Read())
            {
                pedido = new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetDouble(5)
                    //[Incluir Lista de Itens]
                     ,ItemPedido.ObterListaPorPedido(dr.GetInt32(0))
                     );
            }

            return pedido;
        }
        public static List<Pedido> ObterLista()
        {
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from pedidos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(
                    new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetDouble(5)
                     //[Incluir Lista de Itens]
                      ,ItemPedido.ObterListaPorPedido(dr.GetInt32(0))
                     )
                    );
            }
            return pedidos;
        }
        /// <summary>
        /// Este ... por id de cliente...
        /// </summary>
        /// <param name="id">id do cliente</param>
        /// <returns>lista de pedidos do cliente informado, caso haja.</returns>
        public static List<Pedido> ObterListaPorCLiente(int id)
        {
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from pedidos where cliente_id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(
                    new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetDouble(5)
                     //[Incluir Lista de Itens]
                      ,ItemPedido.ObterListaPorPedido(dr.GetInt32(0))
                     )
                    );
            }
            return pedidos;
        }
        public static List<Pedido> ObterListaPorUsuario(int id)
        {
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from pedidos where usuario_id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(
                    new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetDouble(5)
                     //[Incluir Lista de Itens]
                     // ,ItemPedido.ObterListaPorPedido(dr.GetInt32(0))
                     )
                    );
            }
            return pedidos;
        }

    }
}
