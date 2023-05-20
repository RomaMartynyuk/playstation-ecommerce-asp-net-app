namespace PlaystationStoreAsp.Models.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Companies
                if(!context.Companies.Any())
                {
                    context.Companies.AddRange(new List<Company>()
                    {
                        new Company()
                        {
                            Name = "Ubisoft",
                            Country = Enum.CompanyCountries.France
                        },
                        new Company()
                        {
                            Name = "EA Games",
                            Country = Enum.CompanyCountries.UnitedStates
                        },
                        new Company()
                        {
                            Name = "Sony Interactive",
                            Country = Enum.CompanyCountries.Japan
                        },
                    });
                    context.SaveChanges();
                }
                if(!context.Games.Any())
                {
                    context.Games.AddRange(new List<Game>()
                    {
                        new Game()
                        {
                            Name = "Assassin's Creed: Unity",
                            Description = "Paris, 1789 – The French Revolution turns a once-magnificent city into a place of terror and chaos. Its cobblestone streets run red with the blood of commoners who dared to rise up against the oppressive aristocracy.",
                            ImageURL = "https://image.api.playstation.com/cdn/UP0001/CUSA00663_00/0JH9uaYLozePLWj3M7QowO3YtHbXnXg1.png",
                            Price = 36.99,
                            ReleaseDate = DateTime.Now.AddDays(-80),
                            NumberOfPlayers = 1,
                            Genre = Enum.GameGenre.Stealth,
                            CompanyId = 1
                        },
                        new Game()
                        {
                            Name = "FIFA 23",
                            Description = "FIFA 23 is a football video game published by Electronic Arts (or simply EA). It is the 30th installment in the FIFA series that is developed by EA Sports, and the final installment under the FIFA banner",
                            ImageURL = "https://i0.wp.com/bugaloogameshop.com/wp-content/uploads/2022/07/FIFA-23.jpg?fit=1200%2C1200&ssl=1",
                            Price = 42.72,
                            ReleaseDate = DateTime.Now.AddDays(-34),
                            NumberOfPlayers = 4,
                            Genre = Enum.GameGenre.Simulator,
                            CompanyId = 2
                        },
                        new Game()
                        {
                            Name = "Uncharted 4: A Thief's End",
                            Description = "Uncharted 4: A Thief's End is a 2016 action-adventure game developed by Naughty Dog and published by Sony Computer Entertainment. It is the fourth main entry in the Uncharted series.",
                            ImageURL = "https://image.api.playstation.com/vulcan/img/rnd/202011/1018/SGqMZHd7WWmN4XIcLfYMxJsc.png",
                            Price = 23.23,
                            ReleaseDate = DateTime.Now.AddDays(-233),
                            NumberOfPlayers = 1,
                            Genre = Enum.GameGenre.Action,
                            CompanyId = 3
                        },
                        new Game()
                        {
                            Name = "The Last of Us",
                            Description = "The Last of Us is a 2013 action-adventure game developed by Naughty Dog and published by Sony Computer Entertainment. Players control Joel, a smuggler tasked with escorting a teenage girl, Ellie, across a post-apocalyptic United States.",
                            ImageURL = "https://image.api.playstation.com/vulcan/img/rnd/202011/1020/FKgazVvG7BcWouCr39mIiXkW.png",
                            Price = 32.43,
                            ReleaseDate = DateTime.Now.AddDays(-167),
                            NumberOfPlayers = 1,
                            Genre = Enum.GameGenre.Stealth,
                            CompanyId = 3
                        },
                        new Game()
                        {
                            Name = "Marvel's Spider-Man",
                            Description = "Marvel's Spider-Man is a 2018 action-adventure game developed by Insomniac Games and published by Sony Interactive Entertainment. Based on the Marvel Comics character Spider-Man, it tells an original narrative that is inspired by the long-running comic book mythology, while also drawing from various adaptations in other media.",
                            ImageURL = "https://image.api.playstation.com/vulcan/img/rnd/202011/0714/vuF88yWPSnDfmFJVTyNJpVwW.png",
                            Price = 38.57,
                            ReleaseDate = DateTime.Now.AddDays(-26),
                            NumberOfPlayers = 1,
                            Genre = Enum.GameGenre.Action,
                            CompanyId = 3
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
