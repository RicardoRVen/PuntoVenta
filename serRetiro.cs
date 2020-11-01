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
    public partial class serRetiro : Form
    {
        SqlCommand cmd;
        public serRetiro()
        {
            InitializeComponent();
        }

        private void serRetiro_Load(object sender, EventArgs e)
        {
            lblturno.Text = Convert.ToString(Generales.nTurno);
            this.txtCajero.Text = Generales.sUsuario.ToString();
            this.Carga_ComboUsuario();
        }

        private void Carga_ComboUsuario() 
        {

            try
            {
                //Query a la base de datos  producto
                string sComando = "SP_Carga_ComboUsuario";

                SqlCommand sqlCom = new SqlCommand(sComando, XSQL.gSqlCon);

                SqlDataAdapter adProd = new SqlDataAdapter(sComando, XSQL.gSqlCon);

                // Este metodo se encarga de llenar el combobox 
                DataSet dsProd = new DataSet();
                adProd.Fill(dsProd);
                cbxUsuario.DataSource = dsProd.Tables[0];
                cbxUsuario.DisplayMember = "nombre";
                cbxUsuario.ValueMember = "id_usuario";
                sqlCom.Dispose();
            }
            catch (Exception ex)
            {
                Mensajes.Error("Ha ocurrido un error en el sistema" + ex.Message);
            }
            finally
            {
                XSQL.gSqlCon.Close();
            }

        }
        public void GuardaRetiro()
        {
             
            int sCaja = Generales.nCaja;
            int sCajero = Generales.nUsuario;
            int nMonInicial = Convert.ToInt16(usrMonto.nValor);
            string sConcepto = txtConcepto.Text;

            string sTipo = "";

            if (rbtnPrimero.Checked)
            {
                sTipo = rbtnPrimero.Text;
            }
            else if (radioButton3.Checked)
            {
                sTipo = radioButton3.Text;
            }
            else if (radioButton1.Checked)
            {
                sTipo = radioButton1.Text;
            }
            


            int nTurno = Generales.nCaja;

            if (usrMonto.nValor == 0)
            {
                Mensajes.Aviso("Ingresa la cantidad a retirar");

                this.usrMonto.txtNumero.BackColor = Color.Red;
            }
            else {
                cmd = new SqlCommand("SP_Registra_Retiro", XSQL.gSqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pTurno = new SqlParameter("@nTurno", SqlDbType.Int);
            //pTurno.Direction = ParameterDirection.InputOutput;
            pTurno.Value = nTurno;
            cmd.Parameters.Add(pTurno);



            SqlParameter pCaja = new SqlParameter("@nCaja", SqlDbType.Int);
            pCaja.Value = sCaja;
            cmd.Parameters.Add(pCaja);

            SqlParameter pCajero = new SqlParameter("@nCajero", SqlDbType.Int);
            pCajero.Value = sCajero;
            cmd.Parameters.Add(pCajero);


            SqlParameter pUsuario = new SqlParameter("@idSupervisor", SqlDbType.VarChar, 50);
            pUsuario.Value = cbxUsuario.SelectedValue;
            cmd.Parameters.Add(pUsuario);


            SqlParameter pMinicial = new SqlParameter("@nImporte", SqlDbType.Money);
            pMinicial.Value = nMonInicial;
            cmd.Parameters.Add(pMinicial);

            SqlParameter pConcepto = new SqlParameter("@nConcepto", SqlDbType.VarChar, 50);
            pConcepto.Value = sConcepto;
            cmd.Parameters.Add(pConcepto);

            SqlParameter pTipo = new SqlParameter("@nTipo", SqlDbType.VarChar, 20);
            pTipo.Value = sTipo;
            cmd.Parameters.Add(pTipo);

            SqlParameter pidTurno = new SqlParameter("@nIdturno", SqlDbType.Int);
            pidTurno.Value =Generales.nTurno;
            cmd.Parameters.Add(pidTurno);


            try
            {
                XSQL.gSqlCon.Open();
                cmd.ExecuteNonQuery();

              //  Generales.nTurno = (int)pTurno.Value;

                Mensajes.Aviso("Registro guardado Satisfactoriamente " );
            }
            catch (Exception ex)
            {
                Mensajes.Error("A ocurrido un error en el sistema, " + ex.Message);
            }
            finally
            {
                XSQL.gSqlCon.Close();
            }
            this.Close();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
      
            this.GuardaRetiro();
        }
    }
}
