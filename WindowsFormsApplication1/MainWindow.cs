using System;
using TagLib;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MusicFormatFixer
{
    public partial class MusicFormatFixer : Form
    {
        public MusicFormatFixer()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
            InitializeComponent();
            RB_Style1.Checked = true;
            L_Percent.Text = String.Concat(0, "%");
        }

        private void B_PickFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderPicker = new FolderBrowserDialog();
            if (FolderPicker.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TB_FolderPath.Text = FolderPicker.SelectedPath;
            }
        }

        private void B_Start_Click(object sender, EventArgs e)
        {
            L_Percent.Text = String.Concat(0, "%");
            PB_PercentDone.Value = 0;

            if (Directory.Exists(TB_FolderPath.Text))
            {
                List<string> FileTypes = new List<string>()
                {
                    ".AAC",
                    ".MP3",
                    ".OGG",
                    ".WMA",
                    ".ALAC",
                    ".FLAC",
                    ".AIFF",
                    ".WAV",
                    ".APE",
                    ".M4A",
                };
                string[] fileEntries = Directory.GetFiles(TB_FolderPath.Text);

                PB_PercentDone.Maximum = fileEntries.Length;
                PB_PercentDone.Step = 1;

                foreach (string FilePath in fileEntries)
                {
                    if (FileTypes.Contains(Path.GetExtension(FilePath).ToUpperInvariant()))
                    {
                        string FileName = Path.GetFileNameWithoutExtension(FilePath);
                        string FileExtension = Path.GetExtension(FilePath);
                        String SongTitle = "";
                        String SongArtist = "";

                        for (int i = 0; i < FileName.Length - 1; i++)
                        { 
                            if (FileName[i].Equals('-') && FileName[i + 1].Equals(' '))
                            {
                                if (RB_Style1.Checked == true)
                                {
                                    SongTitle = FileName.Substring(i + 1);
                                    SongArtist = FileName.Substring(0, i - 1);
                                    break;
                                }
                                else
                                {
                                    SongTitle = String.Concat(FileName.Substring(0, i - 2), FileExtension);
                                    SongArtist = FileName.Substring(i + 1, FileName.Length - 1);
                                    break;
                                }
                            }
                        }

                        if (SongTitle.Equals("") == false)
                        {
                            string[] Artists = { SongArtist };
                            TagLib.File ThisSong = TagLib.File.Create(FilePath);
                            ThisSong.Tag.Title = SongTitle;
                            ThisSong.Tag.Performers = null;
                            ThisSong.Tag.Performers = Artists;
                            ThisSong.Save();
                            System.IO.File.Move(FilePath, String.Concat(FilePath.Substring(0, FilePath.Length - (Path.GetFileName(FilePath).Length)), String.Concat(SongTitle, FileExtension)));
                        }
                    }
                    PB_PercentDone.PerformStep();
                    double Current = Convert.ToDouble(PB_PercentDone.Value);
                    double Max = Convert.ToDouble(fileEntries.Length);
                    double PercentRaw = (Current / Max) * 100;
                    int Percentage = Convert.ToInt32(PercentRaw);
                    L_Percent.Text = String.Concat(Percentage, "%");
                    L_Percent.Refresh();
                }
            }
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
