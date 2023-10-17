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
        public string Name { get; set; }
        [EmailAddress]
        public string Email{ get; set; }
        public string? Phone { get; set; }
        public DateTime? Birth { get; set; }
    }
}
