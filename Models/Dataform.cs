using System.ComponentModel.DataAnnotations;



namespace TPLOCAL1.Models
{
    public class Dataform
    {
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required(ErrorMessage = "Selectionner un sexe")]
        public string Sexe { get; set; }
        [MinLength(5)]
        public string Addresse { get; set; }
        [RegularExpression("\\d{5}", ErrorMessage = "Doit contenir cinq chiffres exp : 92320")]
        
        public int CodePostal { get; set; }
        public string Ville { get; set; }
        [EmailAddress]
        public string Email { get; set; }


        [DataType(DataType.Date)]
        public DateTime DateDeb { get; set; }
        [Required]
        public string Formation { get; set; }
        [Required]
        public string? CobolAvis { get; set; }
        [Required]
        public string? FormObj { get; set; }

    }

 
}
