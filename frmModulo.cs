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
    public partial class frmModulo : Form
    {
        SqlCommand cmd;
        public frmModulo()
        {
            InitializeComponent();
        }

        private void frmModulo_Load(object sender, EventArgs e)
        {
            this.ControlaControles(false);
            this.ListaBusqueda();
        }
        #region Metodos
        private void ControlaControles(bool bPrende)
        {
            this.usrNumMod.txtNumero.Enabled = bPrende;
            this.txtNombreMod.Enabled = bPrende;
            this.txtFormato.Enabled = bPrende;
            this.chkEs_administrador.Enabled = bPrende;

            this.btnDeshacer.Enabled = bPrende;
            this.btnGuardar.Enabled = bPrende;
            this.btnEliminar.Enabled = !bPrende;
            this.btnNuevo.Enabled = !bPrende;
            this.btnModificar.Enabled = !bPrende;



        }
        private void Limpia_Texto()
        {

            this.usrNumMod.txtNumero.Text = "0";
            this.txtFormato.Text  = "";
            this.txtNombreMod.Text = "";
        }

        private void Guardar()
        {
            int nFolio = Convert.ToInt16(usrNumMod.nValor);
            string sNombre = txtNombreMod.Text;
            string sFormato = txtFormato.Text;
            bool sAdmin = chkEs_administrador.Checked;

            //   sPassword = Encriptador.RijndaelSimple.Encriptar(sPassword);


            cmd = new SqlCommand("SP_Inserta_Modulo", XSQL.gSqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pFolio = new SqlParameter("@nIdmodulo", SqlDbType.Int);
            pFolio.Direction = ParameterDirection.InputOutput;
            pFolio.Value = nFolio;
            cmd.Parameters.Add(pFolio);

            SqlParameter pNombre = new SqlParameter("@cNombremodulo", SqlDbType.VarChar, 50);
            pNombre.Value = sNombre;
            cmd.Parameters.Add(pNombre);

            SqlParameter pPwd = new SqlParameter("@cFormato", SqlDbType.VarChar, 50);
            pPwd.Value = sFormato;
            cmd.Parameters.Add(pPwd);
       
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
        private void Carga_Modulo()
        {

            string comando = "SP_Carga_Modulo";
            SqlCommand sp = new SqlCommand(comando, XSQL.gSqlCon);
            sp.CommandType = CommandType.StoredProcedure;

            SqlParameter pFolio = new SqlParameter("@nidmodulo", SqlDbType.Int);
            pFolio.Value = Convert.ToDecimal(usrNumMod.nValor);
            sp.Parameters.Add(pFolio);
            try
            {
                XSQL.gSqlCon.Open();
                SqlDataReader dr = sp.ExecuteReader();
                if (dr.Read())
                {
                    this.txtNombreMod.Text = dr[1].ToString();
                    this.txtFormato.Text = dr[2].ToString();
                    this.chkEs_administrador.Checked = Convert.ToBoolean(dr[3]);
                    
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error("se presento un error" + ex.Message);
            }
            finally
            {
                XSQL.gSqlCon.Close();
            }



        }
        private void ListaBusqueda()
        {
            SqlCommand sqlCom = new SqlCommand("SP_Regresa_Modulo", XSQL.gSqlCon);

            sqlCom.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daplat = new SqlDataAdapter(sqlCom);
            DataSet dsPlat = new DataSet();
            daplat.Fill(dsPlat, "Modulo");
            dtGridMod.DataSource = dsPlat.Tables[0];


        }

        private void Eliminar()
        {
            int nId = Convert.ToInt16(usrNumMod.nValor);


            cmd = new SqlCommand("SP_Borra_Modulo", XSQL.gSqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pFolio = new SqlParameter("@idmodulo", SqlDbType.Int);
            pFolio.Value = nId;
            cmd.Parameters.Add(pFolio);

            try
            {
                XSQL.gSqlCon.Open();
                cmd.ExecuteNonQuery();


                this.Limpia_Texto();

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
        #endregion
        #region eventos
        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            this.Carga_Modulo();
            this.ControlaControles(false);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.ControlaControles(true);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            

            this.Limpia_Texto();
            this.ControlaControles(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFormato.Text) || string.IsNullOrEmpty(txtNombreMod.Text))
            {


                Mensajes.Error("Llena los campos mandatorios");

                if (string.IsNullOrEmpty(txtFormato.Text))
                {
                    txtFormato.BackColor = Color.Red;
                }
                if (string.IsNullOrEmpty(txtNombreMod.Text))
                {
                    txtNombreMod.BackColor = Color.Red;
                }

            }
            else
            {
                this.Guardar();
            }



        }
        private void txtNombreMod_TextChanged(object sender, EventArgs e)
        {
            this.txtNombreMod.BackColor = Color.White;
        }

        private void txtFormato_TextChanged(object sender, EventArgs e)
        {
            this.txtFormato.BackColor = Color.White;
        }

#endregion

        private void tabProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ListaBusqueda();
        }

        private void usrNumMod_Validated(object sender, EventArgs e)
        {
            this.Carga_Modulo();
        }

        private void dtGridMod_DoubleClick(object sender, EventArgs e)
        {
            string sNumfolio;
            sNumfolio = this.dtGridMod[0, dtGridMod.CurrentCell.RowIndex].Value.ToString();
            this.usrNumMod.txtNumero.Text = sNumfolio;

           
            this.ControlaControles(false);

            this.tabProductos.SelectedIndex = 0;
            this.usrNumMod.Focus();

            this.Carga_Modulo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Mensajes.Pregunta("Estas seguro que deseas eliminar el Folio?"))
            {
                if (usrNumMod.nValor > 0)
                {
                    this.Eliminar();

                    this.Limpia_Texto();
                }
                else
                {

                }
            }


        }

     

       
    }
}
