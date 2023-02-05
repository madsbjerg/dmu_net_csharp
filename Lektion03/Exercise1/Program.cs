namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, here are some shapes! \n");

            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle(1, 2, 5));
            shapes.Add(new Circle(0, 0, 5));
            shapes.Add(new Circle(1, 1, 10));
            shapes.Add(new Square(1, 2, 3, 5));
            shapes.Add(new Square(2, 4, 3, 5));

            foreach(Shape s in shapes)
            {
                Console.WriteLine("Shape: " + s.ToString());
                Console.WriteLine("Area: " + s.GetArea());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}