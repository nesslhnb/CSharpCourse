using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My Name is Neslihan Bükte";
            var result = sentence.Length; // kaç karakterden oluştuğunu söyler.
            var result2 = sentence.Clone(); // ilgili cümlenin bir referansını daha oluşturur.
            bool result3 = sentence.EndsWith("ğ"); // bu cümle ğ ile bitiyor mu, bitiyorsa true, bitmiyorsa false döndürür. 
            bool result4 = sentence.StartsWith("My Name"); // bu cümle My Name ile başlıyor mu, başlıyorsa true, başlamıyorsa false döndürür. 
            var result5 = sentence.IndexOf("name"); // belli bir karakteri veya ifadeyi aramak için kullanılır. varsa eğer kaçıncı karakterdeyse o sayıyı döndürür, eğer yoksa -1 döndürür.
            var result6 = sentence.LastIndexOf(" "); // boşluk arar ama sondan aramaya başlar.
            var result7 = sentence.IndexOf(" "); // boşluk arar ama baştan aramaya başlar, bulduğu ilk boşluğu söyler diğerlerini söylemez.
            var result8 = sentence.Insert(0, "Hello, "); // bir cümleye başka bir metni yerleştirmek için kullanılır. 0. karakterden itibaren hello virgül boşluk ekler.
            var result9 = sentence.Substring(3); // metni parçalamak için kullanılır. mesela burda 3.karakterden itibaren alır metni. ya da substring(3,4) dersek 3. karakterden itibaren 4 tane al.
            var result10 = sentence.ToLower(); // bütün karakterleri küçüğe çevirir.
            var result11 = sentence.ToUpper(); // bütün karakterleri büyüğe çevirir.
            var result12 = sentence.Replace(" ", " - "); // belli karakterleri değiştirmek için kullanılır. mesela burada metinde boşluklar yerine çizgi kullanılır.
            var result13 = sentence.Remove(2); // metinde belli bir indexten itibaren atmak için kullanılır. burada 2'den itibaren kalan metni siler. ya da remove(2,4) yaparsak 2'den itibaren 4 karakteri uçurur.

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
