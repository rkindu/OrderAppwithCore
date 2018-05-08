using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationApplication.Models
{
    public class OrderModel
    {
        [Display(Name="Customer Name")]
        public string FirstName { get; set; }

        [Display(Name = "Base Filling")]
        public int BaseFillingId { get; set; }

        public List<SelectListItem> BaseFilling { get; } = new List<SelectListItem> {
             new SelectListItem{Value = "1", Text= "Pie"},
             new SelectListItem{Value ="2", Text="Fruit"},
             new SelectListItem{Value = "3", Text ="Granola"}
        };

        
        [Display(Name = "Cream")]
        public string CreamTypeString { get; set; }


        public List<string> CreamType { get; } = new List<string> {
             "Cream",
             "Ice",
            "Yogurt"
        };
        
        //[Display(Name = "Topping")]
        //public string Topping { get; set; }



    }
}
