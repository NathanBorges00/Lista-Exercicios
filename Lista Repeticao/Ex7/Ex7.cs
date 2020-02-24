using System;
/* Faça um programa que leia 5 números e informe o maior número.*/
public class exercicio7
{
    public void Ex7()
    {
        int maior = 0;
        
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Infome um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if(numero > maior)
            {
                maior = numero;
            }
        }

        Console.Write("\nMaior numero: " + maior);

        Console.ReadKey();
    }
}