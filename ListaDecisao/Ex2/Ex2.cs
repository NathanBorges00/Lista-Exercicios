using System;
/* Faça um Programa que peça um valor e mostre na tela se o valor é positivo ou negativo.*/
public class exercicio2
{
    public void Ex2()
    {
        Console.Write("Insira m valor: ");
        int valor = Convert.ToInt32(Console.ReadLine());

        if(valor < 0)
        {
            Console.Write("\nValor inserido é negativo!!");
        }
        else
        {
            Console.Write("\nValor inserido é positivo!!");
        }

        Console.ReadKey();
    }
}