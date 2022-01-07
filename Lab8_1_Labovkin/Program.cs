using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_1_Labovkin
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Admin\Desktop\работа";

            if (Directory.Exists(path))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);

                foreach (var file in directoryInfo.GetFiles())
                {
                    Console.WriteLine("Файл: " + file.Name);
                }
                foreach (var directory in directoryInfo.GetDirectories())
                {
                    Console.WriteLine("Подкаталог: " + directory.Name);

                    foreach (var file in directory.GetFiles())
                    {
                        Console.WriteLine("\tФайл: " + file.Name);
                    }
                }
            }
            else
            {
                Console.WriteLine("Указанный каталог отсутствует");
            }
            Console.ReadKey();
        }
    }
}
