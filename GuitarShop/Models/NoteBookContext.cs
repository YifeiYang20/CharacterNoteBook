using Microsoft.EntityFrameworkCore;

namespace CharacterNoteBook.Models
{
    public class NoteBookContext : DbContext
    {
        public NoteBookContext(DbContextOptions<NoteBookContext> options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<TheSpecies> Species { get; set; }
        public DbSet<UsedCharacter> UsedCharacters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TheSpecies>().HasData(
                new TheSpecies { TheSpeciesID = 1, Name = "Characters" },
                new TheSpecies { TheSpeciesID = 3, Name = "Story Elements" }
            );

            modelBuilder.Entity<UsedCharacter>().HasData(
                new UsedCharacter
                {
                    UsedCharacterID = 1,
                    TheSpeciesID = 1,
                    Code = "1",
                    Name = "Vitriol (Medical raw material supplier)",
                    Species = "Mermaid"
                },
                new UsedCharacter
                {
                    UsedCharacterID = 2,
                    TheSpeciesID = 1,
                    Code = "1",
                    Name = "Copper (Fire awareness publicity volunteer)",
                    Species = "Phoenix"
                },
                new UsedCharacter
                {
                    UsedCharacterID = 3,
                    TheSpeciesID = 1,
                    Code = "2",
                    Name = "MoLing (Engineering painter with highly competitive science)",
                    Species = "Fox"
                },
                new UsedCharacter
                {
                    UsedCharacterID = 4,
                    TheSpeciesID = 1,
                    Code = "2",
                    Name = "JunQing (Surrealist and idealist writer)",
                    Species = "Bunny"
                },
                new UsedCharacter
                {
                    UsedCharacterID = 5,
                    TheSpeciesID = 1,
                    Code = "3",
                    Name = "Erin (Medical expert with a small amount of anti social consciousness)",
                    Species = "Bear"
                },
                new UsedCharacter
                {
                    UsedCharacterID = 6,
                    TheSpeciesID = 1,
                    Code = "3",
                    Name = "Phoebus (A peace ambassador who has made great contributions to society)",
                    Species = "Bear"
                },
                new UsedCharacter
                {
                    UsedCharacterID = 13,
                    TheSpeciesID = 1,
                    Code = "4",
                    Name = "Sofia (Versatile vtuber)",
                    Species = "Mermaid"
                },
                new UsedCharacter
                {
                    UsedCharacterID = 14,
                    TheSpeciesID = 1,
                    Code = "4",
                    Name = "Hydro (Marine Environmental Protection Ambassador)",
                    Species = "Jellyfish"
                }, 
                new UsedCharacter
                {
                    UsedCharacterID = 15,
                    TheSpeciesID = 3,
                    Code = "5",
                    Name = "One of them picked up a stray cat",
                    Species = " "
                },
                new UsedCharacter
                {
                    UsedCharacterID = 16,
                    TheSpeciesID = 3,
                    Code = "6",
                    Name = "They live in the same apartment, but today one of them triggered a fire while cooking for everyone",
                    Species = " "
                },
                new UsedCharacter
                {
                    UsedCharacterID = 17,
                    TheSpeciesID = 3,
                    Code = "7",
                    Name = "Two of them were photographed by their classmates when they were traveling together and said they were lovers, but they were not",
                    Species = " "
                },
                new UsedCharacter
                {
                    UsedCharacterID = 18,
                    TheSpeciesID = 3,
                    Code = "8",
                    Name = "The police broke into their party and took one of them",
                    Species = " "
                }

            );
        }
    }
}