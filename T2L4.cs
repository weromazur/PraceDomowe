using System;

namespace T2L4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Praca domowa T2L4

            //1. Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy.

            string firstName = "Karolina";
            string lastName = "Kowalska";
            byte age = 28;
            char gender = 'k';
            ulong pesel = 93010132102;
            ulong employeeNumber = 2509324094;
           
            //2. Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je
            //w odwrotnej kolejności niż zostały zadeklarowane.

            char one = 'a';
            char two = 'b';
            char three = 'c';
            Console.WriteLine($"{three} {two} {one}");

            //3. Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość przekątnej.

            Console.WriteLine("Podaj długość boku a prostokąta: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość boku b prostokąta: ");
            double sideB = double.Parse(Console.ReadLine());
            double diagonal = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            Console.WriteLine($"Długość przekątnej tego prostokąta wynosi: {diagonal}");

            //4. Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie
            //przypiszesz im następujące wartości: a. 10 b. Szkoła Dotneta c. 12,5

            byte a = 10;
            string b = "Szkoła Dotneta";
            float c = 12.5f;

            //5. Napisz program w którym poprosisz użytkownika o jego dane personalne tj. imię, nazwisko,
            //numer telefonu, adres email, wzrost, waga itp.

            Console.WriteLine("Proszę wypełnić formularz");
            Console.WriteLine("Imię: ");
            string firstName2 = Console.ReadLine();
            Console.WriteLine("Nazwisko: ");
            string lastName2 = Console.ReadLine();
            Console.WriteLine("Wiek: ");
            byte age2 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Płeć: ");
            string gender2 = Console.ReadLine();
            Console.WriteLine("Wzrost: ");
            float height2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Waga: ");
            float weight2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Numer telefonu: ");
            uint phoneNumber2 = uint.Parse(Console.ReadLine());
            Console.WriteLine("E-mail: ");
            string email2 = Console.ReadLine();
        }
    }
}
