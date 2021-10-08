using System;
using System.IO;

namespace DemoArchivos
{
    class Program
    {     

        static void Main(string[] args)
        {
            // escribirArchivo();
            leerArchivo();
            
            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }

        static void escribirArchivo()
        {
            // ubicacion o ruta del archivo
            string ubicacionArchivo = @"C:\mi_archivo.txt";
            // texto a escribir en el archivo
            string texto = "";
            

            Console.WriteLine("Ingrese el texto a grabar: ");
            texto = Console.ReadLine();

            // Escribimos datos en Archivo
            StreamWriter writer = File.AppendText(ubicacionArchivo);
            writer.WriteLine(texto);

            writer.Close();
        }

        static void leerArchivo()
        {
            string linea;
            string ubicacionArchivo = @"D:\mi_archivo.txt";
            Console.WriteLine(" ======== VISOR DE ARCHIVO ========");

            try
            {
                StreamReader reader = new StreamReader(ubicacionArchivo);
                while ((linea = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se produjo un error: " + ex.Message);                
            }
            
        }

        


    }
}
