using System;

namespace classAndObj // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        interface universe
        {
          public  void worlds();
        }
        interface  world
        {
          public  void human();
        }
        abstract class Person: world
        {
            public abstract void human();
            //  public abstract void human() { }
            public void method1()
            {
                Console.WriteLine("common method");
            }

            public abstract void method2();
        }


         class Student : Person,universe
        {
            public  void worlds()
            {
                Console.WriteLine("this is universe");
            }
            public override void human()
            {
                Console.WriteLine("world class");
            }
            public override void method2()
            {
                Console.WriteLine("overloaded method");
            }
        }
        public class Author
        {
            public string Authorname;
            public string Name { get { return Authorname; } set { Authorname = value; } }

            internal Author() { }
           internal  Author(string Authorname){
            this.Authorname = Authorname;  
            }

            internal void Aname()
            {
                Console.WriteLine(Authorname);
            }


            public virtual void testPolyMorphism()
            {
                Console.WriteLine(Authorname);
            }
        }

        public class Book: Author
        {

           
            
            private string name;
            private string catagory;
            private int id;

            public string Name { get { return name; } set { name = value; } }
            public int Id { get { return Id; } set { id = value; } }
            public string Catagory { get { return catagory;  } set{ catagory = value; } }


           public Book() { }
           public Book(string name, int id, string catagory,string Authorname) : base(Authorname)
            {
                this.name = name;
                this.id = id;
                this.catagory = catagory;
               this.Authorname = Authorname;


            }


            public void show()
            {
                Console.WriteLine(name+" "+id+" "+catagory+" "+Authorname);
            }

            public override void testPolyMorphism()
            {
                Console.WriteLine("this is derived class execute");
                base.testPolyMorphism();
            }
        }
        static void Main(string[] args)
        {
            var stu = new Student();
       //     stu.method1();
         //   stu.method2();
            stu.human();
            stu.worlds();
            var obj = new Book("A brief history of time", 1, "Science","stephin hawkings");
            obj.show();
            obj.Aname();
            var newObj = new Book();

          
            newObj.Name = "Danob";
            newObj.Id = 2;
            newObj.Catagory = "ficton";
            newObj.Authorname = "jafor ikbal";
            newObj.show();
            Console.WriteLine("Hello World!");

            var parent= new Author("arshad");
            parent.testPolyMorphism();
            var book = new Book("A brief history of time", 1, "Science", "stephin hawkings");
            book.testPolyMorphism();
        }
    }
}