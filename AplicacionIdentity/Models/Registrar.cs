using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AplicacionIdentity.Models
{
    public class Registrar
    {
        [Required(ErrorMessage = "El Email es obligatorio!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatorio!")]
        [StringLength(50, ErrorMessage ="La {0} debe ser minimo {2} caracteres y maximo {1}", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [DisplayName("Contraseña")]
        public string Password { get; set; }

        [Required(ErrorMessage ="La confirmacion de la contraseña es obligatoria")]
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden!")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmacion de Contraseña")]

        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Los nombres son obligatorios!")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Los apellidos son obligatorios!")]
        public string Apellidos { get; set; }
    }
}

