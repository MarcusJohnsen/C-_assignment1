using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_part1
{
    class Album
    {
        //defining all the variables used for the object
        private string albumName;
        private string artistName;
        private int numOfTracks;

        public void start()
        {
            Console.WriteLine("Starting the Album Program!");
            Console.WriteLine();

            readingAlbumData();
            writingAlbumData();
        }

        private void readingAlbumData()
        {
            nameAlbum();
            nameArtist();
            trackNumbers();
        }

        private void writingAlbumData()
        {
            //making it look as wanted in the assignment
            Console.WriteLine();
            Console.WriteLine("Album Name: " + albumName);
            Console.WriteLine("Artist/Band: " + artistName);
            Console.WriteLine("Number of Tracks: " + numOfTracks);
            Console.WriteLine("Enjoy listening!");
        }


        private void nameAlbum()
        {
            Console.WriteLine("What is the name of your favorite music album?");
            albumName = Console.ReadLine();
        }

        private void nameArtist()
        {
            Console.WriteLine("What is the name of the artist or band for " + albumName + "?");
            artistName = Console.ReadLine();
        }

        private void trackNumbers()
        {
            Console.WriteLine("How many tracks does " + albumName + " have?");
            string numResult = Console.ReadLine();
            //parsing the input result to an int to fit the variable datatype
            numOfTracks = int.Parse(numResult);
        }

    }
}
