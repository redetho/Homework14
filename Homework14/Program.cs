using System;
using System.Globalization;
using System.Collections.Generic;

namespace Homework14
{
    class Program
    {
        static void Main(string[] args)
        {
            //cria uma lista e prepara para receber a quantidade de formas.
            List<Formas> list = new List<Formas>();
            //recebe o numero de formas para o for.
            Console.WriteLine("-Insira o número de formas: ");
            int m = int.Parse(Console.ReadLine());

            for (int i = 1; i < m + 1; i++)
            {
                //pede cor, e pergunta se é um circulo ou retangulo.
                Console.WriteLine("Forma " +i +": ");
                Console.WriteLine("Digite R para retângulo ou C para círculo.");
                char c = char.Parse(Console.ReadLine());
                //se for digitado R, pede informações do retângulo
                if (c == 'R')
                {
                    Console.WriteLine("Digite a altura de seu retângulo: ");
                    double altura = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a largura de seu retângulo: ");
                    double largura = double.Parse(Console.ReadLine());
                    Console.WriteLine("A cor será preta, azul ou vermelha? (0,1 ou 2)");
                    Color cor = Enum.Parse<Color>(Console.ReadLine());

                    list.Add(new Retangulo(largura, altura, cor));
                }
                //se for digitado C, pede informações do círculo.
                else if (c == 'C')
                {
                    Console.WriteLine("Digite o Raio de seu círculo: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("A cor será preta, azul ou vermelha? (0,1 ou 2)");
                    Color cor = Enum.Parse<Color>(Console.ReadLine());

                    list.Add(new Círculo(raio, cor));
                }
                //se alguma outra tecla for digitada, erro.
                else
                {
                    Console.WriteLine("caractere inválido!");
                }

            }
            //apresenta a área de cada forma
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Área de cada forma: ");
            foreach (Formas forma in list)
            {
                Console.WriteLine(forma.Área().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}