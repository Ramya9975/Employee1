using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Employee1
{
   
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        
        public double Salary { get; set; }
        public Boolean Active { get; set; }

        public ArrayList employee = new ArrayList();


        public void create() 
        {
            Console.WriteLine("Enter Your Employee-ID: ");
            Id = int.Parse(Console.ReadLine());
            employee.Add(Id);
            Console.WriteLine("Enter your Employee-Name ");
            Name= Console.ReadLine();
            employee.Add(Name);
            Console.WriteLine("Enter your Employee-DateOfBirth");
            DateOfBirth = DateTime.Parse(Console.ReadLine());
            employee.Add(DateOfBirth);
            Console.WriteLine("Enter your Employee-salary");
            Salary= Double.Parse(Console.ReadLine());
            employee.Add(Salary);
            Console.WriteLine("Enter your status: ");
            Active = Boolean.Parse(Console.ReadLine());
            employee.Add(Active);
           
        }
        public void ViewALL() 
        {
            foreach(object k in employee) 
            {
                Console.WriteLine(k);
            }

        }
        
    }
  
    






}
