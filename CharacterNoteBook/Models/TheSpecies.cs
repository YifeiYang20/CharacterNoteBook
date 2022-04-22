using System.ComponentModel.DataAnnotations;

namespace CharacterNoteBook.Models
{
    public class TheSpecies
    {
        public int TheSpeciesID { get; set; }

        [Required(ErrorMessage = "Please enter a theSpecies name.")]
        public string Name { get; set; }
    }
}
