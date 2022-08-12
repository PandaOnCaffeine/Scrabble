namespace Scrabble
{
    internal class Program
    {
        //A static string for the word, so it can be used across functions
        static string word;
        static void Main(string[] args)
        {
            //Runs Gui
            Program.Gui();
            Console.ReadLine();
        }
        static void Gui()
        {
            //Indicates that the user has to input a word
            Console.WriteLine("Indtast dit ord");
            Program.Controller();
            //writes the words total amount of points
            Console.WriteLine($"Dit ord er værd {TotalPoints()} points ialt");
        }
        static void Controller()
        {

            Model();
        }
        static void Model()
        {
            //Sets the string word to what the user inputs
            word = Console.ReadLine();
        }
        static int Letters1Point(string word)
        {
            //checks each char for the letters worth 1 point
            //Changes the word to lowercase so your word can be both lower and uppercase
            int points = 0;
            foreach (char ch in word.ToLower())
            {
                char.ToLower(ch);
                if (ch == 'e' || ch == 'a' || ch == 'r' || ch == 'n')
                {
                    points++;
                }
            }
            return points;
        }
        static int Letters2Points (string word)
        {
            //checks each char for the letters worth 2 point
            //Changes the word to lowercase so your word can be both lower and uppercase
            int points = 0;
            foreach (char ch in word.ToLower())
            {
                char.ToLower(ch);
                if (ch == 'd' || ch == 'l' || ch == 'o' || ch == 's'||ch == 't')
                {
                    points += 2;
                }
            }
            return points;
        }
        static int Letters3Points(string word)
        {
            //checks each char for the letters worth 3 point
            //Changes the word to lowercase so your word can be both lower and uppercase
            int points = 0;
            foreach (char ch in word.ToLower())
            {
                char.ToLower(ch);
                if (ch == 'b' || ch == 'i' || ch == 'k' || ch == 'f' || ch == 'g' || ch == 'm' || ch == 'u' || ch == 'v')
                {
                    points += 3;
                }
            }
            return points;
        }
        static int Letters4Points(string word)
        {
            //checks each char for the letters worth 4 point
            //Changes the word to lowercase so your word can be both lower and uppercase
            int points = 0;
            foreach (char ch in word.ToLower())
            {
                char.ToLower(ch);
                if (ch == 'h' || ch == 'j' || ch == 'p' || ch == 'y' || ch == 'æ' || ch == 'ø' || ch == 'å')
                {
                    points += 4;
                }
            }
            return points;
        }
        static int Letters8Points(string word)
        {
            //checks each char for the letters worth 8 point
            //Changes the word to lowercase so your word can be both lower and uppercase
            int points = 0;
            foreach (char ch in word.ToLower())
            {
                if (ch == 'c' || ch == 'x' || ch == 'z' || ch == 'w' || ch == 'q')
                {
                    points += 8;
                }
            }
            return points;
        }
        static int TotalPoints()
        {
            return Letters1Point(word) + Letters2Points(word) + Letters3Points(word) + Letters4Points(word) + Letters8Points(word);
        }
    }
}