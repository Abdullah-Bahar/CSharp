using Utils; // Print Methodlarını Kullanmak İçin

namespace CreateString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print.Green("String Oluşturma / Birleştirme \n");

            string _istanbul = "İstanbul";
            string _ankara = "Ankara";

            Print.Red("'+' Operatörü İle Birleştirme");
            string cites1 = _istanbul + _ankara;
            Console.WriteLine($"cites1 : '{cites1}'\n");

            Print.Red("string.Format() İle Birleştirme");
            string cites2 = String.Format("{0} {1}", _istanbul, _ankara); // Eski yöntem (C# 5 öncesi)
            Console.WriteLine($"cites2 : '{cites2}'\n");

            Print.Red("String Interpolation ($)");
            string cites3 = $"{_istanbul} {_ankara}";   // interpolasyon (interpolation)
            Console.WriteLine($"cites3 : '{cites3}'\n");
        }
    }
}
