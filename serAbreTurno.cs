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
    public partial class serAbreTurno : Form
    {

        SqlCommand cmd;
        public serAbreTurno()
        {
            InitializeComponent();
        }

        private void serAbreTurno_Load(object sender, EventArgs e)
        {
            this.txtCaja.Text = Generales.sCaja.ToString(); 
            this.txtCajero.Text = Generales.sUsuario.ToString();


        }
          
        public void  GuardaTurno()
        {
        
            int sCaja =Generales.nCaja;
           int sCajero =Generales.nUsuario;
           int nMonInicial = Convert.ToInt16(usrMonto.nValor);
           
      string sTipo = "";
    
            if (rbtnPrimero.Checked)
           {
               sTipo = rbtnPrimero.Text;
           }
            else if (radioButton3.Checked)
            {
                sTipo = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                sTipo = radioButton4.Text;
            }
            else if (radioButton5.Checked)
            {
                sTipo = radioButton5.Text;
            }
         
      
            int nTurno = 0;
       
                
            cmd = new SqlCommand("SP_Registra_Turno", XSQL.gSqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pTurno = new SqlParameter("@nTurno", SqlDbType.Int);
            pTurno.Direction = ParameterDirection.InputOutput;
            pTurno.Value = nTurno;
            cmd.Parameters.Add(pTurno);
 
            

            SqlParameter pCaja = new SqlParameter("@nCaja", SqlDbType.Int);
            pCaja.Value = sCaja;
            cmd.Parameters.Add(pCaja);

            SqlParameter pCajero = new SqlParameter("@nCajero", SqlDbType.Int);
            pCajero.Value = sCajero;
            cmd.Parameters.Add(pCajero);

            SqlParameter pMinicial = new SqlParameter("@nMonto_ini", SqlDbType.Money);
            pMinicial.Value = nMonInicial;
            cmd.Parameters.Add(pMinicial);

     
            SqlParameter pTipo = new SqlParameter("@nTipo", SqlDbType.VarChar,20); 
            pTipo.Value = sTipo;
            cmd.Parameters.Add(pTipo);


       
            try
            {
                XSQL.gSqlCon.Open(); 
                cmd.ExecuteNonQuery();

                Generales.nTurno =( int) pTurno.Value;

                Mensajes.Aviso("Turno abierto con el folio " +Generales.nTurno.ToString());
                
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardaTurno();
           
            this.Close();
           


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}
