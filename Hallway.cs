using static System.Console;

namespace HomeWork12Game
{
    internal class Hallway
    {
        Basement basement = new Basement();

        public void HallwayRun()
        {
            string whereToGo;

            WriteLine("\nВыйдя из кабинета, профессор оказался в коридоре.\n");
            while (true)
            {
                Write("Введите \"ВПЕРЕД\", чтобы пройти по коридору, или \"НАЗАД\" для возврата в лабораторию: ");
                whereToGo = ReadLine().ToLower();
                switch (whereToGo)
                {
                    case "вперед":
                        WriteLine("\nПройдя по коридору, профессор наткнулся на запертые кабинеты и лестницу.");
                        DownOrNot();
                        return;
                    case "назад":
                        WriteLine("\nВернувшись в лабораторию, профессор заметил, что за время его отсутствия ничего там не изменилось, и он вышел обратно в коридор.\n");
                        break;
                    default:
                        WriteLine("\nЯ не могу туда идти!\n");
                        break;
                }
            }
        }

        private void DownOrNot()
        {
            string downStairs;

            while (true)
            {
                Write("\nСпуститься? (ДА): ");
                downStairs = ReadLine().ToLower();
                switch (downStairs)
                {
                    case "да":
                        basement.InBasement();
                        return;
                    default:
                        WriteLine("\nМы не можем стоять тут вечно!\n");
                        break;
                }
            }
        }
    }
}
