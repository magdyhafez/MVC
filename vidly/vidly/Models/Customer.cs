using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class Customer
    {
        [Key]
         public int Id { get; set; }
         public string Name { get; set; }
    }

   
}