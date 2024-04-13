using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using clase.ClaseBase;

namespace clase.ClaseHija
{
    internal class XboxClass : Class1
    {
        public bool LectorDisco { get; set; }
        public string MostrardetallesXbox()
        {


            MostrarDetalles();
            return $"Lector de Disco: (LectordeDisco)";

        }

        internal string MostrardetellesXbox()
        {
            throw new NotImplementedException();
        }
    }
}
