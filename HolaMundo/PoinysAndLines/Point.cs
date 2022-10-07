namespace PointsAndLines
{
    class Point
    {
        private int x;
        public int y;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point()
        {

        }
    }
    

}

