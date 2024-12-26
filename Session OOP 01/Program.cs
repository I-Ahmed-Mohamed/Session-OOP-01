using Common;
namespace Session_OOP_01
{

    //What You Can Write Inside Namespace ?

    //1. Class
    //2. Struct
    //3. Interface
    //4. Enum

    // Access Modifier Allowed Inside Namespace ?

    // 1. Internal [Default]
    // 2. Public


    public enum Days
    {
        Saturday,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
    }

    public enum Grades
    {
        A, B, C, D, E, F,
    }

    public enum Gender
    {
        Male = 1, Female = 2, male = 3, female = 4,
    }
    enum Branches : byte // 8 byte => 0 to 2500
    {
        Dokki, NaserCity, Maadi, Alex, SmartVillage, Cairo
    }

    public enum Premission
    {
        Delete, Execute, Read, Write
    }

    class Employee
    {
        public string Name;
        public int Age;
        public decimal Salary;
        public Gender Gender;
        public Premission Premissions;


    }


    internal class Program
    {

        #region Excpetion Handling
        //static void DoSomeCode()
        //{
        //    try
        //    {
        //        int x, y, z;
        //        x = int.Parse(Console.ReadLine()); //SystemException
        //        y = int.Parse(Console.ReadLine());
        //        z = x / y; // System.DivideByZeroException

        //        int[] Numbers = { 1, 2, 3 }; // Size 3
        //        Numbers[10] = 100; // System.IndexOutOfRangeException
        //    }
        //    // if any Exception Happened in try  Block
        //    // CLR Will create object From Class Of Exception
        //    // Through in Catch Block
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        //static void DoProtectiveCode()
        //{
        //    int x, y, z;
        //    bool flag;

        //    do
        //    {
        //        Console.WriteLine("Enter First Number");
        //        flag = int.TryParse(Console.ReadLine(), out x);
        //    }
        //    while (!flag);


        //    do
        //    {
        //        Console.WriteLine("Enter Second Number");
        //        flag = int.TryParse(Console.ReadLine(), out y);
        //    }
        //    while (!flag || y == 0);


        //    z = x / y;

        //    int[] Numbers = null;
        //    if (Numbers?.Length > 10) ;
        //    {
        //        // Numbers = Null => Numbers?.length = null
        //        // NUmbers = != Null => Numbers?.length = length 
        //        Numbers[10] = 100;
        //    } 
        #endregion



        static void Main(string[] args)
        {

            #region Part 01 Exception Handling and Protective Code
            // Exceptions
            // 1. System Exceptions
            //// 1.1 Format Exception
            //// 1.2 Index Out Of Range Exception
            //// 1.3 Null Reference Exception
            //// 1.4 Invalid Operation Exception
            //// 1.5 Arithmetic Exception
            ////  1.5.1 Divided By Zero Exception
            ////  1.5.2 Overflow Exception
            // 2. Application Exception

            //try
            //{
            //    DoProtectiveCode();
            //    throw new Exception();

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //finally
            //{
            //    // Close | Delete | Release |  Deallocate Unmanaged Resources 
            //    // open File
            //    // Connection With Database

            //    Console.WriteLine("Finally");

            //}

            //Console.WriteLine("After try Catch");


            #endregion

            #region Part 02 Access Modifiers
            //Private
            //Private Protected
            //Protected
            //Internal
            //Protected Internal
            //Public

            // TypeA obj = new TypeA(); // valid 
            // TypeB obj2 = new TypeB(); // invalid {internal} 

            //obj.y = 20; invalid
            // obj.z = 30; // valid    
            #endregion

            #region Enum

            #region Enum - Example 01
            //Grades x = Grades.A;

            //if (x == Grades.A)
            //    Console.WriteLine(":)");
            //else
            //    Console.WriteLine("(:");

            //Grades y = (Grades)2;  // Explicit Casting
            //Console.WriteLine(y); // C 

            //Grades z = (Grades)10; // Explicit Casting
            //Console.WriteLine(z); // 10

            #endregion

            #region Enum - Example 02
            //     Console.WriteLine("Please Enter Your Grade");
            //     //Grades x   = (Grades) Enum.Parse(typeof(Grades), Console.ReadLine()); // invalid

            //bool Result =     Enum.TryParse(typeof(Grades), Console.ReadLine(), out object x);
            //     Console.WriteLine(Result);
            //     Console.WriteLine($"Your Grade is {x}");

            #endregion

            #region  Enum - Example 03 multilabel - case sensitivity [TryParse]

            //Gender G1 = Gender.Female;
            //Console.WriteLine(G1); // Female

            //Gender G2 = (Gender)2;
            //Console.WriteLine(G2); // Female

            //string Gender = "male";
            //Gender x = (Gender)Gender;

            //Enum.TryParse(typeof(Gender), Gender, out object Result); // C# 1.0

            //bool Flag = Enum.TryParse<Gender>(Gender, true, out Gender Result); C# 2.0
            //Console.WriteLine(Flag);
            //Console.WriteLine(Result);

            //Gender x = new Gender(); // Take Default Vlue of Enum = 0
            //Console.WriteLine(x);                        

            #endregion

            #region Enum - Example 04 (Permissions)
            //Embloyee embloyee = new Embloyee();
            //embloyee.Name = " Ahmed ";
            //embloyee.Gender = Gender.Male;
            //embloyee.Premissions = (Premission)3;
            //Console.WriteLine(embloyee.Premissions); // Delete , Execute

            // if you Want to add Premission (Read)
            // Do XOR Operation

            // ^
            // embloyee.Premissions = embloyee.Premissions ^ Premission.Read;

            // Console.WriteLine(embloyee.Premission); // Delete , Execute , Read


            // if you Want to add Premission (Read)
            // Do XOR Operation

            //embloyee.Premissions = embloyee.Premissions ^ Premission.Read;
            //Console.WriteLine(embloyee.Premission); // Delete , Execute 

            // if you want to Check if deleted is Existed Or  Not 
            // Do And Operation
            // &

            //embloyee.Premissions & Premission.Delete;
            // if delete is Existed => return Delete 
            // if delete is Existed =>  return Random Value 

            //Console.WriteLine(embloyee.Premission); // Delete , Execute 

            //if ((embloyee.Premissions & Premission.Delete) == Premission.Delete)
            //{
            //    Console.WriteLine("Delete is Existed");
            //}
            //else
            //{
            //    Console.WriteLine("Delete is not Existed");

            //}

            //  Console.WriteLine(embloyee.Premission); // Delete , Execute 

            // if you want to Check if deleted is Existed Or  Not 
            // if Existed => Do  Nothing
            // if Not Existed => Add 
            // Do And Operation

            // embloyee.Premissions = embloyee.Premissions | Premission.Read;
            // Console.WriteLine(embloyee.Premission); // Delete , Execute 



            // | 

            #endregion

            #endregion

            #region Part 06 Struct
            Point P1;

            // Declare Variable from type "Point"
            // CLr Will Allocate 8 Uninitialized bytes Stack

            //Console.WriteLine(P1.x); // invalid
            //P1.X = 10;
            //P1.Y = 20;
            // Console.WriteLine(P1.x)
            // Console.WriteLine(P1.y)

            P1 = new Point(50);
            // new => is just only for Constructor Selection
            // That Will Initialize Attribute Of Struct

            Console.WriteLine($"x = {P1.x}");
            Console.WriteLine($"x = {P1.y}");
            Console.WriteLine(P1); // vlaid this Boxing Unboxing
            Console.WriteLine(P1.ToString()); // invalid  

            //int x = 10;
            //Console.WriteLine(x); // 10
            //Console.WriteLine(P1.ToString()); // 10






            #endregion



            #region Assignment OOP 01
            // Part 01 - Problem 1
            #region WeekDays
            // Create an enum for days of the week
enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        class Program1
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Days of the Week:");
                foreach (var day in Enum.GetValues(typeof(WeekDays)))
                {
                    Console.WriteLine(day);
                }
            }
        }
        #endregion

