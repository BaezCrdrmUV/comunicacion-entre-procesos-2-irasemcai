using System;
using System.Diagnostics;
using System.IO;


namespace ComunicacionEntreProcesos2
{
    class Program
    {
        
        static void Main(string[] args)
        {                        
            instrucciones();
        }

        public static void instrucciones()
        {
            Process proceso = Process.GetCurrentProcess();
           
            Console.WriteLine("1. Mandar Mensaje 2. Leer mensajes");
            string opcion = Console.ReadLine();
            
            switch (opcion)
            {
                case "1":
                    StreamWriter writer = File.CreateText("ProcesoFile.txt");
                    Console.WriteLine("Escribe tu mensaje: ");
                    string mensaje = Console.ReadLine();

                    writer.WriteLine("ID: " + proceso.Id + " Hora: " + proceso.StartTime + " Mensaje: " + mensaje);

                    writer.Close();
                    break;

                case "2":
                    StreamReader reader = File.OpenText("ProcesoFile.txt");
                    string linea= "";
                    while(linea != null)
                    {
                        linea = reader.ReadLine();
                        Console.WriteLine(linea);
                    }
                    reader.Close();
                    break;
             

            }
        }
    }
}
