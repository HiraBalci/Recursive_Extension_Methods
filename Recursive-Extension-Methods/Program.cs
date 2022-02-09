using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Extension_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //recursive -> öz yinelemeli
            //3^4
            int result = 1;
            for(int i = 1; i < 5; i++)
            {
                result = result * 3;
                
            }
            Console.WriteLine(result);
            Islemler islem=new Islemler();
            Console.WriteLine(islem.Expo(3,4));
            //extension methodlar
            string ifade = "Hira Balcı";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
                Console.WriteLine(ifade.RemoveWhiteSpaces().MakeUpperCase());
                Console.WriteLine(ifade.RemoveWhiteSpaces().MakeLowerCase());
                int[] dizi = {9,3,6,2,1,5,0};

               dizi.SortArray();
                dizi.EkranaYazdir();
                int sayi = 5;
               Console.WriteLine( sayi.IsEvenNumber());
                Console.WriteLine(ifade.IstediginKarakteriBuyutme());
                Console.WriteLine(ifade.GetFirstCharacter());
            }
            
        }
    }
    public class Islemler
    {
        public int Expo(int sayi,int us)
        {
            if (us < 2)
            {
                return sayi;
            }

                return Expo(sayi, us - 1) * sayi;
            
        }
    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
           return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(' ');
            return string.Join("*", dizi);//aralardaki boşlukları yıldızla değiştirmiş olurum.
        }
        public static string MakeUpperCase(this string param)
        {
            
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {

            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
                Console.WriteLine(item);
        }
        public static bool IsEvenNumber(this int param)
        {
            return (param % 2) == 0;
        }
        public static string IstediginKarakteriBuyutme(this string param)
        {
            return param.Substring(0, 1).ToLower()+ param.Substring(1, param.Length-1).ToUpper();
        }
        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }
    }
}
