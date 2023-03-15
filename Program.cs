using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace csharpIntro
{
    class Program
    {
        /*
             // static void Main(string[] args)
               // {
               //     Console.WriteLine("Hello World");
                    //  string myName = "Mondli";
                    //  int quantity = 10;
                    //  string city = "Pitori";
                    //  Console.WriteLine("My name is: {0} from Mzansi in {1}",  myName, city);
                    //// Console.WriteLine("The quantity is {0} ", quantity);


                    //    string number = "12345";
                    //  int no = Convert.ToInt32(number);
                    //  Console.WriteLine(no);


                    *//*StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < 10; i++)
                    {
                        sb.AppendLine(i.ToString());
                    }
                    System.Console.WriteLine(sb.ToString());

                    System.Console.WriteLine("Press any key to exit");
                    System.Console.ReadKey();*/

        /*string[] partNumbers = {"1298-673-4192", "A08Z-931-468A",
                                "_A90,123,129X", "12345-KKA-1230",
                                 "0919-2893-1256"};
        Regex rgx = new Regex(@"^[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[A-Za-z9]$");
        foreach (string partNumber in partNumbers)
            Console.WriteLine("{0} {1} a valid part number",
                                partNumber,
                                rgx.IsMatch(partNumber) ? "is" : "is not");*/


        /* string city = "Wakanda";
         if (city == "Wakanda")
         {
             Console.WriteLine("Welcome to {0}", city);
         }else
         {
             Console.WriteLine("You're not in Wakanda");
         }*/


        /*string country = "South Africa";
         if (country == "South Africa")
         {
             Console.WriteLine("There is Load-shedding");
         } else
         {
             Console.WriteLine("There is no load-shedding");
         }*/

        /* string caseSwitch = "CapeTown";

         switch(caseSwitch)
         {
             case "Durban":
                 Console.WriteLine("Durban");
                 break;

                 case "CapeTown":
                 Console.WriteLine("CapeTown");
                 break;

                 case "Home":
                 Console.WriteLine("You're not going anywhere");
                                     break;

             default:
                 Console.WriteLine("Default case");
                 break;
             }*/

        /* Console.WriteLine("Enter your age: ");
         string age = Console.ReadLine();
         Console.WriteLine("Your age is " + age);*/

        /*var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13};
        int count = 0;
        foreach (int element in fibNumbers)
        {
            count++;
            Console.WriteLine($"Element #{count}: {element}");
        }
        Console.WriteLine($"Number of elements: {count}");*/

        /*int i = 0;
        while(i < 10)
        {
            Console.WriteLine("Value of i: {0}", i);
            i++;
        }*/

        /*int i = 0;

        do
        {
            Console.WriteLine("Value of i: {0}", i);
            i++;

            if (i > 5)
                break;
        } while(true);*/

        /*int[] arr1 = new int[5];
        int[] arr2 = new int[5] {1,2,3,4,5};
        int[] arr3 = {1,2,3,4,5};*//*

        //rows and columns
        *//*int[,] arr = new int[3, 2]
        {
            {1, 2},
            {3, 4 }, 
            {5, 6 }
        };

        Console.WriteLine(arr[0,0]);
        Console.WriteLine(arr[1,0]);*/

        /*int[][] nestedarr = new int[2][];
        nestedarr[0] = new int[3] { 1, 2, 3 };
        nestedarr[1] = new int[2] { 4, 5 };

        Console.WriteLine(nestedarr[1][0]);*//*


        //}

        private static string helloClass = "Hello, class!";
        static void Main(string[] args)
        {
        *//* string helloLocal = "Hello, local!;
          Console.WriteLine(helloLocal);
         Console.WriteLine(Program.helloClass);
         DoStuff();*//*

        int number = 20;
        AddFive(ref number);
        Console.WriteLine(number);
        Console.ReadKey();
        }
        *//*static void DoStuff()
        {
            Console.WriteLine("A message from DoStuff: " + Program.helloClass);
        }*//*
        static void AddFive(ref int number)
        {
            number = number + 5;
        }
        }
        }*/



        /*using System;
        using System.IO; 
        class Example
        {
            static void Main()
            {
                string contents = GetText(@"C:\temp", "example.txt");
                Console.WriteLine("Contents of the file:\n" + contents);
            }
            private static string GetText(string path, string filename)
            {
                var sr = File.OpenText(AppendPathSeparator(path) + filename);
                var text = sr.ReadToEnd();
                return text;
                // Declare a local function.
                string AppendPathSeparator(string filepath)
                {
                    if (!filepath.EndsWith(@"\"))
                        filepath += @"\"; return filepath;
                }
            }
        }*/

        /* static void Main(string[] args)
         {*/
        /* // creating collections and arrays
         var dogs = new List<string>();
         dogs.Add("Bulldog");
         dogs.Add("Collie");
         dogs.Add("German Shephered");
         dogs.Add("Chiuaua");
         dogs.Add("Greyhound");
         dogs.Add("Pit Bull");

         {
             foreach (var dog in dogs)
                 Console.WriteLine(dog + " ");
             Console.ReadLine();
         }*/

        /*int a = 4;
        int b = 0;

        try
        {
        Console.WriteLine("Divide by Zero" + a/b);
        }catch (Exception e) 
        {
            Console.WriteLine("An error has occured..." + e.Message);
        }
        finally
        {
            Console.WriteLine("Finally has been callled..");
        }*/

        /* string s1 = "This is an example of ";
         s1 = s1 + "string concatenation";
         Console.WriteLine(s1);

         #region
         StringBuilder sb2 = new StringBuilder("This is an example of ");
         sb2.Append("String concatenation");
         Console.WriteLine(sb2);
         #endregion

         sb2.AppendLine();
         sb2.Append("using StringBuilder...");
         Console.WriteLine(sb2);

         sb2.Replace("StringBuilder", " the StringBuilder class...");
         Console.WriteLine(sb2);*/

        /*Person p = new Person();
        p.Age = 91;

        Console.WriteLine("Age: " + p.Age);*/

        /*DefConstructor dc = new DefConstructor();
        dc.DoThis();*/

        /*
                    double r = Math.Round(35.3);
                    Console.WriteLine(r);

                    *//*Car.Accelerate();*//*
                    Car c = new Car();
                    c.Decelerate();*/

        /*Mark m = new Mark(6, 7);*/

        //without using "new" keyword
        /*
                    Mark m2;
                    m2.x = 6;
                    m2.y = 7;
                    m2.DoThis();


                }

                public struct Mark
                {
                    public int x = 6;
                    public int y = 7;

                    public Mark(int a, int b)
                    {
                        x = a;
                        y = b;
                    }

                    public void DoThis()
                    {
                        Console.WriteLine(x + y);
                    }
                }*/

        /*public class Car
        {
            public static void Accelerate()
            {
                Console.WriteLine("Car is accelerating...");
            }
            public static void Decelerate()
            {
                Console.WriteLine("Car is slowing down...");
            }
        }*/


        /* public class Person
         {
             private int age;
             public int Age
             {
                 get {
                     return age;
                 }
                 set
                 {
                     if ((value > 0) && (value < 65))
                         age = value;
                 }
                 else 
                 {
                     throw new Exception("Age cannot be over 65...");
                 }
             }*/
        /* public class DefConstructor
     {
         public void DoThis()
         {
             Console.WriteLine("DoThis has run...");
         }
     }

     public class AddConstructor
     {
         public AddConstructor()
         {
             Console.WriteLine("The constructor has been called...");
             DoThat();
         }

         public void DoThat()
         {
             Console.WriteLine("DoThat has executed...");
         }*/
        // }


        /*  static void Main(string[] args)
          {*/
        /* System.Collections.ArrayList list1 = new System.Collections.ArrayList();
         list1.Add(3);
         list1.Add(5);
         list1.Add(12);
        // list1.Add("Hello");


         Console.WriteLine("Non-generic List results...");
         foreach (int x in list1)
         {
             Console.WriteLine(x);
         }

         List<int> list2 =  new List<int>();
         list2.Add(34);
         list2.Add(9);
         list2.Add(21);

         Console.WriteLine("Generic list results...");

         foreach (int item in list2) {
         Console.WriteLine(item);*/

        /*int num = 2147483647;
        long bigNum = num;

        int i = 5;
        double d = 10.5;
        i = (int)d;
        Console.WriteLine("The double variable d converted to int: " + i);*/


        /* object o;
         int x = 25;

         o = x;  //Boxing is taking place
         Console.WriteLine("o= " + o);
         Console.WriteLine("x= " + x);

         o = 123;
         x = (int)o;

         Console.WriteLine("o= " + o);
         Console.WriteLine("x= " + x);*/

        /*Patient p = new Patient();
         p.Examimine("Jamison");*/


        /*     Patient p = new Patient();
             p.Examine();

             Adult a = new Adult();
             a.Examine();

             Patient pa = new Adult();
             pa.Examine();
         }*/
        /* public class Patient
         {
             public string Firstname { get; set; }
             public string Lastname { get; set; }
             public int Age { get; set; }
             public int Weight { get; set; }
             public long SSN { get; set; }

             public void Examimine(string pname)
             {
                 Console.WriteLine("Examinaiton of " + pname + " is completed");
             }
             public void Billing(long ssn)
             {
                 Console.WriteLine("Billing completed...");
             }
         }
         public class Child: Patient
         {
             public void Inoculate
             {
                 Console.WriteLine()
             }
         }*/
        /* public class Patient
          {
              public virtual void Examine()
              {
                  Console.WriteLine("The patient has been examined...");
              }
          }
          public class Adult : Patient
          {
              public void Examine()
              {
                  Console.WriteLine("The adult has been examined...");
              }
          }*/

        /* static void Main(string[] args)
         {
             *//*string x = "Hello";
             string y = "hello";

             Console.WriteLine(x + " is capitalized? " + x.IsCap());*//*

             Machine1 m1 = new Machine1();
             Machine2 m2 = new Machine2();
             Machine3 m3 = new Machine3();
             m1.Start();
             m2.On();
             m3.StartUp();

         }
         public class Machine2 : IControls
         {
             public void On() 
             {
                 Console.WriteLine("On method is called...");
             }

             public void Start()
             {
                 throw new NotImplementedException();
             }

             public void Stop()
             {
                 throw new NotImplementedException();
             }
         }
         public class Machine1 : IControls
         {
             public void Start() 
             { 

             }

             public void Stop()
             {
                 throw new NotImplementedException();
             }
         }

         public class Machine3 : IControls
         {
             public void Start()
             {
                 throw new NotImplementedException();
             }

             public void StartUp()
             {
                 Console.WriteLine("Startup method called...");
             }

             public void Stop()
             {
                 throw new NotImplementedException();
             }
         }

         interface IControls
         {
             void Start();
             void Stop();
         }
 */
        /* public static class StringCap
         {
             public static bool IsCap(this string s)
             {
                 if (string.IsNullOrEmpty(s)) return false;
                 return char.IsUpper(s[0]);
             }
         }*/

        /* static void Main(string[] args)
         {
             Mark m = new Mark();
 *//*            m.DoThis();
 *//*          ((IFirst)m).DoThis();
             ((ISecond)m).DoThis();

            *//* ISecond mm = new Mark();
             mm.DoThis();*//*
         }
         interface IFirst
         {
             void DoThis();
         }
         interface ISecond
         {
             int DoThis();
         }
         public class Mark : IFirst, ISecond
         {
             public void DoThis()
             {
                 Console.WriteLine("Implementation of IFirst.DoThis...");
             }

             int ISecond.DoThis()
             {
                 Console.WriteLine("Implementation of ISecond.DoThis");
                 return 6;
             }
         }*/

        /* static void Main(string[] args)
         {
             List<string> cars = new List<string>();
             cars.Add("Chevrolet");
             cars.Add("Honda");
             cars.Add("Lexus");
             cars.Add("Ford");

             foreach (string car in cars) { 
             Console.WriteLine(car);
             }

             Console.WriteLine("\n" + "Now our own collection..." + "\n");

             Car c = new Car();
             c[0] = "Chevrolet";
             c[1] = "Mercedes";
             c[2] = "Dodge";

             foreach (string car in c)
             {
                 Console.WriteLine(car); 
             }
         }
         public class Car : IEnumerable
         {
             string[] car = new string[3];

             public string this[int carNum]
             {
                 get { return car[carNum]; }
                 set { car[carNum] = value; }
             }

             public IEnumerator GetEnumerator()
             {
                 foreach (string c in car)
                 {
                     yield return c;
                 }
             }*/

        /*delegate int del(int x, int y);
        static void Main(string[] args)
        {
            Mark m = new Mark();
            *//*   Console.WriteLine(m.AddNumbers(3, 3));
               Console.WriteLine(m.MultiplyNumbers(4, 4));*//*

            del d = m.AddNumbers;
            Console.WriteLine(d(3, 4));

            d = m.MultiplyNumbers;
            Console.WriteLine(d(3,4));

            d = m.DoAnotherThing;
            Console.WriteLine(d(3,4));
        }
        public class Mark
        {
            public int AddNumbers(int a, int b)
            {
                return a + b;
            }
            public int MultiplyNumbers(int a, int b)
            {
                return a * b;
            }
            public int DoAnotherThing(int x, int y)
            {
                return x + (y * 3);
            }
        }*/

        /*static void Main(string[] args)
        {
            Mark m = new Mark();
            m.AddNumbers(3, 3);
            m.MultiplyNumbers(3, 3);
            m.SubtractNumbers(3, 3);
        }

        public class Mark
        {
            public void AddNumbers(int a , int b)
            {
                Console.WriteLine("AddNumbers: a + b+ " + (a + b));
            }
            public void MultiplyNumbers(int a , int b)
            {
                Console.WriteLine("MultiplyNumbers: a * b= " + (a * b));
            }
            public void SubtractNumbers(int a , int b)
            {
                Console.WriteLine("SubtractNumbers: a - b = " + (a - b));
            }
        }*/
        /*delegate void del(int x, int y);

        static void Main(string[] args)
        {
            Mark m = new Mark();
            del d;

            d = m.AddNumbers;
            Console.WriteLine("Invoking delegate d with one target");
            d(6, 5);
            Console.WriteLine();

            d += m.MultiplyNumbers;
            Console.WriteLine("Invoking delegate d with two targets");
            d(6, 5);
            Console.WriteLine();

            d += m.SubtractNumbers;
            Console.WriteLine("Invoking delegate d with three targets");
            d(6, 5);
            Console.WriteLine();

            d -= m.MultiplyNumbers;
            Console.WriteLine("Invoking delegate d without MultiplyNumbers:");
            d(6, 5);
            Console.WriteLine();
        }

        public class Mark
        {
            public void AddNumbers(int a, int b)
            {
                Console.WriteLine("AddNumbers: a + b = " + (a + b));
            }
            public void MultiplyNumbers(int a, int b)
            {
                Console.WriteLine("MultiplyNumbers: a * b = " + (a * b));
            }
            public void SubtractNumbers(int a, int b)
            {
                Console.WriteLine("SubtractNumbers: a - b = " + (a - b));
            }
        }*/

        static void Main(string[] args)
        {
            //Instantiate an event publisher object
            EvtPublisher ep = new EvtPublisher();

            //event subscriber object
            EvtSubscriber es = new EvtSubscriber();
            ep.evt += es.HandleTheEvent;

            // Call the checkbalance method on the ep object
            // it will invoke the ep.evt delegate if the balance exceeds 250
            ep.CheckBalance(240);
        }
        public class EvtPublisher
        {
            //  public delegate void del(string x);

            //   public event del evt;

            public EventHandler evt;
            public void CheckBalance(int x)
            {
                if (x > 250)
                    evt(this, EventArgs.Empty);
            }
        } 
        public class EvtSubscriber
        {
            public void HandleTheEvent(object sender, EventArgs e)
            {
                Console.WriteLine("ATTENTION! " + sender + " is advising that the balance is over 250");
            }
        }
    }
    }

        
        

    
//}