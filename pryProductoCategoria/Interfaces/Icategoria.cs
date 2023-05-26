using pryProductoCategoria.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryProductoCategoria.Interfaces
{
    public interface Icategoria
    {


        List<Categoria>ListarCategoria();
        int AgregarCategoria(Categoria c);
        int ActualizarCategoria(Categoria c);
        int EliminarCategoria(int id);
        int RetornarCodigoCategoria();

        List<Producto> BuscarProductos(int idCat);

    }
}
