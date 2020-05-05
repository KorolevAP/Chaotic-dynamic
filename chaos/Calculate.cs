using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chaos
{
    public abstract class BiffurcationMap
    {
        private double _minCoeffValue;
        public double minCoeffValue
        {
            protected get { return _minCoeffValue; }
            set { _minCoeffValue = value; }
        }

        private double _maxCoeffValue;
        public double maxCoeffValue
        {
            protected get { return _maxCoeffValue; }
            set { _maxCoeffValue = value; }
        }

        private double _coefficient; 
        public double coefficient
        {
            get {
                return _coefficient; }
            set
            {
                if (value <= maxCoeffValue && value >= minCoeffValue)
                {
                    _coefficient = value;
                }
                else _coefficient = maxCoeffValue;
            }
        }
        private string _mapName;
        public string mapName
        {
            get { return _mapName; }
            protected set { _mapName = value; }
        }

        protected void setMapName(string value)
        {
            mapName = value;
        }
        public abstract double nextPoint(double point);

  
    }

    public class TentMap : BiffurcationMap
    {
        public TentMap() : base ()
        {
            minCoeffValue = 0;
            maxCoeffValue = 2;
            coefficient = 0d;
            mapName = "TentMap";
        }

        public TentMap(double coeff) : base()
        {
            minCoeffValue = 0;
            maxCoeffValue = 2;
            coefficient = coeff;
            mapName = "TentMap";
        }

        public override double nextPoint(double point)
        {
            if (point <= 0.5)
            {
                return coefficient * point;
            }
            return -coefficient * point + coefficient;
        }
    }

    public class LogisticMap : BiffurcationMap
    {
        public LogisticMap() : base()
        {
            minCoeffValue = 0;
            maxCoeffValue = 4;
            coefficient = 0d;
            mapName = "LogisticMap";

        }

        public LogisticMap(double coeff) : base()
        {
            minCoeffValue = 0;
            maxCoeffValue = 4;
            coefficient = coeff;
            mapName = "LogisticMap";
        }
        public override double nextPoint(double point)
        {
            return coefficient * point * (1 - point);
        }
    }

    public class SinMap : BiffurcationMap
    {
        public SinMap()
        {
            minCoeffValue = 0;
            maxCoeffValue = double.PositiveInfinity;
            coefficient = 0;
            mapName = "SinMap";
        }

        public SinMap(double coeff)
        {
            minCoeffValue = 0;
            maxCoeffValue = double.PositiveInfinity;
            coefficient = coeff;
            mapName = "SinMap";
        }
        public override double nextPoint(double point)
        {
            return coefficient * Math.Sin(Math.PI * point);
        }
    }
}
