using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVenta
{
    public partial class UsrCerrar : UserControl
    {
        public UsrCerrar()
        {
            InitializeComponent();
        }
        public  string sTexto { get; set; }
        public  bool bPregunta { get; set; } 
        private void UsrCerrar_Load(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(sTexto))
            {
                sTexto = "Cerrar";
            }
            this.btnCerrar.Text = sTexto;

            }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (bPregunta)
            {
                if (Mensajes.Pregunta("Deseas  " + sTexto +  " " + "?"))

                this.ParentForm.Close();
            }
            else
            {
                this.ParentForm.Close();
            }
        }
    }
}
