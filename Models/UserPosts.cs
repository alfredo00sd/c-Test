using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class UserPosts
    {
        
        [Display(Name = "Codigo de usuario")]
        public int UserId { get; set; }
        [Key]
        public int Id { get; set; }
        [Display(Name = "Titulo")]
        public string Title { get; set; }
        [Display(Name = "Mensaje")]
        public string Body { get; set; }
    }
}