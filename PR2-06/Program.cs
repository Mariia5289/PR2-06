﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PR2_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // путешественник
            Driver driver = new Driver();
            // машина
            Auto auto = new Auto();
            // отправляемся в путешествие
            driver.Travel(auto);
            // встретились пески, надо использовать верблюда
            Camel camel = new Camel();
            // используем адаптер
            ITransport camelTransport = new CamelToTransportAdapter(camel);
            // продолжаем путь по пескам пустыни
            driver.Travel(camelTransport);

            Console.Read();

        }
        
    }
}
