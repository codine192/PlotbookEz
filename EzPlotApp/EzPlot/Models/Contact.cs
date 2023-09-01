using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzPlot.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? FullName => $"{FirstName} {LastName}";
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? FullAddress => $"{Address} \n{City} ,{State} {ZipCode}";
        public string? FullContact => $"{FullName} \n{Email} \n{Phone} \n{FullAddress}";
        public string? MailingAddress => $"{FullName} \n{Address} \n{City} ,{State} {ZipCode}";

    }
}
