internal class Program
{
    private static void DisplayResults(double result, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine($"Wynik: {result}");
        Console.ResetColor();
    }
    private static void Main(string[] args)
    {
        while (true)
        {
            double result = 0;
            Console.WriteLine("Witaj w kalkulatorze konsolowym!\n");
            Console.WriteLine("Wybierz opcje:\n" + "1. Dodawanie\n" + "2. Odejmowanie\n" + 
                "3. Mnożenie\n" + "4. Dzielenie\n" + "5. Modulo\n" + "6. Potęgowanie\n" 
                + "7. Wyjdz\n" + "8. Pokaż historię");
            Console.WriteLine("Twój wybór: ");
            int youChoice;
            bool isValidChoice = int.TryParse(Console.ReadLine(), out youChoice);
            if (!isValidChoice || youChoice < 1 || youChoice > 8)
            {
                Console.WriteLine("Nieprawidłowy wybór, Wybierz opcję od 1 do 8");
                continue;
            }
            else if (youChoice == 7)
            {
                break;
            }
            else if (youChoice == 8)
            {
                try
                { 
                    string[] logs = File.ReadAllLines("logs.txt");
                    Console.WriteLine("\nHistoria operacji:");
                    foreach (string line in logs)
                    {
                        Console.WriteLine(line);
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Brak pliku z historią operacji!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
            }
            Console.WriteLine("Podaj pierwszą liczbę: ");
            string b = Console.ReadLine();
            double firstNumber = double.Parse(b);
            Console.WriteLine("Podaj drugą liczbę: ");
            string c = Console.ReadLine();
            double secondNumber = double.Parse(c);
            
            if (youChoice == 1)
            {
                result = firstNumber + secondNumber;
                DisplayResults(result, ConsoleColor.Green);
            }
            else if (youChoice == 2)
            {
                result = firstNumber - secondNumber;
                DisplayResults(result , ConsoleColor.Green);
            }
            else if (youChoice == 3)
            {
                result = firstNumber * secondNumber;
                DisplayResults(result, ConsoleColor.Green);
            }
            else if (youChoice == 4)
            {
                if(secondNumber == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Błąd dzielenie przez 0");
                    Console.ResetColor();
                    continue;
                }
                result = firstNumber / secondNumber;
                DisplayResults(result, ConsoleColor.Green);
            }
            else if (youChoice == 5)
            {
                if (secondNumber == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Błąd dzielenie przez 0");
                    Console.ResetColor();
                    continue;
                }
                result = firstNumber % secondNumber;
                DisplayResults(result, ConsoleColor.Green);
            }
            else if (youChoice == 6)
            {
                result = Math.Pow(firstNumber, secondNumber);
                DisplayResults(result, ConsoleColor.Green);
            }
            else if (youChoice == 7)
            {
                break;
            }
            string sciezka = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "logs.txt");
            File.AppendAllText("logs.txt", $"Operacja: {youChoice}\n Dane: {firstNumber}, {secondNumber}\n Wynik: {result}\n");
            Console.WriteLine("Czy chcesz kontynować? (T/N): ");
            c = Console.ReadLine();
            if (c.ToUpper().Equals("N"))
            {
                break;
            }
        }
    }
}