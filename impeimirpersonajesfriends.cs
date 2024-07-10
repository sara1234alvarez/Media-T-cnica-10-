/*
    Autor: Sara Alvarez
    Fecha : 10-07-24
    Descripcion : Los personajes de Friends están 
    organizando un evento y necesitan 
    un programa en C# para imprimir 
    los nombres de los asistentes. 
    Chandler, Joey, Monica, Rachel, Ross, Phoebe
*/
using System;
class MiPrimerVector {
  static void Main() {
         
    
         // declaracion y asidnacion de vector y asignacion de vector dinamico 
       string[] personajes = { "chandler", " joey", " monica" ," rechel","ross" , "phoebe"};
       
          /*imprimir un dato del vector de manera dinamica 
          recorrer imprimiendo el  vector */
          
          for ( int p = 0; p < 6; p++){
              Console.WriteLine(personajes[p]);
          }
        
  }
}