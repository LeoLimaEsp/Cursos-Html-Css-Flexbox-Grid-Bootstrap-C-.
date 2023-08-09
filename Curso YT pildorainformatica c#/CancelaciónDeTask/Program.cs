using System;

namespace CancelaciónDeTask
{
    internal class Program
    {
        static int acumulador = 0;
        static void Main(string[] args)
        {
            //Creación del cancelador de tarea
            CancellationTokenSource miToken = new CancellationTokenSource(); //Señalador
            CancellationToken cancelaToken = miToken.Token; //cancelador de tarea

            Task tarea = Task.Run(() => RealizarTarea(cancelaToken));

            for(int i = 0; i < 100; i++)
            {
                acumulador += 30;

                Thread.Sleep(1000);
                if (acumulador > 100)
                {
                    miToken.Cancel();//Asi se cancela una tarea con el señalador,se cancela la tarea RealizarTarea
                    break; //Para que salga del ciclo despues d
                }
            }
            Thread.Sleep(1000);
            Console.WriteLine(  "Valor del acomulador al cancelar la tarea:" + acumulador);

            Console.ReadLine();
        }

        static void RealizarTarea(CancellationToken Token) //Tiene parametro que indica que recibira de tipo cancellationToken
        {
            for(int i=0; i<100; i++)
            {
                acumulador++;

                var miThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(1000);
                Console.WriteLine( "Ejecutando tarea del thread número:" + miThread);
                Console.WriteLine(acumulador);

                if (Token.IsCancellationRequested)
                {
                    acumulador = 0; //Con esto al cancelar la tarea se resetea todo.
                    return;
                }

            }
        }
    }
}