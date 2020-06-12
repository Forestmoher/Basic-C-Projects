using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarConstructorChain
{
    public class Customer
    {
        public Customer(string name) : this(name, 1)
        {

        }
        public Customer(string name, int beginningCredits)
        {
            Name = name;
            songCredits = beginningCredits;
        }
       

        public string Name { get; set; }
        public int songCredits { get; set; }
    }
    
}
