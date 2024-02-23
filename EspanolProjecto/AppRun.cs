using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspanolProjecto;

internal class AppRun
{
    public void RunEspanol(int beta)
    {
        int alfa = 1;
        Console.WriteLine("Materiales:");
        Console.WriteLine("1. Tornillos con ojo");
        Console.WriteLine("2. Tornillos Spax");
        Console.WriteLine("3. Tureca M12");
        Console.WriteLine("4. Almohadillas");
        Console.WriteLine("5. Mosquetones");
        Console.WriteLine("6. Cureda");
        Console.WriteLine("7. Madera de jardín o madera dura");
        Console.WriteLine("8. Vigas (5)");
        Console.WriteLine("9. Tablas");
        Console.WriteLine("10. Anclajes para postes");
        Console.WriteLine("11. Hormigín Setz-Fix");
        Console.WriteLine("12. Columpio");
        Console.WriteLine("13. Columpio mono");
        Console.WriteLine("14. Barra trapecio");
        Console.WriteLine("15. Papel de lija");
        Console.WriteLine("16. Lazura");
        Console.WriteLine("?Quieres verlo en inglés?");
        string input = Console.ReadLine();
        input.Trim();
        if (beta == 3)
        {

        }
        if (input == "si")
        {
            RunEnglish(alfa);
        }
        else
        {

        }

    }
    public void RunEnglish(int alfa)
    {

    }
}
