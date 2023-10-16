using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class Validaciones
    {
        public static bool ValidarCampo(string nombre)
        {
            bool retorno = true;

            if (!Validaciones.ValidarString(nombre))
            {
                retorno = false;
            }

            if (!nombre.All(letra => char.IsLetter(letra)))
            {
                retorno =  false;
            }

            return retorno;
        }

        public static bool ValidarCampo(string email, char caracter) 
        {
            bool retorno = true;
            if (!Validaciones.ValidarString(email)) 
            {
                retorno = false;
            }
            if (!email.All(letra => char.IsLetter(letra) || letra == caracter || letra == '.'))
            {
                retorno = false;
            }

            return retorno;
           
        }

        private static bool ValidarString(string cadena) 
        {
            bool retorno = true;

            if (cadena.Length > 25)
            {
                retorno = false;
            }

            if (string.IsNullOrEmpty(cadena))
            {
                retorno = false;
            }

            return retorno;
        }
    }
}
