using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyGhost_v1
{
    public partial class GameControl : UserControl
    {
        
        int OffsetX = 0;

        int Pos = 0;
        int MovimentoMassimo = 1;


        Point Ghost = new Point(0,0);
        


        public GameControl()
        {
            InitializeComponent();
            timer1.Enabled = true;
            pictureBox1.Location = new Point(-200, -200);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);

        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //base.OnPaintBackground(e);
            
            e.Graphics.DrawImage(this.BackgroundImage, OffsetX, 0);
            e.Graphics.DrawImage(this.BackgroundImage, OffsetX+ this.BackgroundImage.Width, 0);
            e.Graphics.DrawImage(this.BackgroundImage, OffsetX + (this.BackgroundImage.Width*2), 0);

            if (Ghost.Y> Pos)
            {
                if(Ghost.Y- MovimentoMassimo > Pos)
                    Ghost = new Point(Ghost.X, Ghost.Y- MovimentoMassimo);
                else
                    Ghost = new Point(Ghost.X, Pos);
            }
            else if (Ghost.Y < Pos)
            {
                if (Ghost.Y + MovimentoMassimo < Pos)
                    Ghost = new Point(Ghost.X, Ghost.Y + MovimentoMassimo);
                else
                    Ghost = new Point(Ghost.X, Pos);
            }

            e.Graphics.DrawImage(pictureBox1.Image, Ghost);

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            OffsetX -= 10;
            if (OffsetX < -this.BackgroundImage.Width)
            {
                OffsetX += this.BackgroundImage.Width;
            }
            Invalidate();
        }
    }
}
