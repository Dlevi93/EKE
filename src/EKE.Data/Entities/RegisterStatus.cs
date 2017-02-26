using EKE.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EKE.Data.Entities
{
    public class RegisterStatus : IEntityBase
    {
        public int Id { get; set; }
        public bool Inactive { get; set; }
        public string Message { get; set; }
    }
}
