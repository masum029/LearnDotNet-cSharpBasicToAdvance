﻿
using System;

namespace cSharpBasicToAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            Verbatim vb= new Verbatim();
        }
    }

    public class Verbatim
    {
        public Verbatim()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Write Your Name:");
            string userName = Console.ReadLine();
            string Verbatim = @"Verbatim Literal is a string with an @ symbol prefix, as in @“Hello”. Verbatim literals make escape sequences translate as normal printable characters to enhance readability.";
            Console.WriteLine("My Name is " + userName);
            Console.WriteLine(Verbatim);
        }
    }
}
