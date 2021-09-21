using System;
using System.Collections.Generic;
using System.Text;

namespace LyricsSlide
{
    public class SongLyrics
    {
        //navigation structions
        private string instructions = @"Press up/down arrow to display next/previous paragraph
press right/left arrow to display next/previous song

Press X to end
---------------------------------------------
";

        //properties
        //>>>>>>>>>>+



        //add lyrics
        //-----------------

        //lyrics container
        private string[][] songs = new string[3][];

        //Index for creating new song lyrics
        //I don't want to override the array
        private byte newSongI = 0;

        


        
        //Lyrics display
        //---------------

        //progress through the different parts of a song
        //it cannot be under 0
        private byte progress = 0;

        //songs index
        //it cannot be under 0
        private byte song = 0;        

        //which key was pressed
        private ConsoleKeyInfo keyInfo;





        //methods
        //>>>>>>>+



        

        //create the lyrics for the song
        public void Lyrics(params string[] verse)
        {
            

            //add song verse
            songs[newSongI] = verse;

            //increase index
            ++newSongI;
        }

        //navigate trough verses & songs & display lyrics
        public void DisplayLyrics()
        {
            Console.WriteLine(instructions);
            Console.WriteLine(songs[song][progress]);
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
        }



    }
}
