using static System.Console;

namespace HomeWork12Game
{
    internal class Basement
    {
        ServerRoom serverRoom = new ServerRoom();
        BasementHall basementHall = new BasementHall();

        public void InBasement()
        {
            WriteLine("\nСпускаясь по лестнице, профессор подскользнулся и скатился вниз, вывихнув ногу и сильно ударившись плечом. Он был готов поклясться, что какая-то тварь пнула его под зад.\n");
            WriteLine("\"-10 к здоровью\", - подумал Чудаков, потирая ушибленное плечо и оглядываясь по сторонам.\n");
            WriteLine("Слева была дверь, ведущая в серверную. \"Смертным вход воспрещен!!!\" - гласила табличка на двери, но сама дверь была почему-то не плотно закрыта, и из-за неё пробивалась полоска тусклого зеленоватого свечения.");
            WriteLine("Слышался шум работающей аппаратуры.");
            WriteLine("\nСправа коридор уходил в темноту. Чудаков был в этом подвале всего пару раз за всю свою долгую карьеру в лаборатории, но он знал, что выход в той стороне.");
            WriteLine("\nИз серверной послышался странный звук, выбивающийся из общего монотонного гула серверов.");

            Write("\nЗаглянуть в серверную? (ДА/НЕТ): ");


            string enterServerRoom = ReadLine().ToLower();

            while (true)
            {
                switch (enterServerRoom)
                {
                    case "да":
                        serverRoom.InServerRoom();
                        return;
                    case "нет":
                        basementHall.InBasementHall();
                        return;
                    default:
                        WriteLine("Неверный ввод");
                        break;
                }
            }
        }
    }
}
