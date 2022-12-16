using System;

namespace UTS1NameTag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Nama :");
            string nama = Console.ReadLine();
            Console.WriteLine("NIM  :");
            string NIM = Console.ReadLine();
            Console.WriteLine("Konsentrasi :");
            string konsentrasi = Console.ReadLine();
            Console.WriteLine("|**********************|");
            Console.WriteLine("|Nama: {0,16}|", nama);
            Console.WriteLine("|      {0,16}|", NIM);
            Console.WriteLine("|----------------------|");
            Console.WriteLine("|      {0,16}|", konsentrasi);
            Console.WriteLine("|**********************|");
            Console.ReadLine();
        }
    }
}
