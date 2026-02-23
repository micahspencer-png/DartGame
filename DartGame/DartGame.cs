using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DartGame
{
    //Micah Spencer
    //RCET 3371
    //Spring 2026
    //Dart Game Program
    //
    public partial class DartGame : Form
    {
        int DartCount = 0;
        string DataFile = "..\\..\\..\\DartLocations.Txt";
        int roundCount = 1;
        string DartLocation = "";
        static string[,] DartArray;
        Random Dart = new Random();
        
        

        public DartGame()
        {
            int DartRound = 1;
            InitializeComponent();
            ReadFromFile(DataFile);
            ReadFileCount(DataFile,ref DartRound);
            roundCount = DartRound;
            DartLocation = $"Round{DartRound}";
            SetDefaults();
        }
        //Program Logic--------------------------------------------------------------------------------------------------------------------------

        void SetDefaults() 
        { 
            ReviewRadioButton.Checked = true;
            PlayRadioButton.Checked = false;
            DisplayComboBox.Enabled = false;
            PlayRadioButton.Focus();
            DrawBoard();
        }
        void DrawBoard() 
        {
            Graphics g = DisplayPictureBox.CreateGraphics();
            Pen thePen = new Pen(Color.Black);
            System.Drawing.Image image = System.Drawing.Image.FromFile("..\\..\\..\\DartBoard.jpg");
            float dx = DisplayPictureBox.Width / 500;
            float dy = DisplayPictureBox.Height / 500;
            float sx = DisplayPictureBox.Width /  330f;
            float sy = DisplayPictureBox.Height / 330f;
            g.Clear(Color.White);
            g.TranslateTransform(dx, dy);
            g.ScaleTransform(sx, sy);

            g.DrawImage(image, 0, 0); 
            g.Dispose();
            thePen.Dispose();
            
        }
        void DrawDart(int x, int y)
        {
            Graphics g = DisplayPictureBox.CreateGraphics();
            Pen thePen = new Pen(Color.Red, 1);
            int size = 25;
            float dx = DisplayPictureBox.Width / 500;
            float dy = DisplayPictureBox.Height / 500;
            float sx = DisplayPictureBox.Width / 330f;
            float sy = DisplayPictureBox.Height / 330f;
            g.TranslateTransform(dx, dy);
            g.ScaleTransform(sx, sy);
            g.DrawEllipse(thePen, x - size / 2, y - size / 2, size, size);
            g.DrawLine(thePen, x - 3, y, x + 3, y);
            g.DrawLine(thePen, x, y - 3, x, y + 3);
            g.Dispose();
            thePen.Dispose();
        }

        void Play() 
        {
            
            DisplayComboBox.Enabled = false;
            
            DartCount++;
            if (DartCount == 3)
            {
                Displaylabel.Text = "Press Space to Start again";
                DartCount++;

                int x = Dart.Next(1, 330);
                int y = Dart.Next(1, 330);
                DartLocation += $" {x} {y}";
                DrawDart(x, y);
            }
            else if (DartCount > 4) 
            {
                DartCount = 0;
                Displaylabel.Text = "Press Space to Launch Darts";
                DrawBoard();
                AppendToFile(DataFile,DartLocation);
                roundCount++;
                DartLocation = $"Round{roundCount}";
            }
            else
            {
                int x = Dart.Next(1, 330);
                int y = Dart.Next(1, 330);
                DartLocation += $" {x} {y}";
                DrawDart(x,y);
            }

        }

        void Review() 
        {
            groupBox2.Show();
            Displaylabel.Text = "";
            DartCount = 0;
            DisplayComboBox.Enabled = true;
            DrawBoard();
            ReadFileIntoArray(DataFile);
        }
        static void ReadFromFile(string path)
        {
            try
            {
                using (StreamReader currentFile = new StreamReader(path))
                {
                    currentFile.ReadLine();

                }
            }
            catch 
            {
                using (StreamWriter currentFile = File.CreateText(path))
                {
                    currentFile.WriteLine("Countx x1 y1 x2 y2 x3 y3");
                }
            }
        }
        static int ReadFileCount(string path,ref int count)
        {
            
            using (StreamReader currentFile = new StreamReader(path))
            {
                while (!currentFile.EndOfStream)
                {
                    currentFile.ReadLine();
                    count++;
                }
            }
            count--;
            return count;
        }
        static void AppendToFile(string path, string DartLocation)
        {
            using (StreamWriter currentFile = File.AppendText(path))
            {
                currentFile.WriteLine(DartLocation);
            }
        }
        static int RecordCount(string path,ref int count)
        {
            
            using (StreamReader currentFile = new StreamReader(path))
            {
                while (!currentFile.EndOfStream)
                {
                    currentFile.ReadLine();
                    count++;
                }
            }
            
            return count;
        }

        private static string[,] ReadFileIntoArray(string path)
        {
            int count = 0;
            RecordCount(path, ref count);
            string[,] DartData = new string[6,count];
            string[] temp;
            int RoundNumber = 0;

            using (StreamReader currentFile = new StreamReader(path))
            {
                try
                {
                    while (!currentFile.EndOfStream)
                    {
                        temp = currentFile.ReadLine().Split();
                        DartData[0, RoundNumber] = temp[0];
                        DartData[1, RoundNumber] = temp[1];
                        DartData[2, RoundNumber] = temp[2];
                        DartData[3, RoundNumber] = temp[3];
                        DartData[4, RoundNumber] = temp[4];
                        DartData[5, RoundNumber] = temp[5];
                        DartData[6, RoundNumber] = temp[6];
                        RoundNumber++;
                    }
                }
                catch 
                { 
                }
            }
            DartData = DartArray;
            return DartData;
        }
        //Event Handlers----------------------------------------------------------------------------------------------------------------------------
        private void DartGame_Load(object sender, EventArgs e)
        {
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReviewRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ReviewRadioButton.Checked == true) 
            {
                Review();
            }
            else 
            {
                groupBox2.Hide();
                Displaylabel.Text = "Press Space to Launch Darts";
                DrawBoard();
            }
        }

        private void DartGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') 
            {
                Play();
            }
        }
    }
}
