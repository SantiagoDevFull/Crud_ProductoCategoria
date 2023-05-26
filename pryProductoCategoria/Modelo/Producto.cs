using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryProductoCategoria.Modelo
{
    public class Producto
    {

        private int idPro;
        private string nomPro;
        private int stockPro;
        private double precioPro;
        private Categoria categoria;

        public Producto()
        {
        }

        public Producto(int idPro, string nomPro, int stockPro, double precioPro, Categoria categoria)
        {
            this.idPro = idPro;
            this.nomPro = nomPro;
            this.stockPro = stockPro;
            this.precioPro = precioPro;
            this.categoria = categoria;
        }

        public int IdPro { get => idPro; set => idPro = value; }
        public string NomPro { get => nomPro; set => nomPro = value; }
        public int StockPro { get => stockPro; set => stockPro = value; }
        public double PrecioPro { get => precioPro; set => precioPro = value; }
        public Categoria Categoria { get => categoria; set => categoria = value; }
    }
}
