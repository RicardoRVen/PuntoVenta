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
    public partial class UsrNumeros : UserControl
    {
        public UsrNumeros()
        {
            InitializeComponent();
        } 
        public bool bDecimal { get; set; }
        public Decimal  nValor { get; set; }
        public bool bColor { get; set; }

        private void txtNumero_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //48 a 57 numeros
            //08 back space
            //13 enter
            //46 es punto

            bool bPasa = false;

            if ((e.KeyChar >= 48 && e.KeyChar <= 57) ||
                (e.KeyChar == 13) ||
                   (e.KeyChar == 08) ||
                        (e.KeyChar == 46 && bDecimal))
            {
                bPasa = true;

            }
            if (!bPasa)
            {
                Mensajes.Error("Captura solo datos numericos");
                SendKeys.Send("{BS}");
            }

          
        
        }

       private  void txtNumero_TextChanged(object sender, EventArgs e)
        {
            try
            {

                nValor = Convert.ToDecimal(this.txtNumero.Text);

                this.txtNumero.BackColor = Color.White;
            }
            catch
            {
                nValor = 0;
            }



        }

       private void txtNumero_Enter(object sender, EventArgs e) 
       {
           if (bColor)
           {
               txtNumero.BackColor = Color.Beige;
           }


       }

       private void txtNumero_Leave(object sender, EventArgs e)
       {

          
           if (bColor)
           {
               txtNumero.BackColor = Color.White;
           }
       }
       public void LimpiarTex()
       {
           this.txtNumero.Text = "";
           this.nValor = 0;
       }

       private void UsrNumeros_Load(object sender, EventArgs e)
       {

       }
       public void Asigna(decimal nNumero)
       {
           this.txtNumero.Text = nNumero.ToString();
           this.nValor = nNumero; 
       }
    }
}
