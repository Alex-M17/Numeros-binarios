using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    public class Binarios
    {
        private int[] _numeros = new int[10];
        public int[] Numeros
        {
            get { return _numeros; }
            set { }
        }

        private string[] _binario = new string[10];
        public string[] Binario
        {
            get { return _binario; }
            set { }
        }
    }
}
