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
using System.IO;
namespace PuntoVenta
{
    public partial class frmUsuarios : Form
    {
        SqlCommand cmd;
       
        Encriptar_Desencriptar cifrar = new Encriptar_Desencriptar();
        bool pasa = true;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            this.ListaBusqueda();
            XSQL.Leer_Cadena();
            this.usrNumFolio.txtNumero.Text = "0";
            this.ControlaControles(false);
        }
        #region Metodos
        private void LimpiaDatos()
        {

            this.usrNumFolio.txtNumero.Text = "0";
            this.txtNombre.Text = "";
            this.txtContrasena.Text = "";
            this.txtConfContrasena.Text = "";
            this.cbxEstatus.Text = "Activo";
            this.chkEsAdmin.Checked = false;

            this.usrNumFolio.txtNumero.Focus();
        }

        private void Nuevo()
        {
            this.LimpiaDatos();
            //this.ControlaControles(true);

            this.txtNombre.Focus();
        }
        private void ControlaControles(bool bPrende)
        {
           this.usrNumFolio.txtNumero.Enabled = bPrende;
            //this.txtFolio.Enabled = !bPrende;
            this.txtNombre.Enabled = bPrende;
            this.txtContrasena.Enabled = bPrende;
            this.txtConfContrasena.Enabled = bPrende;
            this.cbxEstatus.Enabled = bPrende;
            this.chkEsAdmin.Enabled = bPrende;

            this.btnDeshacer.Enabled = bPrende;
            this.btnGuardar.Enabled = bPrende;
            this.btnEliminar.Enabled = !bPrende;          
            this.btnNuevo.Enabled =! bPrende;
            this.btnModificar.Enabled = !bPrende;
            this.btnCrear.Enabled= bPrende;
            this.bntCambiar.Enabled = bPrende;

         
        }

