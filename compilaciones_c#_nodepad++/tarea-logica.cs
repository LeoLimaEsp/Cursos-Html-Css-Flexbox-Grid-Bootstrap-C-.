using System;

namespace MayorMenor{	
			
			public class Program
			{
						public static void Main()
						{
							Console.WriteLine("Ejercicio 1 Cuadro 10 x 10 de asteriscos:");
							
							for(int i=0; i<10; i++)
							{
								Console.WriteLine("**********");
							}

							Console.WriteLine("Fin del ejercicio 1");
							//-------------------------------------------------------------------------------
							
							Console.WriteLine("");
							
							Console.WriteLine("Ejercicio 2 Palabras en orden inverso");
							Console.WriteLine("Por favor escribe tres palabras a continuación:");
							
							string palabra1 = Console.ReadLine();
							string palabra2 = Console.ReadLine();
							string palabra3 = Console.ReadLine();
							
							string palabras = palabra3 + " " + palabra2 + " " + palabra1;
							
							Console.WriteLine("Las palabras ingresadas al revés son: " + palabras);
							
							Console.WriteLine("Fin del ejercicio 2");
							//-------------------------------------------------------------------------------
							
							Console.WriteLine("");
							
							Console.WriteLine("Ejercicio 3 Triangulo o Cuadrado");
							Console.WriteLine("Por favor escribe Triangulo si quieres visualizar un triangulo de * ó Cuadrado para vizualizar un cuadrado de *");
							
							string figura = Console.ReadLine();
							
							if (figura == "triangulo" || figura =="cuadrado")
							{
								if(figura == "triangulo")
								{
									for(int i=0; i<5; i++)
									{
										if(i==0)
											Console.WriteLine("    *");
										if(i==1)
											Console.WriteLine("   ***");
										if(i==2)
											Console.WriteLine("  *****");
										if(i==3)
											Console.WriteLine(" *******");
										if(i==4)
											Console.WriteLine("**********");
									}
								}
								else 
								{
									for(int i=0; i<10; i++)
									{
										Console.WriteLine("**********");
									}
								}
							}	
							else
							{
								Console.WriteLine("Error no escribiste la palabra triangulo o cuadrado");
							}	
							
							Console.WriteLine("Fin del ejercicio 3");
							//---------------------------------------------------------------------
							
							Console.WriteLine("");
							
							Console.WriteLine("Ejercicio 4 operaciones entre dos números");
							
							Console.WriteLine("Escribe dos números a sumar, restar, multiplicar, dividir y obtener su modulo:");
							
							int num1 = Convert.ToInt32(Console.ReadLine());
							int num2 = Convert.ToInt32(Console.ReadLine());
							
							int multiplicacion = num1 * num2;
							int division = num1 / num2;
							int suma = num1 + num2;
							int resta = num1 - num2;
							int modulo = num1 % num2;
							
							Console.WriteLine("Resultados: Suma " + num1 + " + " + num2 + " = " + suma + " Resta: " + num1 + " - " + num2 + " = " + resta + " Multiplicación: " + num1 + " * " + num2 + " = " + multiplicacion + " Division: " + num1 + " / " + num2 + " = " + division + " Módulo: " + num1 + " & " + num2 + " = " + modulo + " ");  
							Console.WriteLine("Fin del ejercicio 4");
							//-----------------------------------------------------------------------
							
							Console.WriteLine("");
							
							Console.WriteLine("Ejercicio 5 Tabla de multiplicar");
							Console.WriteLine("Escribe un número para obtener su tabla de multiplicar");
							
							int num = Convert.ToInt32(Console.ReadLine());
							
							for (int i=1; i<=10; i++)
							{
								Console.WriteLine(num + " X " + i + " = " + num*i);
							}
							
							Console.WriteLine("");
							
							Console.WriteLine("Fin del ejercicio 5");
						}
						
			}
			
}