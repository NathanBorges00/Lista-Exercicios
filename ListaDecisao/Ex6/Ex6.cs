using System;
/* Faça um Programa que leia três números e mostre o maior deles.*/
public class exercicio6
{
    public void Ex6()
    {
        int maior = 0;
        for(int i = 0; i < 3; i++)
        {
            Console.Write("Digite um numero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num > maior)
            {
                maior = num;
            }
        }

        Console.Write("Maior numero é: " + maior);
        Console.ReadKey();
    }
}