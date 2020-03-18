using System;

public class exercicio14
{
    public void Ex14()
    {
        int nums, par = 0, impar = 0;

        System.Console.WriteLine("Digite 10 numeros inteiros: ");

        for(int i = 0; i < 10; i++)
        {
            nums = Convert.ToInt32(Console.ReadLine());

            if(nums % 2 == 0)
            {
                par = par + 1;
            }
            else
            {
                impar = impar + 1;
            }
        }

        System.Console.WriteLine("Numeros pares: "+ par);
        System.Console.WriteLine("Numeros impares: "+ impar);
    }
}