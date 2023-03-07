using knowledgecheck2;
using System.Globalization;

internal class Program
{

    private static void Main(string[] args)
    {
        bool gameInPlay = true;

        static bool setGameInPlay(bool gameInPlay)
        {
            return !gameInPlay;
        }

        while (gameInPlay)
        {

            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<BallSports>();

            static bool getOlympicsAnswer(string answer)
            {
                if (answer is null)
                {
                    throw new ArgumentNullException(nameof(answer));
                }

                if (answer != "Y")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var myClass = new BallSports();

                Console.WriteLine("Enter name of the Ball Sport:");
                myClass.Name = Console.ReadLine();
                Console.WriteLine("How many players are there on the field:");
                myClass.NumberOfPlayers = int.Parse(Console.ReadLine());
                Console.WriteLine("Is this sport in the Olympic Games: Y / N ");

                string OlympicsAnswer = Console.ReadLine();
                myClass.InOlympics = getOlympicsAnswer(OlympicsAnswer);

                recordList.Add(myClass);
            }


            // Print out the list of records using Console.WriteLine()
            for (int i = 0; i < numberOfRecords; i++)
            {
                var recordToPrint = recordList[i];
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Ball sport name: " + recordToPrint.Name);
                Console.WriteLine("Number of players: " + recordToPrint.NumberOfPlayers);
                Console.WriteLine("This sport is part of the Olympics " + recordToPrint.InOlympics);

            }

            Console.WriteLine("Play again: Y / N ");
            string continuePlay = Console.ReadLine().ToUpper();

            if (continuePlay == "Y")
            {
                setGameInPlay(gameInPlay);
            }
            else if (continuePlay == "N")
            {
                break;
            }
        }
        
    }
}



