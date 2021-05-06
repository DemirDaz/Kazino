using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kazino
{
   
    public partial class Form2 : Form
    {
        static int prvi = 0;
        Graphics g;
        Brush brush = new SolidBrush(Color.White);
        Font font = new Font("Times New Roman", 50);
        int p1, p2, p3;
        public Form2()
        {

            InitializeComponent();
            
            g = this.CreateGraphics();
            g.DrawString("Welcome", font, brush, new
              PointF(150, 150));

           // score.Image = Properties.Resources.gogo;
            score.Visible = false;
        
           
            ThreadStart childref = new ThreadStart(Welcome);
            
            Thread childThread = new Thread(childref);
            
            childThread.Start();
           

        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            
            

        }

        private void Welcome() {
            
            Thread.Sleep(2500);
            PocniAsync();
            
        }

        private void PocniAsync()
        {
            //System.Threading.Thread.Sleep(2000);
            
            this.BackgroundImage = Properties.Resources.casino3;
            //aparat();
            //Task.Delay(3000).Wait();





        }

        private void aparat() {
            
            Bitmap bitmap = new
            Bitmap(Properties.Resources.aparat);
            g.DrawImage(bitmap, 320, 20, 500, 500);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (prvi == 0) {
                score.Visible = true;
                wait(2000);
                score.Visible = false;
                prvi++;
            }
            spin();
            wait(1700);
            paintRand();
            wait(5000);
            if (p1==p2 && p1 == p3) { 
            isWin();
            wait(5000);
            score.Visible = false; }


            //ROLL
        }

        private void paintRand()
        {
            Graphics gr = CreateGraphics();
            // Image image = new Bitmap("HouseAndTree.gif");
            //TextureBrush tBrush = new TextureBrush(image);
            // tBrush.WrapMode = WrapMode.TileFlipX;
            Pen blackPen = new Pen(Color.Black);

           
            FontFamily fontFamily = new FontFamily("Arial");
            Font font = new Font(
            fontFamily,
            46, FontStyle.Bold,
            GraphicsUnit.Pixel);


            TextureBrush gold = new TextureBrush(Properties.Resources.gold1);
            Rectangle rect = new Rectangle(spin1.Location.X, spin1.Location.Y, 120,50);
            LinearGradientBrush green = new
            LinearGradientBrush(rect, Color.Orange, Color.DarkRed,
            LinearGradientMode.Vertical);
            SolidBrush solidBrush = new SolidBrush(Color.Gold);
            HatchBrush red = new HatchBrush(HatchStyle.ZigZag, Color.Chocolate,Color.Purple);
            
            //texture , hatch i gradient ..

            spin1.Visible = false;
            spin2.Visible = false;
            spin3.Visible = false;

            Random rnd = new Random();
            int broj = rnd.Next(1, 4);

            // string ,zvezda i obicna elipsa.

            //polje1
            if (broj == 1)
            {
                PointF[] pts = StarPoints(5, new Rectangle(spin1.Location.X, spin1.Location.Y, 50, 50));
                gr.FillPolygon(red, pts);
                p1 = broj;
            }
            else if (broj == 2)
            {
                gr.FillEllipse(green, new Rectangle(spin1.Location.X+5, spin1.Location.Y+5, 40, 40));
                p1 = broj;
            }
            else if (broj == 3) {
                gr.DrawString("7", font, gold, spin1.Location.X+5, spin1.Location.Y);
                p1 = broj;
            }

            //polje 2
            broj = rnd.Next(1, 4);

            if (broj == 1)
            {
                PointF[] pts = StarPoints(5, new Rectangle(spin2.Location.X, spin2.Location.Y, 50, 50));
                gr.FillPolygon(red, pts);
                //gr.FillRectangle(red, new Rectangle(spin2.Location.X, spin1.Location.Y, 30, 30));
                p2 = broj;
            }
            else if (broj == 2)
            {
                gr.FillEllipse(green, new Rectangle(spin2.Location.X+5, spin2.Location.Y+5, 40, 40));
                p2 = broj;
            }
            else if (broj == 3)
            {
                gr.DrawString("7", font, gold, spin2.Location.X+5, spin2.Location.Y);
                p2 = broj;
            }

            //polje 3
            broj = rnd.Next(1, 4);

            if (broj == 1)
            {
                PointF[] pts = StarPoints(5, new Rectangle(spin3.Location.X, spin3.Location.Y, 50, 50));
                gr.FillPolygon(red, pts);
                p3 = broj;
            }
            else if (broj == 2)
            {
                gr.FillEllipse(green, new Rectangle(spin3.Location.X+5, spin3.Location.Y+5, 40, 40));
                p3 = broj;
            }
            else if (broj == 3)
            {
                gr.DrawString("7", font, gold, spin3.Location.X+5, spin3.Location.Y);
                p3 = broj;
            }

           

            Point[] tacke = { new Point(),
                                new Point(),
                                new Point(),
                                new Point(),

            };
           // gr.FillClosedCurve(tBrush, new Rectangle(spin1.Location.X, spin1.Location.Y, 30, 30));

          
            
        }

        private PointF[] StarPoints(int num_points, Rectangle bounds)
        {
            // Make room for the points.
            PointF[] pts = new PointF[num_points];

            double rx = bounds.Width / 2;
            double ry = bounds.Height / 2;
            double cx = bounds.X + rx;
            double cy = bounds.Y + ry;

            // Start at the top.
            double theta = -Math.PI / 2;
            double dtheta = 4 * Math.PI / num_points;
            for (int i = 0; i < num_points; i++)
            {
                pts[i] = new PointF(
                    (float)(cx + rx * Math.Cos(theta)),
                    (float)(cy + ry * Math.Sin(theta)));
                theta += dtheta;
            }

            return pts;
        }

        public void isWin() {

            score.Image = Properties.Resources.gold;
            
            score.Visible = true;
            
        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void spin()
        {
            
            spin1.Image = Properties.Resources.spiner;
            
            spin1.Visible = true;

            spin2.Image = Properties.Resources.spiner;
            
            spin2.Visible = true;

            spin3.Image = Properties.Resources.spiner;
            
            spin3.Visible = true;

            

        }
    }
}
