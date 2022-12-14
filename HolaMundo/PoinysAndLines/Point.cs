namespace PointsAndLines
{
    class User
    {
        private string username;
        public int password;
        public static int CurrID;
        public readonly int ID;
        public readonly int HEIGHT;

        public Race race;

        public string Username
        {
            get
            {
                return "Your username is "+username;
            }
            set
            {
                if(value.Length >= 4 && value.Length <= 10)
                {
                    username = value;
                }
                else
                {
                    System.Console.WriteLine("Oops! This is nota  valid username. Please usea username between 4 to 10 characters");
                }
               
            }
        }

        public int Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value >= 4 && value <= 10)
                {
                    password = value;
                }
                else
                {
                    System.Console.WriteLine("Oops! This is nota  valid password. Please use a password between 4 to 10 characters");
                }
            }
        }

        public User(string username, int password, Race race)
        {
            this.username = username;
            this.password = password;
            this.race = race;

            if (this.race == Race.Earthling)
            {
                HEIGHT = 100;

            }
            else if (this.race == Race.Martian)
            {
                HEIGHT = 180;
            }
        }
        public User()
        {
            CurrID++;
            ID = CurrID;

            
            
        }
    }
    

}

