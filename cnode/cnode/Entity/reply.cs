using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnode.Entity
{
   public class reply
    {
       public author author { get; set; }
       public string id { get; set; }
       public string content { get; set; }

       public string create_at { get; set; }

       //public Array ups { get; set; }

    }
}
