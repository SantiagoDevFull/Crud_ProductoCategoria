using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryProductoCategoria.Modelo
{
    public class Categoria
    {

        private int idCat;
        private string nomCat;
        private string estadoCat;
        private int numProductos;

        public Categoria()
        {
        }

        public Categoria(int idCat, string nomCat, string estadoCat)
        {
            this.idCat = idCat;
            this.nomCat = nomCat;
            this.estadoCat = estadoCat;
        }

        public int IdCat { get => idCat; set => idCat = value; }
        public string NomCat { get => nomCat; set => nomCat = value; }
        public string EstadoCat { get => estadoCat; set => estadoCat = value; }

        public int NumProductos { get => numProductos;set=> numProductos = value; }
    }
}
