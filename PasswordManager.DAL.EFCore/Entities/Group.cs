﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.DAL.EFCore.Entities
{
    public class Group
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; } = "";

        [MaxLength(1000)]
        [Required]
        public string Description { get; set; } = "";

        [MaxLength(200)]
        public string PathToIcon { get; set; } = "";

        [Required]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        [Required]
        public DateTime LastAccessDate { get; set; } = DateTime.Now;

        [Required]
        public DateTime LastChangeDate { get; set; } = DateTime.Now;

        public ICollection<Entry> Entries { get; set; } = new HashSet<Entry>();

        [Required]
        public PasswordDb PasswordDb { get; set; }

        public override string ToString() => Name;
    }
}
