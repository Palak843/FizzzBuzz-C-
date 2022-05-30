// See https://aka.ms/new-console-template for more information
using System;

namespace FizzBuzz
{
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        FizzBuzz fb = new FizzBuzz();
        fb.DivisableChecker();
    }
}
}

