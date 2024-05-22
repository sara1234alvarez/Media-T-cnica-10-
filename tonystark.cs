/******************************************************************************
Autor:   Sara Alvarez 
Lenguje  usado :  c#
fecha:  2024-05-22
Descripción: Tony stark, Iron man. quiere saber cuanto dinero debe tener 
     para comprar X tornillos c/u a 300$, pero en la tienda le dan descuentos 
     segun la cantidad comprada.
     crear un algoritmo que ayude a calcular si compra:
     1 sin descuento 
     5 descuento dl 30%
     10 descuento del 50%
*******************************************************************************/
using System;
class programaDescueto {
  static void Main() {

  // variable
  int cantidadDetornillo;
  int  valorTornillo;
 // petición de datos 
 Console.WriteLine (" Digite la cantida del tornillo ");
 cantidadDetornillo = Int32.Parse (Console.ReadLine());
 valorTornillo = 300;
 //validación
   if (cantidadDetornillo >= 5){
      
     Console.WriteLine("el valor del tornillo es:" + (valorTornillo *0.70 ));
     
     // petición de datos 
 Console.WriteLine (" Digite la cantida del tornillo ");
 cantidadDetornillo = Int32.Parse (Console.ReadLine());
 valorTornillo = 300;
 //validación
   if (cantidadDetornillo >= 10){
      
        Console.WriteLine("el valor del tornillo es:" + (valorTornillo *0.50 ));
      Console.WriteLine("el valor del tornillo es:" + (valorTornillo *0.50 * cantidadDetornillo ));
     
 }
  
   
   
 
   }    
       
    
    
    


      
 }
 
 
 
    
  }
  
