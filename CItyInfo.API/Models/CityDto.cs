namespace CItyInfo.API.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string? Description { get; set; }
        public int NumberOfInterest
        {
            get
            {
                return PointsOfInterests.Count;
            }
        }

        public ICollection<PointOfInterestDto> PointsOfInterests { get; set; }
            = new List<PointOfInterestDto>();
    }
}
