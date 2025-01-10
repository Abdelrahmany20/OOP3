namespace OOP3
{
    internal class Program
    {


        public struct Person
        {

            //Q02 P1
            public string name;
            public int age;

            public Person(string Name, int Age)
            {
                name = Name;
                age = Age;
            }
        }

        public class Employee : IComparable
        {  //Q01 p2



            //public int ID;
            //public string Name;
            //public string Security;
            //public decimal Salary;
            //public DateTime HireDate;
            //public string Gender;


            //0.	Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)


            public int ID
            {
                get { return ID; }
                set { ID = value; }
            }
            public string Name
            {
                get { return Name; }
                set { Name = value; }
            }
            public string Security
            {
                get { return Security; }
                set { Security = value; }
            }
            public decimal Salary
            {

                get { return Salary; }
                set { Salary = value; }

            }
            public DateTime HireDate
            {
                get { return HireDate; }
                set { HireDate = value; }

            }
            public string Gender
            {
                get { return Gender; }
                set { Gender = value; }
            }

            public Employee(int id, string name, string securityLevel, decimal salary, DateTime hireDate, string gender)

            {
                ID = id;
                Name = name;
                Security = securityLevel;
                Salary = salary;
                HireDate = hireDate;
                Gender = gender;

            }





            public override string ToString()
            {
                return $"ID :{ID} , name : {Name} , securityLevel : {Security} , salary : {Salary} , HireDate :{HireDate} , Gender : {Gender}  ";
            }




            public class HiringDate //Q02
            {
                public int Day;
                public int Month;
                public int Year;

                public HiringDate(int day, int month, int year)
                {
                    Day = day;
                    Month = month;
                    Year = year;
                }

                public override string ToString()
                {
                    return $"Day : {Day} , Month : {Month} , Year : {Year}";
                }
            }


            //public enum Gender //Q03
            //{
            //M, F
            //}




            public void empinfo()
            {//0.	Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)


                Console.WriteLine($"ID :{ID} , name : {Name} , securityLevel : {Security} , salary : {Salary} , HireDate :{HireDate} , Gender : {Gender}  ");


            }


            public enum SecurityLevel
            {  //Q04
                Guest,
                Developer,
                Secretary,
                DBA
            }



        }







        static void Main(string[] args)
        {

            #region Part 1


            #region Type A
            //internal class TypeA
            //{
            //public int A { get; set; }

            //public TypeA(int _A)
            //{
            //A = _A;
            //}
            //public void Func1()
            //{
            //Console.WriteLine("I'M Base [Parent]");
            //}
            //public virtual void Func2()
            //{
            //Console.WriteLine($"A = {A}");
            //}
            //}
            //internal class TypeB : TypeA
            //{
            //public int B { get; set; }

            //public TypeB(int _A, int _B) : base(_A)
            //{
            //B = _B;
            //}
            ////KeyWord New || Override 
            //public new void Func1()
            //{
            //Console.WriteLine("I'M Drived [Child]");
            //}
            //public override void Func2()
            //{
            //Console.WriteLine($"A = {A} , B = {B}");
            //}

            //}

            //internal class TypeC : TypeB
            //{
            //public int C { get; set; }
            //public TypeC(int _A, int _B, int _C) : base(_A, _B)
            //{
            //C = _C;
            //}
            //public new void Func1()
            //{
            //Console.WriteLine("I'M GrandChild C");
            //}
            //public override void Func2()
            //{
            //Console.WriteLine($"A = {A} , B = {B} , C = {C}");
            //}

            //}

            //internal class TypeD : TypeC
            //{
            //public int D { get; set; }
            //public TypeD(int _A, int _B, int _C, int _D) : base(_A, _B, _C)
            //{
            //D = _D;
            //}
            //public new virtual void Func1()
            //{
            //Console.WriteLine("I'M GrandChild D");
            //}
            //public new virtual void Func2()
            //{
            //Console.WriteLine($"A = {A} , B = {B} , C = {C}, D = {D}");
            //}
            //}


            //internal class TypeE : TypeD
            //{
            //public int E { get; set; }
            //public TypeE(int _A, int _B, int _C, int _D, int _E) : base(_A, _B, _C, _D)
            //{
            //E = _E;
            //}
            //public override void Func1()
            //{
            //Console.WriteLine("I'M GrandChild E");
            //}
            //public override void Func2()
            //{
            //Console.WriteLine($"A = {A} , B = {B} , C = {C}, D = {D}, E={E}");
            //}
            #endregion


            #region Type b

            //public TypeB()
            //{
            ////TypeA typeA = new TypeA();
            ////typeA.x;//Private Protected =>  Private
            ////typeA.y;//Protected => Private
            ////typeA.z = 10;//Internal Protected => Internal 
            //x = 5;//Private
            //y = 6;//Private 
            //z = 7;//Internal

            #endregion


            //       internal class Employee
            //{
            //    public int Id { get; set; }
            //    public string Name { get; set; }
            //    public int Age { get; set; }

            //    public void Func1()
            //    {
            //        Console.WriteLine("I'm Employee");
            //    }
            //    public virtual void Func2()
            //    {
            //        Console.WriteLine($"ID = {Id}, Name = {Name},Age = {Age}");
            //    }
            //}

            //internal class FullTimeEmployee : Employee
            //{
            //    public int Salary { get; set; }

            //    public new void Func1()
            //    {
            //        Console.WriteLine("A'M FullTime Employee");
            //    }
            //    public override void Func2()
            //    {
            //        Console.WriteLine($"ID = {Id}, Name = {Name},Age = {Age}, Salary {Salary}");
            //    }
            //}

            //internal class PartTimeEmployee : Employee
            //{
            //    public int HourRate { get; set; }
            //    public int CountoFHours { get; set; }
            //    public new void Func1()
            //    {
            //        Console.WriteLine("A'M PartTime Employee");
            //    }
            //    public override void Func2()
            //    {
            //        Console.WriteLine($"ID = {Id}, Name = {Name},Age = {Age}, Salary {CountoFHours * HourRate}");
            //    }
            //}
            //internal class Program
            //{
            //    #region Poly
            //    public static void sum(int x, int y)
            //    {
            //        Console.WriteLine(x + y);
            //    }
            //    public static void sum(int x, int y, int z)
            //    {
            //        Console.WriteLine(x + y + z);
            //    }
            //    public static void sum(int x, double y)
            //    {
            //        Console.WriteLine(x + y);
            //    }
            //    public static void sum(double x, double y)
            //    {
            //        Console.WriteLine(x + y);
            //    }
            //    #endregion

            //    public static void ProccessEmpolyee(Employee employee)
            //    {
            //        if (employee is not null)
            //        {
            //            employee.Func1();//Im Employee => Ref
            //            employee.Func2();//Full Part => Object
            //        }
            //    }

            #endregion

            #region PART 2

            #region Q01

            //Person[] persons = new Person[3];

            //persons[0] = new Person("A", 10);
            //persons[1] = new Person("B", 15);
            //persons[2] = new Person("C", 20);

            //for (int i = 0; i < persons.Length; i++)
            //{
            //Console.WriteLine($"Name: {persons[i].name}, Age: {persons[i].age}");
            //}

            #endregion

            #region Q02

            //2.Create a struct called "Person" with properties "Name" and "Age".
            //Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.


            //Person[] people = new Person[3];

            //for (int i = 0; i < 3; i++)


            //{

            //Console.WriteLine("Enter the Name :");
            //string name = Console.ReadLine();


            //Console.WriteLine("Enter The Age :");
            //int age = int.Parse(Console.ReadLine());

            //people[i] = new Person(name, age);

            //}
            //Person oldestPerson = people[0];

            //for (int i = 1; i < 3; i++)
            //{
            //if (people[i].age > oldestPerson.age)
            //oldestPerson = people[i];
            //}

            //Console.WriteLine($"Oldest person is :{oldestPerson.name}");
            #endregion


            #endregion


            #region Part 3




            //try
            //{
            //Employee[] EmpArr1 = new Employee[3];

            //EmpArr1[0] = new Employee(1, "a", "DBA", 1000, new DateTime(2000, 1, 1), "M");
            //EmpArr1[1] = new Employee(2, "b", "Guest", 2000, new DateTime(2000, 2, 2), "M");
            //EmpArr1[2] = new Employee(3, "c", "Security Officer", 5000, new DateTime(2000, 3, 3), "M");

            //for (int i = 0; i < EmpArr1.Length; i++)
            //{
            //EmpArr1[i].empinfo();
            //}
            //}

            //catch (Exception ex)
            //{
            //Console.WriteLine(ex.Message);


            //}











            //q07

            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, "a", "DBA", 1000, new DateTime(2000, 1, 1), "M");
            EmpArr[1] = new Employee(2, "b", "Guest", 2000, new DateTime(2000, 2, 2), "M");
            EmpArr[2] = new Employee(3, "c", "Security Officer", 5000, new DateTime(2000, 3, 3), "M");


            Console.WriteLine(" before sorting :");
            for (int i = 0; i < EmpArr.Length; i++)
            {
                EmpArr[i].empinfo();
            }


            Array.Sort(EmpArr);
            Console.WriteLine("after sorting:");

            Console.WriteLine("\nEmployees sorted by hire date:");
            foreach (var employee in EmpArr)
            {
                Console.WriteLine($"Name: {employee.Name}, Security: {employee.Security}, Salary: {employee.Salary}, Hire Date: {employee.HireDate}, Gender : {employee.Gender}");
            }

            //public int CompareTo(object? obj)
            //{
            //throw new NotImplementedException();
            //}

            #endregion


        } 
    }
}

