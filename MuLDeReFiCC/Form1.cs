using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuLDeReFiCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Music_List ml = new Music_List();
            ml.Show();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            string folder = string.Empty;
            Music_List ml;

            //To make it expand the music folder, roll your own browser class.
            FolderBrowserDialog folderBD = new FolderBrowserDialog();
            folderBD.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            DialogResult dr = new DialogResult();
            dr = folderBD.ShowDialog();

            if (dr == DialogResult.OK)
                folder = folderBD.SelectedPath;

            if (!string.IsNullOrEmpty(folder))
            {
                ml = new Music_List(folder);
                ml.ShowDialog();
            }
        }
    }
}
