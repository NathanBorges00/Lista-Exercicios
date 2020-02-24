using System;

/* Faça um programa que leia e valide as seguintes informações:
Nome: maior que 3 caracteres;
Idade: entre 0 e 150;
Salário: maior que zero;
Sexo: 'f' ou 'm';
Estado Civil: 's', 'c', 'v', 'd';*/
public class exercicio3
{
    public void ex3()
    {
        Console.WriteLine("Preenche os campos a seguir!");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        //Console.WriteLine("\n");

        while(nome.Length < 3)
        {
            Console.Write("Digite um nome com mais de 3 caracteres!");
            nome = Console.ReadLine();
        }

        Console.Write("Idade: ");
        string idade = (Console.ReadLine());
        while(idade.Length < 0 || idade.Length > 150)
        {
            Console.Write("Digite um valor entre 0 e 150!");
            idade = Console.ReadLine();
        }

        Console.Write("Salario: ");
        int salario = Convert.ToInt32(Console.ReadLine());
        while(salario < 0)
        {
            Console.Write("Digite um valor maior que 0");
            salario = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Sexo [f] ou [m]: ");
        string sexo = Console.ReadLine();
        if(sexo != "m" || sexo != "f")
        {
            Console.Write("Somente F ou M");
            sexo = Console.ReadLine();
        }

        Console.Write("Estado civil: [s] [c] [v] [d]");
        string estado = Console.ReadLine();
        if(estado != "s" || estado != "c" || estado != "v" || estado != "d")
        {
            Console.Write("Somente as letras descritas!");
            estado = Console.ReadLine();
        }

        Console.ReadKey();
    }
}