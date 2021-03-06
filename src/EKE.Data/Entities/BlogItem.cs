﻿using EKE.Data.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace EKE.Data.Entities
{
    public class BlogItem : IEntityBase
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public string ShortDescription { get; set; }
        public string MainImageName { get; set; }
        public DateTime DateAdded { get; set; }
        public string Content { get; set; }
        public string Slug { get; set; } 
    }
}
