using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicar_Herencias
{
    public class humano
    {
        private string _nombre;
        private int _edad;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Edad { get => _edad; set => _edad = value; }
    }
}
