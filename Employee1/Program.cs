﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            
            emp.create();
            Console.WriteLine();
            emp.ViewALL();
            Console.ReadLine();
         
        }

        
    }
}
