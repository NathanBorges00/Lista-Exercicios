using System;

    class Teste
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque um numero a ser somado: ");
            int soma1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Coloque outro numero a ser somado: ");
            int soma2 = Convert.ToInt32(Console.ReadLine());

            ex2 soma = new ex2();
            Console.WriteLine("O resultado foi: " + soma.Ex2(soma1,soma2));
            

            Console.ReadKey();
        }
    }
