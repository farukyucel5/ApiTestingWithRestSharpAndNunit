using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTestProject1.Model
{
    

        public class Pets
        {
            public long Id { get; set; }
            public Category Category { get; set; }
            public string Name { get; set; }
            public List<string> PhotoUrls { get; set; }
            public List<Category> Tags { get; set; }
            public string Status { get; set; }
        }

       
    

}
