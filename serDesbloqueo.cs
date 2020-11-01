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
    public partial class serDesbloqueo : Form
    {
        Encriptar_Desencriptar encri = new Encriptar_Desencriptar();
        public serDesbloqueo()
        {
            InitializeComponent();
        }

        private void serDesbloqueo_Load(object sender, EventArgs e)
        {

        }

        private void Desbloquear()
        {

         Generales.sContra =encri.EncryptKey( txtContrasena.Text);

   

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Desbloquear();

            this.Close();

        }
    }
}
