using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Task
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer graphicsTimer;
        LoopProject loopProject; 
        public Form1()
        {
            InitializeComponent();
            Paint += Form1_Paint;
            this.DoubleBuffered = true;
            graphicsTimer = new System.Windows.Forms.Timer();
            graphicsTimer.Interval = 1000 / 120;
            graphicsTimer.Tick += GraphicsTimer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rectangle resolution = Screen.PrimaryScreen.Bounds;

            Project myGame = new Project();
            myGame.Resolution = new Size(resolution.Width, resolution.Height);

            loopProject = new LoopProject();
            loopProject.Load(myGame);
            loopProject.Start();

            graphicsTimer.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            loopProject.Draw(e.Graphics);
        }

        private void GraphicsTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
