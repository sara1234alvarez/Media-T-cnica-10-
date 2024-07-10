/******************************************************************************
  Nombre: Sara Alvarez 
   Fecha: 10-07-24
 Descripcion: Un cliente solicita una mini app en consola que imprima 
frases de forma aleatoria cada que es ejecutado

*******************************************************************************/
using System;
class MiSegundoVector {
  static void Main() {
   string [] frases = {
       "Nunca digas qie no sabes" ,
       "Aprende de los errores es de sabios",
       "la adversidad hace reconocerte a ti mismo"
   }; 
   
   // aleatorio
   Random aleatorio = new Random(); 
   int posicion = aleatorio.Next(0,2);
   
   // imprdimir frase forma aleatoria 
   Console.WriteLine(frases[posicion]);
  }
}