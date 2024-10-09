// See https://aka.ms/new-console-template for more information

using System;
using ConsoleApp2;

Console.WriteLine("Hello, World!");

Console.WriteLine("What's your astrology sign?");

Console.WriteLine("Type\t\tSize (Bytes)\tMin Value\t\tMax Value");
Console.WriteLine("-------------------------------------------------------------");

// sbyte
Console.WriteLine($"sbyte\t\t{sizeof(sbyte)}\t\t{sbyte.MinValue}\t{sbyte.MaxValue}");
        
// byte
Console.WriteLine($"byte\t\t{sizeof(byte)}\t\t{byte.MinValue}\t\t{byte.MaxValue}");
        
// short
Console.WriteLine($"short\t\t{sizeof(short)}\t\t{short.MinValue}\t{short.MaxValue}");
        
// ushort
Console.WriteLine($"ushort\t\t{sizeof(ushort)}\t\t{ushort.MinValue}\t{ushort.MaxValue}");
        
// int
Console.WriteLine($"int\t\t{sizeof(int)}\t\t{int.MinValue}\t\t{int.MaxValue}");
        
// uint
Console.WriteLine($"uint\t\t{sizeof(uint)}\t\t{uint.MinValue}\t\t{uint.MaxValue}");
        
// long
Console.WriteLine($"long\t\t{sizeof(long)}\t\t{long.MinValue}\t{long.MaxValue}");
        
// ulong
Console.WriteLine($"ulong\t\t{sizeof(ulong)}\t\t{ulong.MinValue}\t{ulong.MaxValue}");
        
// float
Console.WriteLine($"float\t\t{sizeof(float)}\t\t{float.MinValue}\t\t{float.MaxValue}");
        
// double
Console.WriteLine($"double\t\t{sizeof(double)}\t\t{double.MinValue}\t{double.MaxValue}");
        
// decimal
Console.WriteLine($"decimal\t\t{sizeof(decimal)}\t\t{decimal.MinValue}\t{decimal.MaxValue}");



Pyramid py = new Pyramid();
py.pyramid();
Console.WriteLine(new string('-', 50));  // Prints 50 dashes
Fizz fz = new Fizz();

Console.WriteLine(new string('-', 50));  // Prints 50 dashes


DaysOldCalculator DC= new DaysOldCalculator();
DC.DisplayDaysOld();
Console.WriteLine(new string('-', 50));  // Prints 50 dashes
//int max = 500;
//checked
//{
//    for (byte i = 0; i < max; i++)
  //  {
   //     Console.WriteLine(i);
  //  }
//}


Increment i = new Increment();






