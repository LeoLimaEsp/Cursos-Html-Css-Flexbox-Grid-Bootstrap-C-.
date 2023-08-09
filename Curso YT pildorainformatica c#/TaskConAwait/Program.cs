namespace TaskConAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RealizarTodasLasTareas();
            Console.ReadLine();
        }
        //Para usar el método waitAll se necesita guardar los métodos en variable

        static void RealizarTodasLasTareas()
        {
            var tarea1 = Task.Run(() =>
            {
                EjecutarTarea();
            });

            tarea1.Wait(); //Uso de método Wait, hasta que termine la tarea antes de poner el método, se procede a los siguientes.

            var tarea2 = Task.Run(() =>
            {
                EjecutarTarea2();
            });

            //Task.WaitAll(tarea1,tarea2); //Uso de método WaitAll, esperar a los DOS que terminen.
            //Task.WaitAny(tarea1, tarea2); //Uso de método WaitAny, esperar a UNO de los dos que terminen.

            var tarea3 = Task.Run(() =>
            {
                EjecutarTarea3();
            });
            
        }

        static void EjecutarTarea()
        {
            for (int i = 0; i < 5; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(1000);
                Console.WriteLine("Esta vuelta de bucle corresponde a la tarea 1 con el Thread: " + miThread);
            }
        }

        static void EjecutarTarea2()
        {
            for (int i = 0; i < 5; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(500);
                Console.WriteLine("Esta vuelta de bucle corresponde a la tarea 2 con el Thread: " + miThread);
            }
        }

        static void EjecutarTarea3()
        {
            for (int i = 0; i < 5; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(500);
                Console.WriteLine("Esta vuelta de bucle corresponde a la tarea 3 con el Thread: " + miThread);
            }
        }
    }
}