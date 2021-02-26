using System;
using System.IO;
using System.Text;

namespace lab1_file_manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static void createFile(string path)
        {
            File.Create(path);
        }
        static void menu()
        {
            Console.WriteLine("EJERCICIO EN LABORATORIO");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("Curso: PROGRAMACIÓN I");
            Console.WriteLine("Nombre: Luis Eduardo Alvarado Celano");
            Console.WriteLine("Carnet: 0900-20-7376");
            Console.WriteLine("Sección: C");
            Console.WriteLine("\n");
        }
    }
}
