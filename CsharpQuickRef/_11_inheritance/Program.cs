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

            void test(object j)
            {
                if (j is 5)
                {
                    Console.WriteLine(5);
                }
                else if (j is int i)
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

        }
    }
}