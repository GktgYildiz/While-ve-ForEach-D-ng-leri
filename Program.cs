using System;

namespace practiceWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //While
            //1'den başlayarak consoledan girilen sayıya kadar (sayı dahil )ortalama hesaplayıp console'a yazdıran program
            // örneğin: girdi olarak 5 yazalım. sistem arkada şunu işliyor (1 2 3 4 5) topla bu sayıları ->15 kaç tane sayı var? 5. o zaman 15/5=3 diyor
            Console.Write("lütfen bir sayı giriniz: ");
            int sayi=int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<=sayi)

            {
                toplam += sayac;
                sayac++;
            }

            Console.WriteLine(toplam/sayi);

            
            
            // 'a'dan 'z'ye kadar tüm harfleri console yazdır
            char character = 'a';
            while (character < 'z')
            {
                if (character == 'g')
                    continue;
                Console.Write(character);
                character++;
            }
            
            Console.Write("*****    FOREACH   *****");
            String[] arabalar =  { "\r\nBMW", "FORD", "TOYOTA", "NISSAN" }; // yazdırdığınızda böw yazısı yukarıda kalıyor. alt satıra yazmak için başına \r\n yazın. "new line"
            foreach(var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
            
        }
    }   
}
