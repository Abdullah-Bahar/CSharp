using Utils; // Print Methodlarını Kullanmak İçin

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print.Green("String Metotları / Fonksiyonları \n");

            Print.Red($"String : 'merhaba'");
            string merhaba = "Merhaba benim adım Sultan Süleyman";
            Console.WriteLine($"merhaba : '{merhaba}' \n");

            // Length
            Print.Red("Length");
            Console.WriteLine($"Lenght : '{merhaba.Length}' \n");

            // StartsWidth & EndsWith
            Print.Red("StartsWidth & EndsWith");
            Console.WriteLine($"StartsWith('m') (Büyük/küçük harf duyarlı) : '{merhaba.StartsWith("m")}'");
            Console.WriteLine($"StartsWith('m') (Büyük/küçük harf duyarsız) : " +
                $"'{merhaba.StartsWith("m", StringComparison.OrdinalIgnoreCase)}'");
            Console.WriteLine($"EndsWith('ğ') (Büyük/küçük harf duyarlı) : '{merhaba.EndsWith("ğ")}'\n");

            // IndexOf & LastIndexOf
            Print.Red("IndexOf & LastIndexOf");
            Console.WriteLine($"IndexOf('Sultan') : '{merhaba.IndexOf("Sultan")}'");
            Console.WriteLine($"IndexOf('sultan') : '{merhaba.IndexOf("sultan")}'");
            Console.WriteLine($"IndexOf(' ') : '{merhaba.IndexOf(" ")}'");
            Console.WriteLine($"LastIndexOf(' ') : '{merhaba.LastIndexOf(" ")}' \n");

            // Insert
            Print.Red("Insert");
            Console.WriteLine($"Insert('(0, Heyyy, ') : '{merhaba.Insert(0, "Heyyy, ")}'");
            Console.WriteLine($"merhaba : '{merhaba}' \n");

            // Substring
            Print.Red("Substring");
            Console.WriteLine($"Substring(0, 4) : '{merhaba.Substring(0, 4)}' \n");

            // ToUpper & ToLower
            Print.Red("ToUpper & ToLower");
            Console.WriteLine($"ToUpper() : '{merhaba.ToUpper()}'");
            Console.WriteLine($"ToLower() : '{merhaba.ToLower()}' \n");

            // Replace
            Print.Red("Replace");
            Console.WriteLine($"Replace(' ', '-') '{merhaba.Replace(" ", "-")}' \n");

            // Remove
            Print.Red("Remowe");
            Console.WriteLine($"Remove(3, 7) '{merhaba.Remove(3, 7)}' \n");

            // Contains
            Print.Red("Contains");
            Console.WriteLine($"Contains(\"adım\") : '{merhaba.Contains("adım")} (küçük/büyük harf duyarlı)' \n");

            // Split & Join
            Print.Red("Split & Join");
            string[] _split = merhaba.Split(" ");

            Console.WriteLine($"Split(\" \") : '{_split}'");
            for (int i = 0; i < _split.Length; i++)
                Console.WriteLine($"{i}. Eleman : {_split[i]}");

            string _join = String.Join("--", _split);
            Console.WriteLine($"Join(\"--\", _split) : '{_join}' \n");

            // Trim / TrimStart / TrimEnd
            Print.Red("Trim / TrimStart / TrimEnd");
            string _trim = "   Hello World   ";
            Console.WriteLine($"_trim        : '{_trim}'");
            Console.WriteLine($"Trim()       : '{_trim.Trim()}'");
            Console.WriteLine($"TrimStart()  : '{_trim.TrimStart()}'");
            Console.WriteLine($"TrimEnd()    : '{_trim.TrimEnd()}'");
        }
    }
}
