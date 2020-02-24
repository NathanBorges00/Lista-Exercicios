using System;
/* Faça um Programa que verifique se uma letra digitada é "F" ou "M".
 Conforme a letra escrever: F - Feminino, M - Masculino, Sexo Inválido.*/
public class exercicio3
{
    public void Ex3()
    {
        Console.Write("Digite [f] ou [m]: ");
        string valor = Console.ReadLine();

        if(valor == "m" || valor == "M")
        {
            Console.Write("M - Masculino");
        }
        else if (valor == "f" || valor == "F")
        {
            Console.Write("F - Feminino");
        }
        else if(valor != "m" || valor != "f" || valor != "M" || valor != "F")
        {
            Console.Write("Sexo Invalido!!");
        }

        Console.ReadKey();
    }
}