using pryProductoCategoria.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryProductoCategoria.Interfaces
{
    public interface Iproducto
    {

        List<Producto> ListarProducto();
        int AgregarProducto(Producto p);
        int ActualizarProducto(Producto p);
        int EliminarProducto(int idPro);
        int RetornarCodigoProducto();

    }
}
