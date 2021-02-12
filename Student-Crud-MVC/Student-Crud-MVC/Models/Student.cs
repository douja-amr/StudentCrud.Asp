using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Student_Crud_MVC.Models
{
    public class Student
    {
        [Key]

        public int id { get; set; }

        [Required (ErrorMessage ="Enter nom etudiant")]
        [Display(Name ="Nom")]

        public string nom { get; set; }

        [Required(ErrorMessage = "Enter prenom etudiant")]
        [Display(Name = "Prenom")]

        public string prenom { get; set; }

        [Required(ErrorMessage = "Enter CIN")]
        [Display(Name = "CIN")]

        public int  cin { get; set; }

        [Required(ErrorMessage = "Enter Adresse")]
        [Display(Name = "Adresse")]

        public string adresse { get; set; }
    }
}
