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
            System.Drawing.Image image = System.Drawing.Image.FromFile("..\\..\\..\\Transparent_DartBoard.jpg");
            float dx = DisplayPictureBox.Width / 500;
            float dy = DisplayPictureBox.Height / 500;
            float sx = DisplayPictureBox.Width /  700f;
            float sy = DisplayPictureBox.Height / 700f;
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
            Pen thePen = new Pen(Color.Red, 2);
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

        void DrawNumber(int x, int y,string s) 
        {
            Graphics g = DisplayPictureBox.CreateGraphics();
            Font drawFont = new Font("Times New Roman", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            float dx = DisplayPictureBox.Width / 500;
            float dy = DisplayPictureBox.Height / 500;
            float sx = DisplayPictureBox.Width / 330f;
            float sy = DisplayPictureBox.Height / 330f;
            g.TranslateTransform(dx, dy);
            g.ScaleTransform(sx,sy);
            Point Num = new Point();
            Num .X = x-1;
            Num .Y = y-1;
            g.DrawString(s,drawFont,drawBrush,Num);
            g.Dispose();
            drawBrush.Dispose();
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
            FillComboBox();
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
            string[,] DartData = new string[count,7];
            string[] temp;
            int RoundNumber = 0;

            using (StreamReader currentFile = new StreamReader(path))
            {
                
                    while (!currentFile.EndOfStream)
                    {
                        temp = currentFile.ReadLine().Split();
                        DartData[RoundNumber,0] = temp[0];
                        DartData[RoundNumber,1] = temp[1];
                        DartData[RoundNumber,2] = temp[2];
                        DartData[RoundNumber,3] = temp[3];
                        DartData[RoundNumber,4] = temp[4];
                        DartData[RoundNumber,5] = temp[5];
                        DartData[RoundNumber,6] = temp[6];
                        RoundNumber++;
                    }
                
            }
            DartArray = DartData;
            return DartData;
        }

        private void FillComboBox() 
        { 
            DisplayComboBox.Items.Clear();
            ReadFileIntoArray(DataFile);
                for (int i = 1; i<DartArray.GetLength(0);i++) 
                {
                    DisplayComboBox.Items.Add(DartArray[i,0]);
                }
        }

        private void ComboBoxChange() 
        { 
            int CBIndex = (int)DisplayComboBox.SelectedIndex + 1;
            int x1 = int.Parse(DartArray[CBIndex, 1]);
            int y1 = int.Parse(DartArray[CBIndex, 2]);
            int x2 = int.Parse(DartArray[CBIndex, 3]);
            int y2 = int.Parse(DartArray[CBIndex, 4]);
            int x3 = int.Parse(DartArray[CBIndex, 5]);
            int y3 = int.Parse(DartArray[CBIndex, 6]);

            RoundTextBox.Text = DartArray[CBIndex,0].ToString();
            Dart1TextBox.Text = $"{DartArray[CBIndex, 1].ToString()}, {DartArray[CBIndex, 2].ToString()}";
            Dart2TextBox.Text = $"{DartArray[CBIndex, 3].ToString()}, {DartArray[CBIndex, 4].ToString()}";
            Dart3TextBox.Text = $"{DartArray[CBIndex, 5].ToString()}, {DartArray[CBIndex, 6].ToString()}";
            DrawBoard();
            DrawDart(x1,y1);
            DrawNumber(x1,y1,"1");
            DrawDart(x2,y2);
            DrawNumber(x2,y2,"2");
            DrawDart(x3,y3);
            DrawNumber(x3,y3,"3");
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

        private void DisplayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxChange();
        }
    }
}
