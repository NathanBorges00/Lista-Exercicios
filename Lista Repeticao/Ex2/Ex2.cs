using System;
/* Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, 
mostrando uma mensagem de erro e voltando a pedir as informações.*/

public class exercicio2
{
    public void ex2 ()
    {
        string nome;
        string senha;

        Console.Write("Insira seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Insira sua senha: ");
        senha = Console.ReadLine();

        while(nome.Equals(senha))
        {
            Console.Write("Digite uma senha diferente do nome de usuario!!");
            senha = Console.ReadLine();
        }

        Console.ReadKey();
    }
}