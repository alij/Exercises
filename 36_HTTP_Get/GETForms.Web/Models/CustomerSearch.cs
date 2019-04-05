using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.Models
{
    public class CustomerSearch
    {
        public string Name { get; set; }

        public string SortMethod { get; set; }

        public static List<SelectListItem> SortOptions = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "last_name" },
            new SelectListItem() { Text = "email" },
            new SelectListItem() { Text = "active" }
        };

    }
}
