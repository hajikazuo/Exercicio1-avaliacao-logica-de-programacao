using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_avaliacao_logica_de_programacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Faça um programa que receba o nome do aluno, nota de trabalho, nota da prova 1 e nota da prova 2. Calcule a média  final (média simples) e apresente o conceito obtido seguindo a seguinte formula:

            //O conceito da será calculado da seguinte forma:
            //Se a nota final for maior ou igual a 8.5, então o conceito é A.
            //Se a nota final estiver entre 7.0 e 8.4, então o conceito é B.
            //Se a nota final estiver entre 6.0 e 6.9, então o conceito é C.
            //Se a nota final estiver entre 0.1 e 5.9, então o conceito é D.
            //Se a nota final for igual a 0.0, então o conceito é E.

            string nome;
            double notatrabalho, notaprova1, notaprova2, mediafinal;


            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.Write("Digite a nota do trabalho: ");
            notatrabalho = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota da primeira prova: ");
            notaprova1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota da segunda prova: ");
            notaprova2 = double.Parse(Console.ReadLine());

            mediafinal = ((notatrabalho + notaprova1 + notaprova2) / 3);

            if (mediafinal >= 8.5 && mediafinal <= 10)
            {
                Console.Write(nome + " seu conceito foi: A");
            }
            else if (mediafinal <= 8.4 && mediafinal >= 7)
            {
                Console.Write(nome + " seu conceito foi: B");
            }
            else if (mediafinal <= 6.9 && mediafinal >= 6)
            {
                Console.Write(nome + " seu conceito foi: C");
            }
            else if (mediafinal >= 0.1 && mediafinal <= 5.9)
            {
                Console.Write(nome + " seu conceito foi: D");
            }
            else if (mediafinal == 0)
            {
                Console.Write(nome + " seu conceito foi: E");
            }
            Console.ReadKey();

        }
    }
}
