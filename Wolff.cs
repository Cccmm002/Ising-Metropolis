using System;
using System.Collections.Generic;
using System.Text;

namespace IsingMetropolis
{
    class Wolff
    {
        //public static bool WolffStarted = false;

        struct Point
        {
            public int i, j;

            public Point (int x, int y)
            { i = x; j = y; }
        }

        static bool considerBond(double J, double beta, Random rd)
        {
            //Bond bond = new Bond(a, b);
            //if (bonds.Contains(bond)) return false;  //This bond has been considered.

            //bonds.Add(bond);   //Now consider this bond.
            double p = 1 - Math.Exp(0 - 2 * beta * J);
            return (rd.Next(1000) <= (int)(p * 1000));
        }

        public static int[,] Update(int[,] state, int width, int height, double J, double beta, Random rd)
        {
            List<Point> flip = new List<Point>();
            Queue<Point> queue = new Queue<Point>();

            //bonds[w, h, 0]:=bond with right spin; bonds[w, h, 1]:=bond with down spin.
            bool[,,] bonds = new bool[width, height, 2];
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    for (int k = 0; k < 2; k++)
                        bonds[i, j, k] = false;

            Point start = new Point(rd.Next(width), rd.Next(height));
            flip.Add(start);
            queue.Enqueue(start);
            while (queue.Count != 0)
            {
                Point cur = queue.Dequeue();
                if (cur.i < width - 1)  //Boundary condition: the most right
                {
                    Point next = new Point(cur.i + 1, cur.j);
                    if(state[cur.i,cur.j]==state[next.i,next.j] && !bonds[cur.i,cur.j,0])
                        if (considerBond(J,beta,rd))
                        {
                            flip.Add(next);
                            queue.Enqueue(next);
                            bonds[cur.i, cur.j, 0] = true;
                        }
                }
                if (cur.j < height - 1)  //Boundary condition: the most down
                {
                    Point next = new Point(cur.i, cur.j + 1);
                    if (state[cur.i, cur.j] == state[next.i, next.j] && !bonds[cur.i, cur.j, 1])
                        if (considerBond(J, beta, rd))
                        {
                            flip.Add(next);
                            queue.Enqueue(next);
                            bonds[cur.i, cur.j, 1] = true;
                        }
                }
                if (cur.i > 0)  //Boundary condition: the most left
                {
                    Point next = new Point(cur.i - 1, cur.j);
                    if (state[cur.i, cur.j] == state[next.i, next.j] && !bonds[cur.i - 1, cur.j, 0])
                        if (considerBond(J, beta, rd))
                        {
                            flip.Add(next);
                            queue.Enqueue(next);
                            bonds[cur.i - 1, cur.j, 0] = true;
                        }
                }
                if (cur.j > 0)  //Boundary condition: the most upper
                {
                    Point next = new Point(cur.i, cur.j - 1);
                    if (state[cur.i, cur.j] == state[next.i, next.j] && !bonds[cur.i, cur.j - 1, 1])
                        if (considerBond(J, beta, rd))
                        {
                            flip.Add(next);
                            queue.Enqueue(next);
                            bonds[cur.i, cur.j - 1, 1] = true;
                        }
                }
            }
            int[,] res = (int[,])state.Clone();
            foreach (Point fp in flip)
                res[fp.i, fp.j] = 0 - state[fp.i, fp.j];
            return res;
        }
    }
}
