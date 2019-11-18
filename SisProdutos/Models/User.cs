using System;
using System.ComponentModel.DataAnnotations;

namespace SisProdutos.models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Access Access { get; set; }
        public DateTime DateCreate { get; set; }

    }

    public enum Access
    {
        admin, member
    }
}
