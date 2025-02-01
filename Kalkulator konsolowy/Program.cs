internal class Program
{
    private static int GetMenuChoice()
    {
        while (true)
        {
            Console.Write("Twój wybór: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 8)
            {
                return choice;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Błąd spowodowany złym wyborem");
            Console.ResetColor();
        }
    }
    private static void ShowAllHistory()
    {
        try
        {
            string[] logs = File.ReadAllLines("logs.txt");
            foreach (string line in logs) {
                Console.WriteLine(line);
            }
        }catch (FileNotFoundException)
        {
            Console.WriteLine("Brak pliku z historią operacji!");
        }
    }
    private static void LogOperation(int operation, double num1, double num2, double result)
    {
        try
        {
            string logEntry = $"[{DateTime.Now}] Operacja: {GetOperationName(operation)} | Liczby: {num1}, {num2} | Wynik: {result}\n";
            File.AppendAllText("logs.txt", logEntry);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Błąd zapisu do pliku: {ex.Message}");
            Console.ResetColor();
        }
    }

    private static string GetOperationName(int operation)
    {
        return operation switch
        {
            1 => "Dodawanie",
            2 => "Odejmowanie",
            3 => "Mnożenie",
            4 => "Dzielenie",
            5 => "Modulo",
            6 => "Potęgowanie",
            _ => "Nieznana operacja"
        };
    }
    private static bool AskToContinue()
    {
        Console.Write("Czy chcesz kontynuować? (T/N): ");
        return Console.ReadLine().ToUpper() == "T";
    }
    private static void DisplayResults(double result, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine($"Wynik: {result}");
        Console.ResetColor();
    }
    private static void ShowMenu()
    {
        Console.WriteLine("Witaj w kalkulatorze konsolowym!\n");
        Console.WriteLine("Wybierz opcje:\n" + "1. Dodawanie\n" + "2. Odejmowanie\n" +
            "3. Mnożenie\n" + "4. Dzielenie\n" + "5. Modulo\n" + "6. Potęgowanie\n"
            + "7. Wyjdz\n" + "8. Pokaż historię");
    }
    private static void ShowHistoryMenu()
    {
        Console.WriteLine("\nHistoria operacji:");
        Console.WriteLine("1. Pokaż wszystkie");
        Console.WriteLine("2. Wyczyść historię");
        Console.WriteLine("3. Powrót");
        Console.Write("Twój wybór: ");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            switch (choice)
            {
                case 1:
                    ShowAllHistory();
                    break;
                case 2:
                    ClearHistory();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Nieprawidłowy wybór!");
                    break;
            }
        }
    }

    private static void ClearHistory()
    {
        try
        {
            File.WriteAllText("logs.txt", string.Empty);
            Console.WriteLine("Historia wyczyszczona!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
    }
    private static double GetNumberFromUser(string prompt)
    {
        double number;
        while (true)
        {
            Console.Write(prompt);
            // 4. Poprawiono odczyt danych wejściowych
            if (double.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("To nie jest prawidłowa liczba");
            Console.ResetColor();
        }
    }
    private static double PerformCalculation(int operation, double num1, double num2)
    {
        return operation switch
        {
            1 => num1 + num2,
            2 => num1 - num2,
            3 => num1 * num2,
            4 => num2 == 0 ? HandleDivisionByZero() : num1 / num2,
            5 => num2 == 0 ? HandleDivisionByZero() : num1 % num2,
            6 => Math.Pow(num1, num2),
            _ => double.NaN
        };
    }
    private static double HandleDivisionByZero()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Błąd: Dzielenie przez zero");
        Console.ResetColor();
        return double.NaN;
    }
    private static void GetUserInput()
    {

    }
    private static void GetUserOutput() { }
    private static void Main(string[] args)
    {
        while (true)
        {
            ShowMenu();
            int choice = GetMenuChoice();

            if (choice == 7) break;
            if (choice == 8)
            {
                ShowHistoryMenu();
                continue;
            }

            double num1 = GetNumberFromUser("Podaj pierwszą liczbę: ");
            double num2 = GetNumberFromUser("Podaj drugą liczbę: ");

            double result = PerformCalculation(choice, num1, num2);
            if (double.IsNaN(result)) continue;

            DisplayResults(result, ConsoleColor.Green);
            LogOperation(choice, num1, num2, result);

            if (!AskToContinue()) break;
        }
    }
}