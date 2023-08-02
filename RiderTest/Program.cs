using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace RiderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestObjects.TestAllObjects();
            TestObjects.LinqExample();
            TestObjects.AnonymousMethodExample();
            TestObjects.NullableReferenceTypeExample();
            TestObjects.TupleDeconstructionExample();
            TestObjects.PatternMatchingExample(42);
            TestObjects.StringInterpolationExample();
            TestObjects.RecordExample();
            
            TestObjects.DelegateExample();
            TestObjects.ThreadPoolExample();
            
            // Test of class
            var circle = new Circle(5);
            ResizableCircle resizableCircle = new ResizableCircle(10);
            
            // Test of thread
            var processManager = new ProcessManager();
            processManager.Start();
            Console.WriteLine("Press Enter to stop the process...");
            Console.ReadLine();
            processManager.Stop();
            Console.WriteLine("Process stopped.");
            
            Console.WriteLine("That's it");
            Console.ReadLine();
        }
    }
    //--------------------------------------------------
    //-------------------------------------------------- This class contains different variables, objects, esnums and so on - that's thy it's big
    //--------------------------------------------------
    #region DifferentVariablesAndThings


    public class TestObjects 
    {
            
        //Simple values
        private int a = 1;

        
        public int A
        {
            get => a;
            set => a = value;
        }


        // Simple arrays
        private static int[] intArray = { 1, 2, 3, 4, 5 };
        private static string[] stringArray = { "Hello", "World" };

        // Lists
        private static List<int> intList = new List<int> { 10, 20, 30, 40, 50 };
        private static List<string> stringList = new List<string> { "Apple", "Banana", "Cherry" };

        // Delegate
        public delegate void CustomDelegate(string message);

        // Simple method using delegate
        public static void PrintMessage(string message)
        {
            Console.WriteLine("Delegate message: " + message);
        }

        // Method using different objects
        public static void TestAllObjects()
        {
            
            // Simple arrays
            Console.WriteLine("Int Array:");
            foreach (var num in intArray)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nString Array:");
            foreach (var str in stringArray)
            {
                Console.WriteLine(str);
            }

            // Lists
            Console.WriteLine("\nInt List:");
            foreach (var num in intList)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nString List:");
            foreach (var str in stringList)
            {
                Console.WriteLine(str);
            }

            // Delegates
            CustomDelegate del = PrintMessage;
            Console.WriteLine("\nDelegate Example:");
            del("Hello from the delegate!");

            // Anonymous types
            var anonymousObject = new { Name = "John", Age = 30 };
            Console.WriteLine("\nAnonymous Type Example:");
            Console.WriteLine($"Name: {anonymousObject.Name}, Age: {anonymousObject.Age}");

            // Tuple
            var tupleObject = Tuple.Create("Alice", 25);
            Console.WriteLine("\nTuple Example:");
            Console.WriteLine($"Name: {tupleObject.Item1}, Age: {tupleObject.Item2}");

            // Dictionary
            var dictionary = new Dictionary<string, int>
            {
                { "One", 1 },
                { "Two", 2 },
                { "Three", 3 }
            };
            Console.WriteLine("\nDictionary Example:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            // Other types
            DateTime currentDate = DateTime.Now;
            TimeSpan timeSpan = TimeSpan.FromHours(3);
            Console.WriteLine("\nOther Types:");
            Console.WriteLine($"Current Date: {currentDate}");
            Console.WriteLine($"Time Span: {timeSpan}");
        }

        // Nested classes and structures
        public class NestedClass
        {
            public int Value { get; set; }
        }

        public struct NestedStruct
        {
            public string Name { get; set; }
        }

        // Enumerations
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        // Nullable types
        private static int? nullableInt = null;
        private static double? nullableDouble = 3.14;

        // Multi-dimensional arrays
        private static int[,] multiDimIntArray = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

        // Custom objects
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        // Collection of custom objects
        private static List<Person> peopleList = new List<Person>
        {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 30 },
            new Person { Name = "Carol", Age = 35 }
        };

        // Indexer (custom indexer property)
        public class IndexerExample
        {
            private int[] values = { 10, 20, 30, 40, 50 };

            public int this[int index]
            {
                get { return values[index]; }
                set { values[index] = value; }
            }
        }

        // Other data types
        private static char singleChar = 'A';
        private static decimal decimalNumber = 123.45M;
        private static bool isTrue = true;
        private static TimeSpan duration = TimeSpan.FromMinutes(120);
        private static DateTimeOffset dateTimeOffset = DateTimeOffset.Now;



        // Arrays of different data types
        private static char[] charArray = { 'A', 'B', 'C' };
        private static bool[] boolArray = { true, false, true };
        

        // Nullable value types
        private static DateTime? nullableDateTime = null;

        // Strings with escape characters
        private static string stringWithEscape = "This is a \"quoted\" string.";

        // Enums with underlying types
        public enum Month : byte
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        // Lambda expressions
        public static void LambdaExample()
        {
            Func<int, int> square = x => x * x;
            Console.WriteLine($"Square of 5: {square(5)}");
        }

        // Events and event handler
        public static event EventHandler MyEvent;

        private static void OnMyEvent()
        {
            MyEvent?.Invoke(null, EventArgs.Empty);
        }

        // Dynamic keyword
        public static void DynamicExample(dynamic dynamicObject)
        {
            Console.WriteLine($"Dynamic Example: {dynamicObject}");
        }

        // LINQ Query
        public static void LinqExample()
        {
            var evenNumbers = intArray.Where(num => num % 2 == 0);
            Console.WriteLine("\nLINQ Example:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }

        // Anonymous methods
        public static void AnonymousMethodExample()
        {
            Action<string> printMessage = delegate(string message)
            {
                Console.WriteLine("Anonymous Method: " + message);
            };
            printMessage("Hello from the anonymous method!");
        }

        // Nullable reference type
        public static void NullableReferenceTypeExample()
        {
            string? nullableString = null;
            Console.WriteLine("\nNullable Reference Type Example:");
            Console.WriteLine($"Nullable String: {nullableString}");
        }

        // Tuple deconstruction
        public static void TupleDeconstructionExample()
        {
            var tuple = (Name: "John", Age: 30);
            var (name, age) = tuple;
            Console.WriteLine("\nTuple Deconstruction Example:");
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        // Pattern matching (C# 9.0)
        public static void PatternMatchingExample(object obj)
        {
            if (obj is int number)
            {
                Console.WriteLine("\nPattern Matching Example:");
                Console.WriteLine($"It's an integer: {number}");
            }
        }

        // String interpolation
        public static void StringInterpolationExample()
        {
            string name = "Alice";
            int age = 25;
            Console.WriteLine("\nString Interpolation Example:");
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        // Records (C# 9.0)
        public record PersonRecord(string Name, int Age);

        public static void RecordExample()
        {
            var person = new PersonRecord("Bob", 30);
            Console.WriteLine("\nRecord Example:");
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }

        
        public delegate void EventHandlerDelegate(string message);

        public static void DelegateExample()
        {
            EventHandlerDelegate handler = new EventHandlerDelegate(PrintMessage1);
            handler("Hello from the delegate!");
        }

        public static void PrintMessage1(string message)
        {
            Console.WriteLine("\nDelegate Example:");
            Console.WriteLine("Delegate message: " + message);
        }


        public static void CountNumbers()
        {
            Console.WriteLine("\nThread Example:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Count: {i}");
                Thread.Sleep(1000);
            }
        }

        // Threading (using ThreadPool)
        public static void ThreadPoolExample()
        {
            ThreadPool.QueueUserWorkItem(PrintThreadPoolMessage, "Hello from ThreadPool!");
        }

        public static void PrintThreadPoolMessage(object state)
        {
            string message = (string)state;
            Console.WriteLine("\nThreadPool Example:");
            Console.WriteLine(message);
        }
        
        }
        
    }

    #endregion 
    
    //--------------------------------------------------
    //-------------------------------------------------- For testing abstract class, inheritance, virtual class
    //--------------------------------------------------
    #region AbstractionInheritanceVirtualClass

    public abstract class Shape 
    
    {
        public abstract double CalculateArea();
        public virtual double CalculateAreaVirtual()
        {
            return 0;
        }
    }

    public class Circle : Shape
    
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculateAreaVirtual()
        {
            return 99999999;
        }

    }
    
    public class Rectangle : Shape
    
    {
        public double a { get; set; }
        public double b { get; set; }

        public Rectangle(double first, double second)
        {
            a = first;
            b = second;
        }
        
        public override double CalculateArea()
        {
            return a * b;
        }
    }

    #endregion ////For testing abstract class, inheritance, virtual class

    //--------------------------------------------------
    //-------------------------------------------------- For testing Interfaces
    //--------------------------------------------------
    #region Interfaces

    public interface IResizable //For testing abstract class and inheritance
    
    {
        void Resize(double factor);
    }

    public class ResizableCircle : IResizable
    {
        public double Radius { get; set; }

        public ResizableCircle(double radius)
        {
            Radius = radius;
        }

        public void Resize(double factor)
        {
            Radius *= factor;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    #endregion
    
    //--------------------------------------------------
    //-------------------------------------------------- For testing Threads
    //--------------------------------------------------

    #region Threads

    public class ProcessManager
    {
        private bool _stopProcess = false;
        private Thread _numbersThread;
        private Thread _stringsThread;

        public void Start()
        {
            _numbersThread = new Thread(AddNumbers);
            _stringsThread = new Thread(AddStrings);

            _numbersThread.Start();
            _stringsThread.Start();
        }

        public void Stop()
        {
            _stopProcess = true;

            _numbersThread.Join();
            _stringsThread.Join();
        }

        private void AddNumbers()
        {
            int sum = 0;
            int count = 1;

            while (!_stopProcess)
            {
                sum += count;
                count++;
                Console.WriteLine(sum);
                Thread.Sleep(100); // Simulate some work
            }

            Console.WriteLine($"Sum of numbers: {sum}");
        }

        private void AddStrings()
        {
            string result = "";
            int count = 1;

            while (!_stopProcess)
            {
                result += $"String {count}, ";
                count++;
                Console.WriteLine(result);
                Thread.Sleep(150); // Simulate some work
            }

            Console.WriteLine($"Concatenated strings: {result}");
        }
    }

    #endregion

