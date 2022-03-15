using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME to LINQ of AddressBook");
            bool flag = true;
            DataTableManager dataTableManager = new DataTableManager();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1.Create Data Table\t2.exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    dataTableManager.CreateDataTable();
                    break;
                case 2:
                    flag = false;
                    break;
            }
            Console.ReadLine();
        }
    }
}
