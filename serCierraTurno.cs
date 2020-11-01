using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PuntoVenta
{
    public partial class serCierraTurno : Form
    {
        SqlCommand cmd;
        public serCierraTurno()
        {
            InitializeComponent();
           
        }

        private void serCierraTurno_Load(object sender, EventArgs e)
        {
             lblturno.Text = Convert.ToString( Generales.nTurno);
            this.txtCajero.Text = Generales.sUsuario.ToString();
        }

        public void CierraTurno() 
        {
            
            int nTurno= Generales.nTurno;
            
            int nMonFinal = Convert.ToInt16(usrMontoFin.nValor);

            string sEstado = "";

            if (rbtnPrimero.Checked)
            {
                sEstado = rbtnPrimero.Text;
            }
            else if (radioButton3.Checked)
            {
                sEstado = radioButton3.Text;
            }


            if (sEstado == "Definitivo" & usrMontoFin.nValor==0 )
            {

                this.usrMontoFin.txtNumero.BackColor = Color.Red;

                Mensajes.Aviso("Captura  el monto final");

            }
            else { 
            


            cmd = new SqlCommand("SP_Cierra_Turno", XSQL.gSqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pTurno = new SqlParameter("@nTurno", SqlDbType.Int);
            pTurno.Direction = ParameterDirection.InputOutput;
            pTurno.Value = nTurno;
            cmd.Parameters.Add(pTurno);



            SqlParameter pEstado = new SqlParameter("@sEstado", SqlDbType.VarChar, 50);
            pEstado.Value = sEstado;
            cmd.Parameters.Add(pEstado);

      

            SqlParameter pMonFinal = new SqlParameter("@nMonto_Fin", SqlDbType.Money);
            pMonFinal.Value = nMonFinal;
            cmd.Parameters.Add(pMonFinal);


            

            try
            {
                XSQL.gSqlCon.Open();
                cmd.ExecuteNonQuery();

                nTurno = (int)pTurno.Value;

                if (sEstado == "Temporal") {
                    Mensajes.Aviso("Turno cerrado Temporalmente con el folio " + nTurno.ToString());
                    this.Close();
                }
                else { 

                Mensajes.Aviso("Turno cerrado Definitivamente con el folio " + nTurno.ToString());
                this.Close();
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error("A ocurrido un error en el sistema, " + ex.Message);
            }
            finally
            {
                XSQL.gSqlCon.Close();
            }
            }
           
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.CierraTurno();
           
        }

      
    }
}
