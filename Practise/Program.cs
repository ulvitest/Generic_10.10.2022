using System;
using System.Collections;
using System.Collections.Generic;

namespace Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region practise
            //int[] numbers = { 1, 6, 4, 3, 7 };
            //Array.Sort(numbers);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Person per1 = new Person();
            //per1.Name = "Name1";
            //per1.Surname = "Surname1";
            //per1.Age = 25;

            //Person per2 = new Person();
            //per2.Name = "Name2";
            //per2.Surname = "Surname2";
            //per2.Age = 16;

            //Person per3 = new Person();
            //per3.Name = "Name3";
            //per3.Surname = "Surname3";
            //per3.Age = 18;


            //Person[] users = {per1,per2,per3};
            //Array.Sort(users);
            //Array.Reverse(users);

            //foreach (var item in users)
            //{
            //    Console.WriteLine(item.Age);
            //}
            #endregion

            #region Generic

            //MyStr myStr = new MyStr();
            //myStr.Add("Sabir");
            //myStr.Add("Lorem");
            //myStr.Add("Ipsum");
            //myStr.GetAll();

            //MyInt myInt = new MyInt();
            //myInt.Add(2);
            //myInt.Add(6);
            //myInt.GetAll();

            //MyList<int> myIntList = new MyList<int>();
            //myIntList.Add(1);
            //myIntList.Add(2);
            //myIntList.GetAll();

            //MyList<string> myStringList = new MyList<string>();
            //myStringList.Add("Sabir");
            //myStringList.Add("Semed");
            //myStringList.GetAll();

            //MyList<Person> myPersonList = new MyList<Person>();
            //myPersonList.Add(new Person());
            //myPersonList.Add(new Person());
            //myPersonList.Add(new Person());
            //myPersonList.GetAll();

            #endregion

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(true);
            //arrayList.Add("Lorem");
            //arrayList.Add(new Person());
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(arrayList.Count);

            List<string> myStrList = new List<string>();
            myStrList.Add(":");
            myStrList.Add("Nuran");

            // Console.WriteLine(myStrList.Contains(":"));
            //myStrList.AddRange(myStrList1);
            //foreach (var item in myStrList)
            //{
            //    Console.WriteLine(item);
            //}

            //LinkedList<string> myList = new LinkedList<string>();
            //myList.AddFirst("Lorem");


            //Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            //keyValuePairs.Add("Semed", "0516000890");
            //keyValuePairs.Add("David", "0703336683");
            //Console.WriteLine(keyValuePairs["Semed"]);

            //foreach (var item in keyValuePairs)
            //{
            //    Console.WriteLine(keyValuePairs[item.Key]);
            //}

            //Stack<string> stack = new Stack<string>();//lifo
            //stack.Push("Sabir");
            //stack.Push("Elman");
            //stack.Push("Reshad");

            //Console.WriteLine(stack.Peek());
            //stack.Pop();

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);

            Console.WriteLine(myQueue.Peek());
            foreach (var item in myQueue)
            {
                //Console.WriteLine(item);
            }


        }
    }

    class MyList<T>
    //where T:class,IComparable
    //where T:class
    //where T:struct
    //where T:new()
    //where T:IComparable
    //where T:U
    //where T : Person
    {
        private T[] arr;

        public MyList()
        {
            arr = new T[0];
        }

        public void Add(T str)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = str;
        }

        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }

    //class MyInt
    //{
    //    private int[] arr;

    //    public MyInt()
    //    {
    //        arr = new int[0];
    //    }

    //    public void Add(int str)
    //    {
    //        Array.Resize(ref arr, arr.Length + 1);
    //        arr[arr.Length - 1] = str;
    //    }

    //    public void GetAll()
    //    {
    //        foreach (var item in arr)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}
}
