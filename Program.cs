using System;
using System.Collections.Generic;

namespace ConsoleApp8_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello SayHelloName = new SayHello();
            Console.WriteLine(SayHelloName.hello("Majid"));

            SaySalam SaySalamName = new SaySalam();
            Console.WriteLine(SaySalamName.hello("Zohre"));

            FromSayHello fromSayHello = new FromSayHello();
            Console.WriteLine(fromSayHello.Sum(4,5));
            Console.WriteLine(fromSayHello.hello("LoVe"));
            //این هلو از کلاس سی هلو اومد که خود کلاس سی هلو هم از اینترفیسش ایمپلیمنت کرده بود
            Console.WriteLine(fromSayHello.goodbay("Love"));


            INterface1 I1 = new SaySalam();//اینتر فیس میتونه فقط به فرزندانش که ازش ارث بری کردن تغیر کند
            INterface1 I2 = new SayHello();//پلیمورفیسم یا همان چندریختی

            Console.WriteLine(I2.hello("A"));
            //I2.goodbay("A");//این گودبای نمیاد و ارور میده

            /*
             Why do we use polymorphism?           
             Polymorphism means "many forms", and it occurs when we have many classes that are
             related to each other by inheritance. Like we specified in the previous chapter; Inheritance
             lets us inherit attributes and methods from another class. Polymorphism uses those
             methods to perform different tasks.
            */


            List<Person> People = new List<Person>();

            Person P1 = new Person();
            P1.Name = "Mohamad";
            P1.Family = "Rezaei";
            P1.Age = 20;
            People.Add(P1);

            Person P2 = new Person();
            P2.Name = "Reza";
            P2.Family = "Dad";
            P2.Age = 20;
            People.Add(P2);

            foreach (Person P in People)
            {
                Console.WriteLine($"Name:{P.Name}  Family:{P.Family}  Age:{P.Age}");
            }
        }
    }
}
