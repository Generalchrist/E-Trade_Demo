using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete {
    public class Catagory:IEntity {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
