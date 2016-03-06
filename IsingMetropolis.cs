using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace IsingMetropolis
{
    public partial class IsingMetropolis : Form
    {
        System.Windows.Forms.Timer timer;

        int[,] currentState;
        int modelWidth, modelHeight;
        Random random;
        Color colorUp, colorDown;
        int CalcPerSec;

        public IsingMetropolis()
        {
            InitializeComponent();
        }

        double Hamiltonian(int[,] state, int width, int height, int i, int j, double J, double h)
        {
            Point left = new Point(); left.Y = j;
            if (i == 0) left.X = 1; else left.X = i - 1;
            Point right = new Point(); right.Y = j;
            if (i == width - 1) right.X = width - 2; else right.X = i + 1;
            Point up = new Point(); up.X = i;
            if (j == 0) up.Y = 1; else up.Y = j - 1;
            Point down = new Point(); down.X = i;
            if (j == height - 1) down.Y = height - 2; else down.Y = j + 1;

            return (0 - J * (state[i, j] * state[left.X, left.Y] + state[i, j] * state[right.X, right.Y] + state[i, j] * state[up.X, up.Y] + state[i, j] * state[down.X, down.Y]) - h * state[i, j]);
        }

        int[,] Metropolis(int[,] init, int width, int height, double J, double beta, double h, Random rd)
        {
            int x = rd.Next(width);
            int y = rd.Next(height);
            double preH = Hamiltonian(init, width, height, x, y, J, h);

            int[,] flip = (int[,])init.Clone();
            flip[x, y] = -1 * init[x, y];
            double postH = Hamiltonian(flip, width, height, x, y, J, h);

            double p = 1;
            if (postH - preH > 0)
                p = Math.Exp(-beta * (postH - preH));
            if (rd.Next(100) > (p * 100))
                flip[x, y] = init[x, y];

            return flip;
        }

        private void cmdInit_Click(object sender, EventArgs e)
        {
            modelHeight = Convert.ToInt32(numHeight.Text);
            modelWidth = Convert.ToInt32(numWidth.Text);
            random = new Random();

            //Create the initial state
            currentState = new int[modelWidth, modelHeight];
            for (int i = 0; i < modelWidth; i++)
                for (int j = 0; j < modelHeight; j++)
                {
                    if (random.Next(1000) < (int)(numUpPos.Value*10))
                        currentState[i, j] = 1;
                    else
                        currentState[i, j] = -1;
                }

            picDraw.Image = Drawing(currentState, modelWidth, modelHeight);
            int mille = BlackMille(currentState, modelWidth, modelHeight);
            ShowPercentage(mille);

            cmdStart.Enabled = true;
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Start();
            cmdStop.Enabled = true;
            cmdStart.Enabled = false;
            numInterval.Enabled = false;
            cmdInit.Enabled = false;
        }

        int BlackMille(int[,] state, int width, int height)
        {
            int sum = 0;
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    if (state[i, j] == 1)
                        sum++;
            return (int)(((float)sum / (width * height)) * 1000);
        }

        void ShowPercentage(int mille)
        {
            lblPercentage.Text = ((float)mille / 10).ToString() + "%";
            Bitmap bar = new Bitmap(picBar.Width, picBar.Height);
            Graphics g = Graphics.FromImage(bar);
            int boundary=(int)(((float)mille / 1000) * picBar.Width);
            g.FillRectangle(Brushes.Black, new Rectangle(0, 0, boundary, picBar.Height));
            g.FillRectangle(Brushes.White, new Rectangle(boundary, 0, picBar.Width - boundary, picBar.Height));
            picBar.Image = bar;
        }

        Bitmap Drawing(int[,] state, int width, int height)
        {
            Bitmap bm = new Bitmap(width, height);
            for(int i=0;i<width;i++)
                for(int j=0;j<height;j++)
                {
                    if (state[i, j] > 0)
                        bm.SetPixel(i, j, colorUp);
                    else
                        bm.SetPixel(i, j, colorDown);
                }

            Bitmap bmShow = new Bitmap(512, 512);
            for (int i = 0; i < 512; i++)
            {
                float wMag = 512 / ((float)modelWidth);
                int w = (int)(i / wMag);
                for (int j = 0; j < 512; j++)
                {
                    float hMag = 512 / ((float)modelHeight);
                    int h = (int)(j / hMag);
                    bmShow.SetPixel(i, j, bm.GetPixel(w, h));
                }
            }

            return bmShow;
        }

        void StepOn(Object sender, EventArgs e)
        {
            for (int i = 0; i < CalcPerSec; i++)
            {
                switch (comboAlgorithm.SelectedIndex)
                {
                    case 0:
                        currentState = Metropolis(currentState, modelWidth, modelHeight, (double)numJ.Value, (1 / ((double)numT.Value)), (double)numM.Value, random);
                        break;
                    case 1:
                        currentState = Wolff.Update(currentState, modelWidth, modelHeight, (double)numJ.Value, (1 / ((double)numT.Value)), random);
                        break;
                    case 2:
                        currentState = Swendsen_Wang.Update(currentState, modelWidth, modelHeight, (double)numJ.Value, (1 / ((double)numT.Value)), random);
                        break;
                }
            }
            picDraw.Image = Drawing(currentState, modelWidth, modelHeight);
            int mille = BlackMille(currentState, modelWidth, modelHeight);
            ShowPercentage(mille);
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Enabled = false;
            cmdStop.Enabled = false;
            cmdStart.Enabled = true;
            numInterval.Enabled = true;
            cmdInit.Enabled = true;
        }

        private void numInterval_ValueChanged(object sender, EventArgs e)
        {
            CalcPerSec = ((int)numInterval.Value) / 100;
        }

        private void IsingMetropolis_Load(object sender, EventArgs e)
        {
            colorUp = Color.Black;
            colorDown = Color.White;

            timer = new Timer();
            timer.Interval = 100;
            CalcPerSec = ((int)numInterval.Value) / 100;
            timer.Enabled = false;
            timer.Tick += new EventHandler(StepOn);

            comboAlgorithm.SelectedIndex = 0;
        }
    }
}
