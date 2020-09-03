using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class EspecieAnimal
    {
        public int IDZoo { get; set; } 
        public string NombreVulgar { get; set; }
        public string NombreCientifico { get; set; }
        public int cantAnimales { get; set; }
        public string ClaseAnimal { get; set; }
        public bool PeligroExtinción { get; set; }

        public EspecieAnimal()
        {
            cantAnimales = 0;
        }
    }
}
