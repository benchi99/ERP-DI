using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP
{
    public class Utils
    {
        public static bool esDniValido(string dni)
        {
            string juegoChar = "TRWAGMYFPDXBNJZSQVHLCKE";
            bool valido = false;

            if (dni.Length != 9)
            {
                return false;
            }
            else
            {
                char letraInsertada = dni[9];
                for (int i = 0; i < juegoChar.Length; i++)
                {
                    if (letraInsertada == juegoChar[i])
                    {
                        valido = true;
                        break;
                    }
                }
                return valido;
            }
        }

    }
}
