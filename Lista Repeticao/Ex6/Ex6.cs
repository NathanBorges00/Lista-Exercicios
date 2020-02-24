using System;
/* Faça um programa que imprima na tela os números de 1 a 20, um abaixo do outro. 
Depois modifique o programa para que ele mostre os números um ao lado do outro.*/
public class exercicio6
{
    public void Ex6()
    {
        //int primeiroNumero = 1;
        for (int i = 1; i < 21; i++)
        {
            Console.WriteLine(+ i);
        }

        Console.WriteLine("\n");

        for (int i = 1; i < 21; i++)
        {
            Console.Write(i + " ");
        }
    }
}