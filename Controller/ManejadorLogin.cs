using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks; 

namespace Controller
{
    public class ManejadorLogin
    {
        Funciones f = new Funciones();

        public string[] Validar(string _user, string _pass)
        {
            string[] resultado = new string[2];
            DataSet r = f.Mostrar($"call p_validar('{_user}', '{Sha1(_pass)}')", "usuarios");
            DataTable dt = r.Tables[0];
            resultado[0] = dt.Rows[0]["rs"].ToString();
            resultado[1] = dt.Rows[0]["Nivel"].ToString(); // Devuelve nivel como string
            return resultado;
        }

        public static string Sha1(string texto)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(texto);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }
    }
}
