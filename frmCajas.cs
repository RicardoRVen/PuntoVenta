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
    public partial class frmCajas : Form
    {
        SqlCommand cmd;
        public frmCajas()
        {
            InitializeComponent();
        }

        private void frmCajas_Load(object sender, EventArgs e)
        {
            this.RegresaCaja();
            this.ControlaControles(false);
            this.usrNumCajas.txtNumero.Text = "0";
        }

        private void ControlaControles(bool bPrende)
        {
            this.usrNumCajas.txtNumero.Enabled = bPrende;
            this.txtNombre.Enabled = bPrende;
            this.txtMaccaddres.Enabled = bPrende;
            this.chkHabilitada.Enabled = bPrende;
        

            this.btnDeshacer.Enabled = bPrende;
            this.btnGuardar.Enabled = bPrende;
            this.btnEliminar.Enabled = !bPrende;
            this.btnNuevo.Enabled = !bPrende;
            this.btnModificar.Enabled = !bPrende;



        }

        private void Carga_Cajas() 
        {

            string comando = "SP_Carga_Caja";
            SqlCommand sp = new SqlCommand(comando, XSQL.gSqlCon);
            sp.CommandType = CommandType.StoredProcedure;

            SqlParameter pFolio = new SqlParameter("@nidCaja", SqlDbType.Int);
            pFolio.Value = Convert.ToDecimal(usrNumCajas.nValor);
            sp.Parameters.Add(pFolio);
            try
            {
                XSQL.gSqlCon.Open();
                SqlDataReader dr = sp.ExecuteReader();
                if (dr.Read())
                {
                    this.txtNombre.Text = dr[1].ToString();
                    this.txtMaccaddres.Text = dr[2].ToString();
             
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
        private void RegresaCaja()
        {
            //conexion ala base de datos mediante procedimiento almacenado
            SqlCommand sqlCom = new SqlCommand("SP_Regresa_Caja", XSQL.gSqlCon);

            sqlCom.CommandType = CommandType.StoredProcedure;


            try
            {
                XSQL.gSqlCon.Open();

                //metodo que se en carga de llenar el datagrid view cajas
                DataTable dtCajas = new DataTable();
                SqlDataAdapter adCajas = new SqlDataAdapter(sqlCom);
                adCajas.Fill(dtCajas);
                dtgvCajas.DataSource = dtCajas;


                XSQL.gSqlCon.Close();


            }
            catch (Exception ex)
            {
                Mensajes.Error("Error de conexion" + ex.Message);
            }
            finally
            {
                XSQL.gSqlCon.Close();
            }
        }
        private void Guardar()
        {
            int nFolio = Convert.ToInt16(usrNumCajas.nValor);
            string sNombre = txtNombre.Text;
            string sMacaddres = txtMaccaddres.Text;
            bool bHabilita = chkHabilitada.Checked;

            cmd = new SqlCommand("SP_Inserta_Caja", XSQL.gSqlCon);  
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pFolio = new SqlParameter("@nIdCaja", SqlDbType.Int);
            pFolio.Direction = ParameterDirection.InputOutput;
            pFolio.Value = nFolio;
            cmd.Parameters.Add(pFolio);

            SqlParameter pNombre = new SqlParameter("@nNombre", SqlDbType.VarChar, 50);
            pNombre.Value = sNombre;
            cmd.Parameters.Add(pNombre);

            SqlParameter pMacaddress = new SqlParameter("@nMacaddress", SqlDbType.VarChar, 50);
            pMacaddress.Value = sMacaddres;
            cmd.Parameters.Add(pMacaddress);

    
            SqlParameter pHabilita = new SqlParameter("@bHabilita", SqlDbType.Bit);
            pHabilita.Value = bHabilita;
            cmd.Parameters.Add(pHabilita);

          
            try
            {
                XSQL.gSqlCon.Open();
                cmd.ExecuteNonQuery();

                nFolio = (int)pFolio.Value;

                Mensajes.Aviso("Caja guardada con el folio: " + nFolio.ToString());
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

        private void Nuevo()
        {
            this.usrNumCajas.txtNumero.Text = "0";
            this.txtNombre.Text = "";
            this.txtMaccaddres.Text = "";
            
        }
        private void Eliminar()
        {
            int nIdCaja = Convert.ToInt16(usrNumCajas.nValor);


            cmd = new SqlCommand("SP_Borra_Caja", XSQL.gSqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pFolio = new SqlParameter("@nidCaja", SqlDbType.Int);
            pFolio.Value = nIdCaja;
            cmd.Parameters.Add(pFolio);

            try
            {
                XSQL.gSqlCon.Open();
                cmd.ExecuteNonQuery();


                this.Nuevo();

                Mensajes.Aviso("Registro Eliminado con el folio: " + nIdCaja.ToString());
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
        private void usrNumCajas_Validated(object sender, EventArgs e)
        {
            this.Carga_Cajas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtMaccaddres.Text) || string.IsNullOrEmpty(usrNumCajas.txtNumero.Text))
            {

                Mensajes.Error("Llena los campos vacios");
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    this.txtNombre.BackColor = Color.Red;
                }

                if (string.IsNullOrEmpty(txtMaccaddres.Text))
                {
                    this.txtMaccaddres.BackColor = Color.Red;
                }

                if (string.IsNullOrEmpty(usrNumCajas.txtNumero.Text))
                {
                    this.usrNumCajas.txtNumero.BackColor = Color.Red;
                }
            }
            else
            {
                this.Guardar();
            }
        }
      
        private void tabCajas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RegresaCaja();
        }

        private void dtgvCajas_DoubleClick(object sender, EventArgs e)
        {
            string sNumfolio;

            sNumfolio = this.dtgvCajas[0, dtgvCajas.CurrentCell.RowIndex].Value.ToString();
            this.usrNumCajas.txtNumero.Text = sNumfolio;

            this.Carga_Cajas();

            this.ControlaControles(false);

            this.tabCajas.SelectedIndex = 0;

            this.usrNumCajas.Focus();
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            this.ControlaControles(false);

            if (usrNumCajas.nValor > 0)
            {
                this.Carga_Cajas();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.ControlaControles(true);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.ControlaControles(true);
                this.Nuevo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Mensajes.Pregunta("Deseas eliminar el producto  "))
            {
                if (usrNumCajas.nValor > 0)
                {
                    this.Eliminar();
                }
                else
                {
                    Mensajes.Error("No puedes eliminar un folio que no existe");
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this.txtNombre.BackColor = Color.White;
        }

        private void txtMaccaddres_TextChanged(object sender, EventArgs e)
        {
            this.txtMaccaddres.BackColor = Color.White;
        }



    }
}
