using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseFirstApproach.Models
{
    
        [Table("Register")]
        public class RegisterModel
        {

            // use [key] if primary key 
            // auto increment - use dataannotation [databaseGenertaed(databaseGeneratedOption.Identity)]
            [Key]
            public int ID { get; set; }
            public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Mobile { get; set; } 
        public bool Gender { get; set; }

        public string Age { get; set; }
        public string UserName { get; set; }
        
          public DateTime JoiningDate { get; set; }
        public string Qualification { get; set; }
        public int PassWord { get; set; }
        public byte image { get; set; }

    }
        public class LoginModel
        {

            // use [key] if primary key 
            // auto increment - use dataannotation [databaseGenertaed(databaseGeneratedOption.Identity)]

            public string UserName { get; set; }
            public int PassWord { get; set; }


        }
       
    }


