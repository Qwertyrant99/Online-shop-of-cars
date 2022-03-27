using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SklepInternetowy.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Wprowadź imię")]
        [StringLength(20)]
        [Required(ErrorMessage = "Imię musi mieć co najmniej 3 znaki")]
        public string name { get; set; }

        [Display(Name = "Wprowadź nazwisko")]
        [StringLength(20)]
        [Required(ErrorMessage = "Nazwisko musi mieć co najmniej 5 znaków")]
        public string surname { get; set; }

        [Display(Name = "Wprowadź adres")]
        [StringLength(20)]
        [Required(ErrorMessage = "Adres musi mieć co najmniej 10 znaków")]
        public string address { get; set; }

        [Display(Name = "Wprowadź numer telefonu")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(9)]
        [Required(ErrorMessage = "Numer musi mieć co najmniej 9 znaków")]
        public string phone { get; set; }

        [Display(Name = "Wprowadź email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "Email musi mieć co najmniej 15 znaków")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
