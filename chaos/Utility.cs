using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chaos
{
    public static class Utility
    {
        public static void ClearQuick(this System.Windows.Forms.DataVisualization.Charting.DataPointCollection Points)
        {
            Points.SuspendUpdates();
            while (Points.Count > 0)
            {
                Points.RemoveAt(Points.Count - 1);
            }
            Points.ResumeUpdates();
        }
    }
    public struct InputOrbitsParams
    {
        public int itersNum { set; get; }
        public double startingPoint { set; get; }
        public double coefficient { set; get; }
        public double coefficientEnd { set; get; }
    }

}
