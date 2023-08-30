namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            String[] choices = { "PIEDRA", "PAPEL", "TIJERA" };
            String playerChoice;
            String computerChoice;
            String winner;

            drawLimit(35);
            Console.WriteLine("|Bienvenido a PIEDRA, PAPEL, TIJERA|");
            drawLimit(35);

            while (playAgain)
            {
                Console.WriteLine("\nEscribe una opcion:\n");

                do
                {
                    playerChoice = choose(choices);

                    if (playerChoice == "false")
                    {
                        Console.WriteLine("\nPor favor, introduce una opción válida\n");
                    }

                } while (playerChoice == "false");

                computerChoice = computerChoose(choices);

                Console.WriteLine("\nHas seleccionado " + playerChoice);
                Console.WriteLine("El ordenador ha seleccionado " + computerChoice);

                switch (playerChoice)
                {
                    case "PIEDRA":
                        if (computerChoice != "PIEDRA")
                        {
                            winner = computerChoice == "TIJERA" ? "\nHas ganado!\n" : "\nHas perdido\n";
                            Console.WriteLine(winner);
                        }
                        else
                        {
                            winner = "\nEmpatados!\n";
                            Console.WriteLine(winner);
                        }
                        break;

                    case "PAPEL":
                        if (computerChoice != "PAPEL")
                        {
                            winner = computerChoice == "PIEDRA" ? "\nHas ganado!\n" : "\nHas perdido\n";
                            Console.WriteLine(winner);
                        }
                        else
                        {
                            winner = "\nEmpatados!\n";
                            Console.WriteLine(winner);
                        }
                        break;

                    case "TIJERA":
                        if (computerChoice != "TIJERA")
                        {
                            winner = computerChoice == "PAPEL" ? "\nHas ganado!\n" : "\nHas perdido\n";
                            Console.WriteLine(winner);
                        }
                        else
                        {
                            winner = "\nEmpatados!\n";
                            Console.WriteLine(winner);
                        }
                        break;
                }

                Console.WriteLine("\nQuieres jugar otra vez?: (Y/N)\n");
                String again = Console.ReadLine();
                again = again.ToUpper();
                playAgain = again == "Y" ? playAgain = true : playAgain = false;

            }

            Console.WriteLine("\nGracias por jugar!\n");
        }

        static void drawLimit(int size)
        {
            for (int i = 0; i <= size; i++)
            {
                if (i == 0 || i == size)
                {
                    var limitSymbol = i == size ? "* \n" : "*";
                    Console.Write(limitSymbol);
                }
                else
                {
                    Console.Write('-');
                }
            };
        }

        static String choose(String[] choices)
        {
            String playerChoice = Console.ReadLine();
            playerChoice = playerChoice.ToUpper();

            if (playerChoice != "" && choices.Contains(playerChoice))
            {
                return playerChoice;
            }
            else
            {
                return "false";
            }

        }

        static String computerChoose(String[] choices)
        {
            Random randomChoice = new Random();
            int randomNum = randomChoice.Next(1, 4);
            String computerChoice = "";

            switch (randomNum)
            {
                case 1:
                    computerChoice = "PIEDRA";

                    break;

                case 2:
                    computerChoice = "PAPEL";

                    break;

                case 3:
                    computerChoice = "TIJERA";

                    break;
            }

            return computerChoice;
        }
    }
}