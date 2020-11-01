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

     
    public partial class frmAcceso : Form
    {
          SqlCommand cmd;

         public int nVan=1;

         Encriptar_Desencriptar cifrar = new Encriptar_Desencriptar();
        public frmAcceso()
        { 
            InitializeComponent();
        }

        private void usrCerrar1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnRegUsuario_Click(object sender, EventArgs e)
        {
            frmRegistraUsuario freg = new frmRegistraUsuario();
            freg.Show();
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {
            XSQL.Leer_Cadena();

          
        }

        private void btnAceptar_Click(object sender, EventArgs e)

        {
          
            this.Accesar();

           
        }
            private void Accesar()
            {

             

                int nUsuario = Convert.ToInt16(this.usrNumUsuario.nValor);
                string sPass = this.txtContrasena.Text;
                bool bAcceso =false ;
                bool bAdmin =false ;

          
                cmd = new SqlCommand("SP_Valida_Usuario", XSQL.gSqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pFolio = new SqlParameter("@nUsuario", SqlDbType.Int);
                pFolio.Value = nUsuario;
                cmd.Parameters.Add(pFolio);

                SqlParameter pContrasena = new SqlParameter("@cPassword ", SqlDbType.VarChar, 50);
                pContrasena.Direction = ParameterDirection.InputOutput; 
                pContrasena.Value =cifrar.EncryptKey(sPass);
                cmd.Parameters.Add(pContrasena);

                SqlParameter sqlAdmin = new SqlParameter("@bAdmin", SqlDbType.Bit);
                 sqlAdmin.Direction = ParameterDirection.Output;
                sqlAdmin.Value = bAdmin;
                cmd.Parameters.Add(sqlAdmin);

                SqlParameter sqlAcceso = new SqlParameter("@bAcceso", SqlDbType.Bit);
                sqlAcceso.Direction = ParameterDirection.Output; 
                sqlAcceso.Value = bAcceso;
                cmd.Parameters.Add(sqlAcceso);

                SqlParameter pNombre = new SqlParameter("@cNombre", SqlDbType.VarChar, 50);
                pNombre.Direction = ParameterDirection.Output;
                pNombre.Value = "";
                cmd.Parameters.Add(pNombre);
                try
                {
                    XSQL.gSqlCon.Open();
                    cmd.ExecuteNonQuery();

               bAcceso=(bool)sqlAcceso.Value;
               bAdmin=(bool)sqlAdmin.Value;
               string sNombre = (string)pNombre.Value;

                    if (!bAcceso)
                    {
                        Mensajes.Error("Usuario y contraseña incorrecta" +nVan.ToString() + "/3");
                        
                        if (nVan ==3)
                        {
                            this.Dispose();
                            Application.Exit();
                        }else
                        {
                            nVan++;
                        }
                 
                    }else
                    {

                        Generales.nUsuario = nUsuario;
                        Generales.sUsuario = sNombre;
                        Generales.bAdmin = bAdmin;
                        Generales.sContrasena = cifrar.EncryptKey(sPass);

                     
                        Form1 Fmain = new Form1();
                           Fmain.Show();
                          
                           this.Hide();
                     
                           Mensajes.Aviso("Bienvenido   " + sNombre);
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

            private void lblserver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                frmConexion frconn = new frmConexion();
                frconn.ShowDialog();
            }

            private void groupBox2_Enter(object sender, EventArgs e)
            {

            }

      
    }
}
