using System.Text;
using Utils;

namespace UseToStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print.Green("StringBuilder Kullanımı \n");

            /*
                StringBuilder:
                    - System.Text namespace'i altındadır.
                    - String gibi davranır ama "mutable" bir yapıya sahiptir.
                    - Yani üzerinde yapılan işlemler (ekleme, silme vb.) yeni bir nesne oluşturmaz.
                    - Performans açısından string birleştirmelerine göre çok daha verimlidir.

                Özellikle çok fazla string birleştirme yapılan senaryolarda (örneğin loglama, raporlama, vb.)
                StringBuilder tercih edilir.
            */

            // Normal Birleştirme
            Print.Red("Normal String Birleştirme");
            string normal = "";
            for (int i = 0; i < 5; i++)
                normal += $"[{i}] "; // Her eklemede yeni string nesnesi oluşur (immutable)
            Console.WriteLine($"Normal String Sonuç : '{normal}' \n");


            // StringBuilder İle Birleştirme
            Print.Red("StringBuilder İle Birleştirme");
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 5; i++)
                sb.Append($"[{i}] "); // Aynı nesne üzerinde çalışır

            Console.WriteLine($"StringBuilder Sonuç : '{sb}' \n");

            // StringBuilder Methodları
            Print.Green("StringBuilder Metotları\n");

            // Append
            Print.Red("Append()");
            Console.WriteLine($"Append(5) : '{sb.Append(5)}' \n");  // Sona Ekleme Yapar

            // AppendLine
            Print.Red("AppednLine()");
            Console.WriteLine($"AppendLine(\"Yeni Satır Eklendi.\") : " +
                $"'{sb.AppendLine(" Yeni Satır Eklendi.")}' \n");  // Sona Satır Ekler (\n ile)

            // Insert
            Print.Red("Insert()");
            Console.WriteLine($"Insert(0, \"BAŞLANGIÇ - \") : " +
                $"'{sb.Insert(0, "BAŞLANGIÇ - ")}' \n");  // Belirtilen index'e ekleme yapar

            // Replace
            Print.Red("Replace()");
            Console.WriteLine($"Replace(\"Yeni\", \"Taze\") : " +
                $"'{sb.Replace("Yeni", "Taze")}' \n"); // Belirli ifadeleri değiştirir

            // Remove
            Print.Red("Remove()");
            Console.WriteLine($"Remove(0, 5) " +
                $": '{sb.Remove(0, 5)}' \n"); // 0. indexten itibaren 5 karakter siler  

            // Kapasite Bilgileri
            Print.Red("StringBuilder Kapasite Bilgileri");
            Console.WriteLine($"Capacity (Başlangıç Kapasitesi) : {sb.Capacity}");
            Console.WriteLine($"MaxCapacity (Maksimum Kapasite) : {sb.MaxCapacity} \n");

            // Kapasiteyi artırmak (gerekiyorsa)
            Print.Red("EnsureCapacity()");
            sb.EnsureCapacity(100);
            Console.WriteLine($"EnsureCapacity(100) çağrıldıktan sonra kapasite : {sb.Capacity}\n");

            // sb
            Print.Red("StringBuilder Son Hal");
            Console.WriteLine($"StringBuilder : '{sb}' \n");

            // sb.ToString()
            Print.Red("ToString()");
            Console.WriteLine($"StringBuilder.ToString() : '{sb.ToString()}' \n");

            // Tür bilgisi
            Print.Red("GetType()");
            Console.WriteLine($"GetType() : {sb.GetType()} \n");

            // Clear
            Print.Red("Clear()");
            sb.Clear(); // Tüm içeriği temizler, ama nesneyi sıfırlamaz, tekrar kullanılabilir
            Console.WriteLine($"Clear() sonrası StringBuilder: '{sb}'");
            Console.WriteLine($"Clear() sonrası kapasite: '{sb.Capacity}' \n");


            /*
                Özet:
                    - StringBuilder, string birleştirmede her defasında yeni referans oluşturmaz.
                    - Performans artışı sağlar.
                    - Char dizisi tutar. (Char[])
                    - Eğer eleman eklerken kapasite dolduysa, daha büyük bir char dizisi ayırıp, eskisini ona kopyalar
                        > Bu bile string'in her seferinde yeni bir nesne oluşturmasından daha performanslıdır.
            */
        }
    }
}
