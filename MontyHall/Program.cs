
namespace MontyHall
{
    public class Program
    {
        public static void Main(string [] args)
        {
            double winCount = 0.0;
            const int totalIterations = 1000;
            for (int i = 0; i < totalIterations; ++i)
            {
                var random = new Random();
                const int numDoors = 3;
                int userDoor = random.Next(1, numDoors + 1);

                GameManager manager = new(numDoors);
                manager.CreateDoors();
                manager.SetUserDoor(userDoor);
                manager.SelectLastChoiceDoor();
                manager.KeepOrSwitchPrompt();

                Prize prize = manager.SelectSwitchOrKeep("switch");
                if (prize == Prize.Car)
                {
                    winCount++;
                }
            }

            Console.WriteLine("Win percentage {0}%", winCount / totalIterations * 100);
        }
    }
}