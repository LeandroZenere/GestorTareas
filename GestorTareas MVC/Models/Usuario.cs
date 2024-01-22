using System.ComponentModel.DataAnnotations;

namespace GestorTareas_MVC.Models
{
    public class Usuario
    {

        [Key]
        public int UsuarioId { get; set; }


        [Required(ErrorMessage = "Por favor, ingresar el nombre de usuario")]
        [Display(Name = "Correo del usuario")]
        [MaxLength(100)]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "Por favor, ingresar el correo")]
        [Display(Name = "Correo del usuario")]
        [MaxLength(100)]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Por favor, ingresar la contraseña")]
        [Display(Name = "Contraseña de la tarea")]
        [MaxLength(500)]
        public string Clave { get; set; }

        //[Required(ErrorMessage = "Por favor, ingresar la contraseña")]
        //[Display(Name = "Contraseña de la tarea")]
        //[MaxLength(500)]
        //public string ConfirmarClave { get; set; }
    }
}
