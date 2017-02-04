using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace MvcMusicStoreTBD.Models
{
    public class User
    {
        public virtual int Id { get; set; }
        [Required]
        [StringLength(90)]
        [DisplayName("First Name")]
        public virtual string FirstName { get; set; }
        [Required]
        [StringLength(90, MinimumLength = 5)]
        public virtual string LastName { get; set; }
        [Required]
        [StringLength(30)]
        public virtual string UserName { get; set; }
        [StringLength(30, MinimumLength = 1)]
        [DataType(DataType.Password)]
        public virtual string Password { get; set; }
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        [AmbientValue(true)]
        public virtual string PasswordComp { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public virtual DateTime BirthDay { get; set; }
        [StringLength(30)]
        //[DataType(DataType.EmailAddress)]
        [EmailAddress]
        //[Remote()]
        public virtual string Email { get; set; }
        [DataType(DataType.MultilineText)]
        public virtual string Comment { get; set; }
        [StringLength(30)]
        [Display(Name = "Ekstra værdi")]
        public virtual string HashStr { get; set; }
    }
}