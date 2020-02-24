using System;
/* ça um programa que imprima na tela apenas os números ímpares entre 1 e 50.*/
public class exercicio9
{
    public void Ex9()
    {
        int count = 51;

        for(int i = 1; i < count; i++)
        {
            if(i % 2 != 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}