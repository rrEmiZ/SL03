using System;

namespace ConsoleApp21
{

    public class SomeClass
    {
        public string TestString { get; set; }
        public void Test()
        {
            Console.WriteLine(TestString);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            dynamic sc = new SomeClass();
            sc.TestString = "Test2";
            sc.Test();

            sc = true;

            sc = "Prawda";

            
            sc = 5.4d;
            sc = 5.4d;
            var sc2 = 5.4d;

            Console.WriteLine("SUPER DZIAŁA 1");

            var zmienna = 10;
            Console.WriteLine(zmienna.GetType());
            //wyświetli System.Int32
            //zmienna = "nap";

            object zmienna2 = new SomeClass(); 
            Console.WriteLine(zmienna2.GetType());
            ((SomeClass)zmienna2).TestString = "Test23";
            ((SomeClass)zmienna2).Test();


            Console.ReadLine();
        }


        //var sc = new SomeClass();
        //sc.TestString = "TESTSTR";
        //sc.Test();

        //Type scType = Type.GetType("ConsoleApp21.SomeClass");
        //object obj = Activator.CreateInstance(scType);  
        //var propInfo = scType.GetProperty("TestSttring");
        //propInfo.SetValue(obj, "TESTREF");
        //var testMethod = scType.GetMethod("Test");
        //testMethod.Invoke(obj,null);
    }
}
