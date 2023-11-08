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
        internal 
    }
}
