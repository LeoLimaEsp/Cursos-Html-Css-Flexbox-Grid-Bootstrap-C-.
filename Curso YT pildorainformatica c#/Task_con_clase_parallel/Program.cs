namespace Task_con_clase_parallel
{
    internal class Program
    {
        private static int acumulador = 0;

        static void Main(string[] args)
        {
            /*for(int i=0; i<10; i++)
            {
                RealizarTarea(i);
                Console.WriteLine($"Acomulador vale {acumulador}. Tarea realizada por el hilo {Thread.CurrentThread.ManagedThreadId}");
            }*/

            //Uso de clase PARALLEL para creación de varias task sin usar el método run.
            Parallel.For(0, 100, dato =>
            {
                Console.WriteLine($"Acomulador vale {acumulador}. Tarea realizada por el hilo {Thread.CurrentThread.ManagedThreadId}");
                if ((acumulador % 2) == 0)
                {
                    acumulador += dato;
                    Thread.Sleep(100);
                }
                else
                {
                    acumulador -= dato;
                    Thread.Sleep(100);
                }
            }); //Varios hilos realicen el mismo método a la misma vez.
        }


        //Aqui se comento el método RealizarTarea porque se puso en la expresión lambda
        /*static void RealizarTarea(int dato)
        {
            Console.WriteLine($"Acomulador vale {acumulador}. Tarea realizada por el hilo {Thread.CurrentThread.ManagedThreadId}");
            if ((acumulador % 2) == 0)
            {
                acumulador += dato;
                Thread.Sleep(100);
            }
            else
            {
                acumulador -= dato;
                Thread.Sleep(100);
            }
        }*/
    }
}