/******************************************************************************
Autor:   Sara Alvarez 
Lenguje  usado :  c#
fecha:  2024-05-22
Descripción: 
*******************************************************************************/
using System;
class programaDescueto {
  static void Main() {

  // variable
  double calificacion1, calificacion2, calificacion3, calificacion4;
  
  
 // petición de datos 
 Console.WriteLine ("ingrese su nota");
 calificacion1= Convert.ToDouble(Console.ReadLine());

 Console.WriteLine ("ingrese su nota");
 calificacion2 =  Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("ingrese su nota");
 calificacion3 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine ("ingrese su nota");
 calificacion4 = Convert.ToDouble(Console.ReadLine());

double Promedio = (calificacion1 + calificacion2 + calificacion3 + calificacion4) / 4;

if(Promedio<=2.9){
          Console.WriteLine("PERDIO");
      }  
      
      
      if(Promedio>=3.0){

            Console.WriteLine("gano"  );    
          }
        
      
      if(Promedio>=4.5){
          Console.WriteLine("felicidades ganaste una beca ");
      } 
      
  }
}
