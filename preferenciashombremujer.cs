/******************************************************************************

Autor : sara alvarez 
Fecha : 29-05-24
Descripción : Ejercicio estructura de decisión múltiple
Se desea un programa que ayude diciendo 
las preferencias según el género:
- Si es un hombre menor de edad sus preferencias son:
    Figuras de acción, Caricaturas, Series TV
- Si es un hombre mayor de edad sus preferencias son:
    cine, picnic y filantropía
- Si es una mujer menor de edad sus preferencias son:
    Muñecas, Maquillaje, Series TV
- Si es una mujer mayor de edad sus preferencias son:
    Maquillaje, Series TV, Cine, filantropía


*******************************************************************************/
using System;
class HelloWorld {
 static void Main(string[]args)  {
    Console.WriteLine("Hello World");
    
     Console.WriteLine("genero");
   Console.WriteLine("digite la opción qie deseas");
   Console.WriteLine(" 1.mujer");
    Console.WriteLine("2.hombre");
    
     Console.Write("digitar la opcion deseado:");
    genero = Int32.Parse(Console.ReadLine());
  Console.Write("Escribe la edad en numeros");
  int edad = Int32.Parse(Console.ReadLine());
      
     
   
    if (genero == "hombre"){
    
        if (edad < 18  ){
          Console.WriteLine(" sus preferencias son: Figuras de acción, Caricaturas, Series TV");
       }
       
   }
   
 }
}
   