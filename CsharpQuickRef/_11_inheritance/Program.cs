namespace _11_inheritance
{
    internal class Program
    {
        // base class
        class Person
        {
            public string fName = "";
            public string lName = "";

            // method
            public string fullname()
            {
                return fName + " " + lName;
            }
        }

        class PersonInfo : Person
        {
            public int age = 0;
            public string gender = "";

            // method
            public string personIdentity()
            {
                return fullname() + ", age: " + age + ", gender: " + gender;
            }
        }


        static void Main(string[] args)
        {
            // base class
            Person personName = new Person();
            personName.fName = "Bill";
            personName.lName = "William";
            Console.WriteLine(personName.fullname());

            Console.WriteLine();  // space in output

            // inherited class
            PersonInfo personInfo = new PersonInfo();
            personInfo.fName = "Clara";
            personInfo.lName = "William";
            personInfo.age = 25;
            personInfo.gender = "female";
            Console.WriteLine(personInfo.personIdentity());

            Console.WriteLine();  // space in output

            // downcast and upcast
            PersonInfo personInfoUpcast = new PersonInfo();
            personInfoUpcast.fName = "Henry";
            personInfoUpcast.lName = "Hill";
            personInfoUpcast.age = 44;
            personInfoUpcast.gender = "male";

            // upcast 
            Person personUpcast = personInfoUpcast;
            // Console.WriteLine(personUpcast.personIdentity());  // ERROR - only Person' members can be access
            Console.WriteLine(personUpcast.fullname());
            // downcast
            PersonInfo personDowncast = (PersonInfo)personUpcast;
            Console.WriteLine(personDowncast.personIdentity());  // everything specific to PersonInfo was preserved in the upcast/downcast of personInfoUpcast

            Console.WriteLine();  // space in output

            // boxing allows for value type variables to be converted to reference type
            double price = 2.99;
            object priceObj = price;  // now seen as a ref type
            // unboxing via cast
            price = (double)priceObj;

            Console.WriteLine();  // space in output

            // 'is' | 'as' keywords - used to avoid exception when casting
            var n = 12;
            var d = 2.2333;
            if (n is double)
            {
                int p = (int)d;
                Console.WriteLine(p);
            }

            int ten = 10;
            object tenObj = ten;
            string tenStr = tenObj as string;  //only works with ref types - invalid cast returns a null
            Console.WriteLine(tenStr is null);

            Console.WriteLine();  // space in output

            // 'is'  - pattern matching
            object obj = "Some Text";
            if (!(obj is string text))
            {
                return;
            }
            Console.WriteLine(text);

            Console.WriteLine();  // space in output

            // used with ref types, value types and constants
            void test(object j)  // using the 'is' - the introduced pattern variable is thru the block and after the end of the if statement
            {
                if (j is 5)
                {
                    Console.WriteLine(5);
                }
                else if (j is int i)  // validation and assigning it to a variable of the same datatype
                {
                    Console.WriteLine("int:" + i);
                }
                else if (j is null)
                {
                    Console.WriteLine("null");
                }
            }

            test(5);
            test(1);
            test(null);

            Console.WriteLine();  // space in output

            void testSwitch(object j)
            {
                switch(j)
                {
                    // order is important - fisrt case matching number must be first so the case int can be matched
                    case 5:
                        Console.WriteLine(5);
                        break;
                    case int i:
                        Console.WriteLine("int:" + i);
                        break;
                    case null:
                        Console.WriteLine("null");
                        break;
                }
            }

            testSwitch(5);
            testSwitch(1);
            testSwitch(null);

            Console.WriteLine();  // space in output

            // C# 9 or later - logical operators  - is this a letter
            bool IsLetter(char letter)
            {
                return letter is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
            }
            Console.WriteLine(IsLetter((char)68));   // true explicit cast
            Console.WriteLine(IsLetter((char)0));   // flase explicit cast
            Console.WriteLine(IsLetter('G'));  // true
            Console.WriteLine(IsLetter('\u0068'));  // h true

            Console.WriteLine();  // space in output

            // C# 9 or later - logical operators  - is this a positive double of 10 or less
            bool IsDoubleLessThanTen(double val)
            {
                return val is >= 0.001 and <= 10.0;
            }
            Console.WriteLine(IsDoubleLessThanTen('G'));  // false
            Console.WriteLine(IsDoubleLessThanTen(0.7));  // true
            Console.WriteLine(IsDoubleLessThanTen(0.0001));  // false
            Console.WriteLine(IsDoubleLessThanTen(11));  // false
            Console.WriteLine(IsDoubleLessThanTen(2));  // true - int converts

        }
    }
}