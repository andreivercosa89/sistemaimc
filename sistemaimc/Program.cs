using System;

namespace sistemaimc
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 1;

            do
            {

                Imc imc = new Imc();

                Console.WriteLine("Informe o Nome do aluno: ");
                imc.Nome = Console.ReadLine().ToUpper();

                Console.WriteLine("Informe o Peso: ");
                imc.Peso = Double.Parse(Console.ReadLine().Replace(".",","));

                Console.WriteLine("Informe a Altura: ");
                imc.Altura = Double.Parse(Console.ReadLine().Replace(".", ","));

                Console.WriteLine("{0}: {1}", imc.Nome, imc.getImc());

                Console.WriteLine("\n\nDeseja continuar: \n1 - Sim\n2 - Nao");
                op = Int32.Parse(Console.ReadLine());
                
            } while (op == 1);
        }
    }
}
