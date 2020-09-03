using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Zoologico
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public double Tam { get; set; }
        public double PresupuestoAnual { get; set; }
        public int cantEspeciesEnExtinción { get; set; }
        public List<EspecieAnimal> Especies { get; set; }
       
        public Zoologico()
        {
            Especies = new List<EspecieAnimal>();
            cantEspeciesEnExtinción = 0;
        }
    }
}
