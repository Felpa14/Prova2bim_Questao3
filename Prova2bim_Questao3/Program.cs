using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2bim_Questao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Olá, escolha a forma geométrica para calcular a área:\n1-Triângulo\n2-Losângo\n3-Trapézio\n-> ");
            int forma = Convert.ToInt32(Console.ReadLine());

            switch (forma)
            {
                case 1:
                    double area1, base1, altura1;
                    Console.Write("Quanto é a base? = ");
                    base1 = Double.Parse(Console.ReadLine());
                    Console.Write("Quanto é a altura? = ");
                    altura1 = Double.Parse(Console.ReadLine());
                    area1 = (base1 * altura1) / 2;
                    if (area1 < 1 || base1 < 1 || altura1 < 1) {
                        Console.Write("Um dos valores está negativo! Digite somente valores positivos.");
                    } else {
                        Console.Write("A área do Triângulo é de: " + area1);
                    }
                    break;

                case 2:
                    double area2, diag1, diag2;
                    Console.Write("Quanto é a diagonal 1? = ");
                    diag1 = Double.Parse(Console.ReadLine());
                    Console.Write("Quanto é a diagonal 2? = ");
                    diag2 = Double.Parse(Console.ReadLine());
                    area2 = (diag1 * diag2) / 2;
                    if (area2 < 1 || diag1 < 1 || diag2 < 1) {
                        Console.Write("Um dos valores está negativo! Digite somente valores positivos.");
                    } else {
                        Console.Write("A área do Losângo é de: " + area2);
                    }
                    break;

                case 3:
                    double area3, base2, base3, altura2;
                    Console.Write("Quanto é a base menor? = ");
                    base2 = Double.Parse(Console.ReadLine());
                    Console.Write("Quanto é a base maior? = ");
                    base3 = Double.Parse(Console.ReadLine());
                    Console.Write("Quanto é a altura? = ");
                    altura2 = Double.Parse(Console.ReadLine());
                    area3 = ((base2 + base3) * altura2) / 2;
                    if (area3 < 1 || base2 < 1 || base3 < 1 || altura2 < 1) {
                        Console.Write("Um dos valores está negativo! Digite somente valores positivos.");
                    } else {
                        Console.Write("A área do Trapézio é de: " + area3);
                    }
                    break;

                 default:
                    Console.Write("O número digitado não é válido!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
