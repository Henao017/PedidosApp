using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp
{
    //sealed evita que la clase sea heredada
    public sealed class RegistroPedidos
    {
        // registro peudido es un singleton, almacena una unica instancia de la clase
        private static RegistroPedidos _instancia;

        // Se usa para asegurarque solo un hilo a la vez acceda a la creacion de la instancia (Esto es util para entornos multihilos
        private static readonly object _lock = new object();

        //Lista de pedidos, solo pueden modificarse dentro de esta clase y guarda todos los pedidos a traves de una instancia
        public List<Pedido> Pedidos { get; private set; }

        // Constructor privado para evitar la instanciacion directa
        private RegistroPedidos() => Pedidos = new List<Pedido>();

        //Propiedad estática singleton 
        public static RegistroPedidos Instancia 
        {
            // enlazamos el singleton a la propiedad Instancia
            get
            {
                // lock significa que solo un hilo puede acceder a este bloque de código a la vez
                lock (_lock) 
                {
                    // si la instancia es nula, la creamos
                    if (_instancia == null) 
                    { 
                        _instancia = new RegistroPedidos();
                    }
                    return _instancia;
                }
            }

        }

        //Metodo para agregar pedidos
        public void AgregarPedido(Pedido pedido) 
        { 
            Pedidos.Add(pedido);
        }
    }
}
