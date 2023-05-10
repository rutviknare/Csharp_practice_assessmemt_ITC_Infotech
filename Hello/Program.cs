using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;



namespace Hello
{
    /*
    class Program

    {
        static void displayname(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        public static void Main(string[] args)
        { */
    // 1.Write a C# Program to print “Welcome to C# Programming”
    //  Console.WriteLine("Welcome To C# programming");
    // 2.Write a C# Program toget input from the user and perform calculationssuch as
    // a.Area of a triangle.
    // Console.WriteLine("Enter the Base and Height:");
    // int b = Convert.ToInt32(Console.ReadLine());
    // int h=Convert.ToInt32(Console.ReadLine());
    //int result=Convert.ToInt32((h*b)/2);
    //Console.WriteLine("Area of triangle: " + result);
    // b.Check Whether a Given Number is Even or Odd.
    //Console.WriteLine("Enter the Number:");
    //int number=Convert.ToInt32(Console.ReadLine());
    // if (number % 2 == 0)
    /* {
         Console.WriteLine("Number is Even");
     }
     else
     {
         Console.WriteLine("NUmber is Odd");
     }
     // c.Multiplicationtable.
     Console.WriteLine("Enter the Number:");
     int num=Convert.ToInt32(Console.ReadLine()); ;
     for(int i = 1; i <= 10; i++)
     {
         Console.WriteLine(num + "*" + i + "=" + num * i);
     } */
    //3.Write a programto print the length of the string without using library functionss

    /*Console.WriteLine("Enter the String:");
    string name=Console.ReadLine();
    int length=0;
    foreach(char i in name)
    {
        length++;
    }
    Console.WriteLine("LEngth of string:" + length); */

    /* Console.WriteLine("Enter the name and age: ");
    string name=Console.ReadLine();
    int age=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Hello {name} and your age is {age}"); */

    /*

    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpDepartment { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfJoining { get; set; }
        public double Salary { get; set; }

        public Employee(int empID, string empName, string empDepartment, DateTime dateOfBirth, DateTime dateOfJoining, double salary)
        {
            EmpID = empID;
            EmpName = empName;
            EmpDepartment = empDepartment;
            DateOfBirth = dateOfBirth;1
            DateOfJoining = dateOfJoining;
            Salary = salary;
        }

        public double CalculateSalaryHike()
        {
            // Calculate the duration in years since joining
            TimeSpan duration = DateTime.Now - DateOfJoining;
            int years = (int)(duration.Days / 365.25); // Considering leap years

            if (years >= 1)
            {
                double salaryHike = Salary * 0.1; // 10% hike
                Salary += salaryHike;
            }

            return Salary;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Employee> employeeList = new List<Employee>();

            // Create employee objects and add them to the list
            employeeList.Add(new Employee(1, "John Doe", "IT", new DateTime(1990, 5, 15), new DateTime(2022, 1, 1), 50000));
            employeeList.Add(new Employee(2, "Jane Smith", "HR", new DateTime(1988, 9, 10), new DateTime(2023, 4, 15), 60000));
            employeeList.Add(new Employee(3, "Michael Johnson", "Sales", new DateTime(1992, 3, 25), new DateTime(2021, 6, 20), 55000));
            employeeList.Add(new Employee(4, "Emily Davis", "Finance", new DateTime(1995, 8, 5), new DateTime(2023, 2, 10), 65000));
            employeeList.Add(new Employee(5, "David Wilson", "Marketing", new DateTime(1991, 12, 3), new DateTime(2022, 9, 5), 70000));

            // Print the employee list
            Console.WriteLine("Employee List:");
            Console.WriteLine("==============");

            foreach (Employee employee in employeeList)
            {
                Console.WriteLine("Employee ID: " + employee.EmpID);
                Console.WriteLine("Employee Name: " + employee.EmpName);
                Console.WriteLine("Department: " + employee.EmpDepartment);
                Console.WriteLine("Date of Birth: " + employee.DateOfBirth.ToShortDateString());
                Console.WriteLine("Date of Joining: " + employee.DateOfJoining.ToShortDateString());
                Console.WriteLine("Salary: " + employee.CalculateSalaryHike());
                Console.WriteLine();
                Console.ReadLine();
            }
        } 

    }
    }*/
    /*
    class Program
    {
        private string color;
        private int maxspeed;
        /*public void printname(string color, int maxspeed)
        {
            Console.WriteLine("Color of object 1: "+color);
            Console.WriteLine("Max Speed of Object 1: "+maxspeed);
        } */
    /*
    public Program(string color, int maxspeed)
    {
        this.color=color;
        this.maxspeed=maxspeed ;
    }
    */
    /*public string Color
    {
        get { return color; }
        set { color = value; }
    }

    static void Main(string[] args)
    {
        //In this below the code example of diff object..
        //Program p1= new Program();
        //Program p2= new Program();
        // Console.WriteLine("Enter the Color for object 1: ");
        // p1.color = Console.ReadLine();
        //// Console.WriteLine("Enter the max Speed for object 1: ");
        //p1.maxspeed= Convert.ToInt32(Console.ReadLine());
        //  Console.WriteLine("Enter the Color for object 2: ");
        // p2.color = Console.ReadLine();
        // Console.WriteLine("Enter the max Speed for object 2: ");
        // p2.maxspeed = Convert.ToInt32(Console.ReadLine());

        /*  Console.WriteLine("Color of Object 1: "+p1.color);
          Console.WriteLine("Max speed of object 1: "+p1.maxspeed);
          Console.WriteLine("Color of Object 2: " + p2.color);
          Console.WriteLine("Max speed of object 2: " + p2.maxspeed); */
    // p1.printname(p1.color,p1.maxspeed);


