using pryProductoCategoria.Controlador;
using pryProductoCategoria.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryProductoCategoria.Vista
{
    public partial class frmProductos : Form
    {

        private ControlProducto daoPro = new ControlProducto();
        public frmProductos()
        {
            InitializeComponent();
            
            Listar();
            Limpiar();

        }

        public void Listar()
        {
            TABLAPRODUCTOS.Rows.Clear();

            foreach(Producto x in daoPro.ListarProducto())
            {
                TABLAPRODUCTOS.Rows.Add(x.IdPro,x.NomPro,x.StockPro,x.PrecioPro,x.Categoria.IdCat,x.Categoria.NomCat,x.Categoria.EstadoCat);
            }
        }

        public void Limpiar()
        {
            txtIDpro.Text = "" + daoPro.RetornarCodigoProducto();
            txtProducto.Clear();
            txtStock.Value = 0;
            txtPrecio.Value = 0;

            txtIDcat.Clear();
            txtCategoria.Clear();
            txtEstadoCat.Clear();

            btnAgregar.Enabled=true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;

            TABLAPRODUCTOS.ClearSelection();

        }

        

        private void btnCategorias_Click(object sender, EventArgs e)
        {

            frmIndex vista=new frmIndex();
            vista.Show();
            this.Dispose();
            

        }

        private void btnSeleccionarCategoria_Click(object sender, EventArgs e)
        {
            frmSeleccionarCategoria vista = new frmSeleccionarCategoria();

            vista.Visible = true;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if(txtProducto.Text.Trim().Length <= 0) {
                Util.Mensajes.MsgAdvertencia("Producto vacío");
                return;
            }

            if(txtStock.Value < 0)
            {
                Util.Mensajes.MsgAdvertencia("Stock negativo");
                return;
            }
            if (txtPrecio.Value < 0)
            {
                Util.Mensajes.MsgAdvertencia("Precio negativo");
                return;
            }
            if (txtCategoria.Text.Trim().Length <= 0)
            {
                Util.Mensajes.MsgAdvertencia("::: Seleccionar categoria :::");
                return;
            }

            string producto = txtProducto.Text;
            int stock =(int) txtStock.Value;
            double precio =(double)txtPrecio.Value;
            int idCat = int.Parse(txtIDcat.Text);

            Categoria c = new Categoria();
            c.IdCat = idCat;
            Producto obj = new Producto();
            obj.NomPro = producto;
            obj.StockPro = stock;
            obj.PrecioPro = precio;
            obj.Categoria = c;

            int res = daoPro.AgregarProducto(obj);

            if (res > 0)
            {
                Util.Mensajes.MsgInformativo("Producto agregado correctamente");
            }
            else
            {
                Util.Mensajes.MsgError("Produto no se pudo agregar");
            }

            Listar();
            Limpiar();

        }

        private void TABLAPRODUCTOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int fila = e.RowIndex;

            txtIDpro.Text = TABLAPRODUCTOS.Rows[fila].Cells[0].Value.ToString();
            txtProducto.Text = TABLAPRODUCTOS.Rows[fila].Cells[1].Value.ToString();
            txtStock.Text = TABLAPRODUCTOS.Rows[fila].Cells[2].Value.ToString();
            txtPrecio.Text = TABLAPRODUCTOS.Rows[fila].Cells[3].Value.ToString();
            txtIDcat.Text = TABLAPRODUCTOS.Rows[fila].Cells[4].Value.ToString();
            txtCategoria.Text = TABLAPRODUCTOS.Rows[fila].Cells[5].Value.ToString();
            txtEstadoCat.Text = TABLAPRODUCTOS.Rows[fila].Cells[6].Value.ToString();

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (txtProducto.Text.Trim().Length <= 0)
            {
                Util.Mensajes.MsgAdvertencia("Producto vacío");
                return;
            }

            if (txtStock.Value < 0)
            {
                Util.Mensajes.MsgAdvertencia("Stock negativo");
                return;
            }
            if (txtPrecio.Value < 0)
            {
                Util.Mensajes.MsgAdvertencia("Precio negativo");
                return;
            }
            if (txtCategoria.Text.Trim().Length <= 0)
            {
                Util.Mensajes.MsgAdvertencia("::: Seleccionar categoria :::");
                return;
            }

            int idPro = int.Parse(txtIDpro.Text);
            string producto = txtProducto.Text;
            int stock = (int)txtStock.Value;
            double precio = (double)txtPrecio.Value;
            int idCat = int.Parse(txtIDcat.Text);

            Categoria c = new Categoria();
            c.IdCat = idCat;
            Producto obj = new Producto();
            obj.IdPro= idPro;
            obj.NomPro = producto;
            obj.StockPro = stock;
            obj.PrecioPro = precio;
            obj.Categoria = c;

            int res = daoPro.ActualizarProducto(obj);

            if (res > 0)
            {
                Util.Mensajes.MsgInformativo("Producto actualizado correctamente");
            }
            else
            {
                Util.Mensajes.MsgError("Produto no se pudo actualizar");
            }

            Listar();
            Limpiar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idPro=int.Parse(txtIDpro.Text);

            DialogResult resultado = Util.Mensajes.MsgSiNO("¿Seguro deseas eliminar el PRODUCTO "+txtProducto+"?");

            if(resultado == DialogResult.Yes)
            {
                int res = daoPro.EliminarProducto(idPro);

                if (res > 0)
                {
                    Util.Mensajes.MsgInformativo("Producto eliminado correctamente");
                }
                else
                {
                    Util.Mensajes.MsgError("Producto no se pudo eliminar");
                }
                Listar();
                Limpiar();
            }

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
