/******************************************************************************
Autor:   Sara Alvarez 
Lenguje  usado :  c#
fecha:  2024-05-22
Descripción: Programa con  decisiones  para 
habilitar votaciones de personas y descuento 
de la matricula de estudio  
*******************************************************************************/
using System;
class programa {
  static void Main() {

  // variable
  int edad;
  int valorMatricula;
 // captura de datos 
 Console.WriteLine ("Digite su edad ");
 edad = Int32.Parse (Console.ReadLine());
 
  Console.WriteLine(" Dgite su valor de matricula");
 valorMatricula = Int32.Parse (Console.ReadLine());
 // validación
 if (edad >=18){
     Console.WriteLine(" felicidadades usted puede vota");
     Console.WriteLine("usted pagara de matricula" + (valorMatricula * 0.85));
 }
 
 
 
    
  }
  
}