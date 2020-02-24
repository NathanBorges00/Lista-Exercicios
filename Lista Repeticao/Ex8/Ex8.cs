using System;
/* Faça um programa que leia 5 números e informe a soma e a média dos números.*/
public class exercicio8
{
    public void Ex8()
    {
        int soma = 0;
        int media = 0;
        int count = 5;

        for (int i = 0; i < count; i++)
        {
            Console.Write("Informe um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            soma = soma + numero;
        }

        Console.Write("\nSoma: " + soma);

        media = soma / count;
        Console.Write("\nMedia: " + media);

        Console.ReadKey();
    }
}