using pryProductoCategoria.Config;
using pryProductoCategoria.Controlador;
using pryProductoCategoria.Modelo;
using pryProductoCategoria.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryProductoCategoria
{
    public partial class frmIndex : Form
    {


        private ControlCategoria daoCat=new ControlCategoria();
        private int numProductos = 0;

        public frmIndex()
        {
            InitializeComponent();
            LLenarComboBox();
            Listar();
            Limpiar();
        }

        public void Listar()
        {
            TABLA.Rows.Clear();

                foreach (Categoria x in daoCat.ListarCategoria())
                {
                    TABLA.Rows.Add(x.IdCat, x.NomCat, x.EstadoCat, x.NumProductos);
                }
            
        }

        public void LLenarComboBox()
        {
            
            boxEstado.Items.Add(Util.Constantes.ESTADO_ACTIVO);
            boxEstado.Items.Add(Util.Constantes.ESTADO_INACTIVO);
            boxEstado.SelectedIndex= 0;
        }
        public void Limpiar()
        {

            txtID.Text=""+daoCat.RetornarCodigoCategoria();
            txtCategoria.Clear();
            boxEstado.SelectedIndex = 0;

            btnAgregar.Enabled=true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnVerProductos.Enabled = false;

            TABLA.ClearSelection();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtCategoria.Text.Trim().Length <= 0)
            {
                Util.Mensajes.MsgInformativo("Categoría vacío");
                return;
            }

            if(boxEstado.SelectedIndex== 0)
            {
                Util.Mensajes.MsgInformativo("::: Seleccionar estado :::");
                return;
            }

            string nombre = txtCategoria.Text;
            string estado=boxEstado.SelectedItem.ToString();

            Categoria c=new Categoria();
            c.NomCat=nombre;
            c.EstadoCat=estado;

            int res=daoCat.AgregarCategoria(c);

            if(res>0)
            {
                Util.Mensajes.MsgInformativo("Categoria agreado correctamente");
            }
            else
            {
                Util.Mensajes.MsgError("Categoria no se pudo agregar");
            }

            Listar();
            Limpiar();
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void TABLA_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int fila = e.RowIndex;

            txtID.Text = TABLA.Rows[fila].Cells[0].Value.ToString();
            txtCategoria.Text = TABLA.Rows[fila].Cells[1].Value.ToString();
            boxEstado.Text = TABLA.Rows[fila].Cells[2].Value.ToString();
            numProductos = int.Parse(TABLA.Rows[fila].Cells[3].Value.ToString());

            btnAgregar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnVerProductos.Enabled = true;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (numProductos > 0)
            {
                Util.Mensajes.MsgAdvertencia("No puedes eliminar una CATEGORIA que tiene productos registrados");
                return;
            }

            int idCat = int.Parse(txtID.Text);
            string nomCat = txtCategoria.Text;

            

            DialogResult resultado = Util.Mensajes.MsgSiNO("¿Estás seguro de eliminar la CATEGORIA "+nomCat+"?");

            if (resultado == DialogResult.Yes)
            {

                int res = daoCat.EliminarCategoria(idCat);

                if (res > 0)
                {
                    Util.Mensajes.MsgInformativo("Categoria eliminada correctamente");
                }
                else
                {
                    Util.Mensajes.MsgError("Categoria no se pudo eliminar");
                }

                Limpiar();
                Listar();

            }


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (txtCategoria.Text.Trim().Length <= 0)
            {
                Util.Mensajes.MsgInformativo("Categoría vacío");
                return;
            }

            if (boxEstado.SelectedIndex == 0)
            {
                Util.Mensajes.MsgInformativo("::: Seleccionar estado :::");
                return;
            }

            int idCat=int.Parse(txtID.Text);
            string nombre = txtCategoria.Text;
            string estado = boxEstado.SelectedItem.ToString();

            Categoria c = new Categoria();
            c.IdCat= idCat;
            c.NomCat = nombre;
            c.EstadoCat = estado;

            int res = daoCat.ActualizarCategoria(c);

            if (res > 0)
            {
                Util.Mensajes.MsgInformativo("Categoria actualizado correctamente");
            }
            else
            {
                Util.Mensajes.MsgError("Categoria no se pudo actualizar");
            }

            Listar();
            Limpiar();


        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {

            string mensaje = "";
            int idCat = int.Parse(txtID.Text);
            
            if(daoCat.BuscarProductos(idCat).Count() <= 0)
            {
                Util.Mensajes.MsgInformativo("La categoria seleccionada no tienen productos registrados");
                return;
            }

            foreach(Producto obj in daoCat.BuscarProductos(idCat))
            {
                mensaje += obj.IdPro +"\t"+ obj.NomPro + "\t" + obj.StockPro + "\t" + obj.PrecioPro + "\n";
            }

            Util.Mensajes.MsgInformativo(mensaje);


        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos vista = new frmProductos();
            vista.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
