using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("****Dizi Tanımlama****");

            // string[] colors = new string[5];
            // string[] animals = {"Kedi","Köpek","Kuş","Maymun"};

            // int[] dizi;
            // dizi = new int[5];

            // // Dizilere değer atama ve erişim

            // colors[0] = "Mavi";
            // dizi[3] = 10;


            // Console.WriteLine(animals[0]);
            // Console.WriteLine(dizi[3]);
            // Console.WriteLine(colors[0]);

            // Console.Write("Lütfen Dizi eleman sayısını giriniz:");
            // int sayi = int.Parse(Console.ReadLine());

            // int[] numberArray = new int[sayi];
            // for (int i = 0; i < sayi; i++)
            // {
            //     Console.Write("{0}. sayı girin:",i+1);
            //     numberArray[i] = int.Parse(Console.ReadLine());
            // }

            // int toplam = 0;
            // foreach (var item in numberArray)
            // {
            //     toplam+=item;
            // }
            // Console.WriteLine("Ortalama :" +toplam/sayi);
            Console.WriteLine("*********Array Sınıfı Methodları**********");
            //Sort
            int[] sayiDizisi = {23,12,86,72,3,11,17,21};
            
            Console.WriteLine("**********Dizinin Sıralamadan önceki hali********");
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*********Sıralı Dizi Listesi***************");
            Array.Sort(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //Clear
            Console.WriteLine("**********Array Clear********");
            Array.Clear(sayiDizisi,2,2);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //Reverse
            Console.WriteLine("********** Reverse ********");
            Array.Reverse(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //IndexOf
            Console.WriteLine("********** Array Index Of ********");
            
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //Resize
            Console.WriteLine("********** Array Resize ********");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
