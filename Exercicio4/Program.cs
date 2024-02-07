using System;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
      

            decimal faturSP = 67836.43m;
            decimal faturRJ = 36678.66m;
            decimal faturMG = 29229.88m;
            decimal faturES = 27165.48m;
            decimal faturOutros = 19849.53m;


            decimal totalMensal = faturSP + faturRJ + faturMG + faturES + faturOutros;

            decimal percenSP = (faturSP / totalMensal) * 100;
            decimal percenRJ = (faturRJ / totalMensal) * 100;
            decimal percenMG = (faturMG / totalMensal) * 100;
            decimal percenES = (faturES / totalMensal) * 100;
            decimal percenOutros = (faturOutros / totalMensal) * 100;

            Console.WriteLine($"Percentual de representação de SP: {percenSP:F2}%");
            Console.WriteLine($"Percentual de representação de RJ: {percenRJ:F2}%");
            Console.WriteLine($"Percentual de representação de MG: {percenMG:F2}%");
            Console.WriteLine($"Percentual de representação de ES: {percenES:F2}%");
            Console.WriteLine($"Percentual de representação de outros: {percenOutros:F2}%");
        }
    }
}
