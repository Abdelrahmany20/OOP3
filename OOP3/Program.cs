namespace OOP3
{
    internal class Program
    {
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











            #endregion



        }
    }
}
