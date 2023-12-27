using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dortislem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen 1. Sayıyı Giriniz");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen 2. Sayıyı Giriniz:");
            double s2 = Convert.ToDouble(Console.ReadLine());

            double sonuc = s1 + s2;
            double sonuc1 = s1 - s2;
            double sonuc2 = s1 * s2;
            double sonuc3 = s1 / s2;



            //Console.WriteLine("İşlemin Sonucu:" + Convert.ToString(sonuc));
            Console.WriteLine(" Toplama İşleminin Sonucu:" + sonuc.ToString());
            Console.WriteLine("Çıkarma İşleminin Sonucu:" + sonuc1.ToString());
            Console.WriteLine("Çarpma İşleminin Sonucu:" + sonuc2.ToString());
            Console.WriteLine("Bölme İşleminin Sonucu:" + sonuc3.ToString());
            Console.ReadKey();
        }
    }
}
