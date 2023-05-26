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
    public partial class frmSeleccionarCategoria : Form
    {

        
        ControlCategoria daoCat = new ControlCategoria();
        public frmSeleccionarCategoria()
        {
            InitializeComponent();
            Listar();
        }

        public void Listar()
        {
            TABLASELECCIONARCATEGORIA.Rows.Clear();

            foreach(Categoria x in daoCat.ListarCategoria())
            {
                TABLASELECCIONARCATEGORIA.Rows.Add(x.IdCat, x.NomCat, x.EstadoCat);
            }
            TABLASELECCIONARCATEGORIA.ClearSelection();
        }

        private void TABLASELECCIONARCATEGORIA_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int fila = e.RowIndex;

            TXTIDCAT.Text = TABLASELECCIONARCATEGORIA.Rows[fila].Cells[0].Value.ToString();
            TXTCATEGORIA.Text = TABLASELECCIONARCATEGORIA.Rows[fila].Cells[1].Value.ToString();
            TXTESTADO.Text = TABLASELECCIONARCATEGORIA.Rows[fila].Cells[2].Value.ToString();

            btnSeleccionar.Enabled = true;
            

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

            if (TXTESTADO.Text.Equals("INACTIVO", StringComparison.OrdinalIgnoreCase))
            {
                Util.Mensajes.MsgInformativo("::: Seleccione una categoria Activo :::");
                return;
            }

            frmProductos.txtIDcat.Text = TXTIDCAT.Text;
            frmProductos.txtCategoria.Text= TXTCATEGORIA.Text;
            frmProductos.txtEstadoCat.Text= TXTESTADO.Text;

            this.Dispose();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {

            TABLASELECCIONARCATEGORIA.Rows.Clear();

            foreach (Categoria obj in daoCat.ListarCategoria())
            {
                if((obj.NomCat.ToUpper().Contains(txtFiltrar.Text.ToUpper()) || obj.EstadoCat.ToUpper().Contains(txtFiltrar.Text.ToUpper())))
                {
                    TABLASELECCIONARCATEGORIA.Rows.Add(obj.IdCat,obj.NomCat,obj.EstadoCat);
                    TABLASELECCIONARCATEGORIA.ClearSelection();
                }
            }
            
            

        }
    }
}
