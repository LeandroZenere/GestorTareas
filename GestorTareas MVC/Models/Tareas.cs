using System.ComponentModel.DataAnnotations;

namespace GestorTareas_MVC.Models
{
    public class Tarea
    {
        [Key]
        public int TareaId { get; set; }

        [Required(ErrorMessage = "Por favor, ingresar el título de la tarea")]
        [Display(Name = "Título de la tarea")]
        [MaxLength(25)]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Por favor, ingresar la descripción de la tarea")]
        [Display(Name = "Descripción de la tarea")]
        [MaxLength(150)]
        public string Descripcion { get; set; }

        public DateTime FechaVencimiento { get; set; }

        [Required]
        public Prioridad Prioridad { get; set; }
    }

    public enum Prioridad
    {
        Baja,
        Media,
        Alta
    }
}