        private bool PasaValidaciones()
        {

            string sMensaje = "";
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtContrasena.Text) || string.IsNullOrEmpty(txtConfContrasena.Text)) 
            {
              

                Mensajes.Error("Llena los campos mandatorios");

                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    txtNombre.BackColor = Color.Red;
                }
                if (string.IsNullOrEmpty(txtContrasena.Text))
                {
                    txtContrasena.BackColor = Color.Red;
                }
                if (string.IsNullOrEmpty(txtConfContrasena.Text))
                {
                    txtConfContrasena.BackColor = Color.Red;
                }
                pasa = false;
            }
                
            else{
                

            if (txtContrasena.Text != txtConfContrasena.Text)
            {
                sMensaje = sMensaje + " -El password no coincide \n";

                txtContrasena.BackColor = Color.Red;
                txtConfContrasena.BackColor = Color.Red;

            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                sMensaje = sMensaje + " -Nombre vacio \n";
                txtNombre.BackColor = Color.Red;
            }

            if (string.IsNullOrEmpty(sMensaje))
            {
                pasa = true;
            }
            else
            {
                pasa = false;
                Mensajes.Error("Se presentaron los siguientes mensajes: \n" + sMensaje);
            }
            
              }
            return pasa; 
            
      }      
        
 
        private void Carga_Usuario()
        {
       
            string comando = "SP_Carga_Usuario";
            SqlCommand sp = new SqlCommand(comando, XSQL.gSqlCon);
            sp.CommandType = CommandType.StoredProcedure;

            SqlParameter pFolio = new SqlParameter("@nidusuario", SqlDbType.Int);
            pFolio.Value = Convert.ToDecimal(usrNumFolio.nValor);
            sp.Parameters.Add(pFolio);
            try { 
            XSQL.gSqlCon.Open();
            SqlDataReader dr = sp.ExecuteReader();
            if (dr.Read())
            {
                string contra;
                //string contraconf; 
                this.txtNombre.Text = dr[1].ToString();
                this.cbxEstatus.Text = dr[2].ToString();
                this.chkEsAdmin.Checked = Convert.ToBoolean(dr[3]);
               contra= dr[4].ToString();
              // contraconf = dr[4].ToString();
                dr.Close();

                this.txtContrasena.Text = cifrar.DecryptKey(contra);
                this.txtConfContrasena.Text = cifrar.DecryptKey(contra);


            }
            }
            catch (Exception ex)
            {
                Mensajes.Error("se presento un error"+ex.Message);
            }
            finally
            {
                XSQL.gSqlCon.Close();
            }


            
        }

        private void ListaBusqueda()
        {
            SqlCommand sqlCom = new SqlCommand("SP_Regresa_Usuario", XSQL.gSqlCon);

            sqlCom.CommandType = CommandType.StoredProcedure;
             SqlDataAdapter daplat = new SqlDataAdapter(sqlCom);
                DataSet dsPlat = new DataSet();
                daplat.Fill(dsPlat, "Usuario");
                dtgvUsuario.DataSource = dsPlat.Tables[0];

              
        }
        private void Guardar()
        {
            int nFolio = Convert.ToInt16(usrNumFolio.nValor);
            string sNombre = txtNombre.Text;
            string sPassword =cifrar .EncryptKey ( txtContrasena.Text);
            string sStatus = cbxEstatus.Text;
            bool sAdmin = chkEsAdmin.Checked;

    
            
                
            cmd = new SqlCommand("SP_Inserta_usuario", XSQL.gSqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pFolio = new SqlParameter("@nId", SqlDbType.Int);
            pFolio.Direction = ParameterDirection.InputOutput;
            pFolio.Value = nFolio;
            cmd.Parameters.Add(pFolio);

            SqlParameter pNombre = new SqlParameter("@cNombre", SqlDbType.VarChar, 50);
            pNombre.Value = sNombre;
            cmd.Parameters.Add(pNombre);

            SqlParameter pPwd = new SqlParameter("@cContrasena", SqlDbType.VarChar, 400);
            pPwd.Value = sPassword;
            cmd.Parameters.Add(pPwd);

            SqlParameter pEstatus = new SqlParameter("@cEstatus", SqlDbType.VarChar, 20);
            pEstatus.Value = sStatus;
            cmd.Parameters.Add(pEstatus);

            SqlParameter pEs_admin = new SqlParameter("@bEs_Administrador", SqlDbType.Bit);
            pEs_admin.Value = sAdmin;
            cmd.Parameters.Add(pEs_admin);

            try
            {
                XSQL.gSqlCon.Open(); 
                cmd.ExecuteNonQuery();

                nFolio = (int)pFolio.Value;

                Mensajes.Aviso("Registro guardado con el folio: " + nFolio.ToString());
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

        
        #endregion

        #region Eventos
        

        
        private void Eliminar()
        {
            int nId = Convert.ToInt16(usrNumFolio.nValor);
         

            cmd = new SqlCommand("SP_Borra_Usuario", XSQL.gSqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pFolio = new SqlParameter("@idusuario", SqlDbType.Int);
            pFolio.Value = nId;
            cmd.Parameters.Add(pFolio);

            try
            {
                XSQL.gSqlCon.Open();
                cmd.ExecuteNonQuery();


                this.LimpiaDatos();

                Mensajes.Aviso("Registro Eliminado con el folio: " + nId.ToString());
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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Mensajes.Pregunta("Estas seguro que deseas eliminar el registro?"))
            {
                if (usrNumFolio.nValor > 0) { 
                this.Eliminar();

                this.LimpiaDatos();
                }
                else
                {
                   
                }
            }
        }

        

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
           // this.ControlaControles(true);
        
            this.PasaValidaciones();
            if (pasa == true) { 
                        this.Guardar();
                        this.LimpiaDatos();

            }
        }

        private void usrNumeros1_Load(object sender, EventArgs e)
        {
            
        }

        private void tbRegistra_Click(object sender, EventArgs e)
        {

        }
      

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string sTexto = "";
            if (string.IsNullOrEmpty(txtContrasena.Text))
            {
              sTexto ="Crear Clave de Acceso ";
            }else
            {
                  sTexto ="Reiniciar Clave de Acceso";
            }

            if (Mensajes.Pregunta("seguro que desea?  "+sTexto)){
            string sPass = Generales.CreaContrasena();
            txtContrasena.Text = sPass;
            txtConfContrasena.Text = sPass;

            Mensajes.Aviso("La contraseña generada es "+sPass);
            }
            else if(string.IsNullOrEmpty(txtConfContrasena.Text))
            {
                
            }
            else
            {
                Mensajes.Aviso("El usuario ya tiene una contraseña asignada");
            }
        }

        private void bntCambiar_Click(object sender, EventArgs e)
        {
         
            if (Mensajes.Pregunta("Seguro que deseas Cambiar la contraseña?"))
            {
                Ser_CambiaContrasena ser = new Ser_CambiaContrasena();
                ser.sPass = txtContrasena.Text;
                ser.ShowDialog();
                
                string sNuevo = ser.sPass;


               if(sNuevo != txtContrasena.Text)
                {
                   txtConfContrasena.Text=sNuevo;
                    txtContrasena.Text=sNuevo;
                    Mensajes.Aviso("Contraseña nueva   " + sNuevo);
                }
               else
               {
                  
               }
            }
        }

        #endregion

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ListaBusqueda();
        }

        private void usrNumeros4_Load(object sender, EventArgs e)
        {

        }

        private void dtgvUsuario_DoubleClick(object sender, EventArgs e)
        {

            string sNumfolio;
            sNumfolio = this.dtgvUsuario[0, dtgvUsuario.CurrentCell.RowIndex].Value.ToString();
            this.usrNumFolio.txtNumero.Text = sNumfolio;
           
            this.Carga_Usuario();
            this.ControlaControles(false);
            this.tbcRegistra.SelectedIndex = 0;
          
            this.usrNumFolio.Focus();

        }

        private void usrNumeros4_Validated(object sender, EventArgs e)
        {
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this.txtNombre.BackColor = Color.White;
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            this.txtContrasena.BackColor = Color.White;
        }

        private void txtConfContrasena_TextChanged(object sender, EventArgs e)
        {
            this.txtConfContrasena.BackColor = Color.White;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.ControlaControles(true);
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            this.ControlaControles(false);

            if (usrNumFolio.nValor > 0)
            {
                this.Carga_Usuario();
            }
        }

        private void usrNumFolio_Validated(object sender, EventArgs e)
        {
            if (usrNumFolio.nValor > 0)
            {
                this.Carga_Usuario();
            }
        }
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            
            this.Nuevo();
            this.usrNumFolio.txtNumero.Text ="0";
            this.ControlaControles(true);
        }
      

    }
}
