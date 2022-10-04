using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HauntedLocation.Models
{
    public class HauntedLocationContext: DbContext
    {
        public HauntedLocationContext(DbContextOptions<HauntedLocationContext> options)
                    : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Location>()
                  .HasData(
                      new Location { LocationId = 1, Name = "Davis Graveyard", Keyword = "Attraction", City = "Milwaukie", Address = "8703 SE 43rd Ave, Milwaukie, OR", Description= "A spooky halloween display with noises, special effects and props.", Link = "http://davisgraveyard.com/gallery/" },
                      new Location { LocationId = 2, Name = "Old Town Pizza & Brewing", Keyword = "Tour", City = "Portland", Address = "226 NW Davis St, Portland, OR", Description= "A pizzeria known for ita haunted past and haunted tunnel tours.", Link = "https://www.otbrewing.com/" },
                      new Location { LocationId = 3, Name = "Portland Walking Tours", Keyword = "Tour", City = "Portland", Address = "131 NW 2nd Ave, Portland, OR", Description= "Walking tours of Portland including after dark haunted walking tours.", Link = "https://portlandwalkingtours.com/" },
                      new Location { LocationId = 4, Name = "Shanghai Tunnels/Portland Underground Tour", Keyword = "Tour", City = "Portland", Address = "120 NW 3rd Ave, Portland, OR", Description = "Guided tours of portland's underground Chinatown tunnels rumored to have a dark and spooky past.", Link = "http://www.portlandtunnels.com/welcome-to-the-shanghai-tunnel-tours.html" },
                      new Location { LocationId = 5, Name = "Portland Walking Tours", Keyword = "Tour", City = "Portland", Address = "", Description = "", Link = "" },
                      new Location { LocationId = 6, Name = "Portland Walking Tours", Keyword = "Tour", City = "Portland", Address = "", Description = "", Link = "" },
                      new Location { LocationId = 7, Name = "Portland Walking Tours", Keyword = "Tour", City = "Portland", Address = "", Description = "", Link = "" },
                      new Location { LocationId = 8, Name = "Portland Walking Tours", Keyword = "Tour", City = "Portland", Address = "", Description = "", Link = "" },
                      new Location { LocationId = 9, Name = "Portland Walking Tours", Keyword = "Tour", City = "Portland", Address = "", Description = "", Link = "" },
                      new Location { LocationId = 10, Name = "Portland Walking Tours", Keyword = "Tour", City = "Portland", Address = "", Description = "", Link = "" },
                      new Location { LocationId = 11, Name = "Portland Walking Tours", Keyword = "Tour", City = "Portland", Address = "", Description = "", Link = "" },
                      new Location { LocationId = 12, Name = "Portland Walking Tours", Keyword = "Tour", City = "Portland", Address = "", Description = "", Link = "" },
                      new Location { LocationId = 13, Name = "Portland Walking Tours", Keyword = "Tour", City = "Portland", Address = "", Description = "", Link = "" },
                      new Location { LocationId = 14, Name = "Portland Walking Tours", Keyword = "Tour", City = "Portland", Address = "", Description = "", Link = "" },
                      new Location { LocationId = 15, Name = "Portland Walking Tours", Keyword = "Tour", City = "Portland", Address = "", Description = "", Link = "" },
                      new Location { LocationId = 16, Name = "Portland Walking Tours", Keyword = "Tour", City = "Portland", Address = "", Description = ".", Link = "" },
                      new Location { LocationId = 17, Name = "Portland Walking Tours", Keyword = "Tour", City = "Portland", Address = "", Description = "", Link = "" },
                      new Location { LocationId = 18, Name = "Portland Walking Tours", Keyword = "Tour", City = "Portland", Address = "", Description = "", Link = "" },
                      new Location { LocationId = 19, Name = "Portland Walking Tours", Keyword = "Tour", City = "Portland", Address = "", Description = "", Link = "" },
                      new Location { LocationId = 20, Name = "Portland Walking Tours", Keyword = "Tour", City = "Portland", Address = "", Description = "", Link = "" },
            );
        }
        public DbSet<Location> Locations { get; set; }
    }
}
