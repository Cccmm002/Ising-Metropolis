using System;
using System.Collections.Generic;

namespace IsingMetropolis
{
    class Swendsen_Wang
    {
        struct Point
        {
            public int i, j;

            public Point(int x, int y)
            { i = x; j = y; }
        }

        public static int[,] Update(int[,] state, int width, int height, double J, double beta, Random rd)
        {
            double p = 1 - Math.Exp(0 - 2 * beta * J);

            //bonds[w, h, 0]:=bond with right spin; bonds[w, h, 1]:=bond with down spin.
            bool[,,] bonds = new bool[width, height, 2];

            for (int i = 0; i < width-1; i++)
                for (int j = 0; j < height-1; j++)
                {
                    bonds[i, j, 0] = false;
                    if (state[i, j] == state[i + 1, j])
                        if (rd.Next(100) < (p * 100))
                            bonds[i, j, 0] = true;

                    bonds[i, j, 1] = false;
                    if (state[i, j] == state[i, j + 1])
                        if (rd.Next(100) < (p * 100))
                            bonds[i, j, 1] = true;
                }

            //Flood-fill to get all clusters
            int[,] belonging = new int[width, height];
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    belonging[i, j] = -1;

            Dictionary<int, bool> clusters = new Dictionary<int, bool>();

            for (int index = 0; index < width * height; index++)
            {
                int i = index % width;
                int j = index / width;
                if (belonging[i, j] >= 0) continue;

                int curCluster = clusters.Count;
                Queue<Point> q = new Queue<Point>();
                q.Enqueue(new Point(i, j));
                belonging[i, j] = curCluster;
                clusters.Add(curCluster, rd.Next(100) < 50);

                while (q.Count != 0)
                {
                    Point cur = q.Dequeue();
                    if (cur.i != width - 1 && bonds[cur.i, cur.j, 0])
                    {
                        if (belonging[cur.i + 1, cur.j] < 0)
                        {
                            belonging[cur.i + 1, cur.j] = curCluster;
                            q.Enqueue(new Point(cur.i + 1, cur.j));
                        }
                    }
                    if (cur.j != height - 1 && bonds[cur.i, cur.j, 1])
                    {
                        if (belonging[cur.i, cur.j + 1] < 0)
                        {
                            belonging[cur.i, cur.j + 1] = curCluster;
                            q.Enqueue(new Point(cur.i, cur.j + 1));
                        }
                    }
                    if (cur.i != 0)
                    {
                        if (bonds[cur.i - 1, cur.j, 0] && belonging[cur.i - 1, cur.j] < 0)
                        {
                            belonging[cur.i - 1, cur.j] = curCluster;
                            q.Enqueue(new Point(cur.i - 1, cur.j));
                        }
                    }
                    if (cur.j != 0)
                    {
                        if (bonds[cur.i, cur.j - 1, 0] && belonging[cur.i, cur.j - 1] < 0)
                        {
                            belonging[cur.i, cur.j - 1] = curCluster;
                            q.Enqueue(new Point(cur.i, cur.j - 1));
                        }
                    }
                }
            }

            int[,] res = new int[width, height];
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    res[i, j] = clusters[belonging[i, j]] ? 1 : -1;

            return res;
        }
    }
}