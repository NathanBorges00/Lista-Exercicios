using System;
/* Desenvolva um gerador de tabuada, capaz de gerar a tabuada de qualquer número inteiro entre 1 a 10. 
O usuário deve informar de qual numero ele deseja ver a tabuada. A saída deve ser conforme o exemplo abaixo:
Tabuada de 5:
5 X 1 = 5
5 X 2 = 10
...
5 X 10 = 50*/
public class exercicio12
{
    public void Ex12()
    {
        Console.Write("Qual tabuada deseja? ");
        int tabuada = Convert.ToInt32(Console.ReadLine());

        Console.Write("Tabuada do " + tabuada + ":");
        Console.Write("\n");
        Console.Write("\n");

        for(int i = 1; i <= 10; i++)
        {
            Console.Write(tabuada + " x " + i + " = " + (tabuada * i));
            Console.Write("\n");
        }

        Console.ReadKey();
    }
}