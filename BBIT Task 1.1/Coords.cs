namespace BBIT_Task_1._1
{
    struct Coords
    {
        public int x;
        public int y;

        public Coords(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public void SetCoords(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"x:{this.x}, y:{this.y}";
        }
    }
}
