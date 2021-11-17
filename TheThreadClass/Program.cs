/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;
using System.Threading;

namespace Very_Basic_Multithreading_with_the_Thread_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread01 = new Thread(ThreadStartingPoint);
            myThread01.Start();       // .Net will spawn the thread and call ThreadStartingPoint()

            // We can't use myThread01 again so we'll make more Thread objects
            Thread myThread02 = new Thread(ThreadStartingPoint);
            myThread02.Start();       // .Net will spawn the thread and call ThreadStartingPoint()

            Thread myThread03 = new Thread(ThreadStartingPoint);
            myThread03.Start();       // .Net will spawn the thread and call ThreadStartingPoint()
        }
        /// <summary>
        /// The code our threads will execute
        /// </summary>
        private static void ThreadStartingPoint()
        {
            Console.WriteLine("I am your thread");
            // Do some processing here
        }
    }
}
