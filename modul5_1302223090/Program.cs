// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Hello, World!");

namespace modul5_1302223090
{
    class Penjumlahan<T>
    {
        public static T JumlahTigaAngka <T>(T number1, T number2, T number3) where T : IAdditionOperators<T, T, T>
        {
            return number1 + number2 + number3;      
        }
       
    }
    class Program
    {
        public static void Main(string[] args)
        {
            long n1 = 12;
            long n2 = 34;
            long n3 = 56;
            Penjumlahan<long>.JumlahTigaAngka(n1, n2, n3);
        }
    }
}