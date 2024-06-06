using static System.Console;

namespace HomeWork12Game
{
    internal class GuardRoom
    {
        public void InGuardRoom()
        {
            FarBasementHall basementHall = new FarBasementHall();
            Archive archive = new Archive();

            int bandage = 1;
            int bottle = 1;
            int emptyBottle = 0;
            int outside = 0;

            WriteLine("\nЗайдя в комнату охраны, профессор осмотрел свой бок. Сняв окровавленную рубашку, он увидел длинные борозды, как от огромных когтей.");
            WriteLine("\n\"Ещё -35 к здоровью\", - констатировал профессор.\n");
            WriteLine("Рана была неглубокая, но разодранный бок кровоточил и, вероятно, было сломано ребро... а может не одно.");
            WriteLine("На столе стоял недопитый чай, и валялась вчерашняя газета с недоконченным кроссвордом. Рядом с кроватью стояла тумба, на стене висела аптечка.");
            WriteLine("Рядом с аптечкой на стене был план этажа. Согласно плану, сразу за комнатой охраны коридор делал поворот, за которым был отмечен выход.\n");
            WriteLine("Под потолком он заметил вентиляционную шахту.\n");

            WriteLine("Выберите действие:\n1. Заглянуть в аптечку\n2. Обыскать тумбочку\n3. Покинуть комнату охраны");

            int choosingAction = Convert.ToInt32(ReadLine());

            while (choosingAction != 3)
            {
                switch (choosingAction)
                {
                    case 1:
                        if (bandage > 0)
                        {
                            WriteLine("\nВ аптечке лежали бинт и анальгин.");
                            WriteLine("Кое-как перебинтовав рану на боку и завязав сверху бинт рубашкой, Чудаков проглотил таблетку анальгина.");
                            bandage--;
                        }
                        else
                        {
                            WriteLine("\nАптечка оказалась пуста.");
                        }
                        break;
                    case 2:
                        if (bottle > 0)
                        {
                            WriteLine("\nВ тумбе нашлась слегка початая бутылка водки.");
                            Write("\nВыпить? (ДА/НЕТ): ");
                            string choosingDrink = ReadLine().ToLower();
                            if (choosingDrink == "да")
                            {
                                WriteLine("\nПрофессор залпом осушил полбутылки. По телу растеклось тепло. Он смог немного расслабиться.");
                                WriteLine("Остатки он вылил на уже пропитавшиеся кровью бинты.");
                            }
                            else
                            {
                                WriteLine("\nПрофессор вылил все содержимое бутылки на уже пропитавшиеся кровью бинты.");
                            }
                            bottle--;
                            emptyBottle++;
                        }
                        else
                        {
                            WriteLine("\nТумбочка оказалась пуста.");
                        }
                        break;
                    case 3:
                        return;
                    default:
                        WriteLine("\nНеверный выбор.");
                        break;
                }
                WriteLine("\nВыберите действие:\n1. Заглянуть в аптечку\n2. Обыскать тумбочку\n3. Покинуть комнату охраны");
                choosingAction = Convert.ToInt32(ReadLine());
            }

            if (choosingAction == 3)
            {
                WriteLine("\nПрофессор направился к двери, но путь ему преградила тварь, похожая на огромного паука.");
                WriteLine("Чудакову почему-то вспомнился С. Кинг.");

                while (true)
                {
                    WriteLine("Выберите действие:\n1. Попытаться отвлечь монстра и выбежать в коридор\n2. Забраться в шахту, в надежде не застрять там");
                    int choiseSave = Convert.ToInt32(ReadLine());

                    switch (choiseSave)
                    {
                        case 1:
                            if (emptyBottle > 0)
                            {
                                Random random = new Random();
                                int chance = random.Next(0, 10);
                                if (chance >= 5)
                                {
                                    WriteLine("\nПрофессор бросил пустую бутылку в дальний угол комнаты. Монстр пополз на шум, а Чудаков в это время выскочил за дверь, успев закрыть её за собой.");
                                    emptyBottle--;
                                    outside++;
                                }
                                else
                                {
                                    WriteLine("\nПрофессор бросил пустую бутылку в дальний угол комнаты, но монстр не обратил на это внимание и двинулся прямо на Чудакова.");
                                    emptyBottle--;
                                }
                            }
                            else
                            {
                                WriteLine("\nВ руках пусто. Отвлекать некогда и нечем.");
                            }
                            break;
                        case 2:
                            WriteLine("\nЧудаков вскочил на стол и дотянулся до вентиляционной шахты, забравшись в неё настолько проворно, насколько позволяли его ушибленное плечо и раненый бок.");
                            outside--;
                            break;
                    }

                    if (outside > 0)
                    {
                        basementHall.InFarBasementHall();
                        break;
                    }
                    else if (outside < 0)
                    {
                        archive.InArchive();
                        break;
                    }
                }
            }
        }
    }
}