    //Contructor Example 
    ////Console.WriteLine("Color of Object 1: " + p1.color);
    // Console.WriteLine("Max Speed of Object 1: "+p1.maxspeed);


    //Constructor Parameters
    /*

    Program p2= new Program();
    p2.Color = "Green";
    p2.maxspeed = 100;
    Console.WriteLine(p2.color);
    Console.WriteLine(p2.maxspeed);

    Console.ReadLine();

}
} */

    /*
    class Rutvik
    {
        public string name;
        public void setname()
        {
            Console.WriteLine("Rutvik Class Name: " + name);

        }
    }
    class Nare : Rutvik
    {
        public void setsurname(string surname="Neymar")
        {
            Console.WriteLine("Surname of Nare class: "+surname);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Nare nare = new Nare(); 
            nare.setname();
            Console.WriteLine("Enter the surname for class Nare Class: ");
            string name=Console.ReadLine();
            nare.setsurname(name);
            Console.ReadLine();
        }
    } */

    //The sealed Keyword very imp topic
    /*
    sealed class Rutvik
    {
        public string name;
        public void printname()
        {
            Console.WriteLine(name);
        }
    }
    class Program: Rutvik
    {
        //It's showing error 
    }
    */
    /*
    class printname
    {
        public void printclassnamae()
        {
            Console.WriteLine("This is printname class..");
        }
    }
    class printsurname : printname
    {
        public void printclasssurname()
        {
            Console.WriteLine("This is printsurname class,,,.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            printname printname = new printname();
            printsurname printsurname = new printsurname();
            printname.printclassnamae();
            printsurname.printclasssurname();
            Console.ReadLine(); 
            
        }
    }*/
    //Abstraction Below is the example
    /*
    abstract class Rutvik
    {
        public abstract void printnameclass();
        public void printsurname()
        {
            Console.WriteLine("Hii Its rutvik class.. which contain absract method...");
        }
    }

    class Nare: Rutvik
    {
        public override void printnameclass()
        {
            Console.WriteLine("This is Nare class which is using abract method...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Nare nare = new Nare(); 
            nare.printnameclass();
            Console.ReadLine();
        }
    }
    */

    //Below is example of single Interface
    /* interface Rutvik
    {
        void printname();
    }
    class Nare : Rutvik
    {
        public void printname()
        {
            Console.WriteLine("This class using implemention of super interface class");
        }
    }
    class tempclass : Nare { 
    
        public void printname()
        {
            Console.WriteLine("This class is temp classs for override method...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Nare nare = new Nare(); 
            nare.printname();
            tempclass tempclass = new tempclass();  
            tempclass.printname();
            Console.ReadLine();
        }
    } */
    /*
    interface firstinterface
    {
        void firstclass();
    }
    interface secondinterface
    {
        void secondclass();

    }

    class finalclass : firstinterface , secondinterface { 
    
        public void firstclass()
        {
            Console.WriteLine("This is first class interface....");
        }

        public void secondclass()
        {
            Console.WriteLine("This is Second Class interface....");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            finalclass f1= new finalclass();
            f1.firstclass();
            f1.secondclass();
            Console.ReadLine();
        }
    }
    */

    //Exception used of try catch and finally statement
    /*
    class Program{

        static void Main()
        {
            try
            {
                int[] arr = { 1, 2, 3, 4, 5, };
                Console.WriteLine("Current Element in array: "+arr[7]);
            }
            catch(Exception e)
            {
                Console.WriteLine("testing try catch program....");
            }
            finally
            {
                Console.WriteLine("This is Finally Statement....");
                Console.ReadLine();
            }

        }
    }*/
    //class Program
    //{
    /*
        static void printnumber(int num)
        {
            if (num > 18)
            {
                throw new ArithmeticException("Your age is more than 18 year");
            }
            else
            {
                Console.WriteLine("Your age is OK....");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Age:");
            int num = Convert.ToInt32(Console.ReadLine());
            printnumber(num);
            Console.ReadLine();
        }
    }
    */
    class A
    {
        public void samemethodname(string name,string surname)

        {
            Console.WriteLine("1st Method of Class A");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
        }
        public void samemethodname(string name, int age, string surname)
        {
            Console.WriteLine("2nd Method of Class A");
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Age: " + age);
        }
    }
    class Program {
    
            public static void Main(string[] args) { 
        
            A a = new A();
            a.samemethodname("Rutvik", "Nare");
            a.samemethodname("Rutvik", 23, "Nare");
            Console.ReadLine();
        }
    
    }

}









