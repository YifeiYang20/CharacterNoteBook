using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CharacterNoteBook.Models;

namespace CharacterNoteBook.Controllers
{
    public class UsedCharacterController : Controller
    {
        private NoteBookContext context;

        public UsedCharacterController(NoteBookContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return RedirectToAction("List", "UsedCharacter");
        }

        [Route("[controller]s/{id?}")]
        public IActionResult List(string id = "All")
        {
            var species = context.Species
                .OrderBy(c => c.TheSpeciesID).ToList();

            List<UsedCharacter> usedCharacters;
            if (id == "All")
            {
                usedCharacters = context.UsedCharacters
                    .OrderBy(p => p.UsedCharacterID).ToList();
            }
            else
            {
                usedCharacters = context.UsedCharacters
                    .Where(p => p.TheSpecies.Name == id)
                    .OrderBy(p => p.UsedCharacterID).ToList();
            }

            var model = new UsedCharacterListViewModel
            {
                Species = species,
                UsedCharacters = usedCharacters,
                SelectedTheSpecies = id
            };

            return View(model);
        }

        
    }
}