        // Part 01 - Problem 2
            #region Season
        // Create an enum for seasons
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        class Program2
        {
            static void Main(string[] args)
            {
                Console.Write("Enter a season name (Spring, Summer, Autumn, Winter): ");
                string input = Console.ReadLine();

                if (Enum.TryParse(input, true, out Season season))
                {
                    switch (season)
                    {
                        case Season.Spring:
                            Console.WriteLine("Spring: March to May");
                            break;
                        case Season.Summer:
                            Console.WriteLine("Summer: June to August");
                            break;
                        case Season.Autumn:
                            Console.WriteLine("Autumn: September to November");
                            break;
                        case Season.Winter:
                            Console.WriteLine("Winter: December to February");
                            break;
                        default:
                            Console.WriteLine("Invalid season.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }
        #endregion

        // Part 01 - Problem 3
           #region Permissions
        // Create an enum for permissions [Flags]
        [Flags]
        enum Permissions
        {
            None = 0,
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8
        }

        class Program3
        {
            static void Main(string[] args)
            {
                Permissions userPermissions = Permissions.Read | Permissions.Write;

                Console.WriteLine("Current Permissions: " + userPermissions);

                // Add Delete permission
                userPermissions |= Permissions.Delete;
                Console.WriteLine("After Adding Delete: " + userPermissions);

                // Remove Write permission
                userPermissions &= ~Permissions.Write;
                Console.WriteLine("After Removing Write: " + userPermissions);

                // Check if Execute permission exists
                bool hasExecute = (userPermissions & Permissions.Execute) == Permissions.Execute;
                Console.WriteLine("Has Execute Permission: " + hasExecute);
            }
        }
        #endregion

        // Part 01 - Problem 4
           #region Colors
        // Create an enum for colors
        enum Colors
        {
            Red,
            Green,
            Blue,
            Yellow,
            Black,
            White
        }

        class Program4
        {
            static void Main(string[] args)
            {
                Console.Write("Enter a color name: ");
                string input = Console.ReadLine();

                if (Enum.TryParse(input, true, out Colors color))
                {
                    if (color == Colors.Red || color == Colors.Green || color == Colors.Blue)
                    {
                        Console.WriteLine($"{color} is a primary color.");
                    }
                    else
                    {
                        Console.WriteLine($"{color} is not a primary color.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid color name.");
                }
            }
        }
        #endregion

        // Part 01 - Problem 5
           #region Point
        // Create a struct for a 2D point
        struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double DistanceTo(Point other)
            {
                return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2));
            }
        }

        class Program5
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the coordinates for the first point:");
                Console.Write("X1: ");
                double x1 = double.Parse(Console.ReadLine());
                Console.Write("Y1: ");
                double y1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the coordinates for the second point:");
                Console.Write("X2: ");
                double x2 = double.Parse(Console.ReadLine());
                Console.Write("Y2: ");
                double y2 = double.Parse(Console.ReadLine());

                Point p1 = new Point(x1, y1);
                Point p2 = new Point(x2, y2);

                Console.WriteLine($"The distance between the two points is: {p1.DistanceTo(p2):F2}");
            }
        }
        #endregion

        #endregion

    }






}

    enum Roles
    {
        Admin = 10, Editor = 20, Viewer = 30,
    }

    class Embloyee
    {
        string Name;
        int Age;
        double Salary;
        Gender Gender;
        Roles


    }
}

