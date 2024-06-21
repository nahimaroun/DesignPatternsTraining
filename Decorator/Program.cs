﻿namespace FactoryDesignPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a pc type:");
            Console.WriteLine("'High-end'/'Middle-end'/'Low-end'");
            string Input = Console.ReadLine();
            IComputer Type = ComputerFactory.GetComputer(Input);
            Console.WriteLine("This is a " + Type.PCType());
            Console.WriteLine("It has this " + Type.GPU() + " GPU.");
        }
    }
}
