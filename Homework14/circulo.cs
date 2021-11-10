using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
    class Círculo : Formas
    {
        //construtores e overrides
        public double Raio { get; set; }
        public Círculo(double raio, Color cor) : base(cor)
        {
            Raio = raio;
            Color = cor;
        }
        public override double Área()
        {
            return Math.PI * (Raio * Raio);
        }
    }
}