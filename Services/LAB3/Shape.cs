namespace WebApplication3.LAB3
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }
        public int GetArea(int x)
        {
            return Width * Height * x;
        }

        public float GetArea(float x)
        {
            return (Width * Height * x);
        }


        public int GetShorterSide()
        {
            return new List<int>() { Width, Height }.Min();

        }



    }
}
