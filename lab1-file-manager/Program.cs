using System;
using System.IO;
using System.Text;

namespace lab1_file_manager
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo opt;
            do
            {
                Menu();
                opt = Console.ReadKey(true);
                Console.Clear();
                switch (opt.Key) {
                    case ConsoleKey.D1:
                        CreateFile();
                        break;
                    case ConsoleKey.D2:
                        DeleteFile();
                        break;
                    case ConsoleKey.D3:
                        ReWriteFile();
                        break;
                    case ConsoleKey.D4:
                        UpdateFile();
                        break;
                    case ConsoleKey.D5:
                        ReadFileContent();
                        break;
                    case ConsoleKey.D6:
                        Console.WriteLine("Nos vemos pronto");
                        break;
                    default:
                        Console.WriteLine("Esa tecla no está permitida");
                        break;
                }
            } while (opt.Key != ConsoleKey.D6);
        }
        static void CreateFile()
        {
            string path;
            CenterText("CREAR ARCHIVO");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            CenterText("-------------------------------------");
            CenterLeftText("INGRESE PATH DEL ARCHIVO");
            CenterText("-------------------------------------");
            path = Console.ReadLine();
            CenterText("-------------------------------------");
            try
            {
                File.Create(path);
                CenterText("EL ARCHIVO FUE CREADO EXITOSAMENTE");
                CenterText("-------------------------------------");
                Console.ReadKey();
                Console.Clear();
            } catch (Exception e)
            {
                CenterText("ERROR AL CREAR EL ARCHIVO");
                CenterText("-------------------------------------");
                Console.WriteLine(e);
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void ReWriteFile()
        {
            CenterText("RENOMBRAR ARCHIVO");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            string path;
            CenterText("-------------------------------------");
            CenterLeftText("INGRESE PATH DEL ARCHIVO");
            CenterText("-------------------------------------");
            path = Console.ReadLine();
            CenterText("-------------------------------------");
            try
            {
                FileInfo fi = new FileInfo(path);
                if (fi.Exists)
                {
                    string npath;
                    CenterLeftText("INGRESE PATH NUEVO DEL ARCHIVO");
                    CenterText("-------------------------------------");
                    npath = Console.ReadLine();
                    CenterText("-------------------------------------");
                    fi.MoveTo(npath);
                    CenterText("EL ARCHIVO FUE ACTUALIZADO EXITOSAMENTE");
                    CenterText("-------------------------------------");
                    Console.ReadKey();
                    Console.Clear();

                }
                else
                {
                    CenterText("NO HEMOS ENCONTRADO NINGÚN ARCHIVO CON ESTA RUTA");
                    CenterText("-------------------------------------");
                    Console.ReadKey();
                    Console.Clear();
                }
            }catch (Exception e)
            {
                CenterText("ERROR AL ACTUALIZAR EL ARCHIVO");
                CenterText("-------------------------------------");
                Console.WriteLine(e);
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void DeleteFile()
        {
            string path;
            CenterText("ELIMINAR ARCHIVO");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            CenterText("-------------------------------------");
            CenterLeftText("INGRESE PATH DEL ARCHIVO");
            CenterText("-------------------------------------");
            path = Console.ReadLine();
            CenterText("-------------------------------------");
            try
            {
                FileInfo fi = new FileInfo(path);
                if (fi.Exists)
                {
                    fi.Delete();
                    CenterText("EL ARCHIVO FUE ELIMINADO EXITOSAMENTE");
                    CenterText("-------------------------------------");
                    Console.ReadKey();
                    Console.Clear();

                }
                else
                {
                    CenterText("NO HEMOS ENCONTRADO NINGÚN ARCHIVO CON ESTA RUTA");
                    CenterText("-------------------------------------");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            catch (Exception e)
            {
                CenterText("ERROR AL ELIMINAR EL ARCHIVO");
                CenterText("-------------------------------------");
                Console.WriteLine(e);
                Console.ReadKey();
                Console.Clear();
            }
        }
        static async void UpdateFile()
        {
            string path;
            CenterText("ACTUALIZAR ARCHIVO");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            CenterText("-------------------------------------");
            CenterLeftText("INGRESE PATH DEL ARCHIVO");
            CenterText("-------------------------------------");
            path = Console.ReadLine();
            CenterText("-------------------------------------");
            try {
                FileInfo fi = new FileInfo(path);
                if (fi.Exists)
                {
                    string text;
                    CenterLeftText("ESCRIBE ALGO:");
                    CenterText("-------------------------------------");
                    text = Console.ReadLine();
                    await File.WriteAllTextAsync(path, text);
                    CenterText("EL ARCHIVO FUE ACTUALIZADO EXITOSAMENTE");
                    CenterText("-------------------------------------");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    CenterText("NO HEMOS ENCONTRADO NINGÚN ARCHIVO CON ESTA RUTA");
                    CenterText("-------------------------------------");
                    Console.ReadKey();
                    Console.Clear();
                }
            }catch(Exception e)
            {
                CenterText("ERROR AL ACTUALIZAR EL ARCHIVO");
                CenterText("-------------------------------------");
                Console.WriteLine(e);
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void ReadFileContent()
        {
            string path;
            CenterText("LISTAR INFORMACIÓN DEL ARCHIVO");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            CenterText("-------------------------------------");
            CenterLeftText("INGRESE PATH DEL ARCHIVO");
            CenterText("-------------------------------------");
            path = Console.ReadLine();
            CenterText("-------------------------------------");
            try 
            {
                FileInfo fi = new FileInfo(path);
                if (fi.Exists)
                {
                    string[] lines = File.ReadAllLines(path);
                    foreach(string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    CenterText("-------------------------------------"); 
                    CenterText("EL ARCHIVO FUE LEÍDO EXITOSAMENTE");
                    CenterText("-------------------------------------");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    CenterText("NO HEMOS ENCONTRADO NINGÚN ARCHIVO CON ESTA RUTA");
                    CenterText("-------------------------------------");
                    Console.ReadKey();
                    Console.Clear();
                }
            }catch(Exception e)
            {
                CenterText("ERROR AL LEER EL ARCHIVO");
                CenterText("-------------------------------------");
                Console.WriteLine(e);
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void Menu()
        {
            //menu
            CenterText("EJERCICIO EN LABORATORIO");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("Curso: PROGRAMACIÓN I");
            Console.WriteLine("Nombre: Luis Eduardo Alvarado Celano");
            Console.WriteLine("Carnet: 0900-20-7376");
            Console.WriteLine("Sección: C");
            Console.WriteLine("\n");
            CenterText("-------------------------------------");
            CenterText("MENÚ PRINCIPAL");
            CenterText("-------------------------------------");
            CenterLeftText("1. CREACIÓN DE ARCHIVO");
            CenterLeftText("2. ELIMINACIÓN DE ARCHIVO");
            CenterLeftText("3. RENOMBRAR ARCHIVO");
            CenterLeftText("4. AGREGAR INFORMACIÓN AL ARCHIVO");
            CenterLeftText("5. LISTAR INFORMACIÓN DEL ARCHIVO");
            CenterLeftText("6. SALIDA");
            CenterText("-------------------------------------");
            CenterText("ELIJA EL NÚMERO DE OPCIÓN [ ]");
            CenterText("-------------------------------------");

        }
        static void CenterText(string text)
        {
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}",text));
        }
        static void CenterLeftText(string text)
        {
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2)+text.Length-15) + "}", text));
        }
    }
}
