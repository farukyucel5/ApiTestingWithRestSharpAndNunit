using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTestProject1.Model
{

    public class GetStore
    {

        public int id { get; set; }
        public int petId { get; set; }
        public int quantity { get; set; }
        public string status { get; set; }
        public bool complete { get; set; }
    }

}
