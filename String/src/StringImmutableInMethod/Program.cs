using Utils;

namespace StringImmutableInMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print.Green("Metotlara String Gönderme: Immutable Davranış & Ref & Out\n");

            // Method'la String Değerini Değiştirme (Normal)
            Print.Red("String Değer Atama");
            string naber = "naber";
            Console.WriteLine($"Orijinal naber : '{naber}'");

            StringDegerAtama(naber);
            Console.WriteLine($"Metot sonrası naber : '{naber}'\n");
            /*
            Açıklama:
                - String immutable olduğu için metoda gönderilen 'naber', metot içinde
                değiştirildiğinde yeni bir nesne oluşur.
                - Dışarıdaki orijinal değişken etkilenmez. Her ne kadar referans değer olsa da.
                - Yani method'a gönderilen referans değeri, string üzerininde işlem yapılmak istendiğinde
                referans'ı değişir. Bu durumda da method içindeki ve dışındaki değişkenin refransları farklı olur.
            */


            // Method'la String Değerini Değiştirme (REF)
            Print.Red("Ref ile Değer Atama");

            string _stringRef = "Bu bir ref için string ifadedir.";
            Console.WriteLine($"Orijinal _stringRef : '{_stringRef}'");

            StringDegerAtamaByRef(ref _stringRef);
            Console.WriteLine($"Method sonrası _stringRef : '{_stringRef}' \n");


            // Method'la String Değerini Değiştirme (OUT)
            Print.Red("Out ile Değer Atama");

            string _stringOut = "Bu bir out için string ifadedir.";
            Console.WriteLine($"Orijinal _stringOut : '{_stringOut}'");

            StringDegerAtamaByOut(out _stringOut);
            Console.WriteLine($"Method sonrası _stringOut : '{_stringOut}' \n");
        }

        private static void StringDegerAtama(string s)
        {
            s = "İyidir senden naber";
            Console.WriteLine($"Metot içindeki naber : '{s}'");
        }

        private static void StringDegerAtamaByRef(ref string s)
        {
            s = "Ref Timeeeee...";
            Console.WriteLine($"Metot içindeki _stringRef : '{s}'");
        }

        private static void StringDegerAtamaByOut(out string s)
        {
            s = "Out Timeeeee...";
            Console.WriteLine($"Metot içindeki _stringRef : '{s}'");
        }
    }
}
