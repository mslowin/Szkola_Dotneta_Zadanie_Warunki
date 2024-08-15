using System.Data;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Szkola_Dotneta_Zadanie_Warunki
{
    internal class Program
    {
        private static void Main()
        {
            // Zadanie 1
            int a = 5;
            int b = 5;

            if (a == b)
            {
                Console.WriteLine($"{a} i {b} są równe");
            }

            // Zadanie 2
            Console.WriteLine("\r\nTest na parzystą i nieparzystą liczbę: ");
            while (true)
            {
                Console.Write("Proszę podać liczbę: ");
                if (!int.TryParse(Console.ReadLine(), out int userInputInt))
                {
                    continue;
                }

                if (userInputInt % 2 == 0)
                {
                    Console.WriteLine($"{userInputInt} jest liczbą parzystą.");
                    break;
                }

                Console.WriteLine($"{userInputInt} jest liczbą nieparzystą.");
                break;
            }

            // Zadanie 3
            Console.WriteLine("\r\nTest na dodatnią i ujemną liczbę: ");
            while (true)
            {
                Console.Write("Proszę podać liczbę: ");
                if (!int.TryParse(Console.ReadLine(), out int userInputInt))
                {
                    continue;
                }

                if (userInputInt > 0)
                {
                    Console.WriteLine($"{userInputInt} jest liczbą dodatnią.");
                    break;
                }

                if (userInputInt < 0)
                {
                    Console.WriteLine($"{userInputInt} jest liczbą ujemną.");
                    break;
                }

                Console.WriteLine($"{userInputInt} nie jest ani dodatnie ani ujemne.");
                break;
            }

            // Zadanie 4
            Console.WriteLine("\r\nTest na rok przestępny: ");
            while (true)
            {
                Console.Write("Proszę podać rok: ");
                if (!int.TryParse(Console.ReadLine(), out int userInputInt))
                {
                    continue;
                }

                if (userInputInt < 0)
                {
                    continue;
                }

                if (IsLeapYear(userInputInt))
                {
                    Console.WriteLine($"{userInputInt} jest rokiem przestępnym.");
                    break;
                }

                Console.WriteLine($"{userInputInt} nie jest rokiem przestępnym.");
                break;
            }

            // Zadanie 5
            Console.WriteLine("\r\nTest na stanowisko posła/premiera/senatora/prezydenta: ");
            while (true)
            {
                Console.Write("Proszę podać swój wiek: ");
                if (!int.TryParse(Console.ReadLine(), out int userInputInt))
                {
                    continue;
                }

                if (userInputInt <= 0)
                {
                    continue;
                }

                if (userInputInt >= 35)
                {
                    Console.WriteLine("Możesz zostać prezydentem, posłem i senatorem.");
                    break;
                }

                if (userInputInt >= 30)
                {
                    Console.WriteLine("Możesz zostać posłem i senatorem.");
                    break;
                }

                if (userInputInt >= 21)
                {
                    Console.WriteLine("Możesz zostać posłem.");
                    break;
                }

                Console.WriteLine("Możesz dalej być sobą.");
                break;
            }

            // Zadanie 6
            Console.WriteLine("\r\nTest na karła: ");
            while (true)
            {
                Console.Write("Proszę podać swój wzrost w centymetrach: ");
                if (!int.TryParse(Console.ReadLine(), out int userInputInt))
                {
                    continue;
                }

                if (userInputInt <= 0)
                {
                    Console.WriteLine("Ty kłamczuchu, jeszcze raz");
                    continue;
                }

                if (userInputInt <= 34)
                {
                    Console.WriteLine("Jesteś liliputem.");
                    break;
                }

                if (userInputInt <= 100)
                {
                    Console.WriteLine("Jesteś Hobbitem.");
                    break;
                }

                if (userInputInt <= 140)
                {
                    Console.WriteLine("Jesteś krasnoludem.");
                    break;
                }

                if (userInputInt <= 200)
                {
                    Console.WriteLine("Jesteś człowiekiem.");
                    break;
                }

                if (userInputInt <= 240)
                {
                    Console.WriteLine("Jesteś przerośniętym człowiekiem.");
                    break;
                }

                Console.WriteLine("Jesteś olbrzymem (albo kłamiesz).");
                break;
            }

            // Zadanie 7
            Console.WriteLine("\r\nTest na największą liczbę: ");
            while (true)
            {
                // TODO: jak największych liczb jest kilka to może to napisać?????????????????????

                Console.Write("Proszę podać pierwszą liczbę: ");
                if (!int.TryParse(Console.ReadLine(), out int firstNumber))
                {
                    Console.Write("Jeszcze raz...\r\n");
                    continue;
                }

                Console.Write("Proszę podać drugą liczbę: ");
                if (!int.TryParse(Console.ReadLine(), out int secondNumber))
                {
                    Console.Write("Jeszcze raz...\r\n");
                    continue;
                }

                Console.Write("Proszę podać trzecią liczbę: ");
                if (!int.TryParse(Console.ReadLine(), out int thirdNumber))
                {
                    Console.Write("Jeszcze raz...\r\n");
                    continue;
                }

                var numbersList = new List<int>([firstNumber, secondNumber, thirdNumber]);
                numbersList.Sort();

                Console.WriteLine($"{numbersList[2]} jest największą z podanych.");
                break;
            }

            // Zadanie 8
            // matma > 70 && fiza > 45 && chemia > 45 && wszystkie3 > 180
            // LUB
            // matma + inny przedmiot > 150
            Console.WriteLine("\r\nTest na studenta: ");
            while (true)
            {
                Console.Write("Proszę podać wynik z matematyki: ");
                if (!int.TryParse(Console.ReadLine(), out int maths) || maths < 0)
                {
                    Console.Write("Błąd, jeszcze raz\r\n");
                    continue;
                }

                Console.Write("Proszę podać wynik z fizyki: ");
                if (!int.TryParse(Console.ReadLine(), out int physics) || physics < 0)
                {
                    Console.Write("Błąd, jeszcze raz\r\n");
                    continue;
                }

                Console.Write("Proszę podać wynik z chemii: ");
                if (!int.TryParse(Console.ReadLine(), out int chemistry) || chemistry < 0)
                {
                    Console.Write("Błąd, jeszcze raz\r\n");
                    continue;
                }

                if (maths > 70 && physics > 55 && chemistry > 45 && (maths + physics + chemistry > 180))
                {
                    Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
                    break;
                }

                if (maths + physics > 150 || maths + chemistry > 150)
                {
                    Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
                    break;
                }

                Console.WriteLine("Kandydat nie dopuszczony do rekrutacji.");
                break;
            }

            // Zadanie 9
            Console.WriteLine("\r\nTest temperatury: ");
            while (true)
            {
                Console.Write("Proszę podać temperature: ");
                if (!double.TryParse(Console.ReadLine(), out double temp))
                {
                    Console.Write("Błąd, jeszcze raz\r\n");
                    continue;
                }

                if (temp < 0)
                {
                    Console.WriteLine("Cholernie piździ.");
                    break;
                }

                if (temp < 10)
                {
                    Console.WriteLine("Zimno.");
                    break;
                }

                if (temp < 20)
                {
                    Console.WriteLine("Chłodno.");
                    break;
                }

                if (temp < 30)
                {
                    Console.WriteLine("W sam raz.");
                    break;
                }

                if (temp < 40)
                {
                    Console.WriteLine("Zaczyna być słabo, bo gorąco.");
                    break;
                }

                if (temp >= 40)
                {
                    Console.WriteLine("Czas na Alaskę.");
                    break;
                }

                Console.WriteLine("Nie wiem co ty wpisałeś xD.");
                break;
            }

            // Zadanie 10
            Console.WriteLine("\r\nTest na trójkąt: ");
            while (true)
            {
                Console.Write("Proszę podać boki trójkąta oddzielone spacjami: ");
                var input = Console.ReadLine();

                if (input == null || input == string.Empty)
                {
                    Console.Write("Błąd, jeszcze raz\r\n");
                    continue;
                }

                var numbersStrings = input.Replace('.', ',').Split(" ");

                if (numbersStrings.Length > 3)
                {
                    Console.Write("Błąd, za dużo liczb\r\n");
                    continue;
                }

                var numbersList = new List<double>();

                foreach (var num in numbersStrings)
                {
                    if (double.TryParse(num, out double result))
                    {
                        numbersList.Add(result);
                    }
                }

                if (numbersList.Exists(num => num < 0) || numbersList.Exists(num => num == 0))
                {
                    Console.Write("Błąd, boki muszą być dodatnie\r\n");
                    continue;
                }

                numbersList.Sort();

                if (numbersList[2] >= numbersList[0] + numbersList[1])
                {
                    Console.Write("Nie można zbudować trójkąta!\r\n");
                    break;
                }
                else
                {
                    Console.Write("Można zbudować trójkąt!\r\n");
                    break;
                }
            }

            // Zadanie 11
            Console.WriteLine("\r\nZamiana oceny: ");
            while (true)
            {
                Console.Write("Proszę podać ocenę cyfrą (1, 2, 3, 4, 5 lub 6): ");
                var input = Console.ReadLine();

                if (input == null || input == string.Empty || input.Length > 1)
                {
                    Console.Write("Błąd, jeszcze raz\r\n");
                    continue;
                }

                if (!int.TryParse(input, out int number))
                {
                    Console.Write("Błąd, jeszcze raz\r\n");
                    continue;
                }

                if (number == 0 || number > 6)
                {
                    Console.Write("Błąd, jeszcze raz\r\n");
                    continue;
                }

                Console.WriteLine(number switch
                {
                    1 => "Niedostateczny",
                    2 => "Dopuszczający",
                    3 => "Dostateczny",
                    4 => "Dobry",
                    5 => "Bardzo dobry",
                    6 => "Celujący",
                    _ => "Błąd"
                });
                break;
            }

            // Zadanie 12
            Console.WriteLine("\r\nZamiana dnia tygodnia: ");
            while (true)
            {
                Console.Write("Proszę podać dzień tygodnia cyfrą (1, 2, 3, 4, 5, 6 lub 7): ");
                var input = Console.ReadLine();

                if (input == null || input == string.Empty || input.Length > 1)
                {
                    Console.Write("Błąd, jeszcze raz\r\n");
                    continue;
                }

                if (!int.TryParse(input, out int number))
                {
                    Console.Write("Błąd, jeszcze raz\r\n");
                    continue;
                }

                if (number == 0 || number > 7)
                {
                    Console.Write("Błąd, jeszcze raz\r\n");
                    continue;
                }

                Console.WriteLine(number switch
                {
                    1 => "Poniedziałek",
                    2 => "Wtorek",
                    3 => "Środa",
                    4 => "Czwartek",
                    5 => "Piątek",
                    6 => "Sobota",
                    7 => "Niedziela",
                    _ => "Błąd"
                });
                break;
            }

            // Zadanie 13
            // Postanowiłem zrobić taki bardziej intuicyjny kalkulator
            Console.WriteLine("\r\nKalkulator");
            Console.WriteLine("\r\nAby zakończyć należy wpisać: exit");
            while (true)
            {
                Console.Write("Podaj działanie: ");
                var input = Console.ReadLine();

                if (input == null || input == string.Empty)
                {
                    Console.Write("Błąd, brak danych\r\n");
                    continue;
                }

                if (input == "exit")
                {
                    break;
                }

                var regex = @"[+\-*/]";
                var matches = Regex.Matches(input, regex);

                if (matches.Count == 0)
                {
                    Console.Write("Błąd, należy podać całe działanie\r\n");
                    continue;
                }

                try
                {
                    var table = new DataTable();
                    var result = table.Compute(input, string.Empty);
                    Convert.ToDouble(result);
                    Console.WriteLine($"Wynik: {result}\r\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}\r\n");
                    break;
                }
            }
        }

        private static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
        }
    }
}
