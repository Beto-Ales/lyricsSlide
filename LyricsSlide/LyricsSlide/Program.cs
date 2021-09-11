using System;

namespace LyricsSlide
{
    class Program
    {
        static void Main(string[] args)
        {

            //general variables
            //-----------------            

            //general instructions
            string instructions = @"Press up/down arrow to display next/previous paragraph
press right/left arrow to display next/previous song

Press X to end
---------------------------------------------
";

            //all the songs
            string[][] songs = new string[2][];

            //track the progress though the different parts of a song
            //it cannot be under 0
            byte progress = 0;

            //songs index
            //it cannot be under 0
            byte song = 0;

            //Index for creating new song lyrics
            //I don't want to override the array
            byte newSongI = 0;

            //which key was pressed
            ConsoleKeyInfo keyInfo;


            //LyricsSlide for the songs
            //-------------------------

            songs[newSongI] = new string[]
            {
                @"Let It Be 
The Beatles

When I find myself in times of trouble, Mother Mary comes to me
Speaking words of wisdom, let it be
And in my hour of darkness she is standing right in front of me
Speaking words of wisdom, let it be",
                @"Let It Be 
The Beatles

Let it be, let it be, let it be, let it be
Whisper words of wisdom, let it be",
                @"Let It Be 
The Beatles

And when the broken hearted people living in the world agree
There will be an answer, let it be
For though they may be parted, there is still a chance that they will see
There will be an answer, let it be",
                @"Let It Be 
The Beatles

Let it be, let it be, let it be, let it be
There will be an answer, let it be",
                @"Let It Be 
The Beatles

And when the night is cloudy there is still a light that shines on me
Shinin' until tomorrow, let it be
I wake up to the sound of music, Mother Mary comes to me
Speaking words of wisdom, let it be",
                @"Let It Be 
The Beatles

And let it be, let it be, let it be, let it be
Whisper words of wisdom, let it be"
            };

            ++newSongI;

            //another song

            songs[newSongI] = new string[]
            {
                @"Here Comes the Sun
The Beatles

Here comes the sun do, do, do
Here comes the sun
And I say it's all right",


                @"Here Comes the Sun
The Beatles

Little darling, it's been a long cold lonely winter
Little darling, it seems like years since it's been here",


                @"Here Comes the Sun
The Beatles

Here comes the sun do, do, do
Here comes the sun
And I say it's all right",


                @"Here Comes the Sun
The Beatles

Little darling, the smiles returning to the faces
Little darling, it feels like years since it's been here",


                @"Here Comes the Sun
The Beatles

Here comes the sun do, do, do
Here comes the sun
And I say it's all right",
            };

            ++newSongI;


            //1 first song paragraph

            Console.WriteLine(instructions);
            Console.WriteLine(songs[song][progress]);

            //Console.WriteLine(songs[0].Length - 1);


            //2 key event

            do
            {
                keyInfo = Console.ReadKey();
                //Console.WriteLine(keyInfo.Key);

                if (progress < songs[song].Length - 1 && keyInfo.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    ++progress;
                    Console.WriteLine(instructions);
                    Console.WriteLine(songs[song][progress]);
                }

                if (progress > 0 && keyInfo.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    --progress;
                    Console.WriteLine(instructions);
                    Console.WriteLine(songs[song][progress]);
                }


                
                //LeftArrow
                if (song < songs.Length - 1 && keyInfo.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    progress = 0;
                    ++song;
                    Console.WriteLine(instructions);
                    Console.WriteLine(songs[song][progress]);
                }


                if (song > 0 && keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    progress = 0;
                    --song;
                    Console.WriteLine(instructions);
                    Console.WriteLine(songs[song][progress]);
                }
            }
            while (keyInfo.Key != ConsoleKey.X);






            //    do
            //{
            //    Console.WriteLine("it works");
            //}
            //while (keyInfo.Key == ConsoleKey.DownArrow);

            //Console.WriteLine(keyInfo.Key);

            //Console.WriteLine(songs[0][1]);
        }
    }
}
