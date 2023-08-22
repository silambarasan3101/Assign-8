using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_8
{
    using System;
    using System.Collections.Generic;

    public partial class Order
    {
        public int OrderId { get; set; }
        public System.DateTime OrderDate { get; set; }
        public short Quantity { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<bool> isShipped { get; set; }
    }
}
