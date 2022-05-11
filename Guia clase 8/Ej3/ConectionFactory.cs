using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_clase_8
{
    public class Creator
    { 
        public static ConnectionFactory CreateConection(int num)
        {
            switch (num)
            {
                case 1:
                    {
                        
                        return new ConexionMysql();
                        break;
                    }                 
                case 2:
                    {
                        return new ConexionSQL();
                        break;
                    }
                   
                case 3:
                    {
                        return new ConexionOracle();
                        break;
                    }
            }
            return new ConexionMysql();
        }
        
    }
    public abstract class ConnectionFactory
    {
        public abstract void GetConnection();
    }   
    public class ConexionSQL : ConnectionFactory
    {
        public override void GetConnection()
        {
            Console.WriteLine("Conectando con la clase SQL");
        }
    }
    public class ConexionMysql : ConnectionFactory
    {
        public override void GetConnection()
        {
            Console.WriteLine("Conectando con la clase Mysql");
        }
    }
    public class ConexionOracle : ConnectionFactory
    {
        public override void GetConnection()
        {
            Console.WriteLine("Conectando con la clase Oracle");
        }
    }
}
