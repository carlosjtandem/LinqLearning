using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibary
{
    public class ListManager
    {

        public static List<Person> loadSampleData()
        {

            List<Person> listadoPersonas = new List<Person>();

            listadoPersonas.Add(new Person { FirstName = "Carlos", LastaName = "Aucancela", YearsOfExpericience = 10, Birthday = Convert.ToDateTime("07/04/1986") });
            listadoPersonas.Add(new Person { FirstName = "Juan", LastaName = "Lopez", YearsOfExpericience = 5, Birthday = Convert.ToDateTime("07/04/1986") });
            listadoPersonas.Add(new Person { FirstName = "Peter", LastaName = "Hernandez", YearsOfExpericience = 4, Birthday = Convert.ToDateTime("07/02/1996") });
            listadoPersonas.Add(new Person { FirstName = "Jhon", LastaName = "Smith", YearsOfExpericience = 3, Birthday = Convert.ToDateTime("07/03/1995") });
            listadoPersonas.Add(new Person { FirstName = "Sara", LastaName = "Lopez", YearsOfExpericience = 6, Birthday = Convert.ToDateTime("07/04/1988") });
            listadoPersonas.Add(new Person { FirstName = "Steve", LastaName = "Smith", YearsOfExpericience = 10, Birthday = Convert.ToDateTime("07/05/1992") });
            listadoPersonas.Add(new Person { FirstName = "Luois", LastaName = "MEndez", YearsOfExpericience = 8, Birthday = Convert.ToDateTime("07/08/1980") });

            return listadoPersonas;

        }

    }
}
