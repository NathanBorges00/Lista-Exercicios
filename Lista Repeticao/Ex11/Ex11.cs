using System;
/* Altere o programa anterior para mostrar no final a soma dos números.*/
public class exercicio11
{
    public void Ex11()
    {
        int soma = 0;
        
        Console.Write("Insira um numero: ");
        int numIni = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira um numero: ");
        int numFinal = Convert.ToInt32(Console.ReadLine());

        while(numFinal < numIni)
        {
            Console.Write("O primeiro numero tem que ser menor que o segundo numero!!");

            Console.Write("\nInsira um numero: ");
            numIni = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira um numero: ");
            numFinal = Convert.ToInt32(Console.ReadLine());
        }

        for(int i = numIni + 1; i <= numFinal - 1; i++)
        {
            Console.Write(i + " ");
            soma = soma + i;
        }

        Console.Write("\nSoma: " + soma);
    }
}