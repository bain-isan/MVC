//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusDetails.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using BusDetails.Models.Validations;
    
    public partial class BusInfo
    {
        [Key]
        public int BusID { get; set; }

        [Required]
        [BoardingPointValidation]
        public string BoardingPoint { get; set; }

        [Required]
        public Nullable<System.DateTime> TravelDate { get; set; }

        [Required]
        [Range(200.5, 345.35)]
        public Nullable<decimal> Amount { get; set; }

        [Required]
        [Range(1, 5)]
        public Nullable<int> Rating { get; set; }
    }
}