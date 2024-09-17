namespace Git_SUT24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, to this awesome game!");
            Console.WriteLine("Choose a nickname");
            string userNick = Console.ReadLine();
            Console.WriteLine($"Greetings {userNick}");


            Console.WriteLine("Choose a number");

            Console.WriteLine("1. Skriv ett ord " +
                "\n2. Skriv ett number " +
                "\n3.Avsluta program");
            string userNum = Console.ReadLine();
            int nr = Convert.ToInt32(userNum);


            switch (nr)
            {

                case 1:
                    Console.WriteLine("Skriv ett ord");
                    break;

                case 2:
                    Console.WriteLine("Skriv ett tal");
                    
                    break;

                case 3:

                    break;

                default:
                    Console.WriteLine("Vad håller du på med");
                    break;







            }
           

        }
    }
}
