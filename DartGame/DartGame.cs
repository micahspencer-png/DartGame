using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        string DataFile = "..\\..\\..\\Dart.Txt";
        string DartData = "";
        string[,] DartArray;
        Random Dart = new Random();
        int GameCount = 0;
        

        public DartGame()
        {
            
            InitializeComponent();
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

                int x = Dart.Next(1, 100);
                int y = Dart.Next(1, 100);

                DrawDart(x, y);
            }
            else if (DartCount > 4) 
            {
                DartCount = 0;
                Displaylabel.Text = "Press Space to Launch Darts";
                DrawBoard();
            }
            else
            {
                
                int x = Dart.Next(1,100);
                int y = Dart.Next(1,100);

                DrawDart(x,y);
            }

        }

        void Review() 
        {
            DartCount = 0;
            DisplayComboBox.Enabled = true;
            DrawBoard();
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
