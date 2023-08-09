using System;

namespace MayorMenor{	
			
			public class Program
			{
						public static void Main()
						{
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
						}
						
			}
			
}