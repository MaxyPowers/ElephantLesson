
class Elephant
{
    public string Name;
    public int EarSize;

    public void WhoAmI()
    {
        Console.WriteLine($"My name is {Name}.");
        Console.WriteLine($"My ears are {EarSize} inches tall.");
    }

    public void HearMessage(string message, Elephant whoSaidIt)
    {
        Console.WriteLine(Name + " heard a message");
        Console.WriteLine(whoSaidIt.Name + " said this: " + message);
    }

    public void SpeakTo(Elephant whoTalkTo, string message)
    {
        whoTalkTo.HearMessage(message, this);
    }

    public Elephant(string name, int earSize)
    {
        Name = name;
        EarSize = earSize;
    }
}

class Progam
{
    public static void Remove(ref Elephant lloyd, ref Elephant lucinda)
    {
        Elephant second = lloyd;
        lloyd = lucinda;
        lucinda = second;
        Console.WriteLine("References have been swapped");
    }

    static void Main(string[] args)
    {
        Elephant lloyd = new Elephant("Lloyd", 40);
        Elephant lucinda = new Elephant("Lucinda", 33);

        Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");

        while (true)
        {
            char key = Console.ReadKey(true).KeyChar;
            Console.WriteLine("You pressed " + key);
            if (key == '1')
            {
                lloyd.WhoAmI();
            }
            else if (key == '2')
            {
                lucinda.WhoAmI();
            }
            else if (key == '3')
            {
                Remove(ref lloyd, ref lucinda);
            }
            else if (key == '4')
            {
                lloyd = lucinda;
                lloyd.EarSize = 4321;
                lloyd.WhoAmI();
            }
            else if (key == '5')
            {
                lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
            }
            else
                Console.WriteLine("You are a idiot xD");

            Console.WriteLine();
        }
    }
}