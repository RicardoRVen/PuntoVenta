using System;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace PuntoVenta
{
    public partial class frmConexion : Form
    {
        public frmConexion()
        {
            InitializeComponent();
        }

        private void frmConexion_Load(object sender, EventArgs e)
        {

            //este codigo se encarga de leer el archivo de txt Datos de la clase cadena
            StreamReader reader = cadena.Leer_datos(); 

            string sServidor = reader.ReadLine();
            string sBD = reader.ReadLine();
            string sAut = reader.ReadLine();
            string sUsuario = reader.ReadLine();


            reader.Close();

            this.txtServidor.Text = sServidor;
            this.txtBD.Text = sBD;
            this.txtUsuario.Text = sUsuario;
            this.chkAutWin.Checked = Convert.ToBoolean(sAut);
            this.ConfigConexion();
        }

        private void ConfigConexion()
        {
            Boolean bLimpiar = this.chkAutWin.Checked;
            if (bLimpiar)
            {
                txtPassword.Text = "";
                txtUsuario.Text = "";
            }
            //metodo que oculta los controles de usuario y password
            this.lblPass.Enabled = !this.chkAutWin.Checked;
            this.lblUser.Enabled = !this.chkAutWin.Checked;
            this.txtUsuario.Enabled = !this.chkAutWin.Checked;
            this.txtPassword.Enabled = !this.chkAutWin.Checked;

        }
        private void chkAutWin_CheckedChanged_1(object sender, EventArgs e)
        {
            this.ConfigConexion();
        }
        string sCadena = "";

        //metodo que se encarga de hacer la conexion al servidor
        private void Conectar()
        {
            //clase que hace la conexion a la base de datos
            Boolean bAutenticacion_W = this.chkAutWin.Checked;
            string sServidor = txtServidor.Text;
            string sBD = txtBD.Text;
            string sUsuario = txtUsuario.Text;
            string sPassword = txtPassword.Text;
            if (bAutenticacion_W)

            {
                //cadena de conexion con seguridad integrada
                sCadena = "Data Source= " + sServidor + "; Initial Catalog =" + sBD + ";Integrated Security=true;";

            }
            else
            {
                //cadena de conexion con usuario especifico
                sCadena = "Data Source= " + sServidor + "; Initial Catalog =" + sBD + ";User Id=" + sUsuario + ";Password=" + sPassword + ";";

            }
            //se hace instancia a la clase de la conexion

         
         
           XSQL.SQLcon = new SqlConnection(sCadena);
          
            try
            {
                XSQL.SQLcon.Open();
                //llamada a la clase mensaje
                Mensajes.Aviso("Conexion exitosa");

                XSQL.SQLcon.Close();

                // genera la cadena de conexion en un archivo de texto
                cadena.Escribe_datos(sServidor, sBD, Convert.ToString(bAutenticacion_W), sUsuario);
            }
            catch (Exception ex)
            {
                Mensajes.Error("Ha ocurrido un error en el sistema " + ex.Message);
            }
    
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            this.Conectar();
          
        }

        
    }
}
