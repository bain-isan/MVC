//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomerManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class CUSTOMER
    {
        public int CustomerId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Name...")]
        [StringLength(49)]
        public string CustomerName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter City...")]
        [StringLength(49, ErrorMessage = "City Length max 49 char...")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter Age...")]
        [Range(0, 150)]
        public Nullable<int> Age { get; set; }

        [Required(ErrorMessage = "Please Enter Phone Number...")]
        public Nullable<long> Phone { get; set; }


        [Required(ErrorMessage = "Please Enter Pincode...")]
        public Nullable<int> PinCode { get; set; }
    }
}
