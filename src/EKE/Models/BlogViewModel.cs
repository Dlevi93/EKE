using EKE.Data.Entities;
using EKE.Service.ServiceModel;
using System.Collections.Generic;

namespace EKE.Models
{
    public class BlogViewModel
    {
        public List<BlogItem> Articles { get; set; }
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
        public List<DateFilter> DateFilter { get; set; }
        public int SelectedYear { get; set; }
        public int SelectedMonth { get; set; }
    }
}
