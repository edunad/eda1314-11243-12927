using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Pepino_A_Star
{
    /// <summary>
    /// The Node Class
    /// </summary>
    public class Node
    {
        public double _cost;
        public double _heuristic;
        public double _total;

        public Vector2 _pos;

        public List<Node> _neightbors;

        public Node _parent;

        /// <summary>
        /// Node Constructor
        /// </summary>
        /// <param name="pos">Node Position</param>
        public Node(Vector2 pos)
        {
            this._neightbors = new List<Node>();
            this._pos = pos;
            this._cost = 0;
            this._heuristic = 0;
        }

        /// <summary>
        /// Calculates the Total f()
        /// </summary>
        public void CalcTotal()
        {
            _total = _cost + _heuristic;
        }

    }

    /// <summary>
    /// @author Eduardo Fernandes nº12927
    /// @author Damien Fialho nº11243
    /// 
    /// @date 06/06/1024
    /// @code https://code.google.com/p/eda1314-11243-12927/
    /// 
    /// The Pathfinder Class. Created by us. Inspired by http://theory.stanford.edu/~amitp/GameProgramming/
    /// </summary>
    /// 
    public static class AStarPathFinder
    {

        /// <summary>
        /// Calculates the Cost based on the color given
        /// </summary>
        /// <param name="color">The color, from 0 to 255</param>
        /// <returns></returns>
        public static double CalculateCost(byte color)
        {
           double STEPS = 220;
           return (double)(255 - STEPS) / color;
        }

        /// <summary>
        /// Checks if the position is outside the picture.
        /// </summary>
        /// <param name="_pos">The Position to check</param>
        /// <returns></returns>
        public static bool IsOutsidePicture(Vector2 _pos)
        {
            return (_pos.X - 1 < 0 || _pos.Y - 1 < 0 || _pos.Y + 1 > GlobalStuff.Height || _pos.X + 1 > GlobalStuff.Width);
        }

        /// <summary>
        /// Creates the Nod Neighbors
        /// </summary>
        /// <param name="_nod">The Node</param>
        /// <param name="_finalNode">The End Node</param>
        public static void CreateNeighbors(Node _nod, Node _finalNode)
        {
            _nod._neightbors.Clear();

            for (int X = -1; X < 2; X++)
                for (int Y = -1; Y < 2; Y++)
                {

                    if (GlobalStuff._heuristicMODE == 0)
                        if ((X == 0 && Y == 0) || (X == -1 && Y == -1) || (X == -1 && Y == 1) || (X == 1 && Y == 1) || (X == 1 && Y == -1)) continue; // Do not add center.

                    if (GlobalStuff._heuristicMODE == 1)
                        if (X == 0 && Y == 0) continue;

                    int XNew = _nod._pos.X + X;
                    int YNew = _nod._pos.Y + Y;

                    if (IsOutsidePicture(new Vector2(XNew, YNew))) continue;

                    Node _neigh = new Node(new Vector2(XNew, YNew));

                    if (GlobalStuff._heuristicMODE == 0)
                        _neigh._heuristic = ManhattenH(_neigh, _finalNode);
                    else
                        _neigh._heuristic = Euclidean(_neigh, _finalNode);

                    _neigh.CalcTotal();

                    _nod._neightbors.Add(_neigh);
                }

        }
        /// <summary>
        /// Finds the Path between the start node and the end node
        /// </summary>
        /// <param name="_start">Start Node</param>
        /// <param name="_end">End Node</param>
        /// <param name="Steps">Each Time Step</param>
        /// <returns>The Average</returns>
        public static double FindPath(Node _start, Node _end, int Steps)
        {

            Dictionary<int, Node> _openList = new Dictionary<int, Node>();
            Dictionary<int, Node> _closedList = new Dictionary<int, Node>();
            List<double> _nodeTimes = new List<double>();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();


            int Infc = 0;

            Node _current = _start;
            _openList[Get1DVector(_start._pos.X, _start._pos.Y)] = _start;

            while (true)
            {
                int X = _current._pos.X;
                int Y = _current._pos.Y;

                if (X == _end._pos.X && Y == _end._pos.Y )
                {
                    _end._parent = _current;
                    break;
                }

                _current = GetMinTotal(_openList);
                _openList.Remove(Get1DVector(_current._pos.X, _current._pos.Y));
                _closedList[Get1DVector(_current._pos.X, _current._pos.Y)] = _current;

                CreateNeighbors(_current, _end);

                foreach (Node neigh in _current._neightbors)
                {

                    int INDX = Get1DVector(neigh._pos.X, neigh._pos.Y);

                    if (_closedList.ContainsKey(INDX)) continue;

                    if (_openList.ContainsKey(INDX))
                    {
                        double NewCost = _current._cost + CalculateCost(GetPGMData(neigh._pos.X, neigh._pos.Y));

                        if (NewCost < _openList[INDX]._cost)
                        {

                            _openList[INDX]._parent = _current;
                            _openList[INDX]._cost = NewCost;
                            _openList[INDX].CalcTotal();

                        }
                    }
                    else
                    {

                        neigh._parent = _current;
                        neigh._cost = _current._cost + CalculateCost(GetPGMData(neigh._pos.X, neigh._pos.Y));
                        neigh.CalcTotal();

                        _openList[INDX] = neigh;
                    }

                }

                if ((Infc % Steps) + 1 == 1)
                {   
                    _nodeTimes.Add((double)stopwatch.ElapsedMilliseconds);
                }

                Infc++;
            }

            _nodeTimes.Add((double)stopwatch.ElapsedMilliseconds); // Add the last time.

            double totas = 0;

            foreach (double sad in _nodeTimes)
                totas += sad;

            return (totas / Infc);

        }

        /// <summary>
        /// Converts 2D to 1D
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>The Vector</returns>
        /// 
        public static int Get1DVector(int x, int y)
        {
            return (y * GlobalStuff.Width + x);
        }

        /// <summary>
        /// Gets the stored PGM Data
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>The Color</returns>
        public static byte GetPGMData(int x, int y)
        {
            return (byte)GlobalStuff._pgmData[(y * GlobalStuff.Width + x)];
        }

        /// <summary>
        /// Manhatten Heuristic
        /// </summary>
        /// <param name="_start">Node to Check</param>
        /// <param name="_end">End Node</param>
        /// <returns></returns>
        public static double ManhattenH(Node _start, Node _end)
        {
            double dx = Math.Abs(_start._pos.X - _end._pos.X);
            double dy = Math.Abs(_start._pos.Y - _end._pos.Y);

            return (dx + dy);
        }

        /// <summary>
        /// Euclidean Heuristic
        /// </summary>
        /// <param name="_start">Node to Check</param>
        /// <param name="_end">End Node</param>
        /// <returns></returns>
        public static double Euclidean(Node _start, Node _end)
        {
            double dx = Math.Abs(_start._pos.X - _end._pos.X);
            double dy = Math.Abs(_start._pos.Y - _end._pos.Y);

            return Math.Sqrt(dx * dx + dy * dy);
        }

        /// <summary>
        /// Gets the Min Node total on the List.
        /// </summary>
        /// <param name="_list">The List to Check from</param>
        /// <returns>The Min Node</returns>
        public static Node GetMinTotal(Dictionary<int,Node> _list)
        {
            Node MAX = new Node(new Vector2());
            MAX._total = double.MaxValue;

            foreach (Node _nd in _list.Values)
            {
                if (_nd == null) continue;

                if (_nd._total < MAX._total)
                    MAX = _nd;
                else
                    continue;
            }

            return MAX;
        }

    }
}
