using static System.Console;

namespace HomeWork12Game
{
    internal class BossRoom
    {
        public void InBossRoom()
        {
            Hospital hospital = new Hospital();

            int fireExtinguisher = 0;

            WriteLine("\nОказавшись в комнате, Чудаков понял, что это последняя остановка на его пути.");
            WriteLine("Он увидел гермодверь с надписью \"Выход\".");
            WriteLine("Рядом с дверью висел огнетушитель.");
            WriteLine("Как только профессор подошел к двери и взялся за ручку, он услышал за спиной хлопанье, будто вода капает с потолка на пол.");
            WriteLine("Резко обернувшись, он увидел Существо, напоминающее огромного слизняка. Из отверстия, что могло быть ртом, стекала вязкая слюна и с шипением падала на пол.\n");
            WriteLine("\"Так вот во что я вляпался\", - подумал профессор, чувствуя, как бетонный пол охлаждает его босые ноги.");
            WriteLine("\nТем временем существо начало медленно двигаться к Чудакову. Оно было крайне неуклюжее.");

            while (true)
            {
                Write("\n1. Бежать или 2. Атаковать: ");
                int lastChoice = Convert.ToInt32(ReadLine());
                switch (lastChoice)
                {
                    case 1:
                        WriteLine("\nБежать некуда, придется принять последний бой.");
                        break;
                    case 2:
                        WriteLine("\nСхватив с огнетушителя, он направил его к монстру.");
                        fireExtinguisher++;
                        Write("Нажать на рычаг? (ДА/НЕТ): ");
                        string pressDown = ReadLine().ToLower();
                        switch (pressDown)
                        {
                            case "да":
                                WriteLine("\nСдавив рычаг, Чудаков выпустил смесь из огнетушителя в сторону слизня.");
                                Random random = new Random();
                                int chanceOfHit = random.Next(0, 10);
                                if (chanceOfHit > 5)
                                {
                                    WriteLine("\nСлизень отшатнулся от попавшей в него струи смеси и поспешил отступить. Но насколько надолго?");
                                }
                                else
                                {
                                    WriteLine("\nПрофессор понял, что промахнулся и не нашел ничего лучше, чем запустить в слизняка опустевший огнетушитель, и кажется, попал прямо в его пасть.");
                                    fireExtinguisher--;
                                }
                                break;
                            case "нет":
                                WriteLine("\n- Чего ты ждешь? Жми!!!, - заорал сам на себя профессор.");
                                break;
                            default:
                                WriteLine("\nНеверный ввод");
                                break;
                        }
                        break;
                    default:
                        WriteLine("\nНеверный ввод");
                        break;
                }

                if (fireExtinguisher > 0)
                {
                    WriteLine("\nПрофессор отбросил пустой огнетушитель и поспешил к двери.");
                }
                else
                {
                    WriteLine("\nПока слизняк давился, пытаясь переварить огнетушитель, профессор поспешил к двери.");
                }

                WriteLine("\nСхватившись за ручку, Чудаков начал ее крутить.");

                while (true)
                {
                    Write("\nВыберите вариант: 1. Влево 2. Вправо: ");
                    int turn = Convert.ToInt32(ReadLine());
                    switch (turn)
                    {
                        case 1:
                            WriteLine("\nНе поддается, надо крутить в другую сторону.");
                            break;
                        case 2:
                            WriteLine("\nСо скрежетом ручка повернулась, и дверь открылась.");
                            WriteLine("От резкого удара яркого дневного света в глаза, измученный и обессиленный профессор потерял сознание.");
                            hospital.InHospital();
                            return;
                        default:
                            WriteLine("\nНеверный ввод");
                            break;
                    }
                }
            }
        }
    }
}
