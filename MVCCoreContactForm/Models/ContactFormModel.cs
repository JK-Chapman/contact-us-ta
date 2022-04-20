using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace MVCCoreContactForm.Models
{
    public class ContactFormModel
    {
        [StringLength(100, MinimumLength = 1)]
        [Required]
        public string firstName { get; set; }

        [StringLength(100, MinimumLength = 1)]
        [Required]
        public string lastName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Required]
        public string email { get; set; }

        [Required]
        public string message { get; set; }

        public void postData()
        {
            using StreamWriter file = new StreamWriter("FormOutput.csv", append: true);
            string data = $"{this.firstName}, {this.lastName}, {this.email}, {this.message}";

            file.WriteLine(data);
        }
    }
}
