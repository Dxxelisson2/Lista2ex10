using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2_ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1;
            double p2;
            double n;
            Console.Write("Digite o valor de p1: ");
            p1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de p2: ");
            p2 = double.Parse(Console.ReadLine());
            n = (p1 + (2 * p2)) / 3;
            if (n >= 5)
                Console.Write("aluno aprovado: ");
            else
                Console.Write("aluno reprovado: ");


        }
    }
}
