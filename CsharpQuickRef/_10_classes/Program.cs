namespace _10_classes
{

    internal class Program
    {
        // basic class
        class Box
        {
            public int x, y;  // fields
            public int GetArea()  // method
            {
                return x * y;
            }
        }

        // with contructors
        class Rectangle
        {
            public int x, y;
            public int GetArea()
            {
                return x * y;
            }

            // first contructor
            public Rectangle()
            {
                x = 2;
                y = 5;
            }

            // second overloading constructor
            public Rectangle(int a)
            {
                x = a;
                y = a;
            }


            // third overloading constructor
            public Rectangle(int width, int height)
            {
                x = width;
                y = height;
            }

        }

        static void Main(string[] args)
        {
            // create object of box - basic class
            Box b = new Box();
            b.x = 10;
            b.y = 20;
            int boxArea = b.GetArea();  // result 200
            Console.WriteLine(boxArea);

            // create object of box with object initializers - basic class
            Box boi = new Box() { x = 1, y = 3 };
            int boiArea = boi.GetArea();  // result 3
            Console.WriteLine(boiArea);


            // create an object of Rectangle class using the constructors
            Rectangle firstConstr = new Rectangle();
            int firstArea = firstConstr.GetArea();  // result 10
            Console.WriteLine(firstArea);

            Rectangle secConstr = new Rectangle(5);
            int secArea = secConstr.GetArea();  // result 25
            Console.WriteLine(secArea);

            Rectangle thirdConstr = new Rectangle(5, 10);
            int thirdArea = thirdConstr.GetArea();  // result 50
            Console.WriteLine(thirdArea);


            Console.WriteLine();  // space in output
        }
    }
}