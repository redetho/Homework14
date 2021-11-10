using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
         abstract class Formas
    {
        //construtores e overrides
        public Color Color { get; set; }
        public Formas(Color cor)
        {
            Color = cor;
        }

        public abstract double Área();
    }
}