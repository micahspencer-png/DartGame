using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartGame
{
    public partial class DartGame : Form
    {
        public DartGame()
        {
            InitializeComponent();
        }
        //Program Logic--------------------------------------------------------------------------------------------------------------------------

        void DrawBoard() 
        {
            Graphics g = DisplayPictureBox.CreateGraphics();
            Pen thePen = new Pen(Color.Black);
            System.Drawing.Image image = System.Drawing.Image.FromFile("C:\\Users\\Micas\\OneDrive\\Documents\\Git\\Images\\DartBoard.jpg");

            g.DrawImage(image, 0, 0);

            g.Dispose();
            thePen.Dispose();
        }

        //Event Handlers----------------------------------------------------------------------------------------------------------------------------
        private void DartGame_Load(object sender, EventArgs e)
        {
            DrawBoard();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
