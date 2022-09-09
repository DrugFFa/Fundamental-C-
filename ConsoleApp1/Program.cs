//Program Sederhana Menghiitung Nilai Akhir Mahasiswa (Daffa Amanullah - A11.2019.11993)
using System;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int i;
            int jumlah;
            string jum;
            Console.WriteLine("Selamat Datang Di Program Penghitung Nilai Akhir");
            Console.Write("Masukkan Total Peserta = ");
            jum = Console.ReadLine();
            jumlah = Convert.ToInt32(jum);
            //ContohMethod totalpeserta = new ContohMethod();
            ContohMethod Name = new ContohMethod();
            ContohMethod TampilkanNilai = new ContohMethod();
            ContohMethod RataRata = new ContohMethod();
            TampilkanNilai.Pemisah(); //Akan menampilkan pemisah
            i = 0;
            while (i<jumlah)
            {
                Console.WriteLine("Hi, {0}", Name.NamaPeserta());//menampilkan nama peserta
                TampilkanNilai.Pemisah(); //Akan menampilkan pemisah
                Console.WriteLine("Nilai Akhir Kamu Adalah = {0}", RataRata.NilaiAkhir()); //Menampilkan Rata Rata Nilai UTS
                TampilkanNilai.Pemisah(); //Akan menampilkan pemisah
                i++;
            }
            
        } 
        public class ContohMethod
        {
            public int NilaiAkhir()
            {
                string val1,val2,val3;
                int uts, tugas, uas, akhir;
                Console.WriteLine("Masukkan Nilai UTS: ");
                val1 = Console.ReadLine();
                uts = Convert.ToInt32(val1); //convert string ke int
                Console.WriteLine("Masukkan Nilai UAS: ");
                val2 = Console.ReadLine();
                uas = Convert.ToInt32(val2);//convert string ke int
                Console.WriteLine("Masukkan Nilai Tugas: ");
                val3 = Console.ReadLine();
                tugas = Convert.ToInt32(val3);//convert string ke int

                akhir = (uts + tugas + uas) / 3;

                //Kondisi
                if (akhir > 85)
                {
                    Console.WriteLine("Selamat, Nilai kamu A, Ibumu pasti bangga");
                }
                else if (akhir > 70)
                {
                    Console.WriteLine("Mantap, Nilai kamu B");
                }
                else
                {
                    Console.WriteLine("Nilaimu saat ini adalah C, tetap semangat !");
                }
                 return akhir;

                
            }
            public void Pemisah()
            {
                
                Console.WriteLine("----------------------");
                
            }

            public string NamaPeserta()
            {
                Console.Write("Masukkan Nama Kamu Disini = ");
                string nama = Console.ReadLine();
                return nama;
            }

            //public int jumlahpeserta()
            //{
               // int jumlah;
               // string jum;
               // Console.Write("Masukkan Total Peserta = ");
                //jum = Console.ReadLine();
               // jumlah = Convert.ToInt32(jum);

               // return jumlah;
            //}

         
        }
    }
}
