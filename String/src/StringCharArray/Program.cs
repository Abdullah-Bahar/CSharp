using Utils;

namespace StringCharArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print.Green("String ve Char Dizileri \n");

            /*
                String aslında bir karakter dizisidir (char[]).
                Bu nedenle bir string'i char dizisine çevirebilir, veya bir char dizisinden string oluşturabiliriz.
            */

            // String To Char Array
            Print.Red("String'den Char Dizisine Dönüştürme");
            string kelime = "Merhaba";
            char[] harfler = kelime.ToCharArray();

            Console.WriteLine($"kelime : '{kelime}'");
            Console.WriteLine("harfler dizisi : ");
            for (int i = 0; i < harfler.Length; i++)
                Console.WriteLine($"[{i}] : {harfler[i]}");
            Console.WriteLine();

            // Char Array To String
            Print.Red("Char Dizisinden String Oluşturma");
            char[] sehir = { 'A', 'n', 'k', 'a', 'r', 'a' };
            string sehirString = new string(sehir);
            Console.WriteLine($"Char dizisi -> string : '{sehirString}' \n");

            // String Üzerinden karakter erişimi
            Print.Red("String Üzerinde Karakterlere Erişim");
            Console.WriteLine($"string 'kelime': '{kelime}'");
            Console.WriteLine($"kelime[0] : '{kelime[0]}'");
            Console.WriteLine($"kelime[3] : '{kelime[3]}' \n");

            // String üzerinden karakter değişimi (Dolaylı Yöntem)
            Print.Red("String Üzerinde Karakter Değiştirme (Dolaylı Yöntem)");
            /*
                - String'ler karakter dizisine benzese de "immutable" yapıya sahiptir.
                - Yani doğrudan karakter değiştirilemez.
                - Örneğin:
                    > kelime[0] = 'X'; // HATA! (Compile-time error)
            
                - Değiştirmek için char[]’e çevirip işlem yapılabilir:
            */

            Console.WriteLine("Değişiklik Öncesi");
            Console.WriteLine($"string 'kelime': {kelime} \n");

            char[] degistir = kelime.ToCharArray();
            Console.WriteLine("Karakter dizisi üzerinde değişiklik yapılıyor...");

            Console.WriteLine("harfler dizisi : ");
            for (int i = 0; i < degistir.Length; i++)
            {
                degistir[i] = (char)(degistir[i] + 1);
                Console.WriteLine($"[{i}] : {degistir[i]}");
            }
            Console.WriteLine();

            kelime = new string(degistir);
            Console.WriteLine("Değişiklik Sonrası");
            Console.WriteLine($"string 'kelime': {kelime} \n");

            /*
                Özet:
                    - String -> char[] dönüşümü: ToCharArray()
                    - char[] -> String dönüşümü: new string(charArray)
                    - String’ler karakter temelli yapıdadır ancak immutable olduğu için
                      doğrudan karakter değişimi yapılamaz.
                    - Dolaylı olarak char[] kullanılarak değişiklik yapılabilir.
            */
        }
    }
}
