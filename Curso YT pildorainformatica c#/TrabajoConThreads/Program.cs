using System.Threading;

namespace TrabajoConThreads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(MétodoSaludo);
            t.Start();
            //Sincronización de hilo o Thread
            t.Join();

            Thread t2 = new Thread(MétodoSaludo);
            t2.Start();
            t2.Join();

            Console.WriteLine("Hola desde el thread 1");
            Thread.Sleep(1000);
            Console.WriteLine("Hola desde el thread 1");
            Thread.Sleep(1000);
            Console.WriteLine("Hola desde el thread 1");
            Thread.Sleep(1000);
            Console.WriteLine("Hola desde el thread 1");
            Thread.Sleep(1000);
            Console.WriteLine("Hola desde el thread 1");
        }

        static void MétodoSaludo()
        {
            Console.WriteLine("Hola desde el thread 2");
            Thread.Sleep(1000);
            Console.WriteLine("Hola desde el thread 2");
            Thread.Sleep(1000);
            Console.WriteLine("Hola desde el thread 2");
            Thread.Sleep(1000);
            Console.WriteLine("Hola desde el thread 2");
            Thread.Sleep(1000);
        }













    }
}