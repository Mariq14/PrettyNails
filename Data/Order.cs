using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PettyNails.Data
{
    public class Order
    {
        public int Id{ get; set; }


        public int ProductId { get; set; }
        public virtual Articul Articuls { get; set; }


        public int UserId { get; set; }
        public virtual User Users { get; set; }


        public DateTime OrderedOn { get; set; }

    }
}
