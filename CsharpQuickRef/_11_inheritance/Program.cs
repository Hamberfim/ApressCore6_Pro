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

        }
    }
}