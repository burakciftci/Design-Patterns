﻿using System;
using AbstractFactoryDesingPattern.Interface;
using AbstractFactoryDesingPattern.Model;

namespace AbstractFactoryDesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new ConcreteFactory2());


        }
        public static void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productA.UsefulFunctionA());
            Console.WriteLine(productB.UsefulFunctionB());
            
        }
    }
}
