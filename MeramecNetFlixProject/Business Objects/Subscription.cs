using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeramecNetFlixProject.Business_Objects
{
    class Subscription
    {
        public Subscription(int id, string name, float cost)
        {
            Id = id;
            Name = name;
            Cost = cost;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public float Cost { get; set; }
    }
}
