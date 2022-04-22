//Yifei Yang
using System.Collections.Generic;

namespace CharacterNoteBook.Models
{
    public class UsedCharacterListViewModel
    {
        public List<TheSpecies> Species { get; set; }
        public List<UsedCharacter> UsedCharacters { get; set; }
        public string SelectedTheSpecies { get; set; }
        public string CheckActiveTheSpecies(string theSpecies) => theSpecies == SelectedTheSpecies ? "active" : "";
    }
}