using System;
/* Faça um Programa que verifique se uma maiuscula digitada é vogal ou consoante.*/
public class exercicio4
{
    public void Ex4()
    {
        Console.Write("Insira uma maiuscula qualquer: ");
        string letra = Console.ReadLine();
        string maiuscula = letra.ToUpper();

        if (maiuscula == "A" || maiuscula == "E" || maiuscula == "I" || maiuscula == "O" || maiuscula == "U")
        {
            Console.Write("\nLetra digitada é uma vogal!!");
        }
        else
        {
            Console.Write("\nLetra digitada é uma consoante!!");
        }

        Console.ReadKey();
    }
}