using System;
/* Faça um Programa que leia três números e mostre o maior e o menor deles.*/
public class exercicio7
{
    public void Ex7()
    {
        int maior = 0;
        int menor = 9999;

        for(int i = 0; i < 3; i++)
        {
            Console.Write("Digite um numero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num > maior)
            {
                maior = num;
            }
            if(num < menor)
            {
                menor = num;
            }
        }

        Console.Write("\nMaior: " + maior);
        Console.Write("\nMenor: " + menor);

        Console.ReadKey();
    }
}