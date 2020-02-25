using System;
/* Faça um programa que pergunte o preço de três produtos e informe qual produto você deve comprar, 
sabendo que a decisão é sempre pelo mais barato*/
public class exercicio8
{
    public void Ex8()
    {
        int menor = 9999;
        int count = 0;

        for(int i = 1; i < 4; i++)
        {
            Console.Write("Informe o preço do produto " + i + ":");
            int preco = Convert.ToInt32(Console.ReadLine());

            if(preco < menor)
            {
                menor = preco;
                count++;
            }
        }

        Console.Write("Sugiro comprar o produto " + count);

        Console.ReadKey();
    }
}