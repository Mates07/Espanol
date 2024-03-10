using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EspanolProjecto;

internal class AppRun
{
    public void RunEspanol(bool espanol)
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
        if (espanol == false)
        {
            Step1English(espanol);
        }
        if (input == "si")
        {
            RunEnglish(espanol);
        }
        else
        {
            Step1Espanol(espanol);
        }

    }

    public void Step1Espanol(bool espanol)
    {
        Console.WriteLine("Designar ubicación");
        Console.WriteLine("Contras las vigas laterales al tamaňo requerido");
        Console.WriteLine("?Quieres verlo en inglés?");
        string input = Console.ReadLine();
        input.Trim();
        if (input == "si")
        {
            Step1English(espanol);
        }
        else if (espanol == true)
        {
            Step2Espanol(espanol);
        }
        else if (espanol == false)
        { 
            Step2English(espanol);
        }
    }

    public void Step2Espanol(bool espanol)
    {
        Console.WriteLine("Cortar los tableros de conexión al tamaňo requerido y atornillaros");
        Console.WriteLine("?Quieres verlo en inglés?");
        string input = Console.ReadLine();
        input.Trim();
        if (input == "si")
        {
            Step2English(espanol);
        }
        else if (espanol == true)
        {
            Step3Espanol(espanol);
        }
        else if (espanol == false)
        {
            Step3English(espanol);
        }
    }
    public void Step3Espanol(bool espanol)
    {
        Console.WriteLine("Colocación de los tirantes transversales");
        Console.WriteLine("Atornillar las tablas de conexíon Quitar el");
        Console.WriteLine("Travesaňo falso Tener en cuenta la altura de la");
        Console.WriteLine("Barra trapecio");
        Console.WriteLine("?Quieres verlo en inglés?");
        string input = Console.ReadLine();
        input.Trim();
        if (input == "si")
        {
            Step3English(espanol);
        }
        else if (espanol == true)
        {
            Step4Espanol(espanol);
        }
        else if (espanol == false)
        {
            Step4English(espanol);
        }
    }
    public void Step4Espanol(bool espanol)
    {
        Console.WriteLine("Preperfoar los agujeros");
        Console.WriteLine("Instalación de ganchos");
        Console.WriteLine("Insercion de vigas");
        Console.WriteLine("Transversales fabricíon de puntales");
        Console.WriteLine("?Quieres verlo en inglés?");
        string input = Console.ReadLine();
        input.Trim();
        if (input == "si")
        {
            Step4English(espanol);
        }
        else if (espanol == true)
        {
            Step5Espanol(espanol);
        }
        else if (espanol == false)
        {
            Step5English(espanol);
        }
    }
    
    public void Step5Espanol(bool espanol)
    {
        Console.WriteLine("Excavacion de agujros");
        Console.WriteLine("Atornillado de los pies de los");
        Console.WriteLine("Postes Nivelación de la");
        Console.WriteLine("estructura hormigonado de bases de columnas");
        Console.WriteLine("?Quieres verlo en inglés?");
        string input = Console.ReadLine();
        input.Trim();
        if (input == "si")
        {
            Step5English(espanol);
        }
        else if (espanol == true)
        {
            Step6Espanol(espanol);
        }
        else if (espanol == false)
        {
            Step6English(espanol);
        }
    }
    public void Step6Espanol(bool espanol)
    {
        Console.WriteLine("Medición de posición");
        Console.WriteLine("Excavar un agujero");
        Console.WriteLine("Atornillar el pie del");
        Console.WriteLine("postes hormigonar columnas");
        Console.WriteLine("?Quieres verlo en inglés?");
        string input = Console.ReadLine();
        input.Trim();
        if (input == "si")
        {
            Step6English(espanol);
        }
        else if (espanol == true)
        {
            Step7Espanol(espanol);
        }
        else if (espanol == false)
        {
            Step7English(espanol);
        }
    }
    public void Step7Espanol(bool espanol)
    {
        Console.WriteLine("Desbarbando los bordes");
        Console.WriteLine("Aplicación de oscilante");
        Console.WriteLine("tinte Suspensión");
        string input = Console.ReadLine();
        input.Trim();
        if (input == "si")
        {
            Step5English(espanol);
        }
    }
    public void RunEnglish(bool espanol)
    {
        Console.WriteLine("Materials:");
        Console.WriteLine("1. Screws with an eye");
        Console.WriteLine("2. Spax screws");
        Console.WriteLine("3. Nut size M12");
        Console.WriteLine("4. Pads");
        Console.WriteLine("5. Carabiner hooks");
        Console.WriteLine("6. Rope");
        Console.WriteLine("7. Garden wood or hard wood");
        Console.WriteLine("8. Beams (5)");
        Console.WriteLine("9. Boards");
        Console.WriteLine("10. Anchors for posts");
        Console.WriteLine("11. Setz-Fix concrete");
        Console.WriteLine("12. Swing");
        Console.WriteLine("13. Monkey Swing");
        Console.WriteLine("14. Tarpeze Bar");
        Console.WriteLine("15. Sand Paper 120");
        Console.WriteLine("16. Lazura");
        Console.WriteLine("17. Beam thickness: posts 70 x 70 mm, upper beam 150 x 22 mm");
        Console.WriteLine("18. Seat size: 450 x 250 x 22");
        Console.WriteLine("19. Screwdrivwer");
        Console.WriteLine("20. Cirkular or hand saw");
        Console.WriteLine("21. Electric drill");
        Console.WriteLine("22. Adjustable wrench");
        Console.WriteLine("23. Set of socket nuts");
        Console.WriteLine("24. Mesuring tape or folding tape mesure");
        Console.WriteLine("25. Pencil");
        Console.WriteLine("26. Wood File");
        Console.WriteLine("27. Sand paper");
        Console.WriteLine("28. Hammer");
        Console.WriteLine("29. DIY knife");
        Console.WriteLine("30. Shovel");
        Console.WriteLine("31. Spade");
        Console.WriteLine("32. Spirit level");
        Console.WriteLine("33. Cordless screwdriver");
        Console.WriteLine("34. Hand sander");
        Console.WriteLine("35. Stright saw");
        Console.WriteLine("36. Japanese saw");
        Console.WriteLine("37. Escalera");
        Console.WriteLine("38. Ladder");
        Console.WriteLine("39. Miter and miter saw ");
        Console.WriteLine("40. Hearing protections");
        Console.WriteLine("41. Respirator");
        Console.WriteLine("42. Forstner drill bit");
        Console.WriteLine("43. Ratchet");
        Console.WriteLine("44. Screw clamp");
        Console.WriteLine("45. Whisk");
        Console.WriteLine("46. Mason Jar");
        Console.WriteLine("47. Brush");
        Console.WriteLine("Do you want to see it in Spanish?");
        string input = Console.ReadLine();
        input.Trim();
        if (input == "yes")
        {
            RunEspanol(espanol);
        }
        else if (espanol == false)
        {
            Step1English(espanol);
        }
        else
        {
            Step1Espanol(espanol);
        }
    }

    public void Step1English(bool espanol)
    {
        Console.WriteLine("Determining the location and creating a sketch");
        Console.WriteLine("Cutting the side beams to the required size");
        Console.WriteLine("Do you want to see it in Spanish?");
        string input = Console.ReadLine();
        input.Trim();
        if (input == "yes")
        {
            Step1Espanol(espanol);
        }
        else if (espanol == false)
        {
            Step2English(espanol);
        }
        else
        {
            Step2Espanol(espanol);
        }
    }

    public void Step2English(bool espanol)
    {
        Console.WriteLine("Cutting the connecting boards to the required size and screwing them");
        Console.WriteLine("Do you want to see it in Spanish?");
        string input = Console.ReadLine();
        input.Trim();
        if (input == "yes")
        {
            Step2Espanol(espanol);
        }
        else if (espanol == false)
        {
            Step3English(espanol);
        }
        else
        {
            Step3Espanol(espanol);
        }
    }

    public void Step3English(bool espanol)
    {
        Console.WriteLine("Attaching the transverse braces");
        Console.WriteLine("Screwing the connecting boards");
        Console.WriteLine("Removing the dummy cross member");
        Console.WriteLine("Taking into account the height of the trapeze bar");
        Console.WriteLine("Do you want to see it in Spanish?");
        string input = Console.ReadLine();
        input.Trim();
        if (input == "yes")
        {
            Step3Espanol(espanol);
        }
        else if (espanol == false)
        {
            Step4English(espanol);
        }
        else
        {
            Step4Espanol(espanol);
        }
    }

    public void Step4English(bool espanol)
    {
        Console.WriteLine("Pre-drilling the holes");
        Console.WriteLine("Installation of hooks");
        Console.WriteLine("Insertion of cross beams");
        Console.WriteLine("Fabrication of struts");
        Console.WriteLine("Do you want to see it in Spanish?");
        string input = Console.ReadLine();
        input.Trim();
        if (input == "yes")
        {
            Step4Espanol(espanol);
        }
        else if (espanol == false)
        {
            Step5English(espanol);
        }
        else
        {
            Step5Espanol(espanol);
        }
    }

    public void Step5English(bool espanol)
    {
        Console.WriteLine("Excavation of holes");
        Console.WriteLine("Screwing the feet of the posts");
        Console.WriteLine("Leveling the structure");
        Console.WriteLine("Concreting of column bases");
        Console.WriteLine("Do you want to see it in Spanish?");
        string input = Console.ReadLine();
        input.Trim();
        if (input == "yes")
        {
            Step5Espanol(espanol);
        }
        else if (espanol == false)
        {
            Step6English(espanol);
        }
        else
        {
            Step6Espanol(espanol);
        }
    }

    public void Step6English(bool espanol)
    {
        Console.WriteLine("Position measurement");
        Console.WriteLine("Excavating a hole");
        Console.WriteLine("Screwing the post foot");
        Console.WriteLine("Concreting of columns");
        Console.WriteLine("Do you want to see it in Spanish?");
        string input = Console.ReadLine();
        input.Trim();
        if (input == "yes")
        {
            Step6Espanol(espanol);
        }
        else if (espanol == false)
        {
            Step7English(espanol);
        }
        else
        {
            Step7Espanol(espanol);
        }
    }

    public void Step7English(bool espanol)
    {
        Console.WriteLine("Deburring the edges");
        Console.WriteLine("Stain application");
        Console.WriteLine("Swing suspension");
        Console.WriteLine("Do you want to see it in Spanish?");
        string input = Console.ReadLine();
        input.Trim();
        if (input == "yes")
        {
            Step7Espanol(espanol);
        }
    }
}
