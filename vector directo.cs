/*
    son variables para almacenar múltiples datos
*/
using System;
class MiPrimerVector {
  static void Main() {
         
    
         // declaracion y asidnacion de vector 
       string [] nombre2 = { " sara" , " valeria" , "esteban"};
       
        // imprimir un dato del vector de manera directa 
          Console.WriteLine (nombre2[1]);
          
        /*imprimir un dato del vector de manera dinamica 
          recorrer imprimiendo el  vector */
        for ( int i= 0; i <= 3; i++){
            Console.WriteLine (nombre2[i]);
          
        }
  }
}