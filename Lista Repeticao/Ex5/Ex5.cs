using System;
/* Altere o programa anterior permitindo ao usuário informar as populações e as taxas de crescimento iniciais.
 Valide a entrada e permita repetir a operação.*/
public class exercicio5
{
    public void Ex5()
    {
        double ano = 0;
        double crescimentoA;
        double crescimentoB;

        while(true)
        {
            Console.WriteLine("Informe a população do pais A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a taxa de crescimento do pais A: ");
            crescimentoA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a população do pais B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a taxa de crescimento do pais B: ");
            crescimentoB = Convert.ToDouble(Console.ReadLine());

            while(a <= b)
            {
                a += a * (crescimentoA / 100);
                b += b * (crescimentoB / 100);
                ano += 1;
            }

            Console.WriteLine("A ultrapassa ou iguala a B em " + ano + " anos");

            Console.WriteLine("Quer continuar? (s/n)");
            string continuar = Console.ReadLine();

            if (!continuar.Equals('s')) break;
            Console.ReadKey();
        }
    }
}