using System;
using System.Collections.Generic;
using System.Text;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> songs = new Queue<string>(input);

            while (songs.Count > 0)
            {
                string inputed = Console.ReadLine();
                string[] command = inputed.Split();

                string currentCommand = command[0];

                if (currentCommand == "Play")
                {
                    songs.Dequeue();
                }
                else if (currentCommand == "Add")
                {
                    string currentSong = string.Empty;


                    if (command.Length > 1)
                    {

                        StringBuilder helperForSong = new StringBuilder();

                        for (int i = 1; i < command.Length; i++)
                        {
                            helperForSong.Append(command[i] + " ");
                        }



                        currentSong = helperForSong.ToString();

                        currentSong = currentSong.Substring(0, currentSong.Length - 1);

                    }

                    if (songs.Contains(currentSong))
                    {
                        Console.WriteLine("{0} is already contained!", currentSong);
                    }
                    else
                    {
                        songs.Enqueue(currentSong);
                    }

                }
                else if (currentCommand == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }

            }

            Console.WriteLine("No more songs!");
        }
    }
}
