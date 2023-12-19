using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BussinessLogic;



namespace Final_Project.Models
{
    public class ProductModel
    {
        [Required(ErrorMessage = "Please Enter Name")]
        [Display(Name = "Please Enter Name")]
        public string product_name {  get; set; }

        [Required(ErrorMessage = "Please Enter Product ID")]
        [Display(Name = "Please Enter Product ID")]
        public string product_id { get; set;}

        
       
    }
}