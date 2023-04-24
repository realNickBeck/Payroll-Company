using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PayrollCompany.Models
{
    public class TimeOff
    {
        [Required(ErrorMessage = "Please enter the starting date.")]
        public string From { get; set; }

        [Required(ErrorMessage = "Please enter the ending date.")]
        public DateTime? To { get; set; }

        [Required(ErrorMessage = "Please enter the reason.")]
        public string Reason { get; set; }

        [Required(ErrorMessage = "Please select a PTO status.")]
        public string PTO { get; set; }

    }
}
