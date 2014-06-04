using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepino_A_Star
{

    public class Node
    {
        public double _cost;
        public double _heuristic;
        public double _total;

        public Vector2 _pos;

        public List<Node> _neightbors;

        public Node _parent;
        public double Time;

        public Node(Vector2 pos)
        {
            this._neightbors = new List<Node>();
            this._pos = pos;
            this._cost = 0;
            this._heuristic = 0;
        }

        public void CalcTotal()
        {
            _total = _cost + _heuristic;
        }

    }

    public static class AStarPathFinder
    {

        public static double CalculateCost(byte color)
        {
           double STEPS = 220;
           return (double)(255 - STEPS)/ color;
            //return 1 - (color / 255);
            //return Math.Abs((color - 80) / (255 - 80));
        }

        public static bool IsOutsidePicture(Vector2 _pos)
        {
            return (_pos.X - 1 < 0 || _pos.Y - 1 < 0 || _pos.Y + 1 > GlobalStuff.Height || _pos.X + 1 > GlobalStuff.Width);
        }

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

        public static int ClampValue(int max, int min ,int value){
            if (value > max) return max;
            if (value < min) return min;
            return value;
        }

        public static void FindPath(Node _start, Node _end, Bitmap img)
        {

            Dictionary<int, Node> _openList = new Dictionary<int, Node>();
            Dictionary<int, Node> _closedList = new Dictionary<int, Node>();

            Node _current = _start;
            _openList[Get1DVector(_start._pos.X, _start._pos.Y)] = _start;

            while (true)
            {
                int X = _current._pos.X;
                int Y = _current._pos.Y;

                double _startTime = DateTime.Now.Millisecond;

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

                    if (GlobalStuff._drawNeigbor)
                    {
                        int ColorHer = ClampValue(255, 10, (int)(Math.Abs(neigh._heuristic) * 155));
                        int ColorVal = ClampValue(255, 10, (int)(Math.Abs(neigh._cost) * 155));
                        img.SetPixel(neigh._pos.X, neigh._pos.Y, Color.FromArgb(0, ColorVal,ColorHer));
                        GlobalStuff._pathMenu.SetImagePreview(img);
                    }

                }

                _current.Time = Math.Abs(DateTime.Now.Millisecond - _startTime);

            }

            Node tmp = _end;
            GlobalStuff._timeMenu.ClearNodeList();

            double Total = 0;
            double MaxPt = 0;

            while (true)
            {
                if (tmp._parent == null) break;
                img.SetPixel(tmp._pos.X, tmp._pos.Y, GlobalStuff._pathColor);
                GlobalStuff._pathMenu.SetImagePreview(img);

                GlobalStuff._timeMenu.AddNodeInfo("Node {" + tmp._pos + "} -> Time : " + ((double)(tmp.Time)).ToString() + " - Cost : " + Math.Round(tmp._cost, 3) + " - Heuristic : " + Math.Round(tmp._heuristic, 3));
                Total += tmp.Time;
                MaxPt++;

                tmp = tmp._parent;
            }

            GlobalStuff._timeMenu.SetAverage(((double)(Total / MaxPt)).ToString());
            GlobalStuff._pathMenu.SetPathFinished();

        }

        public static int Get1DVector(int x, int y)
        {
            return (y * GlobalStuff.Width + x);
        }

        public static byte GetPGMData(int x, int y)
        {
            return (byte)GlobalStuff._pgmData[(y * GlobalStuff.Width + x)];
        }

        public static double ManhattenH(Node _start, Node _end)
        {
            double dx = Math.Abs(_start._pos.X - _end._pos.X);
            double dy = Math.Abs(_start._pos.Y - _end._pos.Y);

            return (dx + dy);
        }

        public static double Euclidean(Node _start, Node _end)
        {
            double dx = Math.Abs(_start._pos.X - _end._pos.X);
            double dy = Math.Abs(_start._pos.Y - _end._pos.Y);

            return Math.Sqrt(dx * dx + dy * dy);
        }


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
