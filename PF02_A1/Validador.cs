using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF02_A1
{
    public class Validador
    {
        public static bool EsContrasenyaValida(string contrasenya)
        {
            return !string.IsNullOrEmpty(contrasenya)
            && contrasenya.Length >= 8
            && contrasenya.Contains('#');
        }

    }
}
