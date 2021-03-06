﻿using EKE.Data.Entities.Base;
using System.Collections.Generic;

namespace EKE.Data.Entities
{
    public class WorkShop : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public virtual ICollection<Photographer> Photographers { get; set; }
    }
}
