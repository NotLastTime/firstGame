using static System.Console;

namespace HomeWork12Game
{
    internal class CombinationLock
    {
        public void Lock()
        {
            BasementHall basementHall = new BasementHall();

            string combinationLock;
            HashSet<int> validNumbers = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int attemptСounter = 3;

            while (attemptСounter > 0)
            {
                WriteLine();
                if (attemptСounter == 1)
                {
                    WriteLine($"Осталось {attemptСounter} попытка");
                }
                else
                {
                    WriteLine($"Осталось {attemptСounter} попытки");
                }

                Write("\nВведите 4-х значный пин-код и нажмите Enter (0001-помощь):");
                
                combinationLock = ReadLine();
                
                if (combinationLock.Length != 4 && !AllDigitsValid(combinationLock, validNumbers))
                {
                    WriteLine("\nНеверные символы или их количество");
                }
                else
                {
                    int code = Convert.ToInt32(combinationLock);
                    switch (code)
                    {
                        case 0001:
                            WriteLine("\nСумма цифр пин-кода равна 18. При этом сумма первых 2-х цифр равна сумме последних 2-х цифр");
                            break;
                        case 9054:
                            WriteLine("\nДверь открылась и профессор пулей вылетел в коридор.");
                            basementHall.InBasementHall();
                            return;
                        default:
                            WriteLine("\nНеверно!");
                            break;
                    }
                }
                attemptСounter--;
            }

            if (attemptСounter < 1)
            {
                WriteLine("\nНа экране появилась надпись \"Несанкционированный доступ. Блокировка 15 минут\"");
                WriteLine("\nВ ту же секунду Существо настигнуло Чудакова и с радостным чавканием откусило ему голову.");
                WriteLine("\nВы проиграли :(\n");
                WriteLine("Нажмите любую клавишу для выхода");
                ReadKey();
            }
        }

        private static bool AllDigitsValid(string combinationLock, HashSet<int> validNumbers)
        {
            foreach (char c in validNumbers)
            {
                if (!validNumbers.Contains(c - '0'))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
