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

            // is | as keywords

        }
    }
}