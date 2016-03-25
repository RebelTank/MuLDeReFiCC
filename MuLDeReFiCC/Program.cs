/**
* Copyright Steven Curtis 2016
* MuLDeReFiCC: Music Library Deduplication, Reorganization, FIle Conversion, and Curation.
* An application to gather your music libraries all into one place and clean them up, removing duplicates,
* converting file types you never use, filling in metadata, and trying to place it all together in a way that makes sense.
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuLDeReFiCC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Form1());
            new PopDB();
            //Application.Run(new Music_List());

        }
    }
}
