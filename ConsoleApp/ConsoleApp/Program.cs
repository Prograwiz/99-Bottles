using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StartOfTheSong());

            string StartOfTheSong()
            {
                string lyrics = "Start of the song!" + Environment.NewLine + Environment.NewLine;

                // Lyrics of the song
                for (int i = 99; i > 0; i--)
                {
                    lyrics += Environment.NewLine + i + $" bottle{(i == 1 ? "" : "s")} of beer on the wall,";
                    lyrics += Environment.NewLine + i + $" bottle{(i == 1 ? "" : "s")} of beer!";
                    lyrics += Environment.NewLine + "Take one down,";
                    lyrics += Environment.NewLine + "Pass it around,";
                    lyrics += Environment.NewLine +
                              $"{(i - 1 == 0 ? "No more bottles" : i - 1 + $" bottle{(i - 1 == 1 ? "" : "s")}")} of beer on the wall!" +
                              Environment.NewLine;
                }

                lyrics += Environment.NewLine + Environment.NewLine + "End of the song!";

                return lyrics;
            }
        }
    }
}