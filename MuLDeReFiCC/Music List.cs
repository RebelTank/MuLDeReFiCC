using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//get directory to search
//search directory for music files
//place each music file found in the database

//Is folder a valid directory?
//Read all files and folders under folder and place full directory, file name, and extension into db
//if file extension is mp3, ogg, mp4, etc...
//fill out file info including hash and last pulled?

namespace MuLDeReFiCC
{
    public partial class Music_List : Form
    {
        public Music_List()
        {
            InitializeComponent();
            //this.label1.Text = "here we are\nstuff";

            //Read in a folder and show it in label1.Text
            ExploreFolder(@"C:\Users\Steven\Music\Apocalyptica");
        }

        public Music_List(string folder)
        {
            InitializeComponent();

            ExploreFolder(folder);
        }

        private void ExploreFolder(string folder)
        {
            //Open folder
            foreach (string file in Directory.EnumerateFiles(folder))
            {
                //length + 1 to remove opening '\'
                string filename = file.Substring(folder.Length + 1);

                //get enumerable list of extensions from db and compare against all of them
                if ((filename.Split('.').Length > 1) &&
                    filename.ToLower().EndsWith(".mp3", StringComparison.Ordinal))
                    //parse on . and see if file is music type
                    label1.Text += filename + "\n";
            }
        }
    }
}
