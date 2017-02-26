using EKE.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EKE.Models
{
    public class RegisterViewModel
    {
        public Photographer Photographer { get; set; }
        public RegisterStatus RegisterStatus { get; set; }
    }
}
