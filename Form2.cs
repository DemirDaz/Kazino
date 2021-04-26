using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Form2()
        {

            InitializeComponent();
            
            g = CreateGraphics();
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
            if(prvi == 0) { 
            score.Visible = true;
            wait(2000);
            score.Visible = false;
            prvi++;
            }
            spin();
            wait(1700);
            isWin();
            wait(5000);
            score.Visible = false;
            //ROLL
        }

        public void isWin() {
            score.Image = Properties.Resources.gold;
            
            score.Visible = true;
            spin1.Visible = false;
            spin2.Visible = false;
            spin3.Visible = false;
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
