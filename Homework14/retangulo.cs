using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
    class Retangulo : Formas
    {
        //construtores e overrides
        public double Largura { get; set; }
        public double Altura { get; set; }
        public Retangulo(double largura, double altura, Color cor) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double Área()
        {
            return (Largura * Altura);
        }
    }
}