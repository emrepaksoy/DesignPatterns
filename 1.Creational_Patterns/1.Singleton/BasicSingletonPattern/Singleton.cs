using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSingletonPattern
{
    public class Singleton
    {
        public static Singleton Instance;
        private Singleton() { }

        //public static Singleton GetInstance()
        //{
        //    if (Instance == null)
        //        Instance = new Singleton();
        //    return Instance;
        //}


        public static Singleton GetInstance 
        { 
            get { return Instance; }
        }
        static Singleton() 
        { 
            Instance = new Singleton(); 
        }

        public void doSomeThing()
        {
            Console.WriteLine("asd asd");
        }

    }
}
