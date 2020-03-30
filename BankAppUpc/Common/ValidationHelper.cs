using System;
using System.Collections.Generic;
using System.Text;

namespace Semana_1_Sesion_1.Common
{
    class ValidationHelper
    {
        public static bool ProductPendingOrDisabled(Enums.Status status)
        {
            var statusList = new List<Enums.Status>();

            statusList.Add(Enums.Status.Disabled);
            statusList.Add(Enums.Status.Disabled);

            return statusList.Contains(status);
        }
    }
}
