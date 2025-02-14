﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("owner")]
    public class Owner
    {
        [Column("OwnerId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is requred")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Address is requred")]
        [StringLength(100, ErrorMessage = "Address cannot be longer then 100 characters")]
        public string Address { get; set; }

        public ICollection<Account> Accounts { get; set; }

    }
}
