using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase.ClaseBase;

namespace clase.ClaseHija
{
    internal class PlayStation: Class1
    {
        public string ModeloControlador { get; set; }
        public string MostrarDetallesPS()
        {
            MostrarDetallesPS();
            return $"Modelo de Controlador: {ModeloControlador}";
        }

        internal string MostrarDetallesPlaystation()
        {
            throw new NotImplementedException();
        }
    }
}