using System;
using System.Data.SqlClient;
using System.IO;

namespace PuntoVenta
{
    

    class XSQL
    {
        public static SqlConnection SQLcon; 

        public static bool conecta(string sCadena)
        {
            SQLcon = new SqlConnection(sCadena);

             bool bExito =false;

            try
            {
                SQLcon.Open();

                 bExito = true;
                
            }
            catch (Exception ex)
            {
                Mensajes.Error("Ha ocurrido un error en el Sistema " + ex.Message);
            }
            finally
            {
                SQLcon.Close();
            }
            return bExito;
        }

        public static SqlConnection gSqlCon; 
        public static void Leer_Cadena()
        {
            string sRuta = cadena.gsPathGral;

            StreamReader reader = new StreamReader(sRuta + "\\Cadena.txt");
            string sCadena = reader.ReadLine();
            reader.Close();

            gSqlCon = new SqlConnection(sCadena);
        }
    }
}
