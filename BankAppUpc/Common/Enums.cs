using System;
using System.Collections.Generic;
using System.Text;

namespace Semana_1_Sesion_1.Common
{
    public static class Enums
    {
        public enum Status
        {
            Pending, Disabled, Approved
        }
        public enum OrderStatus
        {
            Pending,
            Approved,
            Canceled,
            Rejected
        }
    }
}
