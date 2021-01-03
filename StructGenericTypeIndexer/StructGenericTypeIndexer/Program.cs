using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructGenericTypeIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Indexer
            //Library library = new Library("Libraf");
            //Book book = new Book("C# 9.0");
            //library[100] = book;
            //Console.WriteLine(library[0]);


            //string str = "Hello";

            //Console.WriteLine(str[0]);
            #endregion

            #region Struct
            //Volume volume = new Volume();
            //volume.GetVolume();
            //Volume volume1;
            //volume1.Z = 10;
            //Console.WriteLine(volume1.Z);
            //int a = 5;
            //bool isMaried = true;
            #endregion

            #region Tuple,ValueTuple
            #region Tuple - reference
            //Tuple<int, string, string> person = new Tuple<int, string, string>(1,"Anar","Balacayev");
            //var person = Tuple.Create(1, "Anar", "Balacayev",4,5,6,7,8);
            //Console.WriteLine(person.Item1);
            //Console.WriteLine(person.Item2);
            //Console.WriteLine(person.Item3);
            #endregion
            #region VlueTuple-value
            //ValueTuple<int, string, string> person = (1, "Bill", "Gates");
            //(int, string, string) person= (1, "Bill", "Gates");
            //Console.WriteLine(person.Item2);
            //var person = (Id: 1, FirstName: "Bill", LastName: "Gates");
            //var number = (1,2,3,4,5,6,7,8,9,0);
            //Console.WriteLine(person.FirstName);
            #endregion
            #endregion

            #region Generic type
            //MyIntList intList = new MyIntList();
            //intList.AddMember(5);
            //intList.AddMember(15);
            //intList.AddMember(25);
            //MyStrList strList = new MyStrList();
            //strList.AddMember("Salam");
            //MyPersonList personList = new MyPersonList();
            //personList.AddMember(new Person("Pervin"));
            //MyList<int> intList = new MyList<int>();
            //intList.AddMember(5);
            //intList.AddMember(15);

            //MyList<string> strList = new MyList<string>();
            //strList.AddMember("Elvin");

            //MyList<Person,IRun> people = new MyList<Person, IRun>();
            //people.AddMember(new Person("Famil"));
            //Print<int>(5);
            //Print<string>("Hello");
            #endregion

            #region Collection
            #region ArrayList
            //ArrayList arrlist = new ArrayList();
            //arrlist.Add("Hello");
            //arrlist.Add(new Person());
            //arrlist.Add(true);
            //arrlist.Add(new int[] { 1, 2, 3 });
            //arrlist.Insert(1, "Salam");
            ////arrlist.Clear();
            ////arrlist.Remove("Hello");
            //foreach (var item in arrlist)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region List
            //List<int> intList = new List<int>();
            //intList.Add(5);
            //Console.WriteLine(intList.Contains(5));
            //List<Person> people = new List<Person>();
            //Person p = new Person("Anar");
            //people.Add(new Person("Anar"));
            //people.Add(new Person("Elvin"));
            //Console.WriteLine(people[0]);
            #endregion
            #region Dictionary
            //Dictionary<string, string> phones = new Dictionary<string, string>();
            //phones.Add("Kamran", "+994512373434");
            //phones.Add("Anar", "+994703766983");
            //phones.Add("Elvin", "+994708511483");

            //phones.Remove("Kamran");
            //foreach (var item in phones)
            //{
            //    Console.WriteLine(item.Key + "  " + item.Value);
            //}
            //Console.WriteLine(phones["Anar"]);
            #endregion
            #region Queue - FIFO
            //Queue<string> q = new Queue<string>();
            //q.Enqueue("Anar");
            //q.Enqueue("Elvin");
            //q.Enqueue("Musa");


            //string str=q.Dequeue();
            ////q.Dequeue();
            ////q.Dequeue();
            //Console.WriteLine("Novebedekiler:");
            //foreach (string item in q)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Sonuncu siradan chixarilan:");
            //Console.WriteLine(str);
            #endregion
            #region Stack - LIFO
            //Stack<Person> stack = new Stack<Person>();
            //stack.Push(new Person("Musa"));
            //stack.Push(new Person("Elvin"));
            //stack.Push(new Person("Anar"));

            ////Console.WriteLine(stack.Peek());


            //int count = stack.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    stack.Pop();
            //}

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
        }

        #region Generic type
        //static void Print<T>(T x)
        //{
        //    Console.WriteLine(x);
        //}
        #endregion
    }

    #region Generic type
    //class MyList<T> where T:IRun,new()
    class MyList<T,U> where T:U where U:class,new()
    {
        private T[] numbers;
        public MyList()
        {
            numbers = new T[0];
        }

        public void AddMember(T member)
        {
            Array.Resize(ref numbers, numbers.Length + 1);
            numbers[numbers.Length - 1] = member;
        }
    }

    //class MyStrList
    //{
    //    private string[] numbers;
    //    public MyStrList()
    //    {
    //        numbers = new string[0];
    //    }

    //    public void AddMember(string member)
    //    {
    //        Array.Resize(ref numbers, numbers.Length + 1);
    //        numbers[numbers.Length - 1] = member;
    //    }
    //}

    //class MyPersonList
    //{
    //    private Person[] numbers;
    //    public MyPersonList()
    //    {
    //        numbers = new Person[0];
    //    }

    //    public void AddMember(Person member)
    //    {
    //        Array.Resize(ref numbers, numbers.Length + 1);
    //        numbers[numbers.Length - 1] = member;
    //    }
    //}


    interface IRun
    {

    }
    public class Person:IRun
    {
        public string Name { get; set; }
        public Person()
        {

        }
        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    #endregion

    #region Struct - value
    interface IVolume { }
    struct Volume:IVolume
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z;
        public Volume(int x,int y,int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void GetVolume()
        {
            Console.WriteLine($"{X*Y*Z}");
        }
    }

    #endregion

    #region Indexer

    class Library
    {
        public string Name { get; set; }
        private Book[] books;
        public Library(string name)
        {
            Name = name;
            books = new Book[100];
        }

        public Book this[int index]
        {
            get
            {
                try
                {
                    return books[index];
                }
                catch (Exception)
                {

                    return books[0];
                }
                
            }
            set
            {
                try
                {
                    books[index] = value;
                }
                catch (Exception)
                {

                    Console.WriteLine($"Max index: {books.Length-1}");
                }
            }
        }

        //public void AddBook(Book book)
        //{
        //    Array.Resize(ref books, books.Length + 1);
        //    books[books.Length - 1] = book;
        //}
    }

    class Book
    {
        public string Name { get; set; }
        public Book(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
    #endregion
}
