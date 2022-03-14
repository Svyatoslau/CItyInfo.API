using CItyInfo.API.Models;

namespace CItyInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        //public static CitiesDataStore Current { get; set; } = new CitiesDataStore();

        
        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id =1,
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Buiding",
                            Description = "A 102-story skyscraper located in Midtown Manhattan."
                        }
                    }
                    
                },
                new CityDto()
                {
                    Id=2,
                    Name = "Antwerp",
                    Description = "the one with the cathedral tah was never really finished.",
                    PointsOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Cathedral of Our Lady",
                            Description = "A wrought iron lattice tower on the Champ de Mars, named after."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Antwerp Central Station",
                            Description = "The the finest example of railway architecture in Belgium."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that big tower.",
                    PointsOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Eiffel Tower",
                            Description = "A wrought iron lattice tower on the Champ de Mars, named after."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "The Louvre",
                            Description = "The world's largest museum."
                        }
                    }
                }
            };
        }
    }
}
