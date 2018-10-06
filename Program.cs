using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();

            intList.Add(10);
            intList.Add(98);
            intList.Add(356);
            intList.Add(46);
            intList.Add(3467);

            foreach (int item in intList)
            {
                Console.WriteLine(item);
            }

            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee() { ID = 101, Name = "Robert" });
            empList.Add(new Employee() { ID = 102, Name = "John" });
            empList.Add(new Employee() { ID = 103, Name = "Maria" });

            foreach (Employee item in empList)
            {
                Console.WriteLine(item.ID + "\t" + item.Name);
            }

            Console.ReadKey();
        }
    }
}
