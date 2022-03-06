using System;
using System.IO.Compression;

namespace Verzeichnis_komprimieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string startPath = @".";
            const string zipPath = @"..\BinFolder.zip";
            const string extractPath = @"Extracted\";

            // Kompletten Bin Ordner (genauer, den Ordner in dem sich die Binaries befinden) komprimieren
            ZipFile.CreateFromDirectory(startPath, zipPath);

            // Zip Archiv Entpacken
            ZipFile.ExtractToDirectory(zipPath, extractPath);



        }
    }
}
