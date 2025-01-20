﻿using System;

class BitwiseOperators {
static void Main(string[] args) {
int a = Convert.ToInt32(Console.ReadLine()); 
int b = Convert.ToInt32(Console.ReadLine());  

Console.WriteLine("a & b: " + (a & b)); 
Console.WriteLine("a | b: " + (a | b));
Console.WriteLine("a ^ b: " + (a ^ b)); 
Console.WriteLine("~a: " + (~a)); 
Console.WriteLine("a << 1: " + (a << 1)); 
Console.WriteLine("a >> 1: " + (a >> 1)); 
}
}