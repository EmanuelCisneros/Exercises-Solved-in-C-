using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
 {
     static void Main(string[] args)
 {
     byte CAN, K;
     int MAY, MEN, NUM;
     string linea;
     Console.Write("LÍMITE:"); linea = Console.ReadLine();
     CAN = byte.Parse(linea);
     Console.Write("DIGITE UN NÚMERO:"); linea = Console.ReadLine();
     MAY = int.Parse(linea);
     MEN = MAY;
 
 for (K = 2; K <= CAN; K++)
 {
     Console.Write("DIGITE UN NÚMERO:"); linea = Console.ReadLine();
     NUM = int.Parse(linea);
     if (NUM > MAY) MAY = NUM;
     if (NUM < MEN) MEN = NUM;
 }
 Console.WriteLine("EL MAYOR ES : " + MAY);
 Console.WriteLine("EL MENOR ES : " + MEN);
 Console.WriteLine("DIFERENCIA ES : " + (MAY - MEN));
 Console.Write("Pulse una Tecla:"); Console.ReadLine();
 }
 }
}
