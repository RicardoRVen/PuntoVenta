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
    public partial class frmContrasenas : Form
    {
        

        Encriptar_Desencriptar Descifrar = new Encriptar_Desencriptar(); 
        public frmContrasenas()
        {
            InitializeComponent();
        }

        private void frmContrasenas_Load(object sender, EventArgs e)
        {
            this.ListaBusqueda();
        }
        private void Carga_Contrasena()  
        {

            string comando = "SP_Carga_Contrasena";
            SqlCommand sp = new SqlCommand(comando, XSQL.gSqlCon);
            sp.CommandType = CommandType.StoredProcedure;

            SqlParameter pFolio = new SqlParameter("@nidusuario", SqlDbType.Int);
            pFolio.Value = Convert.ToDecimal(usrNumFolio.nValor);
            sp.Parameters.Add(pFolio);
            try
            {
                XSQL.gSqlCon.Open();
                SqlDataReader dr = sp.ExecuteReader();
                if (dr.Read())
                {
                    string desifra;
                  desifra = dr[2].ToString();
                  this.txtContrasena.Text  = Descifrar.DecryptKey(desifra);

                    dr.Close();
                }
                else
                {
                    Mensajes.Aviso("No existe este Usuario o esta inactivo");
                    this.txtContrasena.Text = "";
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
            SqlCommand sqlCom = new SqlCommand("SP_Regresa_Contrasena", XSQL.gSqlCon);

            sqlCom.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dacontra = new SqlDataAdapter(sqlCom);
            DataSet dscontra = new DataSet();
            dacontra.Fill(dscontra, "Usuario");
            dtgContrasenas.DataSource = dscontra.Tables[0];


        }

        private void dtgContrasenas_DoubleClick(object sender, EventArgs e)
        {
            string sNumfolio;
            sNumfolio = this.dtgContrasenas[0, dtgContrasenas.CurrentCell.RowIndex].Value.ToString();
            this.usrNumFolio.txtNumero.Text = sNumfolio;

           this.txtContrasena.Text = Descifrar.DecryptKey(dtgContrasenas.CurrentRow.Cells["Contraseña"].Value.ToString());

           this.ListaBusqueda();
     
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Carga_Contrasena();
        }

    }
}
