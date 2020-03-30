using System;
using System.Collections.Generic;
using System.Text;
using Semana_1_Sesion_1.Common;
namespace Semana_1_Sesion_1.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Enums.Status Status { get; set; }
    }
}
