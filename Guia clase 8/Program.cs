using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_clase_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new Creator();
            Creator.CreateConection(1).GetConnection();
            Creator.CreateConection(2).GetConnection();
            Creator.CreateConection(3).GetConnection();
            Console.ReadKey();
        }
  
    }
}
