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
        Console.WriteLine("17. Gross de la viga: postes 70 x 70 mm, almas 150 x 22 mm");
        Console.WriteLine("18. Tamaňo del asiento: 450 x 250 x 22");
        Console.WriteLine("19. Destornillador");
        Console.WriteLine("20. Sierra circular o de meano");
        Console.WriteLine("21. Taldaro electrico");
        Console.WriteLine("22. Llave ajustable");
        Console.WriteLine("23. Juego de tuercas heucas");
        Console.WriteLine("24. Cienta métrica o cienta etrica plegable");
        Console.WriteLine("25. Lápiz");
        Console.WriteLine("26. Lima para madera");
        Console.WriteLine("27. Papel de lija");
        Console.WriteLine("28. Martillo");
        Console.WriteLine("29. Cuchilo de bricolaje");
        Console.WriteLine("30. pala");
        Console.WriteLine("31. Nivel de burbuja");
        Console.WriteLine("32. Destornillador inalámbrico");
        Console.WriteLine("33. Lijadora manual");
        Console.WriteLine("34. Sierra recta");
        Console.WriteLine("35. Pila ocaska");
        Console.WriteLine("36. Escuadra de carpintero");
        Console.WriteLine("37. Escalera");
        Console.WriteLine("38. Ingleteadora");
        Console.WriteLine("39. Gafas de protección");
        Console.WriteLine("40. Protectoras auditivos");
        Console.WriteLine("41. Respirador");
        Console.WriteLine("42. Broca forstner");
        Console.WriteLine("43. Carraca");
        Console.WriteLine("44. Abrazadera de tornillo");
        Console.WriteLine("45. Batidor");
        Console.WriteLine("46. Tarro de cristal");
        Console.WriteLine("47. Cepillo");
        Console.WriteLine("?Quieres verlo en inglés?");
        string input = Console.ReadLine();
        input.Trim();
        if (beta == 3)
        {
            Step1English(alfa);
        }
        if (input == "si")
        {
            RunEnglish(alfa);
        }
        else
        {
            Step1Espanol(beta);
        }

    }

    public void Step1Espanol(int beta)
    {
        Console.WriteLine("Designar ubicación");
        Console.WriteLine("");
    }
    public void RunEnglish(int alfa)
    {
        Console.WriteLine("Materials:");
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
        Console.WriteLine("17. Gross de la viga: postes 70 x 70 mm, almas 150 x 22 mm");
        Console.WriteLine("18. Tamaňo del asiento: 450 x 250 x 22");
        Console.WriteLine("19. Destornillador");
        Console.WriteLine("20. Sierra circular o de meano");
        Console.WriteLine("21. Taldaro electrico");
        Console.WriteLine("22. Llave ajustable");
        Console.WriteLine("23. Juego de tuercas heucas");
        Console.WriteLine("24. Cienta métrica o cienta etrica plegable");
        Console.WriteLine("25. Lápiz");
        Console.WriteLine("26. Lima para madera");
        Console.WriteLine("27. Papel de lija");
        Console.WriteLine("28. Martillo");
        Console.WriteLine("29. Cuchilo de bricolaje");
        Console.WriteLine("30. pala");
        Console.WriteLine("31. Nivel de burbuja");
        Console.WriteLine("32. Destornillador inalámbrico");
        Console.WriteLine("33. Lijadora manual");
        Console.WriteLine("34. Sierra recta");
        Console.WriteLine("35. Pila ocaska");
        Console.WriteLine("36. Escuadra de carpintero");
        Console.WriteLine("37. Escalera");
        Console.WriteLine("38. Ingleteadora");
        Console.WriteLine("39. Gafas de protección");
        Console.WriteLine("40. Protectoras auditivos");
        Console.WriteLine("41. Respirador");
        Console.WriteLine("42. Broca forstner");
        Console.WriteLine("43. Carraca");
        Console.WriteLine("44. Abrazadera de tornillo");
        Console.WriteLine("45. Batidor");
        Console.WriteLine("46. Tarro de cristal");
        Console.WriteLine("47. Cepillo");
        Console.WriteLine("?Quieres verlo en inglés?");
        string input = Console.ReadLine();
        input.Trim();
        if (beta == 3)
        {
            Step1English(alfa);
        }
        if (input == "si")
        {
            RunEnglish(alfa);
        }
        else
        {
            Step1Espanol(beta);
        }
    }

    public void Step1English(int alfa)
    {

    }
}
