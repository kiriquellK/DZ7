namespace Classes
{
    internal class Sphere
    {
        internal double _radius;
        internal double _xCenter;
        internal double _yCenter;
        internal double _zCenter;
        internal double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }
        internal Sphere()
        {
            _radius = 1;
            _xCenter = 0;
            _yCenter = 0;
            _zCenter = 0;
        }
        internal Sphere(double radius)
        {
            _radius = radius;
            _xCenter = 0;
            _yCenter = 0;
            _zCenter = 0;
        }
        internal Sphere(double radius, double xCenter, double yCenter, double zCenter)
        {
            _radius = radius;
            _xCenter = xCenter;
            _yCenter = yCenter;
            _zCenter = zCenter;
        }
        internal double GetVolume()
        {
            return 4 / 3 * Math.PI * _radius * _radius * _radius;
        }
        internal double GetSquare()
        {
            return 4 * Math.PI * _radius * _radius;
        }
        internal string GetCenter()
        {
            return _xCenter.ToString() + "" + _yCenter.ToString() + "" + _yCenter;
        }
        internal void SetCenter(double xCenter, double yCenter, double zCenter)
        {
            _xCenter = xCenter;
            _yCenter = yCenter;
            _zCenter = zCenter;
        }
        internal bool isPointInside(double x, double y, double z)
        {
            double squaredDistance = (x - _xCenter) * (x - _xCenter) + (y - _yCenter) * (y - _yCenter) + (z - _zCenter) * (z - _zCenter);
            return squaredDistance < _radius * _radius;
        }
    }
}
