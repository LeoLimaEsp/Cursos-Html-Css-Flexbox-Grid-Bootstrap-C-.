using System;

namespace MayorMenor{	
			
			public class Program
			{
						public static void Main()
						{
							
							Console.WriteLine("Inicio ejercicio 1");
							Console.WriteLine("Por favor ingrese dos números a comparar:");
									
									int primero = Convert.ToInt32(Console.ReadLine());
									int segundo = Convert.ToInt32(Console.ReadLine());
									
									if (primero > segundo)
									{Console.WriteLine(segundo + " es menor, " + primero + " es el mayor.");}
								
									else if (segundo > primero)
									{Console.WriteLine(primero + " es menor, " + segundo + " es el mayor.");}
								    
									else if (primero == segundo)
									{Console.WriteLine("Los dos números son iguales.");}
								
							Console.WriteLine("Fin ejercicio 1");
							
							//-------------------------------------------------------------
							Console.WriteLine("");
							Console.WriteLine("Inicio ejercicio 2");
							
							Console.WriteLine("Por favor ingrese dos números a dividir, siendo el primer número el dividendo y el segundo el divisor:");
									
									int dividendo = Convert.ToInt32(Console.ReadLine());
									int divisor = Convert.ToInt32(Console.ReadLine());
									
									if (divisor != 0)
										{
											Console.WriteLine("El resultado es: " + dividendo/divisor);
									    }
								    else {Console.WriteLine("Error, el divisor no puede ser 0");}	
							Console.WriteLine("Fin del ejercicio 2");	
							
							//---------------------------------------------------------------
							Console.WriteLine("");
							Console.WriteLine("Inicio ejercicio 3");
							
							Console.WriteLine("Por favor ingrese tres números:");
									
									int a = Convert.ToInt32( Console.ReadLine() );
			                        int b = Convert.ToInt32( Console.ReadLine() );
			                        int c = Convert.ToInt32( Console.ReadLine() );
									
									if( a > b && a > c ){ 
												if( b > c ) 
													Console.WriteLine("El orden de mayor a menor es: " + a + "-" + b + "-" + c); 			
			                                    }
									if( a > b && a > c ){ 
												if( c >= b ) 
													Console.WriteLine("El orden de mayor a menor es: " + a + "-" + c + "-" + b); 			
			                                    }
									if( b > a && b > c ){ 
												if( a > c ) 
													Console.WriteLine("El orden de mayor a menor es: " + b + "-" + a + "-" + c); 			
			                                    }
									if( b > a && b > c ){ 
												if( c > a ) 
													Console.WriteLine("El orden de mayor a menor es: " + b + "-" + c + "-" + a); 			
			                                    }
									if( c > b && c > a ){ 
												if( a > b ) 
													Console.WriteLine("El orden de mayor a menor es: " + c + "-" + a + "-" + b); 			
			                                    }
									if( c > b && c > a ){ 
												if( b > a ) 
													Console.WriteLine("El orden de mayor a menor es: " + c + "-" + b + "-" + a); 			
			                                    }
									if( a == b && a == c ){
                                                Console.WriteLine("Los tres números son iguales: " + c + "-" + b + "-" + a);	
									            }
									if( a == b && b > c){
										        Console.WriteLine("El orden de mayor a menor es: " + a + "-" + b + "-" + c);
									            }
									if( a == b && b < c){
										        Console.WriteLine("El orden de mayor a menor es: " + c + "-" + b + "-" + a);
									            }
								    if( a == c && c > b){
										        Console.WriteLine("El orden de mayor a menor es: " + a + "-" + c + "-" + b);
									            }
									if( a == c && c < b){
										        Console.WriteLine("El orden de mayor a menor es: " + b + "-" + c + "-" + a);
									            }
								    if( c == b && b > a){
										        Console.WriteLine("El orden de mayor a menor es: " + c + "-" + b + "-" + a);
									            }
									if( c == b && b < a){
										        Console.WriteLine("El orden de mayor a menor es: " + a + "-" + b + "-" + c);		
									            }
							
							Console.WriteLine("Fin ejercicio 3");
								
							//--------------------------------------------------------------
							Console.WriteLine("");
							Console.WriteLine("Inicio ejercicio 4");
							
							Console.WriteLine("Introduce un número del 1 al 7");
							
							int option = Convert.ToInt32(Console.ReadLine());
							
							if(option == 1)
								Console.WriteLine("Lunes");
							else if( option == 2)
									Console.WriteLine("Martes");
							else if(option == 3)
									Console.WriteLine("Miercoles");
							else if(option == 4)
									Console.WriteLine("Jueves");
							else if( option == 5)
									Console.WriteLine("Viernes");
							else if(option == 6)
									Console.WriteLine("Sabado");
							else if(option == 7)
								Console.WriteLine("Domingo");
							else Console.WriteLine("Valor no valido.");
							
							Console.WriteLine("Fin ejercicio 4");
							//---------------------------------------------------------------
							Console.WriteLine("");
							Console.WriteLine("Inicio ejercicio 5");
							
							
							Console.WriteLine("Introduce un número");
							
							int numero = Convert.ToInt32(Console.ReadLine());
							
							if(numero >= 1)
								Console.WriteLine("Número positivo.");
							else if(numero == 0)
						            Console.WriteLine("El número ingresado es cero.");
							else if(numero < 0)
									Console.WriteLine("Número negativo");
							else Console.WriteLine("No valido.");
							
							Console.WriteLine("Fin ejercicio 5");
							//--------------------------------------------------------------
							Console.WriteLine("");
							Console.WriteLine("Inicio ejercicio 6");
							Console.WriteLine("Introduce tres números:");
							
							int n1 = Convert.ToInt32(Console.ReadLine());
							int n2 = Convert.ToInt32(Console.ReadLine());
							int n3 = Convert.ToInt32(Console.ReadLine());
							
							if (n1 >= n2 && n1>= n3)
								if(n2 + n3 <= n1) 
								Console.WriteLine("No se puede formar un triangulo");
							if (n2 >= n1 && n2>= n3)
								if(n1 + n3 <= n2)
								Console.WriteLine("No se puede formar un triangulo");
							if (n3 >= n2 && n3>= n1)
								if(n2 + n1 <= n3)
								Console.WriteLine("No se puede formar un triangulo");
							if (n1 > n2 && n1> n3)
								if(n2 + n3 > n1) 
								Console.WriteLine("Se puede formar un triangulo");
							if (n2 > n1 && n2> n3)
								if(n1 + n3 > n2)
								Console.WriteLine("Se puede formar un triangulo");
							if (n3 > n2 && n3> n1)
								if(n2 + n1 > n3)
								Console.WriteLine("Se puede formar un triangulo");
							if(n1 == n2)
								if(n1 + n2 > n3)
									Console.WriteLine("Se puede formar un triangulo");
							if(n1 == n3)
								if(n1 + n3 > n2)
									Console.WriteLine("Se puede formar un triangulo");
							if(n2 == n3)
								if(n2 + n3 > n1)
									Console.WriteLine("Se puede formar un triangulo");
								
							Console.WriteLine("Fin del ejercicio 6");
						}
						
			}
			
}