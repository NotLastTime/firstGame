using static System.Console;

namespace HomeWork12Game
{
    internal class FarBasementHall
    {
        public void InFarBasementHall()
        {
            BossRoom bossRoom = new BossRoom();

            WriteLine("\nПройдя по коридору до угла, профессор вляпался в какую-то вязкую жижу.");
            WriteLine("Осветив фонариком ботинок, он увидел, что его подошва стремительно тает на глазах, будто под действием концентрированной серной кислоты.\n");
            WriteLine("- Только этого мне не хватало, - заорал Чудаков, скидывая ботинки и по стеночке аккуратно обходя лужу.");
            WriteLine("\nЗавернув за угол, профессор осветил коридор и увидел в конце дверь. Если верить плану, то за ней должен быть выход.");
            WriteLine("Чудаков подошёл к двери, взялся за ручку и на секунду замер.");

            while (true)
            {
                Write("Открыть дверь? (ДА/НЕТ): ");
                string openTheDoor = ReadLine().ToLower();

                switch (openTheDoor)
                {
                    case "да":
                        WriteLine("\nОткрыв дверь, профессор шагнул внутрь. Дверь за ним тут же захлопнулась.");
                        bossRoom.InBossRoom();
                        return;
                    case "нет":
                        WriteLine("\nМожем ещё отдохнуть, но не долго, время не ждёт, а твари, что остались позади, рыщут в поисках добычи.");
                        break;
                    default:
                        WriteLine("\nНеверный ввод");
                        break;
                }
            }
        }
    }
}
