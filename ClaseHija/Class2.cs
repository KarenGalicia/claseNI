using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase.ClaseBase;

namespace clase.ClaseHija
{
    internal class Class2
    {
    
        internal class NintendoClass : Class1
        {
            public bool Esportatil { get; set; }

            public string MostrarDetallesNintendo()
            {
                MostrarDetalles();
                return $"Es portátil: {Esportatil}";
            }
        }
    }
}

