//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductFirstVersion.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ProductId { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public decimal Price { get; set; }
    }
}
