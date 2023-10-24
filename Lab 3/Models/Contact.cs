using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab_3.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Musisz podac imie")]
        [StringLength(maximumLength: 50, ErrorMessage = "Zbyt długie imie, max 50 znaków")]
        [Display(Name="Imię")]
        public string Name { get; set; }
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email{ get; set; }
        [Display(Name = "Numer telefonu")]
        public string? Phone { get; set; }
        [Display(Name = "Data urodzenia")]
        public DateTime? Birth { get; set; }
        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }
        [HiddenInput]
        public DateTime Created { get; set; }
    }
}
