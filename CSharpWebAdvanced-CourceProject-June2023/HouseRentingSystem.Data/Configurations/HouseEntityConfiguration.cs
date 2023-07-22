namespace HouseRentingSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    
    using Models;
    public class HouseEntityConfiguration : IEntityTypeConfiguration<House>
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {
            builder
                .Property(h => h.CreatedOn)
                .HasDefaultValue(DateTime.UtcNow);

            builder
                .HasOne(h => h.Category)
                .WithMany(c => c.Houses)
                .HasForeignKey(h => h.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(h => h.Agent)
                .WithMany(a => a.OwnedHouses)
                .HasForeignKey(h => h.AgentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(this.GenerateHouses());
        }

        private House[] GenerateHouses()
        {
            ICollection<House> houses = new HashSet<House>();

            House house;
            house = new House()
            {
                Title = "Big House Marina",
                Address = "North London, UK (near the border)",
                Description = "A big house for your whole family. Don't miss to buy a house with three bedrooms.",
                ImageUrl = "https://nt.global.ssl.fastly.net/binaries/content/gallery/website/national/regions/london/places/red-house/library/built-heritage-history-and-collections/north-front-red-house-london-1243706.jpg",
                PricePerMonth = 2100.00M,

                CategoryId = 3,
                AgentId = Guid.Parse("5268E332-C6B6-43DE-BA7C-7484F968037A"),
                RenterId = Guid.Parse("2D21DCFB-0211-4AB6-BD2E-08DB8A01096F")
            };
            houses.Add(house);

            house = new House()
            {
                Title = "Family House Comfort",
                Address = "Near the Sea Garden in Burgas, Bulgaria",
                Description = "It has the best comfort you will ever ask for. With two bedrooms, it is great for your family.",
                ImageUrl =
                    "https://media.rightmove.co.uk/61k/60887/129625586/60887_11437_IMG_00_0000.jpeg", 
                PricePerMonth = 1200.00M,

                CategoryId = 2,
                AgentId = Guid.Parse("5268E332-C6B6-43DE-BA7C-7484F968037A"),
                RenterId = Guid.Parse("2D21DCFB-0211-4AB6-BD2E-08DB8A01096F")
            };
            houses.Add(house);

            house = new House()
            {
                Title = "Grand House",
                Address = "Boyana Neighbourhood, Sofia, Bulgaria",
                Description = "This luxurious house is everything you will need. It is just excellent.",
                ImageUrl =
                    "https://i.pinimg.com/originals/a6/f5/85/a6f5850a77633c56e4e4ac4f867e3c00.jpg",
                PricePerMonth = 2000.00M,

                CategoryId = 2,
                AgentId = Guid.Parse("5268E332-C6B6-43DE-BA7C-7484F968037A"),
                RenterId = Guid.Parse("2D21DCFB-0211-4AB6-BD2E-08DB8A01096F")
            };
            houses.Add(house);

            return houses.ToArray();
        }
    }
}
