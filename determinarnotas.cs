/******************************************************************************

Autor: sara alvarez valencia 
fecha : 30-05-24
descripción:  programa aprendizaje estructura switch
              ejercicico de aprendizaje 
              dada la nota determinar 
              1- pierde
              2- pierde
              3- gana
              4- alto
              5- superior
              
*******************************************************************************/

using System;
class Programa {
   static void Main() {
     Console.WriteLine("digita una opción (1-5");
     Console.Write("opcion");
      int opcion = Int32.Parse(Console.ReadLine());
       switch(opcion) 
            {
          case 1:
               Console.WriteLine(" pierde");
               break;
         case 2:
                Console.WriteLine(" pierde");
                break;
         case 3:
               Console.WriteLine("gana");
                break;
          case 4:
               Console.WriteLine("alto");
               break;
         case 5:
              Console.WriteLine("superior");
              break;
         default:
              Console.WriteLine("opcion no valida");
             Console.WriteLine("saliendo del Programa....");
             break;
           }
       }
   }
