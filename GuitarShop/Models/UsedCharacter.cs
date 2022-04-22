using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CharacterNoteBook.Models
{
    public class UsedCharacter
    {
        public int UsedCharacterID { get; set; }

        [Required(ErrorMessage = "Please select a theSpecies.")]
        public int TheSpeciesID { get; set; }  

        public TheSpecies TheSpecies { get; set; }

        [Required(ErrorMessage = "Please enter a usedCharacter code.")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Please enter a usedCharacter name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a usedCharacter Species.")]
        public string Species { get; set; }


        public string Slug {
            get {
                if (Name == null)
                    return "";
                else
                    return Name.Replace(' ', '-');
            }
        }
    }
}