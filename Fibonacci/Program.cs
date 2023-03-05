using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        int posicao;

        Console.WriteLine("Informe o número: ");
        posicao = int.Parse(Console.ReadLine());

        int[] vetor = new int[posicao];

        vetor[0] = 1;


        if (posicao == 1)
        {
            Console.WriteLine(vetor[0]);
        }
        else if (posicao == 2)
        {
            vetor[1] = 1;
            Console.Write(vetor[0] + ", " + vetor[1]);
        }
        else
        {
            vetor[1] = 1;

            for (int i = 2; i < posicao; i++)
            {
                vetor[i] = vetor[i - 1] + vetor[i - 2];
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + ", ");
            }

        }





    }
}