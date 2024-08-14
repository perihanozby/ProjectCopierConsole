using System;
using System.IO;

namespace ProjectMoverConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder1 = "Folder1";
            string folder2 = "Folder2";

            string sourceFolder1 = Path.Combine(@"C:\", folder1);
            string sourceFolder2 = Path.Combine(@"C:\", folder2);
            string destinationFolder = @"C:\Windows\Temp";

            MoveFolder(sourceFolder1, Path.Combine(destinationFolder, folder1));
            MoveFolder(sourceFolder2, Path.Combine(destinationFolder, folder2));

            Console.WriteLine("Taşıma işlemi tamamlandı.");
            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey(); 
        }

        private static void MoveFolder(string sourceFolder, string destinationFolder)
        {
            if (Directory.Exists(sourceFolder))
            {
                try
                {
                    Directory.Move(sourceFolder, destinationFolder);
                    Console.WriteLine($"{sourceFolder} başarıyla {destinationFolder} klasörüne taşındı.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Taşıma sırasında bir hata oluştu: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"Kaynak klasör bulunamadı: {sourceFolder}");
            }
        }
    }
}
