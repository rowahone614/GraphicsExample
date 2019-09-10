using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Blue, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            g.DrawRectangle(drawPen, 100, 200, 400, 200);
            g.FillRectangle(drawBrush, 100, 200, 400, 200);

            //Yellow Ellipse

            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            g.FillEllipse(yellowBrush, 100, 200, 400, 200);

            //Blue 'IKEA' Text

            Font drawFont = new Font("Times New Roman", 100, FontStyle.Bold);
            g.DrawString("IKEA", drawFont, drawBrush, 110, 223);

            //Rotated String

            Font drawName = new Font("Times New Roman", 20, FontStyle.Bold);
            g.TranslateTransform(200, 125);
            g.RotateTransform(300);
            g.DrawString("R", drawName, drawBrush, new Rectangle());
            g.ResetTransform();

            g.TranslateTransform(230, 90);
            g.RotateTransform(330);
            g.DrawString("O", drawName, drawBrush, new Rectangle());
            g.ResetTransform();

            g.TranslateTransform(260, 55);
            g.RotateTransform(360);
            g.DrawString("W", drawName, drawBrush, new Rectangle());
            g.ResetTransform();

            g.TranslateTransform(295, 75);
            g.RotateTransform(30);
            g.DrawString("A", drawName, drawBrush, new Rectangle());
            g.ResetTransform();

            g.TranslateTransform(325, 104);
            g.RotateTransform(60);
            g.DrawString("N", drawName, drawBrush, new Rectangle());
            g.ResetTransform();

        }
    }
}
