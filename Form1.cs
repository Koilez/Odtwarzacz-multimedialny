using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media;
using VisioForge.MediaFramework.ONVIF;

namespace LAB10
{
    public partial class Form1 : Form
    {
        MediaPlayer player = new MediaPlayer();
        string s;
        string index;
        List<object> values = new List<object>();

        public Form1()
        {
            InitializeComponent();
            player.Volume = 0.5;
        }
        public void InsertSong(string index)
        {
            textBoxSong.Text = "";
            player.Open(new Uri(@"F:\Visual Studio\OP\LAB10\Song\Music\"+index+".MP3"));
            labelName.Text = index;
            writeTextKaraoke(index);
        }
        private void firstSongToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //открытие песни феличита
            InsertSong("Feliz Navidad");
            
        }

        private void cichaNocŚwiętaNocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //вторая песня
            InsertSong("Cicha noc święta noc");
            
        }

        private void bogSieRodziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //третья песня
            InsertSong("Bóg sie rodzi");
            
            
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            player.Play();
            timer1.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            player.Stop();
            timer1.Stop();
            labelTimeSong.Text = "0 Sec";
            textBoxSong.Text = "";
            progressBar1.Value = 0;
        }

        private void buttonForword_Click(object sender, EventArgs e)
        {
            //перемотка вперед
            TimeSpan currentPosition = player.Position;
            player.Stop();
            timer1.Stop();
            player.Position = currentPosition + TimeSpan.FromSeconds(5);
            player.Play();
            timer1.Start();
        }

        private void buttonRewind_Click(object sender, EventArgs e)
        {
            //перемотка назад
            TimeSpan currentPosition = player.Position;
            player.Stop();
            timer1.Stop();
            if (currentPosition > TimeSpan.FromSeconds(5))
            {
                player.Position = currentPosition - TimeSpan.FromSeconds(5);
                player.Play();
                timer1.Start();
            }
            else
            {
                player.Play();
                timer1.Start();
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {

            player.Pause();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                //считем сколько прошло времени от начала песни
                TimeSpan currentPosition = player.Position;
                int seconds = (int)currentPosition.TotalSeconds;
                labelTimeSong.Text = seconds.ToString()+" Sec";

                for(int i = 0; i < values.Count; i+=2)
                {

                    if (Convert.ToInt32(values[i]) == seconds)
                    {
                        textBoxSong.Text = values[i + 1].ToString();
                        break;
                    }
                    
                }
            }
            catch { }

        }

        private void timerProgresBar_Tick(object sender, EventArgs e)
        {
            try
            {
                //прогрес бар что бы знали где песня
                progressBar1.Value = (int)(player.Position.TotalMilliseconds / player.NaturalDuration.TimeSpan.TotalMilliseconds * 100);
            }
            catch {}
        }


        private void writeTextKaraoke(string index)
        { 
            //запись текста в массив 
            try
            {
                values.Clear();
                using (StreamReader sr = new StreamReader(@"F:\Visual Studio\OP\LAB10\Song\Text\" + index + ".txt"))
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        values.Add(double.Parse(s.Substring(0, 3)));
                        values.Add(s.Substring(3));
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error! Text written incorrectly.");
            }
        }

        private void selectSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //можем считывать аудиофайлы от куда хочешь
            OpenFileDialog openFileDialogSong = new OpenFileDialog();
            openFileDialogSong.Filter = "Audio files|*.mp3;*.wav;*.wma";
            openFileDialogSong.Title = "Select a track";
            if (openFileDialogSong.ShowDialog() == DialogResult.OK)
            {
                player.Open(new Uri(openFileDialogSong.FileName));
                string nameSong = Path.GetFileName(openFileDialogSong.FileName);
                labelName.Text = nameSong.Remove(nameSong.Length - 4);
            }
        }

        private void selectTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //можем считывать текст от куда хочешь
            OpenFileDialog openFileDialogText = new OpenFileDialog();
            openFileDialogText.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialogText.Title = "Select a text";
            if (openFileDialogText.ShowDialog() == DialogResult.OK)
            {
                index = Path.GetFileName(openFileDialogText.FileName);
                index = index.Remove(index.Length - 4);
                writeTextKaraoke(index);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.Volume = (double)trackBarVolume.Value / 100;
            labelVolume.Text = trackBarVolume.Value.ToString() + "%";
        }

        private void clearTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            values.Clear();
            textBoxSong.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
