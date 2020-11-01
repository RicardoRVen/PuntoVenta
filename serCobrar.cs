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
    public partial class serCobrar : Form
    {
        public serCobrar()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void serCobrar_Load(object sender, EventArgs e)
        {
            this.txtTotal.Text  = Convert.ToString(Generales.TotalVenta);
            this.txtPago.Text = "0";
         
        }


        private void CalcularCambio()
        {
            try { 
            decimal NUM1 = decimal.Parse(txtPago.Text);
            decimal NUM2 = decimal.Parse(txtTotal.Text);
              
            decimal resta;
            resta = NUM1-NUM2;
            this.txtCambio.Text = resta.ToString();

            Generales.Cambio = resta;
            }
            catch
            {

            }
        }

        private void usrNumeros1_Validated(object sender, EventArgs e)
        {
            this.CalcularCambio();
        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                } 

        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            this.CalcularCambio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

       

  


    }
}
