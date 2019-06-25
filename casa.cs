using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicar_Herencias
{
    public class casa : humano
    {
        private string _direccion;
        private int _numerodecuenta; 

        public string Direccion { get => _direccion; set => _direccion = value; }
        public int Numerodecuenta { get => _numerodecuenta; set => _numerodecuenta = value; }
    }
}
