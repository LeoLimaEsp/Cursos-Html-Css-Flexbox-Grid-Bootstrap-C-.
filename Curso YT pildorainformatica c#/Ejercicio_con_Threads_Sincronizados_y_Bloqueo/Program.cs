namespace Ejercicio_con_Threads_Sincronizados_y_Bloqueo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuentaFamilia = new CuentaBancaria(3000);

            //Creación de un array de hilos (15)
            Thread[] hilosPersonas = new Thread[15];

            for (int i = 0; i < 15; i++)
            {
                Thread t = new Thread(cuentaFamilia.VamosRetirarEfectivo);

                t.Name = i.ToString();

                hilosPersonas[i] = t;
            }

            for (int i = 0; i < 15; i++)
            {
                hilosPersonas[i].Start();
                hilosPersonas[i].Join(); //Se estan sincronizando uno por uno

            }
        }
    }

    //Creación de nueva clase
    class CuentaBancaria
    {
        private object bloqueo = new object();
        double Saldo { get; set; }
        public CuentaBancaria(double Saldo) 
        {
            this.Saldo = Saldo;
        }

        public double RetirarEfectivo(double Cantidad)
        {
            if((Saldo - Cantidad) < 0)
            {
                Console.WriteLine( $"Lo siento queda ${Saldo} pesos en la cuenta, Hilo: {Thread.CurrentThread.Name}.");
                return Saldo;
            }

            //lock(bloqueo){
            
                if (Saldo >= Cantidad)
                {
                    Console.WriteLine("Retirado: {0}, queda {1} en la cuenta", Cantidad, (Saldo - Cantidad), Thread.CurrentThread.Name);
                    Saldo = Saldo - Cantidad;
                }

                return Saldo;
            //}
            
        }

        public void VamosRetirarEfectivo()
        {
            Console.WriteLine(  "Esta sacando dinero el thread numero:{0}", Thread.CurrentThread.Name);
            for (int i=0; i<4; i++)
            {
                RetirarEfectivo(500);
            }     
        }
    }

}