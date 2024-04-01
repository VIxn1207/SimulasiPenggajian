using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulasi_PenggajianNew2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ulangAplikasi = true;
            string respon;
            string nama;
            int inputJabatan;
            int inputStatusPernikahan;
            double gaji;
            double tunjangan;
            double totalPendapatan;

            Console.Title = "SIMULASI PENGGAJIAN";
            while (ulangAplikasi)
            {
                double inputJumlahAnak = 0;

                Console.WriteLine("SELAMAT DATANG DI APLIKASI SIMULASI PENGGAJIAN");
                Console.WriteLine("PT. SUARA NUSA MULTIMEDIA");
                Console.WriteLine();

                Console.WriteLine("Lengkapi Data Anda Sesuai Dengan Panduan Yang Ada!!");
                Console.WriteLine();

                Console.Write("Input Nama Lengkap                           : ");
                nama = Convert.ToString(Console.ReadLine());
                nama = nama.ToUpper();
                Console.WriteLine();


                 //DAFTAR JABATAN
                Console.WriteLine("Daftar Jabatan :");
                Console.WriteLine("1. Direktur");
                Console.WriteLine("2. Manajer");
                Console.WriteLine("3. Staff");
                Console.WriteLine("4. OB");
                Console.Write("Input Urutan Jabatan (1/2/3/4)               : ");
                inputJabatan = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                //STATUS PERKAWINAN
                Console.WriteLine("Daftar Status Perkawinan :");
                Console.WriteLine("1. Menikah");
                Console.WriteLine("2. Duda/Janda");
                Console.WriteLine("3. Belum Menikah");
                Console.Write("Input Urutan Status Perkawinan (1/2/3)       : ");
                inputStatusPernikahan = Convert.ToInt32(Console.ReadLine());
                
                if (inputStatusPernikahan == 1 || inputStatusPernikahan == 2)
                {
                    Console.WriteLine();
                    Console.Write("Input Jumlah Anak                            : ");
                    inputJumlahAnak = Convert.ToDouble(Console.ReadLine());
                }
                else if (inputStatusPernikahan == 3)
                {
                    inputJumlahAnak = 0;
                }

                //PERHITUNGAN
                         //GAJI
                gaji = (inputJabatan == 1) ? 7500000 :
                       (inputJabatan == 2) ? 5500000 :
                       (inputJabatan == 3) ? 3500000 :
                       (inputJabatan == 4) ? 1500000 : 0;
                string formatGaji = gaji.ToString("N0").Replace(",",".");
                         //TUNJANGAN
                tunjangan = (inputStatusPernikahan == 1 || inputStatusPernikahan == 2) && (inputJumlahAnak == 0) ? 250000 :
                            (inputStatusPernikahan == 1 || inputStatusPernikahan == 2) && (inputJumlahAnak == 1) ? 500000 :
                            (inputStatusPernikahan == 1 || inputStatusPernikahan == 2) && (inputJumlahAnak >= 2) ? 750000 : 0;
                string formatTunjangan = tunjangan.ToString("N0").Replace(",", ".");
                        //TOTAL PENDAPATAN
                totalPendapatan = gaji + tunjangan;
                string formatTotal = totalPendapatan.ToString("N0").Replace(",", ".");

               
                //HASIL AKHIR
                Console.WriteLine();
                Console.WriteLine("SIMULASI KITIR GAJI");
                Console.WriteLine();

                Console.WriteLine("NAMA                 : " + nama);
                Console.WriteLine("JABATAN              : " + cekJabatan(inputJabatan));
                Console.WriteLine("STATUS PERKAWINAN    : " + cekStatusPernikahan(inputStatusPernikahan));
                Console.WriteLine("JUMLAH ANAK          : " + inputJumlahAnak);
                Console.WriteLine("GAJI                 : Rp. " + formatGaji + ",-");
                Console.WriteLine("TUNJANGAN            : Rp. " + formatTunjangan + ",-");
                Console.WriteLine("TOTAL PENDAPATAN     : Rp. " + formatTotal + ",-");

                Console.WriteLine();

                //ULANG-PROGRAM
                Console.Write("Ulang Aplikasi? (Y/T) : ");
                respon = Console.ReadLine();
                respon = respon.ToUpper();
                if (respon == "Y" || respon == "y")
                {
                    ulangAplikasi = true;

                }
                else
                {
                    ulangAplikasi = false;
                    return;
                }
                Console.Clear();

            }
            Console.ReadLine();
            
        }

        static string cekJabatan(double inputJabatan)
        {
            if (inputJabatan == 1)
            {
                return "Direktur";
            }
            else if (inputJabatan == 2)
            {
                return "Manajer";
            }
            else if (inputJabatan == 3)
            {
                return "Staff";
            }
            else if (inputJabatan == 4)
            {
                return "OB";
            }
            else {
                return "Unknown";
            }
        }

        static string cekStatusPernikahan(double inputStatusPernikahan)
        {
            if (inputStatusPernikahan == 1)
            {
                return "Menikah";
            }
                else if (inputStatusPernikahan == 2)
            {
                return "Duda/Janda";
            }
            else if (inputStatusPernikahan == 3)
            {
                return "Belum Menikah";
            }
            else
            {
                return "Unknown";
            }
        }
    }
}
