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
    public partial class frmCliente : Form
    {
        SqlCommand cmd;
        public frmCliente()
        {
            InitializeComponent();
        }
      
        private void frmCliente_Load(object sender, EventArgs e)
        {
            this.Carga_Cliente();
            this.ControlaControles(false); 
        }
        #region METODOS
        private void Nuevo()
        {
          this.usrNumFolio.txtNumero.Text="0";
          this.txtNombre.Text="";
          txtApaterno.Text = "";
          this.txtAmaterno.Text = "";
          this.txtTelefono.Text = "";
          this.txtCelular.Text = "";
          this.txtDireccion.Text = "";
          this.cbxEstatus.Text = "Activo";
         this.usrNumLimCred.txtNumero.Text="";
        }
        private void Registra_Cliente()
        {
            int nFolio = Convert.ToInt16(usrNumFolio.txtNumero.Text);
            string sNombre = txtNombre.Text;
            string sApaterno= txtApaterno.Text;
            string sAmaterno = txtAmaterno.Text; 
            string sTelefono = txtTelefono.Text;
            string sCelular = txtCelular.Text;
            string sDireccion = txtDireccion.Text;
            string sStatus = cbxEstatus.Text;
            int sLimdeCredito = Convert.ToInt16(usrNumLimCred.nValor);

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApaterno.Text) || string.IsNullOrEmpty(txtAmaterno.Text) || string.IsNullOrEmpty(txtDireccion.Text)||string.IsNullOrEmpty(usrNumLimCred.txtNumero.Text))
            {

                Mensajes.Error("Llena los campos mandatorios");
              if(string.IsNullOrEmpty(txtNombre.Text) )
              {
                  txtNombre.BackColor = Color.Red;
              }
              if (string.IsNullOrEmpty(txtApaterno.Text))
              {
                  txtApaterno.BackColor = Color.Red;
              }
              if (string.IsNullOrEmpty(txtAmaterno.Text))
              {
                  txtAmaterno.BackColor = Color.Red;
              }
              if (string.IsNullOrEmpty(txtDireccion.Text))
              {
                  txtDireccion.BackColor = Color.Red;
              }
                
              if (string.IsNullOrEmpty(usrNumLimCred.txtNumero.Text))
              {
                  usrNumLimCred.txtNumero.BackColor = Color.Red;
              } 
               

            }
            else { 
            cmd = new SqlCommand("SP_Inserta_Cliente", XSQL.gSqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pFolio = new SqlParameter("@nId", SqlDbType.Int);
            pFolio.Direction = ParameterDirection.InputOutput;
            pFolio.Value = nFolio;
            cmd.Parameters.Add(pFolio);

            SqlParameter pNombre = new SqlParameter("@cNombre", SqlDbType.VarChar, 50);
            pNombre.Value = sNombre;
            cmd.Parameters.Add(pNombre);

            SqlParameter pApaterno = new SqlParameter("@cApaterno", SqlDbType.VarChar, 50);
            pApaterno.Value = sApaterno;
            cmd.Parameters.Add(pApaterno);

            SqlParameter pAmaterno = new SqlParameter("@cAmaterno", SqlDbType.VarChar, 50);
            pAmaterno.Value = sAmaterno;
            cmd.Parameters.Add(pAmaterno);

            SqlParameter pTelefono = new SqlParameter("@cTelefono", SqlDbType.VarChar, 50);
            pTelefono.Value = sTelefono;
            cmd.Parameters.Add(pTelefono);

            SqlParameter pCelular = new SqlParameter("@cCelular", SqlDbType.VarChar, 50);
            pCelular.Value = sCelular;
            cmd.Parameters.Add(pCelular);

            SqlParameter pDireccion = new SqlParameter("@cDireccion", SqlDbType.VarChar, 80);
            pDireccion.Value = sDireccion;
            cmd.Parameters.Add(pDireccion);

            SqlParameter pEstatus = new SqlParameter("@cEstatus", SqlDbType.VarChar,50);
            pEstatus.Value =sStatus ;
            cmd.Parameters.Add(pEstatus);

            SqlParameter pLimCredito = new SqlParameter("@mLimCredito", SqlDbType.Int);
            pLimCredito.Value = sLimdeCredito;
            cmd.Parameters.Add(pLimCredito);

            
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
        }

        private void Carga_Cliente()
        {
           SqlCommand comando = new SqlCommand("SP_Carga_Cliente",XSQL.gSqlCon);
           
         comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daClie = new SqlDataAdapter(comando);
            DataSet dsClie = new DataSet();
            daClie.Fill(dsClie, "Cliente");
            dtgvCliente.DataSource = dsClie;
            dtgvCliente.DataMember = "Cliente";

            dtgvCliente.Columns[0].Width = 30;
            dtgvCliente.Columns[1].Width = 55;
            dtgvCliente.Columns[4].Width = 55;

            dtgvCliente.Columns[6].Width = 215; 

        }
        private void Eliminar()
        {
            int nId = Convert.ToInt16(usrNumFolio.nValor);


            cmd = new SqlCommand("SP_Borra_Cliente", XSQL.gSqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pFolio = new SqlParameter("@idCliente", SqlDbType.Int);
            pFolio.Value = nId;
            cmd.Parameters.Add(pFolio);

            try
            {
                XSQL.gSqlCon.Open();
                cmd.ExecuteNonQuery();


                this.Nuevo();

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
        private void Regresa_Cliente()
        {

            string comando = "SP_Regresa_Cliente";
            SqlCommand sp = new SqlCommand(comando, XSQL.gSqlCon);
            sp.CommandType = CommandType.StoredProcedure;

            SqlParameter pFolio = new SqlParameter("@nidCliente", SqlDbType.Int);
            pFolio.Value = Convert.ToDecimal(usrNumFolio.nValor);
            sp.Parameters.Add(pFolio);
            try
            {
                XSQL.gSqlCon.Open();
                SqlDataReader dr = sp.ExecuteReader();
                if (dr.Read())
                {

                    this.txtNombre.Text = dr[1].ToString();
                    this.txtApaterno.Text = dr[2].ToString();
                    this.txtAmaterno.Text = dr[3].ToString();
                    this.txtTelefono.Text = dr[4].ToString();
                    this.txtCelular.Text = dr[5].ToString();
                    this.txtDireccion.Text = dr[6].ToString();
                    this.cbxEstatus.Text = dr[8].ToString();
                    this.usrNumLimCred.txtNumero.Text = dr[7].ToString();

                    this.usrNumLimCred.Focus();

                    dr.Close();

                }
                else { 
                Mensajes.Error("Este folio no existe ");
                this.Nuevo();
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

#endregion


        #region EVENTOS
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Registra_Cliente();
        }

        private void tbcRegistra_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Carga_Cliente();
        }

        private void ControlaControles(bool bPrende)
        {
            this.usrNumFolio.txtNumero.Enabled = bPrende;
            this.txtNombre.Enabled = bPrende;
            this.txtApaterno.Enabled = bPrende;
            this.txtAmaterno.Enabled = bPrende;
            this.txtTelefono.Enabled = bPrende;
            this.txtCelular.Enabled = bPrende;
            this.txtDireccion.Enabled = bPrende;
            this.cbxEstatus.Enabled = bPrende;
            this.usrNumLimCred.txtNumero.Enabled = bPrende;
              
            this.btnEliminar.Enabled = !bPrende;
            this.btnNuevo.Enabled = !bPrende;
            this.btnModificar.Enabled = !bPrende;
            this.btnDeshacer.Enabled = bPrende;
            this.btnGuardar.Enabled = bPrende;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Nuevo();
            this.ControlaControles(true);
        }
        private void dtgvCliente_DoubleClick(object sender, EventArgs e)
        {
            string sNumfolio;
           

            sNumfolio = this.dtgvCliente[0, dtgvCliente.CurrentCell.RowIndex].Value.ToString();
            this.usrNumFolio.txtNumero.Text = sNumfolio;
            this.Regresa_Cliente();
           
          
            this.ControlaControles(false);

            this.tbcRegistra.SelectedIndex = 0;
        }

            private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (usrNumFolio.nValor > 0)
            { 
            if(Mensajes .Pregunta ("Deseas eliminar al cliente " + txtNombre.Text +" ?"))
            {
            
                this.Eliminar();
            }
            }
            else
            {
                Mensajes.Aviso("No puedes eliminar a un cliente que no existe");
            }

        }
            private void txtNombre_TextChanged(object sender, EventArgs e)
            {
                txtNombre.BackColor = Color.White;


            }

            private void txtApaterno_TextChanged(object sender, EventArgs e)
            {
                txtApaterno.BackColor = Color.White;
            }

            private void txtAmaterno_TextChanged(object sender, EventArgs e)
            {
                txtAmaterno.BackColor = Color.White;
            }

            private void txtDireccion_TextChanged(object sender, EventArgs e)
            {
                txtDireccion.BackColor = Color.White;
            }

            private void txtNombre_Validated(object sender, EventArgs e)
            {
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    txtNombre.BackColor = Color.White;
                }
            }

            private void usrNumFolio_Validated(object sender, EventArgs e)
            {
                if (usrNumFolio.nValor > 0)
                {
                    this.Regresa_Cliente();
                }
            }
                                                   

        #endregion

            private void btnModificar_Click(object sender, EventArgs e)
            {
                this.ControlaControles(true);
            }

            private void btnDeshacer_Click(object sender, EventArgs e)
            {
                this.ControlaControles(false);

                if (usrNumFolio.nValor > 0) {
                this.Regresa_Cliente();
                }
            }

           
    }
}
