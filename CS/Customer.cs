using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGridLookUpEditCSV {
    public class Customer {
        public Customer() {
            this.ID = 0;
            this.Name = "";
            this.Info = "";
        }

        public Customer(int id, string name, string info) {
            this.ID = id;
            this.Name = name;
            this.Info = info;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
    }
}
