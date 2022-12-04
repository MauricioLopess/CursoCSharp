using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEnumEConst.ex03.Entities.Enums
{
    internal enum OrderStatus : int
    {
        PendingPayment, Processing, Shipped, Delivered
    }
}
