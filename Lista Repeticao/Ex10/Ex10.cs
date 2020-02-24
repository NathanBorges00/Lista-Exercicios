using System;
/* Faça um programa que receba dois números inteiros e gere os números inteiros que estão no
 intervalo compreendido por eles.*/
public class exercicio10
{
    public void Ex10()
    {
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
            Console.Write(i+ " ");
        }
    }
}