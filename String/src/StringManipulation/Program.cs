using Utils;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print.Green("String Manipülasyon (Reverse, Sort, vb.) \n");

            // -----------------------------
            // String Reverse (Ters Çevirme)
            // -----------------------------
            Print.Red("Array.Reverse(charArray) - String Reverse");

            string kelime = "Merhaba";
            Console.WriteLine($"Orijinal kelime : '{kelime}'");

            char[] charArray = kelime.ToCharArray();
            Array.Reverse(charArray);
            string tersKelime = new string(charArray);
            Console.WriteLine($"Ters çevrilmiş kelime : '{tersKelime}' \n");

            // -----------------------------
            // String Sort (Alfabetik Sıralama)
            // -----------------------------
            Print.Red("Array.Sort(charArray) - String Sort");

            char[] siralaArray = kelime.ToCharArray();
            Array.Sort(siralaArray);
            string siraliKelime = new string(siralaArray);
            Console.WriteLine($"Alfabetik sıralanmış kelime : '{siraliKelime}' \n");

            // -----------------------------
            // String Compare (Karşılaştırma)
            // -----------------------------
            Print.Red("String.Compare(string, string) - String Karşılaştırma");

            string a = "Elma";
            string b = "Armut";

            int result = String.Compare(a, b, StringComparison.OrdinalIgnoreCase); // Küçük/Büyük Harf Duyarsız
            Console.WriteLine($"Compare('{a}', '{b}') : {result} \n" +
                $"Sunoç : 0  -> eşit\n" +
                $"Sonuç : <0 -> a<b\n" +
                $"Sonuç : >0 -> a>b\n");

            // -----------------------------
            // String Concat / Join
            // -----------------------------
            Print.Red("String Concat / Join");

            string s1 = "Merhaba";
            string s2 = "Dünya";
            string concat = string.Concat(s1, " ", s2);
            Console.WriteLine($"string.Concat('{s1}', '{s2}') : '{concat}'");

            string[] isimler = { "Ahmet", "Mehmet", "Ayşe" };
            string join = string.Join(", ", isimler);
            Console.WriteLine($"string.Join() ile birleştirme : '{join}' \n");

            // -----------------------------
            // String Equals (Büyük/Küçük Harf Duyarlılığı)
            // -----------------------------
            Print.Red("String Equals");

            string x = "selam";
            string y = "Selam";

            Console.WriteLine($"'{x}'.Equals('{y}') : {x.Equals(y)} (case-sensitive)");
            Console.WriteLine($"'{x}'.Equals('{y}', StringComparison.OrdinalIgnoreCase) : " +
                              $"{x.Equals(y, StringComparison.OrdinalIgnoreCase)} (case-insensitive)\n");

            /*
                Özet:
                    - Reverse : string -> char[] -> ters çevirme -> tekrar string
                    - Sort : string -> char[] -> alfabetik sıralama -> string
                    - Compare : iki string karşılaştırma (0 eşit, <0 küçük, >0 büyük)
                    - Concat / Join : string birleştirme
                    - Equals : string eşitlik kontrolü, case-sensitive ve insensitive seçenekler
            */
        }
    }
}
