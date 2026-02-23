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
        Random DartX = new Random();
        Random DartY = new Random();

        public DartGame()
        {
            
            InitializeComponent();
            SetDefaults();
            DrawBoard();
        }
        //Program Logic--------------------------------------------------------------------------------------------------------------------------

        void SetDefaults() 
        { 
            ReviewRadioButton.Checked = true;
            PlayRadioButton.Checked = false;
            DrawBoard();
        }
        void DrawBoard() 
        {
            Graphics g = DisplayPictureBox.CreateGraphics();
            Pen thePen = new Pen(Color.Black);
            System.Drawing.Image image = System.Drawing.Image.FromFile("..\\..\\..\\DartBoard.jpg");

            g.DrawImage(image, 0, 0); 

            g.Dispose();
            thePen.Dispose();
        }
        void DrawDart(int x, int y)
        {
            Graphics g = DisplayPictureBox.CreateGraphics();
            Pen thePen = new Pen(Color.Blue, 1);
            int size = 25;

            g.DrawEllipse(thePen, x - size / 2, y - size / 2, size, size);
            g.DrawLine(thePen, x - 3, y, x + 3, y);
            g.DrawLine(thePen, x, y - 3, x, y + 3);
            g.Dispose();
            thePen.Dispose();
        }

        void Play() 
        {
            DartCount = DartCount + 1;
            if (DartCount == 4)
            {
                Displaylabel.Text = "Press Space to Start again";
                DartCount = 0;
            }
            else
            {
                int x = DartX.Next(1,579);
                int y = DartY.Next(1,579);

                DrawDart(x,y);
            }
        }

        void Review() 
        { 
        
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
                SetDefaults();
                Review();
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
