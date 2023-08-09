using System.Threading;

namespace Threads_Pool
{
    internal class Program
    {//Uso de threads que realicen diversas tareas, cuando un thread termine una tarea, este toma otra. 
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                /*Thread t = new Thread(EjecutarTares);
                t.Start(); Esto hace las tareas pero no hay control, empiezan varias sin esperar que vayan terminado comienzan otras.*/

                ThreadPool.QueueUserWorkItem(EjecutarTarea, i);
                //ThreadPool.QueueUserWorkItem: Manejo de tareas, inicia y termina un Thread y este mismo puede comenzar a realizar otra tarea. 
            }

            Console.ReadLine();
        }

        static void EjecutarTarea(Object o)
        {
            int vuelta = (int)o;

            Console.WriteLine($"Thread No: {Thread.CurrentThread.ManagedThreadId} ha comenzado su tarea No:" + vuelta);
            Thread.Sleep( 1000 );
            Console.WriteLine($"Thread No: {Thread.CurrentThread.ManagedThreadId} ha terminado su tarea No:" + vuelta);
        }
    }
}