using PokemonReviewApp.Data;
using PokemonReviewApp.Models;

namespace PokemonReviewApp
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.PokemonOwners.Any())
            {
                var pokemonOwners = new List<PokemonOwner>()
                {
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Pikachu",
                            BirthDate = new DateTime(1903, 1, 1),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Electric" } }
                            },
                            Reviews = new List<Review>()
                            {
                                new Review
                                {
                                    Title = "Pikachu",
                                    Text = "Pikachu is the best pokemon, because it is electric",
                                    Reviewer = new Reviewer() { FirstName = "Teddy", LastName = "Smith" }
                                },
                                new Review
                                {
                                    Title = "Pikachu",
                                    Text = "Pikachu is the best at killing rocks",
                                    Reviewer = new Reviewer() { FirstName = "Taylor", LastName = "Jones" }
                                },
                                new Review
                                {
                                    Title = "Pikachu",
                                    Text = "Pikachu, Pikachu, Pikachu",
                                    Reviewer = new Reviewer() { FirstName = "Jessica", LastName = "McGregor" }
                                }
                            }
                        },
                        Owner = new Owner()
                        {
                            Name = "Jack London",
                            Gym = "Brocks Gym",
                            Country = new Country()
                            {
                                Name = "Kanto"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Squirtle",
                            BirthDate = new DateTime(1903, 1, 1),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Water" } }
                            },
                            Reviews = new List<Review>()
                            {
                                new Review
                                {
                                    Title = "Squirtle",
                                    Text = "Squirtle is the best pokemon, because it is electric",
                                    Reviewer = new Reviewer() { FirstName = "Teddy", LastName = "Smith" }
                                },
                                new Review
                                {
                                    Title = "Squirtle",
                                    Text = "Squirtle is the best at killing rocks",
                                    Reviewer = new Reviewer() { FirstName = "Taylor", LastName = "Jones" }
                                },
                                new Review
                                {
                                    Title = "Squirtle",
                                    Text = "Squirtle, Squirtle, Squirtle",
                                    Reviewer = new Reviewer() { FirstName = "Jessica", LastName = "McGregor" }
                                }
                            }
                        },
                        Owner = new Owner()
                        {
                            Name = "Harry Potter",
                            Gym = "Mistys Gym",
                            Country = new Country()
                            {
                                Name = "Saffron City"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Venasuar",
                            BirthDate = new DateTime(1903, 1, 1),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Leaf" } }
                            },
                            Reviews = new List<Review>()
                            {
                                new Review
                                {
                                    Title = "Venasuar",
                                    Text = "Venasuar is the best pokemon, because it is electric",
                                    Reviewer = new Reviewer() { FirstName = "Teddy", LastName = "Smith" }
                                },
                                new Review
                                {
                                    Title = "Venasuar",
                                    Text = "Venasuar is the best at killing rocks",
                                    Reviewer = new Reviewer() { FirstName = "Taylor", LastName = "Jones" }
                                },
                                new Review
                                {
                                    Title = "Venasuar",
                                    Text = "Venasuar, Venasuar, Venasuar",
                                    Reviewer = new Reviewer() { FirstName = "Jessica", LastName = "McGregor" }
                                }
                            }
                        },
                        Owner = new Owner()
                        {
                            Name = "Ash Ketchum",
                            Gym = "Ashs Gym",
                            Country = new Country()
                            {
                                Name = "Millet Town"
                            }
                        }
                    }
                };
                dataContext.PokemonOwners.AddRange(pokemonOwners);
                dataContext.SaveChanges();
            }
        }
    }
}
