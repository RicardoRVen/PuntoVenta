using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVenta
{
    public partial class Ser_CambiaContrasena : Form
    {
        public Ser_CambiaContrasena()
        {
            InitializeComponent();
        }
        public string sPass { get; set; }

        private void Ser_CambiaContrasena_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string sAnterior = txtAnterior.Text;
            string sActual = txtActual.Text;
            string sConfirma = txtNueva.Text;
            string sMensaje="";


            if (sAnterior != sPass)
            {
                sMensaje = "-No coincide el Pasword Anterior" + "\n";
            }
            if (sActual != sConfirma)
            {
                sMensaje =sMensaje + "-No coincide el Pasword Actual con la Confirmacion" + "\n";
            }
            if (string.IsNullOrEmpty(sMensaje))
            {
                sPass = this.txtActual.Text;
            }
            else
            {
                Mensajes.Error("No se modificara la clave de acceso por la(s) razon(es) " + "\n" + sMensaje);
            }
            this.Close();

        }
    }
}
