using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_clase_8
{
    class CountryList
    {
        private static CountryList instance;
        private string[] countryName;
        private static int counter;
        


        private CountryList(string name)
        {
            countryName[counter] = name;
            counter++;
        }
        private CountryList()
        {
        }

        public static CountryList GetInstance()
        {
            if(CountryList.instance == null)
            {
                 CountryList.instance = new CountryList();
            }
            return CountryList.instance;
        }

        public string GetCountry(int id)
        {
            return countryName[id];
        }

        public void GetProvince(int id)
        {
            string name = countryName[id];
            if(name != null)
            {
                Console.WriteLine($"Las provincias de {name} son: ");
                //muestra de pronvincias en proceso
            }
        }
    }
}
