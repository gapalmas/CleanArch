using System;
using System.ComponentModel.DataAnnotations;

namespace App.Core.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateUpdate { get; set; }
    }
}