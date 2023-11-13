using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Ex2._2
{
    public abstract class Product
    {
        public string Name { get; set; }
        public int Price { get; protected set; }
    }
}
