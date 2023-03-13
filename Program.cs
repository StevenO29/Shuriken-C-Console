using System;

namespace Challenge__Shuriken_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan input : ");
            int inputPanjang = Convert.ToInt32(Console.ReadLine());
            int totalAtasBawah = (inputPanjang * 4) - 1;
            int totalKananKiri = (inputPanjang * 8) - 1;
            int horizontalTitikTengah = (totalKananKiri / 2);
            int verticalTitikTengah = (totalAtasBawah / 2);

            if (inputPanjang == 1)
            {
                Console.WriteLine("  *");
                Console.WriteLine("*   *");
                Console.WriteLine("  *");
            }
            else if (inputPanjang % 2 == 1) //input ganjil
            {
                int spasiSatuAtas = inputPanjang + ((inputPanjang / 2) - 1);
                int spasiDuaAtas = spasiSatuAtas + 1;
                int spasiTigaAtas = verticalTitikTengah;
                int spasiTigaBawah = spasiTigaAtas + (inputPanjang / 2);
                int spasiDuaBawah = spasiTigaBawah + 1;
                int spasiSatuBawah = spasiDuaBawah + (inputPanjang / 2);
                int jumlahSpasi = 1;
                for (int spasiHorizontal = 0; spasiHorizontal < totalAtasBawah; spasiHorizontal++)
                {
                    for (int spasiVertical = 0; spasiVertical < totalKananKiri; spasiVertical++)
                    {
                        if ((spasiVertical == horizontalTitikTengah && spasiHorizontal == 0)/*bintang paling atas*/ ||
                            (spasiVertical == (horizontalTitikTengah - spasiHorizontal) && spasiHorizontal > 0 && spasiHorizontal < inputPanjang)/*sisi miring segitiga atas kiri*/ ||
                            (spasiVertical == (horizontalTitikTengah + spasiHorizontal) && spasiHorizontal > 0 && spasiHorizontal < inputPanjang)/*sisi miring segitiga atas kanan*/ ||
                            (spasiVertical == horizontalTitikTengah - (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= inputPanjang && spasiHorizontal < spasiSatuAtas)/*bintang spasi 1 sisi kiri atas*/ ||
                            (spasiVertical == horizontalTitikTengah + (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= inputPanjang && spasiHorizontal < spasiSatuAtas)/*bintang spasi 1 sisi kanan atas*/ ||
                            (spasiVertical == horizontalTitikTengah - (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= spasiSatuAtas && spasiHorizontal < spasiDuaAtas)/*bintang spasi 1 sisi kiri atas kedua*/ ||
                            (spasiVertical == horizontalTitikTengah + (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= spasiSatuAtas && spasiHorizontal < spasiDuaAtas)/*bintang spasi 1 sisi kanan atas kedua*/ ||
                            (spasiVertical == horizontalTitikTengah - (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= spasiDuaAtas && spasiHorizontal < spasiTigaAtas)/*bintang spasi 2 sisi kiri atas*/ ||
                            (spasiVertical == horizontalTitikTengah + (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= spasiDuaAtas && spasiHorizontal < spasiTigaAtas)/*bintang spasi 2 sisi kanan atas*/ ||
                            (spasiVertical == horizontalTitikTengah - (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= spasiTigaAtas && spasiHorizontal < spasiTigaBawah)/*bintang paling kiri dan bawahnya (spasi 3)*/ ||
                            (spasiVertical == horizontalTitikTengah + (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= spasiTigaAtas && spasiHorizontal < spasiTigaBawah)/*bintang paling kanan dan bawahnya (spasi 3)*/ ||
                            (spasiVertical == horizontalTitikTengah - (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= spasiTigaBawah && spasiHorizontal < spasiDuaBawah)/*bintang spasi 2 sisi kiri bawah*/ ||
                            (spasiVertical == horizontalTitikTengah + (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= spasiTigaBawah && spasiHorizontal < spasiDuaBawah)/*bintang spasi 2 sisi kanan bawah*/ ||
                            (spasiVertical == horizontalTitikTengah - (spasiHorizontal + jumlahSpasi) + 4 && spasiHorizontal >= spasiDuaBawah && spasiHorizontal < spasiSatuBawah)/*2 bintang kiri terakhir spasi 1*/ ||
                            (spasiVertical == horizontalTitikTengah + (spasiHorizontal + jumlahSpasi) - 4 && spasiHorizontal >= spasiDuaBawah && spasiHorizontal < spasiSatuBawah)/*2 bintang kanan terakhir spasi 1*/ ||
                            (spasiVertical == spasiHorizontal - (verticalTitikTengah / 2) + inputPanjang && spasiHorizontal > totalAtasBawah - spasiSatuAtas + ((inputPanjang - 5) / 2)) && spasiHorizontal < totalAtasBawah - 1/*sisi miring segitiga bawah kiri*/ ||
                            (spasiVertical == (spasiHorizontal - (verticalTitikTengah / 2) + inputPanjang) + (((inputPanjang * 2) - 2) - (spasiHorizontal - (inputPanjang * 2)) - (spasiHorizontal - totalAtasBawah + 1)) && spasiHorizontal > totalAtasBawah - spasiSatuAtas + ((inputPanjang - 5) / 2) && spasiHorizontal < totalAtasBawah - 1)/*sisi miring kanan segitiga bawah*/ ||
                            (spasiVertical == horizontalTitikTengah && spasiHorizontal == (totalAtasBawah - 1))/*bintang paling bawah*/)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    if (spasiHorizontal >= inputPanjang && spasiHorizontal < spasiSatuAtas)
                        jumlahSpasi += 1;
                    else if (spasiHorizontal >= spasiSatuAtas && spasiHorizontal < spasiDuaAtas)
                        jumlahSpasi += 2;
                    else if (spasiHorizontal >= spasiDuaAtas && spasiHorizontal < spasiTigaAtas)
                        jumlahSpasi += 3;
                    else if (spasiHorizontal >= spasiTigaAtas && spasiHorizontal < spasiTigaBawah)
                        jumlahSpasi -= 5;
                    else if (spasiHorizontal >= spasiDuaBawah && spasiHorizontal < spasiDuaBawah)
                        jumlahSpasi -= 4;
                    else if (spasiHorizontal >= spasiDuaBawah && spasiHorizontal < spasiSatuBawah)
                        jumlahSpasi -= 3;
                    Console.Write("\n");
                }
            }
            else
            {
                int spasiSatuAtas = inputPanjang + ((inputPanjang / 2) - 2);
                int spasiDuaAtas = spasiSatuAtas + 2;
                int spasiTigaAtas = verticalTitikTengah;
                int spasiTigaBawah = spasiTigaAtas + ((inputPanjang / 2) - 1);
                int spasiDuaBawah = spasiTigaBawah + 2;
                int spasiSatuBawah = spasiDuaBawah + (inputPanjang / 2);
                int jumlahSpasi = 1;
                for (int spasiHorizontal = 0; spasiHorizontal < (inputPanjang * 4) - 1; spasiHorizontal++)
                {
                    for (int spasiVertical = 0; spasiVertical < (inputPanjang * 8) - 1; spasiVertical++)
                    {
                        if ((spasiVertical == horizontalTitikTengah && spasiHorizontal == 0) || /*bintang paling atas)*/
                            (spasiVertical == horizontalTitikTengah - spasiHorizontal && spasiHorizontal > 0 && spasiHorizontal < inputPanjang) || /*sisi miring segitiga atas kiri*/
                            (spasiVertical == horizontalTitikTengah + spasiHorizontal && spasiHorizontal > 0 && spasiHorizontal < inputPanjang) || /*sisi miring segitiga atas kanan*/
                            (spasiVertical == horizontalTitikTengah - (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= inputPanjang && spasiHorizontal < spasiSatuAtas) || /*bintang spasi 1 sisi kiri atas*/
                            (spasiVertical == horizontalTitikTengah + (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= inputPanjang && spasiHorizontal < spasiSatuAtas) || /*bintang spasi 1 sisi kanan atas*/
                            (spasiVertical == horizontalTitikTengah - (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= spasiSatuAtas && spasiHorizontal < spasiDuaAtas) || /*bintang spasi 2 sisi kiri atas*/
                            (spasiVertical == horizontalTitikTengah + (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= spasiSatuAtas && spasiHorizontal < spasiDuaAtas) || /*bintang spasi 2 sisi kanan atas*/
                            (spasiVertical == horizontalTitikTengah - (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= spasiDuaAtas && spasiHorizontal < spasiTigaAtas) || /*bintang spasi 3 sisi kiri atas*/
                            (spasiVertical == horizontalTitikTengah + (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= spasiDuaAtas && spasiHorizontal < spasiTigaAtas) || /*bintang spasi 3 sisi kanan atas*/
                            (spasiVertical == horizontalTitikTengah - (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= spasiTigaAtas && spasiHorizontal < spasiTigaBawah) || /*bintang paling kiri dan bawahnya (spasi 3)*/
                            (spasiVertical == horizontalTitikTengah + (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= spasiTigaAtas && spasiHorizontal < spasiTigaBawah) || /*bintang paling kanan dan bawahnya (spasi 3)*/
                            (spasiVertical == horizontalTitikTengah - (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= spasiTigaBawah && spasiHorizontal < spasiDuaBawah) || /*bintang spasi 2 sisi kiri bawah*/
                            (spasiVertical == horizontalTitikTengah + (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= spasiTigaBawah && spasiHorizontal < spasiDuaBawah) || /*bintang spasi 2 sisi kanan bawah*/
                            (spasiVertical == horizontalTitikTengah - (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= spasiDuaBawah && spasiHorizontal < spasiSatuBawah) || /*bintang spasi 1 sisi kiri bawah*/
                            (spasiVertical == horizontalTitikTengah + (spasiHorizontal + jumlahSpasi) && spasiHorizontal >= spasiDuaBawah && spasiHorizontal < spasiSatuBawah) || /*bintang spasi 1 sisi kanan bawah*/
                            (spasiVertical == spasiHorizontal - verticalTitikTengah / 2 + inputPanjang && spasiHorizontal > totalAtasBawah - spasiSatuAtas + ((inputPanjang - 5) / 2) && spasiHorizontal < totalAtasBawah - 1) || /*sisi miring segitiga bawah kiri*/
                            (spasiVertical == (spasiHorizontal - (verticalTitikTengah / 2) + inputPanjang) + (((inputPanjang * 2) - 2) - (spasiHorizontal - (inputPanjang * 2)) - (spasiHorizontal - totalAtasBawah + 1)) && spasiHorizontal > totalAtasBawah - spasiSatuAtas + ((inputPanjang - 5) / 2) && spasiHorizontal < (totalAtasBawah - 1)) || /*sisi miring segitiga bawah kanan*/
                            (spasiVertical == horizontalTitikTengah && spasiHorizontal == totalAtasBawah - 1))/*bintang paling bawah*/
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    if (spasiHorizontal >= inputPanjang && spasiHorizontal < spasiSatuAtas)
                        jumlahSpasi += 1;
                    else if (spasiHorizontal >= spasiSatuAtas && spasiHorizontal < spasiDuaAtas)
                        jumlahSpasi += 2;
                    else if (spasiHorizontal >= spasiDuaAtas && spasiHorizontal < spasiTigaAtas)
                        jumlahSpasi += 3;
                    else if (spasiHorizontal >= spasiTigaAtas && spasiHorizontal < spasiTigaBawah)
                        jumlahSpasi -= 5;
                    else if (spasiHorizontal >= spasiTigaBawah && spasiHorizontal < spasiDuaBawah)
                        jumlahSpasi -= 4;
                    else if (spasiHorizontal >= spasiDuaBawah && spasiHorizontal < spasiSatuBawah)
                        jumlahSpasi -= 3;
                    Console.Write("\n");
                }
            }
        }
    }
}
