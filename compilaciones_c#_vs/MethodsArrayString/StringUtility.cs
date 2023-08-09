using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsArrayString
{
    internal class StringUtility
    {
        //Método que recibe una cadena (string) como parametro, y debe retornar un número indicando la cantidad de espacios de la cadena.
        public static int CountSpaces(string text)
        {
            int suma = 0;
            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                    suma = suma + 1;
            }
            return suma;
        }

        //Método que recibe una cadena y un caracter, debe encontrar si el caracter existe dentro de la cadena, y retornar true/false.
        // Ej. "Murcielago vuela, 'a' ==> true
        // Ej. "Murcielago vuela, 'z' ==> false
        public static bool FindChar(string cadena, char car)
        {
            bool flag = false;
            for(int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == car)
                {
                    flag = true;
                }
            }
            return flag;
        }

    }

}
