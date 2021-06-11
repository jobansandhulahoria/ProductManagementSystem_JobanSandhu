using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementSystem_JobanSandhu.Buzz
{
    public class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public List<ProductManager> ProductManagers { get; set; }
    }
}
