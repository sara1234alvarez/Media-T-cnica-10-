/******************************************************************************
Autor : sara alvarez 
Fecha : 29-05-24
Descripción :
*******
 App menu 
*******
    se solicita crear una minicalculadora que realice:
    - suma
    - resta
    - division 
    debe terminar la ejecutación al usuario elegir opción "salir"

*******************************************************************************/
using System;
using System.Threading;
class HelloWorld {
  static void Main(string[]args) {
   // 1 pantalla beinvenida (imagen ascii)
 Console.WriteLine(".----------------.  ");    
 Console.WriteLine("| .--------------. |");
 Console.WriteLine("| |      _       | |");
 Console.WriteLine("| |     | |      |  ");  
 Console.WriteLine("| |  ___| |___   | |");
 Console.WriteLine("| | |___   ___|  | |");
 Console.WriteLine("| |     | |      | |");
 Console.WriteLine("| |     |_|      | |"); 
 Console.WriteLine("| |              | |");
 Console.WriteLine("| '--------------' |");
 Console.WriteLine("'----------------'  ");
 Console.WriteLine ("Bienvenido a la mini calculadora");
Thread.Sleep(3000); // 3 segundos = 3000 milsegundos
Console.Clear();
   // 2 mosta+rar menu de opciones 
   Console.WriteLine("menu de opciones");
   Console.WriteLine("seleccionar la opcion que deseas");
   Console.WriteLine("1.suma");
    Console.WriteLine("2.resta");
     Console.WriteLine("3.multiplicacion");
   Console.WriteLine("4.division");
   Console.WriteLine("5. Salir");
   // 3 capturar opción 
   Console.Write("digitar la opcion deseado:");
   int opcion = Int32.Parse(Console.ReadLine());
   if (opcion == 5){
       goto salir;
   }
   // captuara los numero elegidos por el usuario
    Console.Write("\ndigitar numero 1: ");
    int numero1 = Int32.Parse(Console.ReadLine());
    Console.Write("\ndigitar numero 2: ");
    int numero2 = Int32.Parse(Console.ReadLine());
//  4 valiar opción eegida 
   if (opcion== 1 ){
        Console.WriteLine ("la suma es:"+ (numero1+numero2));
   }
  
   if (opcion== 2 ){
   Console.WriteLine ("la resta es:"+ (numero1-numero2));
   }
  
   if (opcion== 3 ){
        Console.WriteLine ("la multiplicación es:"+ (numero1*numero2));
   }
  
   if (opcion== 4 ){
       if (numero1 != 0 && numero2 != 0){
            Console.WriteLine ("la division es:"+ (numero1/numero2));
       }  
       
       }   
      
       
       else{
       Console.WriteLine ("no se dividir por cero");
   
       }


  salir:
  Console.WriteLine("saliendo del programa.....");
  
  }
  }
