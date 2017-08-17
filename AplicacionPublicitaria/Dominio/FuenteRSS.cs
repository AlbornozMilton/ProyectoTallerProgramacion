using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionPublicitaria.Dominio
{
    class FuenteRSS:Fuente
    {
        private string iURL;
        private string iDescripcion;

        public FuenteRSS(string pURL, string pDescripcion)
        {
            this.iDescripcion = pDescripcion;
            this.iURL = pURL;
        }
    }
}
