using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace NitroOS
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            Console.Clear();  // Limpia pantalla VGA text mode [web:47]

            // Versión del SO
            Console.WriteLine("cosmoOS v1.0 - Boot Sequence");
            Console.WriteLine("Desarrollado por Eduardo - Granollers, 2026");
            Console.Beep(1000, 200);  // Sonido boot [web:40]

            // Logo ASCII (centrado aprox., ajusta líneas)
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
    _____         _     _     
   / ____|       | |   | |    
  | |  __  __ _  | | __| | __ 
  | | |_ |/ _` | | |/ _` |/ _`|
  | |__| | (_| | | | (_| | (_|
   \_____|\__,_| |_|\__,_|\__,|
");
            Console.WriteLine("    Bienvenido al Sistema Operativo Básico");
            Console.ResetColor();

            // Pausa para ver boot (luego inicia shell)
            Console.WriteLine("\nPresiona Enter para shell...");
            Console.ReadLine();

            // Aquí inicia tu shell básica
            // while(true) { string cmd = Console.ReadLine(); ... }
        }
    }
}
