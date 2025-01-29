internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {        
            Console.WriteLine("Witaj w kalkulatorze konsolowym!\n");
            Console.WriteLine("Wybierz opcje:\n" + "1. Dodawanie\n" + "2. Odejmowanie\n" + "3. Mnożenie\n" + "4. Dzielenie\n" + "5. Wyjdz");
            Console.WriteLine("Twój wybór: ");
            int youChoice;
            bool isValidChoice = int.TryParse(Console.ReadLine(), out youChoice);
            if (!isValidChoice || youChoice < 1 || youChoice > 5)
            {
                Console.WriteLine("Nieprawidłowy wybór, Wybierz opcję od 1 do 5");
                continue;
            }
            else if (youChoice == 5)
            {
                break;
            }
            Console.WriteLine("Podaj pierwszą liczbę: ");
            string b = Console.ReadLine();
            int firstNumber = int.Parse(b);
            Console.WriteLine("Podaj drugą liczbę: ");
            string c = Console.ReadLine();
            int secondNumber = int.Parse(c);
            
            if (youChoice == 1)
            {
                Console.WriteLine("Wynik: ");
                Console.WriteLine(firstNumber + secondNumber);
            }
            else if (youChoice == 2)
            {
                Console.WriteLine("Wynik: ");
                Console.WriteLine(firstNumber - secondNumber);
            }
            else if (youChoice == 3)
            {
                Console.WriteLine("Wynik: ");
                Console.WriteLine(firstNumber * secondNumber);
            }
            else if (youChoice == 4)
            {
                if(secondNumber == 0)
                {
                    Console.WriteLine("Błąd dzielenie przez 0");
                }
                Console.WriteLine("Wynik: ");
                Console.WriteLine(firstNumber / secondNumber);
            }
            else if (youChoice == 5)
            {
                break;
            }
            Console.WriteLine("Czy chcesz kontynować? (T/N): ");
            c = Console.ReadLine();
            if (c.Equals("N")){
                break;
            }
        }
    }
}