using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab3zadanie.Models
{
    public class Book
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        public string? ISBN { get; set; }
        [Range(0, 2023)]
        [Display(Name ="Publication Date")]
        public int? PublicationDate { get; set; }
        public string? Publisher { get; set; }
        [Display(Name = "Literary type")]
        public BookType BookType { get; set; }
    }
}
