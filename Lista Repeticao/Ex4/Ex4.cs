using System;

/* Supondo que a população de um país A seja da ordem de 80000 habitantes com uma taxa anual de crescimento
 e 3% e que a população de B seja 200000 habitantes com uma taxa de crescimento de 1.5%. Faça um programa que
calcule e escreva o número de anos necessários para que a população do país A ultrapasse ou iguale
a população do país B, mantidas as taxas de crescimento.*/
public class exercicio4
{
    public void Ex4()
    {
        double a = 80000;
        double b = 200000;
        double ano = 0;

        while(a <= b)
        {
            a += a * 0.03;
            b += b * 0.015;
            ano += 1;
        }

        Console.WriteLine("A ultrapassa ou iguala a B em " + ano + " anos");
    }
}