/*****************************************************************************
  
 Autor : Sara Alvarez - valeria mosquera 
 Fecha : 2024-05-16
 Descripción : Los avengers necesitan un programa en c# para calcular la fuerza
 necesaria para levantar un objeto en el planeta marte. Completa el espacio
 en blanco para solicitar al usuario la masa del objeto a levantar
 Formula: fuerza= masa * gravedad
*******************************************************************************/
using System;
class program {
  static void Main() {
     Console.WriteLine ("Ingrese la masa del objeto a levantar en kilogramos");
      
      /* VARIABLES */
      double masaObjeto= double.Parse (Console.ReadLine());
      double gravedad = 3.71;
      double  fuerza = masaObjeto * gravedad ;
      Console.WriteLine("la fuerza necesaria para levanatar el objeto es de  aproximadamente " + fuerza
      + "Newton");
      
      
       
     
     
     
     
  
      
  }
  
  
}