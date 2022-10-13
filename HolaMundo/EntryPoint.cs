using PointsAndLines;
namespace HolaMundo
{
    class EntryPoint
    {
        static void Main()
        {
            User user = new User("Putin", 1234, Race.Martian);
           

            System.Console.WriteLine(user.HEIGHT);
            Utilities.ColorfulWritelIne(user.Username, System.ConsoleColor.Blue);


        }

    }
}

