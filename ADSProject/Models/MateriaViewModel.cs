using ADSProject.Utils;
using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
    public class MateriaViewModel
    {
        [Display(Name = "ID")]

        public int idMateria { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe de ser mayor de 50 caracteres ni menor de 3 caracteres. ")]
        [Display(Name = "NombreMateria")]
        public string nombreMateria { get; set; }
        
    }
}
