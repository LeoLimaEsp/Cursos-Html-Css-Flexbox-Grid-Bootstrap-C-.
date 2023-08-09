using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace TaskIRun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Creación de tarea 1
            Task tarea = new Task(EjecutarTraea);
            tarea.Start();*/

            //Creación de tarea 1 con método RUN indicando .start en conjunto
            Task tarea = Task.Run(() =>  EjecutarTarea());

            //Creación de tarea 2 indicando que comience al finalizar la tarea 1
            Task tarea2 = tarea.ContinueWith(EjecutarOtraTarea);


            /*Creación de tarea 2
            //Forma simplificada con lambda de asignar tarea a la Task
            Task tarea2 = new Task(() =>
            {
                for(int j=0; j<10; j++)
                {
                    var miThread = Thread.CurrentThread.ManagedThreadId;
                    Thread.Sleep(1000);
                    Console.WriteLine("Esta vuelta de bucle corresponde al thread: " + miThread + "Ejecutandose desde el main");
                }
            });
            tarea2.Start();*/

            Console.ReadLine();
        }


        static void EjecutarTarea()
        {
            for(int i = 0; i < 10; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(1000);
                Console.WriteLine("Esta vuelta de bucle corresponde al thread: " + miThread);
            }
        }

        static void EjecutarOtraTarea(Task obj)
        {
            for (int i = 0; i < 10; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(1000);
                Console.WriteLine("Esta es otra tarea y corresponde al thread: " + miThread);
            }
        }

    }
}