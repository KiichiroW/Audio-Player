using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioPlayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string[] songFiles, songTitles;

        private void listBoxSongDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            windowsMediaPlayer.URL = songFiles[listBoxSongDisplay.SelectedIndex];

        }

        private void buttonAddSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                songFiles = ofd.FileNames;
                songTitles = ofd.SafeFileNames;

                foreach (string title in songTitles)
                {
                    listBoxSongDisplay.Items.Add(title);
                }
            }
        }
    }
}
