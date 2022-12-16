using System;

namespace UTS2TebakAngka
{
    class Program
    {
        static void Main(string[] args)
        {
            int angka = 15;
            bool diTebak = false;
            while(!diTebak)
            {
                Console.Write("Tebak angka antara 1-100 : ");
                int angkaTebakan = Convert.ToInt32(Console.ReadLine());
                if(angkaTebakan==angka)
                {
                    Console.WriteLine("Anda Benar!");
                    Console.WriteLine("Bye...");
                    break;
                }
                else if(angkaTebakan<angka)
                {
                    Console.WriteLine("Salah, Nilai terlalu rendah.");
                }
                else if(angkaTebakan>angka)
                {
                    Console.WriteLine("Salah, Nilai terlalu tinggi.");
                }
            }
        }
    }
}
