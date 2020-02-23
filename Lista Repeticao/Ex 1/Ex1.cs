using System;
/* Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e 
continue pedindo até que o usuário informe um valor válido.*/
public class Ex1
{
    public void ex1()
    {
        int nota;
        Console.WriteLine("Insira a nota do aluno: ");
        nota = Convert.ToInt32(Console.ReadLine());

        //Console.ReadKey();

        while(nota < 0)
        {
            Console.WriteLine("Insira uma nota valida!");
            nota = Convert.ToInt32(Console.ReadLine());
        }
        Console.ReadKey();
    }
}