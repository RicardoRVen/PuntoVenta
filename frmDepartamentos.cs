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
    public partial class frmDepartamentos : Form
    {
        public frmDepartamentos()
        {
            InitializeComponent();
        }

        private void frmDepartamentos_Load(object sender, EventArgs e)
        {
            this.cargaDepartamento();
            this.usrNumeros1.txtNumero.Text = "0";
            this.ControlaControles(false);

            //this.dtgvDepartamentos.Columns.IsReadOnly;
        }
        private void ControlaControles(bool bPrende)
        {
            this.usrNumeros1.txtNumero.Enabled = bPrende;
            //this.txtFolio.Enabled = !bPrende;
            this.txtDepartamento.Enabled = bPrende;
           


            this.btnDeshacer.Enabled = bPrende;
            this.btnEliminar.Enabled = !bPrende;
            this.btnGuardar.Enabled = bPrende;
            this.btnNuevo.Enabled = !bPrende;
            this.btnModificar.Enabled = !bPrende;
            
        }
        public void Guardar()
        {
            string sFamilia = this.txtDepartamento.Text;
            string sFolio = usrNumeros1.txtNumero.Text;
            //string sFolio = this.txtFolio.Text;
            int nFolio;

            if (string.IsNullOrEmpty(sFolio))
            {
                nFolio = 0;
            }
            else
            {
                nFolio = Convert.ToInt16(sFolio); 
            }


            SqlCommand sqlCom = new SqlCommand("SP_Registra_Departamento", XSQL.gSqlCon);

            sqlCom.CommandType = CommandType.StoredProcedure;

            //crear parametros
            SqlParameter parDeparamento;
            parDeparamento = new SqlParameter("@cNombre", SqlDbType.VarChar);
            parDeparamento.Value = sFamilia;
            sqlCom.Parameters.Add(parDeparamento);

            SqlParameter parFolio;
            parFolio = new SqlParameter("@nFolio", SqlDbType.Int);
            parFolio.Value = nFolio;
            parFolio.Direction = ParameterDirection.InputOutput;
            //Agregamos el parametro  al SP
            sqlCom.Parameters.Add(parFolio);

            // Abrimos conexion

            try
            {

                XSQL.gSqlCon.Open();
                sqlCom.ExecuteNonQuery();
                nFolio = (int)parFolio.Value;
                this. usrNumeros1.txtNumero.Text= nFolio.ToString();

                Mensajes.Aviso("Registro Guardado con el Folio " + nFolio.ToString());
            }
            catch
            {
                Mensajes.Error("Ya existe esta departamento");
            }
            finally
            {
                  XSQL.gSqlCon.Close();
            }

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
        private void Eliminar()
        {

            //Metodo que se encarga de eliminar el folio 

            try
            {

         
    

            SqlCommand sqlCom = new SqlCommand("SP_Borra_Departamento", XSQL.gSqlCon);

            sqlCom.CommandType = CommandType.StoredProcedure;
                    
            SqlParameter parFolio;
            parFolio = new SqlParameter("@idDepartamento", SqlDbType.Int);
            parFolio.Value = usrNumeros1.txtNumero.Text;
            //Agregamos el parametro  al SP
            sqlCom.Parameters.Add(parFolio);

            XSQL.gSqlCon.Open();

            sqlCom.ExecuteNonQuery();
 
            

            Mensajes.Aviso("Registro eliminado satisfactoriamente");
            }
            catch (Exception ex)
            {
                Mensajes.Error("Accion no completada por el sig error" + ex.Message);

            }
            finally
            {
                XSQL.gSqlCon.Close();
            }



        }
       
        private void Regresa_dato()
        {
            //consulta que regresa el nombre del departamento en el texbox departamento

            SqlCommand sqlCom = new SqlCommand("SP_Regresa_Departamento", XSQL.gSqlCon);

            sqlCom.CommandType = CommandType.StoredProcedure;

            SqlParameter parFolio;
            parFolio = new SqlParameter("@idDepartamento", SqlDbType.Int);
            parFolio.Value = usrNumeros1.txtNumero.Text;
            //Agregamos el parametro  al SP
            sqlCom.Parameters.Add(parFolio);

           

            try
            {
                 XSQL.gSqlCon.Open();

                // regresa la consulta sql

                txtDepartamento.Text = sqlCom.ExecuteScalar().ToString();


                 XSQL.gSqlCon.Close();
            }
            catch
            {
                //si el folio es nulo vacia el texbox 
                if ( usrNumeros1.txtNumero.Text == "0")
                {

                }
                else
                {
                    Mensajes.Error("Este folio no existe ");
                 usrNumeros1.txtNumero.Text = "0";
                }

            }
            //cierra la base de datos
            finally
            {
                 XSQL.gSqlCon.Close();
            }

        }
        //Metodo que se encarga de devolver los datos de la tabla departamento
        private void cargaDepartamento() 
        {
            //conexion ala base de datos mediante procedimiento almacenado
            SqlCommand sqlCom = new SqlCommand("SP_Departamento",  XSQL.gSqlCon);

            sqlCom.CommandType = CommandType.StoredProcedure;


            try
            {
                 XSQL.gSqlCon.Open();

                //metodo que se en carga de llenar el datagrid view departamento
                DataTable dtDepartamento = new DataTable();
                SqlDataAdapter adDepartamentos = new SqlDataAdapter(sqlCom);
                adDepartamentos.Fill(dtDepartamento);
                dtgvDepartamentos.DataSource = dtDepartamento;


               

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
        private void txtFolio_Validated(object sender, EventArgs e)
        {

            //instancia del metodo que se encarga de regresar el folio
            

        }
        private void Nuevo()
        {  //metodo que se encarga de limpiar los objetos de texto
             usrNumeros1.txtNumero.Text = "0";
            this.txtDepartamento.Text = "";
            this.txtDepartamento.Focus();

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        { //instancia del metodo nuevo
            
        }
        private void tabFamilias_Click(object sender, EventArgs e)
        {//se encarga de cargar la tabla en el data grid view
            this.cargaDepartamento();
        }

         

   

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            //Boolean bResp;

            if (txtDepartamento.Text == "")
            {
                MessageBox.Show("El texto esta vacio checalo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtDepartamento.BackColor = Color.Red;
            }
            else
            {
                this.Guardar();


                 usrNumeros1.txtNumero.Text= "0";
                this.txtDepartamento.Text = "";
                this.txtDepartamento.Focus();

            }
        }

        private void dtgvDepartamentos_DoubleClick(object sender, EventArgs e)
        {
            // obtuvimos valores del data grid y lo asignamos a los objetos txtdepartamento y txt folio
            string sFolio;
            sFolio = this.dtgvDepartamentos[0, dtgvDepartamentos.CurrentCell.RowIndex].Value.ToString();
            usrNumeros1.txtNumero.Text = sFolio;
            this.Regresa_dato();
            this.ControlaControles(false);
                  
            this.tabFamilias.SelectedIndex = 0;
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            this.Nuevo();

            this.ControlaControles(true);
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (Mensajes.Pregunta("Deseas eliminar este departamento?"))
            {
                if ( usrNumeros1.txtNumero.Text== "0")
                {

                }
                else
                {
                   
                        this.Eliminar();

                }

            }

        }

        private void tabFamilias_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cargaDepartamento();
        }

        private void usrNumeros1_Validated(object sender, EventArgs e)
        {
            if (usrNumeros1.nValor > 0)
            {
                this.Regresa_dato();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.ControlaControles(true);
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            this.ControlaControles(false);
            if (usrNumeros1.nValor > 0) { 
            this.Regresa_dato();
            }
        }

        private void txtDepartamento_TextChanged(object sender, EventArgs e)
        {
            this.txtDepartamento.BackColor = Color.White;
        }

        private void usrNumeros1_Validated_1(object sender, EventArgs e)
        {
            this.Regresa_dato();
        }




    }
}
