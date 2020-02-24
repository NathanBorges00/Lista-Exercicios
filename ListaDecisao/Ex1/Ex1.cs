using System;
/* Faça um Programa que peça dois números e imprima o maior deles.*/
public class exercicio1
{
    public void Ex1()
    {

        int maior = 0;

        for(int i = 0; i < 2; i++)
        {
            Console.Write("Insira um numero inteiro: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 > maior)
            {
                maior = num1;
            }
        }   

        Console.Write("\nMaior numero é: " + maior);

        Console.ReadKey();
    }
}