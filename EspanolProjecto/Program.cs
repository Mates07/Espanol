namespace EspanolProjecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var app = new AppRun();
                Console.WriteLine("Hello, World!");
                Console.WriteLine("Hola, Mundo");
                Console.WriteLine("please choose your language (put 1 for spanish and 2 for englih)");
                Console.WriteLine("Por favor, elija su idioma (ponga 1 para espaňol y 2 para inglés)");
                string input = Console.ReadLine();
                input.Trim();
                if (input == "1")
                {
                    app.RunEspanol(true);
                }
                else if (input == "2")
                {
                    app.RunEnglish(false);
                }
                else if (string.IsNullOrEmpty(input)) 
                {
                    break;
                }
                break;
            }
        }
    }
}
