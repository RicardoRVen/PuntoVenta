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
using System.Net.NetworkInformation;

namespace PuntoVenta

{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        string nPrecio;
    
       string nIVA;

       string detIva; 
        public Form1()
        {
            InitializeComponent();
           
             
   
        }

        private void usrCerrar2_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XSQL.Leer_Cadena();
           this.menuStrip1.Visible = false;
         
          lblUsuario.Text= Generales.sUsuario;
          this.usrCantidad.txtNumero.Text = "1";
       
          this.generalesToolStripMenuItem.Enabled = Generales.bAdmin;
          this.usuariosToolStripMenuItem.Enabled = Generales.bAdmin;
          this.ControlaControles(false);
          this.CargaGridVenta();
        }

        private void CargaGridVenta()
        {
            dtgVenta.ColumnCount = 9;

            dtgVenta.Columns[0].Name = "Codigo";
            dtgVenta.Columns[1].Name = "Cantidad";
            dtgVenta.Columns[2].Name = "Nombre Articulo";
            dtgVenta.Columns[3].Name = "Precio";
            dtgVenta.Columns[4].Name = "Importe";
            dtgVenta.Columns[5].Name = "Subtotal";
            dtgVenta.Columns[6].Name = "Iva";
            dtgVenta.Columns[7].Name = "Total";
            dtgVenta.Columns[8].Name = "IvaAarticulo";

            dtgVenta.Columns[0].Width =50;
            dtgVenta.Columns[1].Width =50;
            dtgVenta.Columns[2].Width = 200;
            dtgVenta.Columns[3].Width = 70;
            dtgVenta.Columns[4].Width =100;
            dtgVenta.Columns[5].Width = 60;
            dtgVenta.Columns[6].Width = 60;
            dtgVenta.Columns[7].Width = 60;
            dtgVenta.Columns[8].Width = 60;

            dtgVenta.Columns[0].ReadOnly =true ;
            dtgVenta.Columns[1].ReadOnly = false;
            dtgVenta.Columns[2].ReadOnly = true;
            dtgVenta.Columns[3].ReadOnly = true;
            dtgVenta.Columns[4].ReadOnly = true;
            dtgVenta.Columns[5].ReadOnly = true;
            dtgVenta.Columns[6].ReadOnly = true;
            dtgVenta.Columns[7].ReadOnly = true;
            dtgVenta.Columns[8].Visible = false;

            dtgVenta.Columns[0].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dtgVenta.Columns[2].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dtgVenta.Columns[3].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dtgVenta.Columns[4].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dtgVenta.Columns[5].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dtgVenta.Columns[6].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dtgVenta.Columns[7].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dtgVenta.Columns[8].DefaultCellStyle.BackColor = Color.WhiteSmoke;

        }

        private void CargaVenta()  

        {
            //declaramos variables
            decimal NUM1 = decimal.Parse(usrCantidad.txtNumero.Text);
            decimal NUM2 = decimal.Parse(nPrecio);

            //calculamos subtotal
            decimal mult;
            mult = NUM1 * NUM2;
            Generales.nImporte = mult.ToString();

            Generales.nSTotal = Generales.nImporte;

            //calculams tasa de interes
              decimal iva;

                iva = (Convert.ToDecimal( Generales.nSTotal) * Convert.ToDecimal( nIVA )/ 100);
                nIVA= iva.ToString();

            //iva por articulo
            decimal ivaArt; 
              ivaArt=Convert.ToDecimal( nIVA )/ 100;
         string  ivaArticulo = ivaArt.ToString();

            //calculamos total * cada linea
                decimal suma;
                suma= iva + mult;
                Generales.nTotal = suma.ToString();
          
            string[] row1 = new string[] { this.usrProductos.txtNumero.Text, this.usrCantidad.txtNumero.Text,this.txtDesdripProducto.Text ,nPrecio,Generales.nImporte,Generales.nSTotal,nIVA,Generales.nTotal,detIva};

            object[] rows = new object[] { row1 };

            foreach (string[] rowArray in rows)
            {
                dtgVenta.Rows.Add(rowArray);
            }

            this.usrProductos.txtNumero.Text = "";
            this.usrCantidad.txtNumero.Text = "1";
            this.txtDesdripProducto.Text = "";
               
        }

        private void ControlaControles(bool bPrende)
        {
            this.usrProductos.txtNumero.Enabled = bPrende;
            this.txtConsulta.Enabled = bPrende;
            this.txtCantArticulos.Enabled = bPrende;
            this.txtDesdripProducto.Enabled = bPrende;
            this.txtIva.Enabled = bPrende;
            this.txtSubtotal.Enabled = bPrende;
            this.usrCantidad.txtNumero.Enabled = bPrende;
            this.txtTotal.Enabled = bPrende;

            
            this.btnBuscar.Enabled = bPrende;
            this.btnAgregar.Enabled = bPrende;

            this.dtgProductos.Enabled = bPrende;
            this.dtgVenta.Enabled = bPrende;
            this.btnCobrar.Enabled = bPrende;
            this.bnCancelar.Enabled = bPrende;
            //this.btnModificar.Enabled = !bPrende;



        }
        private void ConsultaProductos() 
        {
            string sDescripcion = this.txtConsulta.Text;

            string comando = "SP_Consulta_Producto";
            SqlCommand sp = new SqlCommand(comando, XSQL.gSqlCon);
            sp.CommandType = CommandType.StoredProcedure;

            SqlParameter pFolio = new SqlParameter("@nClave", SqlDbType.Int);
            pFolio.Value = Convert.ToDecimal(usrProductos.nValor);
            sp.Parameters.Add(pFolio);


            SqlParameter pDescripcion = new SqlParameter("@sNombre", SqlDbType.VarChar, 50);
            pDescripcion.Value =sDescripcion;
            sp.Parameters.Add(pDescripcion);

            try
            {
                XSQL.gSqlCon.Open();

                DataTable dtConsulta = new DataTable();
                SqlDataAdapter adConsulta = new SqlDataAdapter(sp);
                adConsulta.Fill(dtConsulta);
                dtgProductos.DataSource = dtConsulta;

                SqlDataReader dr = sp.ExecuteReader();
                if (dr.Read())
                {

                    this.usrProductos.txtNumero.Text = dr[0].ToString();
                    this.txtDesdripProducto.Text = dr[1].ToString();
                    nPrecio = dr[2].ToString();
                    nIVA = dr[3].ToString();
                   detIva = dr[3].ToString();
                   //Mensajes.Aviso(""+nPrecio);  

                    dr.Close();
                }
                dtgProductos.Columns[0].Width = 50;
                dtgProductos.Columns[1].Width = 150;
                dtgProductos.Columns[2].Width = 50;
                dtgProductos.Columns[3].Width = 50;
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
        private  Boolean EjecutaModulo(string sModulo)

        {
            Boolean bPasa = false;

            cmd = new SqlCommand("SP_Ejecuta_modulo", XSQL.gSqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pFormato = new SqlParameter("@cFormato", SqlDbType.VarChar,50);
            pFormato.Value = sModulo;
            cmd.Parameters.Add(pFormato);

     
            SqlParameter sqlAdmin = new SqlParameter("@bAdmin", SqlDbType.Bit);
           // sqlAdmin.Direction = ParameterDirection.Output;
            sqlAdmin.Value = Generales.bAdmin;
            cmd.Parameters.Add(sqlAdmin);



            SqlParameter sqlPuede = new SqlParameter("@bPuede",SqlDbType.Bit);
            sqlPuede.Direction = ParameterDirection.Output;
            sqlPuede.Value = false;
            cmd.Parameters.Add(sqlPuede);


            try
            {
                XSQL.gSqlCon.Open();
                cmd.ExecuteNonQuery();


                bPasa = (Boolean)sqlPuede.Value;
                Generales.bPuede = (Boolean)sqlPuede.Value;
                this.Refresh();

                if (!bPasa)
                {
                    Mensajes.Error("No estas autorizado para correr este modulo");
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

            return bPasa;
        }
        private void AbrirTurno() 
        {

         string   sqlMac = this.Maccaddress();
      
         Boolean bPasa = false;

            cmd = new SqlCommand("SP_Valida_Caja", XSQL.gSqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pMac = new SqlParameter("@cMac", SqlDbType.VarChar, 30);
            pMac.Value = sqlMac;
            cmd.Parameters.Add(pMac);

            SqlParameter sqlBpasa = new SqlParameter("@bPasa", SqlDbType.Bit);
            sqlBpasa.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(sqlBpasa);

            SqlParameter sqlnCaja = new SqlParameter("@nCaja", SqlDbType.Int);
            sqlnCaja.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(sqlnCaja);

          SqlParameter sqlcCaja = new SqlParameter("@cCaja", SqlDbType.VarChar,30);
            sqlcCaja.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(sqlcCaja);

            try
            {
                XSQL.gSqlCon.Open();
                cmd.ExecuteNonQuery();

                bPasa = (Boolean)sqlBpasa.Value;

                
                if (!bPasa)
                {
                    Mensajes.Error("Este equipo no esta habilitado como Caja");                   

                }
                else
                {

                    Generales.nCaja = (int)sqlnCaja.Value; 
                    Generales.sCaja = (string)sqlcCaja.Value;

                   

                   
                   // Mensajes.Aviso("Turno Abierto  ");
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
            if (bPasa)
            {
                serAbreTurno ser = new serAbreTurno();
                ser.ShowDialog();

                this.btnCierraTurno.Enabled = true;
                this.btnRetiro.Enabled = true;
                this.btnAbrirTurno.Enabled = false;
                this.btnDesbloquea.Enabled = false;

                this.ControlaControles(true);
            }
        }
        private string Maccaddress()
        {
            string sMac = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus==OperationalStatus.Up)
                {
                    sMac += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return sMac;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (EjecutaModulo("frmAcceso"))
            {
            frmAcceso frAcceso =new frmAcceso();
            frAcceso.Show();
            }
        }

        private void conexionServidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (EjecutaModulo("frmConexion"))
            {
            frmConexion fr = new frmConexion();
            fr.Show();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
         Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EjecutaModulo("frmDepartamentos")) { 
            frmDepartamentos frdep = new frmDepartamentos();
            frdep.Show();
            }
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {

            this.menuStrip1.Visible = true;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            
        }

 

        private void Form1_Click(object sender, EventArgs e)
        {
            this.menuStrip1.Visible = false;
        }

        private void menuStrip1_MouseLeave(object sender, EventArgs e)
        {
            this.menuStrip1.Visible = false;
        }


        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.menuStrip1.Visible = true;
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EjecutaModulo("frmUsuarios"))
            { 
            frmUsuarios frus = new frmUsuarios();
            frus.Show();
            }
        }

   
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
             if (EjecutaModulo("frmCliente")) {
                 this.productosToolStripMenuItem.Enabled = Generales.bPuede;
            frmCliente frClie = new frmCliente();
            frClie.Show();
             }
        }

        private void platillosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EjecutaModulo("frmProductos"))
            { 
            frmProductos frPrd = new frmProductos();
            frPrd.Show();
            }
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

             if (EjecutaModulo("frmProductos"))
            { 
            frmModulo frMod = new frmModulo();
            frMod.Show();
            }
        }

        private void generalesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administracionDeCajasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (EjecutaModulo("frmCajas")) { 
            frmCajas frCajas = new frmCajas();
            frCajas.Show();
            }
        }

        private void btnAbrirTurno_Click(object sender, EventArgs e)
        {
            this.AbrirTurno();

        }

        private void contraseñasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EjecutaModulo("frmContrasenas"))
            {
                frmContrasenas frCajas = new frmContrasenas();
                frCajas.Show();
            }
        }

        private void btnCierraTurno_Click(object sender, EventArgs e)
        {
            serCierraTurno serCierra = new serCierraTurno();
            serCierra.ShowDialog();

            btnCierraTurno.Enabled = false;
            btnRetiro.Enabled = false;
            btnDesbloquea.Enabled = true;
            this.ControlaControles(false);
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            serRetiro seRet = new serRetiro();
            seRet.ShowDialog();

           
        }

        private void btnDesbloquea_Click(object sender, EventArgs e)
        {
            serDesbloqueo serd = new serDesbloqueo();
            serd.ShowDialog();

            if (Generales.regresaValidacion())
            {
                btnCierraTurno.Enabled = true;
                btnRetiro.Enabled = true;
                btnDesbloquea.Enabled = false;
                this.ControlaControles(true);
            }
            else
            {
                Mensajes.Aviso("Contraseña incorrecta");
            }
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.usrProductos.txtNumero.Text="";
            this.ConsultaProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usrProductos.txtNumero.Text) || string.IsNullOrEmpty(txtDesdripProducto.Text))
            {
                Mensajes.Aviso("capture todos los datos");
            }
            else
            {
                this.CargaVenta();
                this.sumaTotal();
            }
          
        }
        private void Registra_Venta()
        {

        }

        public void GuardaVenta() 
        {

           int nFolioVenta = 0;
            int sCaja = Generales.nCaja; 
            int sCajero = Generales.nUsuario;
            decimal nCambio=Generales.Cambio;
            string sDireccion = "lomas taurinas";
            int nTurno=Generales.nTurno;
            decimal Subtotal = Generales.subtotal;
            decimal nIVA = Convert.ToDecimal( txtIva.Text);
            decimal nTotal = Convert.ToDecimal(txtTotal.Text);
            int nCantidad = Convert.ToInt16(txtCantArticulos.Text);
          
                cmd = new SqlCommand("SP_Registra_Venta", XSQL.gSqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pVenta = new SqlParameter("@nVenta", SqlDbType.Int);
                pVenta.Direction = ParameterDirection.InputOutput;
                pVenta.Value = nFolioVenta;
            
                cmd.Parameters.Add(pVenta);




                SqlParameter pCajero = new SqlParameter("@nCajero", SqlDbType.Int);
                pCajero.Value = sCajero;
                cmd.Parameters.Add(pCajero);

                

                SqlParameter pDireccion = new SqlParameter("@sDireccion", SqlDbType.VarChar, 50);
                pDireccion.Value = sDireccion;
                cmd.Parameters.Add(pDireccion);

                SqlParameter pCaja = new SqlParameter("@nCaja", SqlDbType.Int);
                pCaja.Value = sCaja;
                cmd.Parameters.Add(pCaja);

                SqlParameter pTurno = new SqlParameter("@nTurno", SqlDbType.Int);
                pTurno.Value = nTurno;
                cmd.Parameters.Add(pTurno);

                SqlParameter pCambio = new SqlParameter("@nCambio", SqlDbType.Money);
                pCambio.Value = Generales.Cambio;
                cmd.Parameters.Add(pCambio);

                SqlParameter pSubtotal = new SqlParameter("@nSubtotal", SqlDbType.Money);
                pSubtotal.Value = Subtotal;
                cmd.Parameters.Add(pSubtotal);

                SqlParameter pIva = new SqlParameter("@nIva", SqlDbType.Money);
                pIva.Value = nIVA;
                cmd.Parameters.Add(pIva);

                SqlParameter pTotal = new SqlParameter("@nTotal", SqlDbType.Money);
                pTotal.Value = nTotal;
                cmd.Parameters.Add(pTotal);

                SqlParameter pCantidad = new SqlParameter("@nCantidad", SqlDbType.Int);
                pCantidad.Value = nCantidad;
                cmd.Parameters.Add(pCantidad);

                try
                {
                    XSQL.gSqlCon.Open();
                    cmd.ExecuteNonQuery();

                     Generales.gFolioVentas = (int) pVenta.Value;

                    Mensajes.Aviso("Gracias por su compra ");
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
        private void sumaTotal()
        {
                      

                           decimal Total = 0;
                           decimal subtotal = 0;
                           decimal Iva = 0;
                           int CantidadArticulos = 0;
                       foreach (DataGridViewRow row in dtgVenta.Rows)
                         {
                             Total += Convert.ToDecimal( row.Cells["Total"].Value);
                             subtotal += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                             Iva += Convert.ToDecimal(row.Cells["Iva"].Value);
                             CantidadArticulos += Convert.ToInt16(row.Cells["Cantidad"].Value);
                      }

                       this.txtTotal.Text = Total.ToString();
                       this.txtSubtotal.Text = subtotal.ToString();
                       this.txtIva.Text = Iva.ToString();
                       this.txtCantArticulos.Text = CantidadArticulos.ToString();

                       Generales.TotalVenta = Total;
                       Generales.subtotal = subtotal;

        }
        private void Detalle_Venta()
        { 

            int nDetalle = Generales.gFolioVentas;
            int sArticulo = 0;
            decimal nPrecio = 0; 
           // decimal nIVA = 0;
            decimal nImporte = 0;
            decimal nImporte_Iva = 0; 
            int nCantidad = 0;


            cmd = new SqlCommand("SP_Registra_DetalleVenta", XSQL.gSqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pVenta = new SqlParameter("@nDetalle", SqlDbType.Int);
            pVenta.Direction = ParameterDirection.InputOutput;
            pVenta.Value = Generales.gFolioVentas;
            cmd.Parameters.Add(pVenta);

       
            SqlParameter pArticulo = new SqlParameter("@nArticulo", SqlDbType.Int);
            pArticulo.Value = sArticulo;
            cmd.Parameters.Add(pArticulo);

            SqlParameter pCantidad = new SqlParameter("@nCantidad", SqlDbType.Int);
            pCantidad.Value = nCantidad;
            cmd.Parameters.Add(pCantidad);

            SqlParameter pPrecio = new SqlParameter("@nPrecio", SqlDbType.Money);
            pPrecio.Value = nPrecio;
            cmd.Parameters.Add(pPrecio);

            SqlParameter pIva = new SqlParameter("@nIva", SqlDbType.Money);
            pIva.Value = Convert.ToDecimal( nIVA);
            cmd.Parameters.Add(pIva);


            SqlParameter pImporte = new SqlParameter("@nImporte", SqlDbType.Money);
            pImporte.Value = nImporte;
            cmd.Parameters.Add(pImporte);


            SqlParameter pImporteIva = new SqlParameter("@nImporte_iva", SqlDbType.Money);
            pImporteIva.Value = nImporte_Iva;
            cmd.Parameters.Add(pImporteIva);

            



            try
            {

                foreach (DataGridViewRow row in dtgVenta.Rows)
                {

                    if (!row.IsNewRow)
                    {

                        cmd.Parameters["@nDetalle"].Value = Generales.gFolioVentas;
                        cmd.Parameters["@nArticulo"].Value = row.Cells[0].Value;
                        cmd.Parameters["@nCantidad"].Value = row.Cells[1].Value;
                        cmd.Parameters["@nPrecio"].Value = row.Cells[3].Value;    
                        cmd.Parameters["@nImporte"].Value = row.Cells[4].Value;
                        cmd.Parameters["@nIva"].Value = row.Cells[8].Value;
                        //cmd.Parameters["@nIva"].Value = nIVA;
                        cmd.Parameters["@nImporte_iva"].Value = row.Cells[6].Value;

                        XSQL.gSqlCon.Open();

                        cmd.ExecuteNonQuery();  

                        //i++;
                        XSQL.gSqlCon.Close();
                    }

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
        private void usrProductos_Validated(object sender, EventArgs e)
        {
            this.ConsultaProductos();
          
         
        }

        private void txtDesdripProducto_Validated(object sender, EventArgs e)
        {
           this.ConsultaProductos();
        }

        public void Eliminar()
        {

            try
            {
                dtgVenta.Rows.RemoveAt(dtgVenta.CurrentRow.Index);
            }
            catch { }
        }

        private void dtgVenta_DoubleClick(object sender, EventArgs e)
        {
            this.Eliminar();
            this.sumaTotal();
        }

        private void dtgProductos_DoubleClick(object sender, EventArgs e)
        {
            string sNumfolio;

            sNumfolio = this.dtgProductos[0, dtgProductos.CurrentCell.RowIndex].Value.ToString();
            this.usrProductos.txtNumero.Text = sNumfolio;

            this.ConsultaProductos();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            serCobrar srCobra = new serCobrar();
            srCobra.ShowDialog();

             if (Mensajes.Pregunta("Desea guardar Venta?"))
            {
              this.GuardaVenta();
            this.Detalle_Venta();
            dtgVenta.Rows.Clear();
            this.sumaTotal();
            }
            

        }

        private void bnCancelar_Click(object sender, EventArgs e)
        {
            if (Mensajes.Pregunta("Desea Cancelar venta?"))
            {
                dtgVenta.Rows.Clear();
                dtgVenta.Refresh();
                this.sumaTotal();
            }
           
        }

        private void dtgVenta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           // this.CargaVenta();
        }
       
    }
}
