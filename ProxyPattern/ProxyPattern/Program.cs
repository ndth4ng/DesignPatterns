using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    abstract class Subject
    {
        public abstract void DoSomeWork();
    } 

    class ConcreteSubject : Subject
    {
        public override void DoSomeWork()
        {
            Console.WriteLine("TIen hanh yeu cau");
        }
    }

    class Proxy : Subject
    {
        Subject subject;

        public Proxy()
        {
            subject = null;
        }

        public Proxy(Subject subject)
        {
            this.subject = subject;
        }

        public override void DoSomeWork()
        {
            Console.WriteLine("Hello!");
            if (subject == null)
            {
                subject = new ConcreteSubject();
            }
            subject.DoSomeWork();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************DEMO Proxy********************");
            Subject proxy = new Proxy();
            proxy.DoSomeWork();

            Console.ReadKey();
        }
    }
}
