using System;

namespace MayorMenor{	
			
			public class Program
			{
						public static void Main()
						{
							Console.WriteLine("Ingrese un número:");
							int numero = Convert.ToInt32(Console.ReadLine());
							Console.WriteLine("Los números del 1 al {0} son: ", numero); 
							
							for (int i=1; i<= numero; i++)
							{						
								Console.WriteLine(i);
							}
							
							Console.WriteLine("Fin del ejercicio 1");
							
							//-----------------------------------------------------------------
							Console.WriteLine("");
							Console.WriteLine("Inicia ejercicio 2");
							
							Console.WriteLine("Ingrese un número:");
							int digito = Convert.ToInt32(Console.ReadLine());
							
							Console.WriteLine("Los Multiplos de 3 del 0 al {0} son:" , digito);
							
							for(int i=3; i<=digito; i+=3)
							{
								Console.WriteLine(i);
							}
							
							Console.WriteLine("Fin del ejercicio 2");
							
							//------------------------------------------------------------------
							Console.WriteLine("");
							Console.WriteLine("Inicia ejercicio 3");
							
							Console.WriteLine("Ingrese un número");
							int num = Convert.ToInt32(Console.ReadLine());
			
			                for(int i=1; i<=num; i++)
							{
								if(num%i == 0)
								{ 
									Console.WriteLine("El número: {0} es divisor de: {1} ", i, num);						
								}
							}
							
							Console.WriteLine("Fin del ejercicio 3");
							
							//--------------------------------------------------------------------
							Console.WriteLine("");
							Console.WriteLine("Inicia ejercicio 4");
							
							Console.WriteLine("Ingrese un número");
							int x = Convert.ToInt32(Console.ReadLine());
							Console.WriteLine("Los números impares de 1 al {0} son:", x);
			
			                for(int i=1; i<=x; i++)
							{
								if(i%2 != 0)
								{ 
									Console.WriteLine(i);						
								}
							}
							
							Console.WriteLine("Fin del ejercicio 4");
							
							//----------------------------------------------------------------------
							Console.WriteLine("");
							Console.WriteLine("Inicia ejercicio 5");
							
							Console.WriteLine("Ingrese un número");
							int n = Convert.ToInt32(Console.ReadLine());
							int pares = 0;
							int impares = 0;
							
							for(int i=1; i<=n; i++)
							{
								if(i%2 != 0)
								{ 
									impares = impares + i;
								}
							}
							Console.WriteLine("La suma de números impares de 0 a {0} es: {1}", n, impares);
							
							for(int i=1; i<=n; i++)
							{
								if(i%2 == 0)
								{ 
									pares = pares + i;
								}
							}
							Console.WriteLine("La suma de números pares de 0 a {0} es: {1}", n, pares);
     						Console.WriteLine("Fin del ejercicio 5");
							
							//---------------------------------------------------------------------------
							Console.WriteLine("");
							Console.WriteLine("Inicia ejercicio 6");
							
							Console.WriteLine("Ingrese un número para obtener su factorial");
							int number = Convert.ToInt32(Console.ReadLine());
							int acumulador = 1;
							
							for(int i=1; i<=number; i++)
							{
								acumulador = acumulador * i;
							}			

							Console.WriteLine("{0}!={1}", number,acumulador);
							
							Console.WriteLine("Fin del ejercicio 6");
		
						}
						
			}
			
}