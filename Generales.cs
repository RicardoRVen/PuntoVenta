using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    class Generales
         
    {
        public static bool bAdmin; 
        public static int nUsuario; 
        public static string sUsuario;
        public static bool bPuede;
        public static string sCaja;
        public static int nCaja;
        public static int nTurno=0;
        public static string sContrasena;
        public static string sContra;
       
        
        //variables de venta 
        public static string nTotal;
        public static string nSTotal;  
        public static string nImporte;
        public static int gFolioVentas; 
        public static bool Venta; 
        //variables de tickt 
         
        public static decimal TotalVenta;
        public static decimal Cambio; 
        public static decimal subtotal;

        public static string CreaContrasena()
        {
            string sPass="";

            Random rnd = new Random();
            int n = rnd.Next(100000, 999999);
            sPass = n.ToString();

            return sPass; 

        }

        public static bool regresaValidacion()
        {
            bool sDesbloquea=false;
            if (sContra == sContrasena)
            {
                sDesbloquea = true;
            }
            return sDesbloquea;
        }
   }
}