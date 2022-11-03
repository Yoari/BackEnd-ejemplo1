using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd_ejemplo1.Models
{
    public class Garaje:List<Coches>
    {
        public Garaje()
        {
            this.Add(new Coches("1", "Tesla", "Roadster", "Elon Musk"));

            this.Add(new Coches("2", "Toyota", "Yaris", "Domingo Garcia"));

            this.Add(new Coches("3", "Honda", "Civic", "Juan Antonio"));

            this.Add(new Coches("4", "Ferrari", "F48", "Roberto Cardiel"));
        }
    }
}