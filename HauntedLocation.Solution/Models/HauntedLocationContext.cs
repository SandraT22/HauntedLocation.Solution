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
                      new Location { LocationId = 5, Name = "Wolf Creek Inn & Tavern", Keyword = "Hotel", City = "Wolf Creek", Address = "100 Front St, Wolf Creek, OR", Description = "An operational hotel built 1883 with lots of ghostly guests.", Link = "https://wolfcreekinn.com/" },
                      new Location { LocationId = 6, Name = "Golden", Keyword = "Self-guided", City = "Josephine County", Address = "Oregon 97497", Description = "An abandoned mining town rumored to still be home to some of its former residents.", Link = "No Link" },
                      new Location { LocationId = 7, Name = "McMenamin's White Eagle Saloon", Keyword = "Bar", City = "Portland", Address = "836 N Russell St, Portland, OR", Description = "A saloon attached to a hotel within a historic building. The bar and the hotel are rumored to be home to the spirit of Sam Warrick who used to be a bartender and cook in the building.", Link = "https://www.mcmenamins.com/white-eagle-saloon-hotel" },
                      new Location { LocationId = 8, Name = "Lone Fir Cemetary", Keyword = "Tour", City = "Portland", Address = "649 SE 26th Ave, Portland, OR", Description = "A historical pioneer-era cemetary housing about 25,000 deceased occupants. Guided and self-guided tours available.", Link = "https://www.friendsoflonefircemetery.org/?page_id=117" },
                      new Location { LocationId = 9, Name = "Heceta Head Lighthouse", Keyword = "Hotel", City = "Florence", Address = "725 Summer St, Florence, OR", Description = "A working 19th century lighthouse doubling as a bed and breakfast. It is said that guests who stay in the old lightkeeper's quarters meet the old light keepers wife Rue.", Link = "https://www.hecetalighthouse.com/" },
                      new Location { LocationId = 10, Name = "Lithia Park", Keyword = "Nature", City = "Ashland", Address = "Winburn Way, Ashland, OR", Description = "A 100 acre park with gardens, ponds, tennis courts...oh and the ghostly apparitions!", Link = "https://www.ashland.or.us/page.asp?navid=14083" },
                      new Location { LocationId = 11, Name = "McMenamins Edgefield", Keyword = "Hotel", City = "Troutdale", Address = "2126 SW Halsey St, Troutdale, OR", Description = "A large property containing a hotel as well as multiple bars and restaurants. Built in 1911 these buildings have been used as a poor farm and tuberculosis hospital and is rumores to have unmarked graves scattered throughout the property.", Link = "https://www.mcmenamins.com/edgefield" },
                      new Location { LocationId = 12, Name = "Elsinore Theatre", Keyword = "Performance Venue", City = "Salem", Address = "170 High St SE, Salem, OR", Description = "While catching a live-theatre performance or concert at this 1920s theatre, you may also catch the sight of voices of performers who are no longer living.", Link = "http://elsinore.theatresalem.org/?msclkid=097239fff9f016229f995ac2f831c7aa" },
                      new Location { LocationId = 13, Name = "Sparrow Bakery", Keyword = "Restaurant", City = "Bend", Address = "2748 NW Crossing Dr #110, Bend, OR", Description = "A restaurant serving breakfast, lunch and dinner with a side of ghosts belonging to the days when this building was an iron works foundry.", Link = "https://www.thesparrowbakery.net/scott-street/scott-street-footer/" },
                      new Location { LocationId = 14, Name = "Scaponia Recreation Site", Keyword = "Nature", City = "Scappoose", Address = "22870 Scappoose Veronia Rd, Scappoose, OR", Description = "A lovely part with views of the apparition of a horse theif and his from the 1800s who were murdered by an angry mob on the property and burried nearby.", Link = "None" },
                      new Location { LocationId = 15, Name = "Croisan Creek Road", Keyword = "Self-guided", City = "Salem", Address = "Salem, OR 97302", Description = "While cruising down this lonely road, you might want to consider rolling down the windows and enjoying the views. You may just catch a glimpse of the little ghost girl who is seem running into the road chasing after her ball.", Link = "None" }
            );
        }
        public DbSet<Location> Locations { get; set; }
    }
}
