using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tugas_Akhir_7___Thread_Bangun_Ruang
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputan
            Console.WriteLine("Selamat Datang di Perhitungan Bangun Ruang : Balok");
            Console.Write("Masukan Panjang : ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Masukan Lebar : ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Masukan Tinggi  : ");
            int t = int.Parse(Console.ReadLine());

            //Output Versi 1
            Console.WriteLine("Volume Bangun ruang Balok : "); Thread.Sleep(1000);
            Console.WriteLine("Rumus : p x l x t"); Thread.Sleep(1000);
            Console.WriteLine("Jawaban : "); Thread.Sleep(1000);
            Console.WriteLine("          {0} x l x t = {1} ", p, p); Thread.Sleep(1000);
            Console.WriteLine("          {0} x {1} x t = {2}", p, l, p * l); Thread.Sleep(1000);
            int total = p * l * t;
            Console.WriteLine("          {0} x {1} x {2} = {3} ", p, l, t, total); Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("Volume Bangun Ruang Balok adalah {0}", total);

            //Output versi 2
            char[] arr = new char[] { 'p', 'x', 'l', 'x', 't', '=' };
            for (int a = 0; a < 6; a++)
            {
                Console.Write(arr[a]);
                Thread.Sleep(1000);
                if (a == 5)
                {
                    Console.Write("{0}", total);
                }

            }

            Console.ReadKey();
        }
    }
}
