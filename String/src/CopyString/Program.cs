using Utils;

namespace CopyString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print.Green("Kopyalama ve Referans Davranışları \n");

            string merhaba = "Merhaba benim adım Sultan Süleyman";

            // CLone() kopyalma
            Print.Red("Clone() İle Kopyalama");
            // Clone() -> Obje tipinde değer döndüreceği için string'e çevrilmesi gerekiyor
            string _copy1 = (string)merhaba.Clone(); // referans kopyalanır

            Console.WriteLine("Clone() Değişiklik Öncsi");
            bool isCopy1 = Object.ReferenceEquals(merhaba, _copy1);
            Console.WriteLine($"merhaba == _copy1 : '{isCopy1}' (Referans Aynı)");

            Console.WriteLine("Clone() Değişiklik Sonrası");
            _copy1 += ". Seni Bekliyorum Şah";
            isCopy1 = Object.ReferenceEquals(merhaba, _copy1);
            Console.WriteLine($"merhaba == _copy1 : '{isCopy1}' (Referans Artık Aynı Değil)");

            Console.WriteLine($"Clone() : '{_copy1}'");
            Console.WriteLine($"merhaba : '{merhaba}'");
            Console.WriteLine();

            // Atama ile kopyalma
            Print.Red("Atama İle Kopyalma");
            string _copy2 = merhaba; // referans kopyalanır

            Console.WriteLine("_copy2 Değişiklik Öncsi");
            bool isCopy2 = Object.ReferenceEquals(merhaba, _copy2);
            Console.WriteLine($"merhaba == _copy2 : '{isCopy2}' (Referans Aynı)");

            Console.WriteLine("_copy2 Değişiklik Sonrası");
            _copy2 += " Şüphen mi vardı ?";
            isCopy2 = Object.ReferenceEquals(merhaba, _copy2);
            Console.WriteLine($"merhaba == _copy2 : '{isCopy2}' (Referans Artık Aynı Değil)");

            Console.WriteLine($"_copy2 : '{_copy2}'");
            Console.WriteLine($"merhaba : '{merhaba}'");
            Console.WriteLine();

            /*
                * Her iki kopyalama çeşidinde de referans kopyalanır. Ancak string immutable bir 
                değişken olduğu için her bir değişiklikte referans değişiyor.

                * Bu durumda değişiklik yapana kadar her ikisi de aynı referansı gösterir. Ancak
                değişiklik sonrası referansları farklı olur.
            */
        }
    }
}
