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
    public partial class frmProductos : Form
    {

        SqlCommand cmd;
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            this.Carga_ComboDepartamento();

            this.ControlaControles(false);
        }
        #region METODOS

        private void Guardar()
        {
            int nFolio = Convert.ToInt16(usrNumProd.nValor);
            string sProducto = txtProducto.Text;
            string sBarCode = txtCodBar.Text;
            string sClave = txtClave.Text;
            double sImpuesto = Convert.ToDouble(usrNumTasa.txtNumero.Text);
            bool sSeCuenta = chkSecuenta.Checked;
            decimal sPrecio = Convert.ToDecimal(usrPrecio.txtNumero.Text);

            cmd = new SqlCommand("SP_Inserta_Producto", XSQL.gSqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pFolio = new SqlParameter("@nIdProducto", SqlDbType.Int);
            pFolio.Direction = ParameterDirection.InputOutput;
            pFolio.Value = nFolio;
            cmd.Parameters.Add(pFolio);

            SqlParameter pProducto = new SqlParameter("@cProducto", SqlDbType.VarChar, 50);
            pProducto.Value = sProducto;
            cmd.Parameters.Add(pProducto);

            SqlParameter pDepartamento = new SqlParameter("@nDepartamento", SqlDbType.VarChar, 50);
            pDepartamento.Value = cbxDepartamento.SelectedValue;
            cmd.Parameters.Add(pDepartamento);

            SqlParameter pCodBarras = new SqlParameter("@cCodBarras", SqlDbType.VarChar, 50);
            pCodBarras.Value = sBarCode;
            cmd.Parameters.Add(pCodBarras);

            SqlParameter pSeCuenta = new SqlParameter("@bSeCuenta", SqlDbType.Bit);
            pSeCuenta.Value = sSeCuenta;
            cmd.Parameters.Add(pSeCuenta);

            SqlParameter pClave = new SqlParameter("@cClave", SqlDbType.VarChar, 20);
            pClave.Value = sClave;
            cmd.Parameters.Add(pClave);

            SqlParameter pTasaInt = new SqlParameter("@nTasaInteres", SqlDbType.Money);
            pTasaInt.Value = sImpuesto;
            cmd.Parameters.Add(pTasaInt);

            SqlParameter pPrecio= new SqlParameter("@nPrecio", SqlDbType.Decimal);
            pPrecio.Value = sPrecio;
            cmd.Parameters.Add(pPrecio);
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
        private void Nuevo() 
        {
            this.usrNumProd.txtNumero.Text = "0";
            this.txtProducto.Text = "";
            this.txtCodBar.Text = "";
            this.txtClave.Text = "";
            this.usrNumTasa.txtNumero.Text = "";
            this.usrPrecio.txtNumero.Text = "";
        }
        private void Carga_ComboDepartamento() 
        {

            try { 
            //Query a la base de datos  producto
            string sComando = "SP_Carga_ComboDepartamento";

            SqlCommand sqlCom = new SqlCommand(sComando, XSQL.gSqlCon);

            SqlDataAdapter adProd = new SqlDataAdapter(sComando, XSQL.gSqlCon);

            // Este metodo se encarga de llenar el combobox 
            DataSet dsProd = new DataSet();
            adProd.Fill(dsProd);
            cbxDepartamento.DataSource = dsProd.Tables[0];
            cbxDepartamento.DisplayMember = "nombre_departamento";
            cbxDepartamento.ValueMember = "id_departamento";
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

        private void CargarProductos()
        {
            //se encarga de llenar el data grid de la base de datos productos

            SqlDataAdapter adProd = new SqlDataAdapter("SP_Carga_Productos", XSQL.gSqlCon);

            DataTable dsProd = new DataTable();
            // carga la tabla productos
            adProd.Fill(dsProd);
            dtGridProd.DataSource = dsProd;

        }
        private void ControlaControles(bool bPrende)
        {
            this.usrNumProd.txtNumero.Enabled = bPrende;
            this.txtProducto.Enabled = bPrende;
            this.txtClave.Enabled = bPrende;
            this.txtCodBar.Enabled = bPrende;
            this.cbxDepartamento.Enabled = bPrende;
            this.chkSecuenta.Enabled = bPrende;
            this.usrNumTasa.txtNumero.Enabled = bPrende;
            this.usrPrecio.txtNumero.Enabled = bPrende;

            this.btnDeshacer.Enabled = bPrende;
            this.btnGuardar.Enabled = bPrende;
            this.btnEliminar.Enabled = !bPrende;
            this.btnNuevo.Enabled = !bPrende;
            this.btnModificar.Enabled = !bPrende;
           


        }

        private void Regresa_Producto() 
        {

            string comando = "SP_Regresa_Producto";
            SqlCommand sp = new SqlCommand(comando, XSQL.gSqlCon);
            sp.CommandType = CommandType.StoredProcedure;

            SqlParameter pFolio = new SqlParameter("@nidProducto", SqlDbType.Int);
            pFolio.Value = Convert.ToDecimal(usrNumProd.nValor);
            sp.Parameters.Add(pFolio);
            try
            {
                XSQL.gSqlCon.Open();
                SqlDataReader dr = sp.ExecuteReader();
                if (dr.Read())
                {
                    this.txtProducto.Text = dr[1].ToString();
                    this.cbxDepartamento.Text = dr[2].ToString();
                    this.txtCodBar.Text = dr[3].ToString();
                    this.chkSecuenta.Checked = Convert.ToBoolean(dr[4]);
                    this.txtClave.Text = dr[5].ToString();
                    this.usrNumTasa.txtNumero.Text = dr[6].ToString();
                    this.usrPrecio.txtNumero.Text = dr[7].ToString();
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
        private void Eliminar()
        {
            int nId = Convert.ToInt16(usrNumProd.nValor);


            cmd = new SqlCommand("SP_Borra_Producto", XSQL.gSqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pFolio = new SqlParameter("@idProducto", SqlDbType.Int);
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
       #endregion



        #region Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtProducto.Text) || string.IsNullOrEmpty(txtClave.Text) || string.IsNullOrEmpty(usrNumTasa.txtNumero.Text)) 
            {

                Mensajes.Error("Llena los campos vacios");
                if (string.IsNullOrEmpty(txtProducto.Text))
                {
                    this.txtProducto.BackColor = Color.Red;
                }
                
                if (string.IsNullOrEmpty(txtClave.Text))
                {
                    this.txtClave.BackColor = Color.Red;
                }

                if (string.IsNullOrEmpty(usrNumTasa.txtNumero.Text))
                {
                    this.usrNumTasa.txtNumero.BackColor = Color.Red;
                }
             }else { 
                        this.Guardar();
                   }
        }



        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            this.txtClave.BackColor = Color.White;
        }

        private void txtCodBar_TextChanged(object sender, EventArgs e)
        {
            this.txtCodBar.BackColor = Color.White;
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            this.txtProducto.BackColor = Color.White;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.ControlaControles(true);
            this.Nuevo();
            
        }

        private void tabProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CargarProductos();
        }

        private void dtGridProd_DoubleClick(object sender, EventArgs e)
        {
            string sNumfolio;
           
            sNumfolio = this.dtGridProd[0, dtGridProd.CurrentCell.RowIndex].Value.ToString();
            this.usrNumProd.txtNumero.Text = sNumfolio;

            this.Regresa_Producto();
           
            this.ControlaControles(false);

            this.tabProductos.SelectedIndex = 0;

            this.usrNumProd.Focus();
        }

        private void usrNumProd_Validated(object sender, EventArgs e)
        {
            this.Regresa_Producto();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Mensajes.Pregunta("Deseas eliminar el producto  "))
            {
                if (usrNumProd.nValor > 0) { 
                this.Eliminar();
                }
                else
                {
                    Mensajes.Error("No puedes eliminar un folio que no existe");
                }
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

            if (usrNumProd.nValor > 0)
            {
                this.Regresa_Producto();
            }
        }

      

 
       

      

       

      
    }
}
