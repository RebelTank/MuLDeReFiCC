using System;
using System.IO;

namespace MuLDeReFiCC
{
    class PopDB
    {
        public PopDB()
        {
            /*
            Tables to create:
            Album
            Artist
            Genre
            FileType
            TimeSignature
            Mood
            InitialKey
            */

            //get directory to search
            //search directory for music files
            //place each music file found in the database

            string folder = "";

            Console.WriteLine("Folder to search");
            folder = Console.ReadLine(); //test directory: ...

            //Is folder a valid directory?
            //Read all files and folders under folder and place full directory, file name, and extension into db
                //if file extension is mp3, ogg, mp4, etc...
                //fill out file info including hash and last pulled?

            Console.ReadKey(); //pause the console. remove if not debugging
        }
    }
}
