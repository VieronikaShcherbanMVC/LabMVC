using System.ComponentModel.DataAnnotations;

namespace HomeworkManager.Models
{
    public class HomeworkTask
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Opis jest wymagany")]
        [StringLength(100, ErrorMessage = "Opis może mieć maksymalnie 100 znaków")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Termin wykonania jest wymagany")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        [Required(ErrorMessage = "Status jest wymagany")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Priorytet jest wymagany")]
        public string Priority { get; set; }
    }
}