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
                //length + 1 to remove opening \
                label1.Text += file.Substring(folder.Length + 1) + "\n";
            }
        }
    }
}
