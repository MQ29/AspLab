﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    [Table("contacts")]
    public class ContactEntity
    {
        [Key]
        public int ContactId { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [MaxLength(50)]
        [Required]
        public string Email { get; set; }
        [MaxLength(12)]
        [MinLength(9)]
        public string? Phone { get; set; }
        [Column("birth_date")]
        public DateTime? Birth { get; set; }
        public int Priority { get; set; }
        public OrganizationEntity? Organization { get; set; }
        public int OrganizationId { get; set; }

    }
}