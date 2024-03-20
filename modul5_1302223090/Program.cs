// See https://aka.ms/new-console-template for more information
using System.Numerics;


namespace modul5_1302223090
{
    class Penjumlahan<T>
    {
        public static T JumlahTigaAngka <T>(T number1, T number2, T number3) where T : IAdditionOperators<T, T, T>
        {
            return number1 + number2 + number3;      
        }
       
    }
    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates; 

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
            
        }

        public void AddNewData(T input) 
        {
            storedData.Add(input);
            inputDates.Add(DateTime.Now);
        }
        public void printAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data "+ i + " berisi : " + storedData[i] + "yang disimpan pada waktu UTC: " + inputDates[i]);
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            long n1 = 12;
            long n2 = 34;
            long n3 = 56;
            long hasil = Penjumlahan<long>.JumlahTigaAngka(n1, n2, n3);
            Console.WriteLine(hasil);
            
            SimpleDataBase<int> data = new SimpleDataBase<int>();
            data.AddNewData(12);
            data.AddNewData(34);
            data.AddNewData(56);
            data.printAllData();
        }
    }
}