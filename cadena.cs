using System.IO;
using System.Windows.Forms;

namespace PuntoVenta
{
    class cadena
    {

        public static string gsPathGral = Path.GetDirectoryName(Application.ExecutablePath);







        public static void Escribe_datos(string sServidor, string sBD, string sAut, string sUser)
        {

            //metodo que genera el archivo de texto Datos en la ruta de ejecucion del programa
            //C:\Users\Ricar_000\Documents\Visual Studio 2013\Projects\Integrador\Integrador\bin\Debug

            string gsPathGral = Path.GetDirectoryName(Application.ExecutablePath);

            StreamWriter write = new StreamWriter(gsPathGral + "\\Datos.txt");

            write.WriteLine(sServidor);
            write.WriteLine(sBD);
            write.WriteLine(sAut);
            write.WriteLine(sUser);
            write.Close();

        }

        public static StreamReader Leer_datos()
        {
            // metodo para leer los datos del archivo de texto datos .txt con el comando streamReader
            StreamReader reader = new StreamReader(gsPathGral + "\\Datos.txt");

            return reader;
        }

        
    }
}
