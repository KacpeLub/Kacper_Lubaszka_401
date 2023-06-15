using System.ComponentModel.DataAnnotations;

namespace NV_gym.Models
{
    public class Gym
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Pole 'Nazwa' jest wymagane.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Pole 'Miasto' jest wymagane.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Pole 'Ulica' jest wymagane.")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Pole 'Wielkość' jest wymagane.")]
        public int Size { get; set; }

        [Required(ErrorMessage = "Pole 'Opis' jest wymagane.")]
        public string Description { get; set; }
    }
}
