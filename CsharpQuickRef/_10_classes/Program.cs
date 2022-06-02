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

        // Type Inference
        class JunkExample 
        {
            public int one = 1;
            public string two = "two";
            public bool three = true;
            public double four;
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

            // null
            int? n = null;  // nullable value
            // null-coalescing
            int j = n ?? 5;   // 'j' will equal 'n's value if its not null, otherwise is will equal 5
            Console.WriteLine($"Value of j is {j}");

            int? p = 7;
            int r = p ?? 0;  // 'r' will equal 'p's value if its not null, otherwise is will equal 0
            Console.WriteLine($"Value of r is {r}");

            // null assignment
            string str1 = null;
            int? strLen1 = str1?.Length;
            Console.WriteLine($"Value of strLen is {strLen1}");  // result is 'strLen1' is null
            // null and a conditional
            int strLen2 = str1?.Length ?? 0;  // if 'str1' is null then assign a value of zero
            Console.WriteLine($"Value of strLen is {strLen2}");

            // Type Inference - Anonymous class JunkExample { int one = 1; string two = "two";}
            var implicitType = new JunkExample();
            Console.WriteLine($"implicitType.one = {implicitType.one} is {implicitType.one.GetType()}");
            Console.WriteLine($"implicitType.two = {implicitType.two} is {implicitType.two.GetType()}");
            Console.WriteLine($"implicitType.three = {implicitType.three} is {implicitType.three.GetType()}");
            implicitType.four = 1.99;  // assigned
            Console.WriteLine($"implicitType.four = {implicitType.four:C2} is {implicitType.four.GetType()}");

            Console.WriteLine();  // space in output

            // strictly an Anonymous Type
            var someVar = new { first = "'The number one'", second = true, third = 3, fourth = 1.25m};
            Console.WriteLine($"someVar.first = {someVar.first} is {someVar.first.GetType()}");
            Console.WriteLine($"someVar.second = {someVar.second} is {someVar.second.GetType()}");
            Console.WriteLine($"someVar.third = {someVar.third} is {someVar.third.GetType()}");
            Console.WriteLine($"someVar.fourth = {someVar.fourth} is {someVar.fourth.GetType()}");

            Console.WriteLine();  // space in output
        }
    }
}