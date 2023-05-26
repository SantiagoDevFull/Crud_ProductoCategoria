using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryProductoCategoria.Util
{
    public class Mensajes
    {

        public static DialogResult MsgSiNO(string msg)
        {
            DialogResult resultado = MessageBox.Show(msg, "::: Escoja una opcion :::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return resultado;
        }

        public static void MsgInformativo(string msg)
        {
            MessageBox.Show(msg, "::: Mensaje informativo :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MsgError(string msg)
        {
            MessageBox.Show(msg, "::: Mensaje de error :::", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MsgAdvertencia(string msg)
        {
            MessageBox.Show(msg, "::: Mensaje de advertencia :::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
