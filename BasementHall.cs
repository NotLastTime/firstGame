using static System.Console;

namespace HomeWork12Game
{
    internal class BasementHall
    {
        public void InBasementHall() 
        {
            GuardRoom guardRoom = new GuardRoom();
            FarBasementHall farBasementHall = new FarBasementHall();
            string enterGuardRoom;

            WriteLine("\nПеред тем, как захлопнуть дверь, Чудаков почувствовал боль в левом боку, будто его ожгло огнём.");
            WriteLine("Осмотрев запертую дверь, в которую кто-то продолжал ломиться, Чудаков побрёл по коридору.");
            WriteLine("Справа от него была дверь в комнату охраны.");


            while (true)
            {
                Write("\nЗайти? (ДА/НЕТ): ");
                enterGuardRoom = ReadLine().ToLower();
                switch (enterGuardRoom)
                {
                    case "да":
                        guardRoom.InGuardRoom();
                        return;
                    case "нет":
                        WriteLine("\nПрофессор прошёл мимо, даже не заметив, что рядом с ним была дверь.");
                        farBasementHall.InFarBasementHall();
                        return;
                    default:
                        WriteLine("Неверный ввод");
                        break;
                }
            }
        }
    }
}
