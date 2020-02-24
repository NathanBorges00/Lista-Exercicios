using System;
/* Faça um programa para a leitura de duas notas parciais de um aluno. O programa deve calcular a
 média alcançada por aluno e apresentar:
A mensagem "Aprovado", se a média alcançada for maior ou igual a sete;
A mensagem "Reprovado", se a média for menor do que sete;
A mensagem "Aprovado com Distinção", se a média for igual a dez.*/
public class exercicio5
{
    public void Ex5()
    {
        Console.Write("Insira a nota do aluno: ");
        int nota1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira a outra nota do aluno: ");
        int nota2 = Convert.ToInt32(Console.ReadLine());

        int media = (nota1 + nota2) / 2;

        if(media == 10)
        {
            Console.Write("\nAluno aprovado com distinção");
        }
        
        else if(media >= 7)
        {
            Console.Write("\nAluno aprovado!!");
        }
        else
        {
            Console.Write("\nAluno reprovado!!");
        }

        Console.ReadKey();
    }
}