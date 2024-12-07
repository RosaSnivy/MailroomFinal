using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace Mailroom.Models;


public static class SeedData
{
    public static string wt_email = "jswiemers1@buffs.wtamu.edu";
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new MailroomDbContext(serviceProvider.GetRequiredService<DbContextOptions<MailroomDbContext>>());

        if (context.Residents.Any())
        {
            return;
        }
        context.Residents.AddRange(
          new Resident {name = "Kittie Mousdall", email = wt_email, unitNumber = 101},
          new Resident {name = "Claudette Rait", email = wt_email, unitNumber = 102},
          new Resident {name = "Eliza Himsworth", email = wt_email, unitNumber = 103},
          new Resident {name = "Emmit Gann", email = wt_email, unitNumber = 104},
          new Resident {name = "Aurlie Pedycan", email = wt_email, unitNumber = 105},
          new Resident {name = "Keriann Kettlesting", email = wt_email, unitNumber = 106},
          new Resident {name = "Fiorenze Iacovuzzi", email = wt_email, unitNumber = 107},
          new Resident {name = "Darlene Gravie", email = wt_email, unitNumber = 108},
          new Resident {name = "Tomasine Challener", email = wt_email, unitNumber = 109},
          new Resident {name = "Dotti Marple", email = wt_email, unitNumber = 110},
          new Resident {name = "Gabriel Tofanelli", email = wt_email, unitNumber = 201},
          new Resident {name = "Aldo WellDrake", email = wt_email, unitNumber = 202},
          new Resident {name = "Ezmeralda Laydon", email = wt_email, unitNumber = 203},
          new Resident {name = "Kale Lendrem", email = wt_email, unitNumber = 204},
          new Resident {name = "Lenard Cubbit", email = wt_email, unitNumber = 205},
          new Resident {name = "Dedie Caddies", email = wt_email, unitNumber = 206},
          new Resident {name = "Nancy Janosevic", email = wt_email, unitNumber = 207},
          new Resident {name = "Layne Whiterod", email = wt_email, unitNumber = 208},
          new Resident {name = "Averell Labusch", email = wt_email, unitNumber = 209},
          new Resident {name = "Gordan Raddon", email = wt_email, unitNumber = 210},
          new Resident {name = "Deloria Johnes", email = wt_email, unitNumber = 301},
          new Resident {name = "Emmett MacIllrick", email = wt_email, unitNumber = 302},
          new Resident {name = "Sanderson Simoncelli", email = wt_email, unitNumber = 303},
          new Resident {name = "Had Hapke", email = wt_email, unitNumber = 304},
          new Resident {name = "Bellina Rodenburgh", email = wt_email, unitNumber = 305},
          new Resident {name = "Portie Searle", email = wt_email, unitNumber = 306},
          new Resident {name = "Ellsworth Richichi", email = wt_email, unitNumber = 307},
          new Resident {name = "Orlando Mattholie", email = wt_email, unitNumber = 308},
          new Resident {name = "Noby Phelp", email = wt_email, unitNumber = 309},
          new Resident {name = "Wilow Caush", email = wt_email, unitNumber = 310},
          new Resident {name = "Hesther Wincom", email = wt_email, unitNumber = 401},
          new Resident {name = "Ferdie Jzhakov", email = wt_email, unitNumber = 402},
          new Resident {name = "Cornelia Burlingham", email = wt_email, unitNumber = 403},
          new Resident {name = "Rochella Childers", email = wt_email, unitNumber = 404},
          new Resident {name = "Jennie Christensen", email = wt_email, unitNumber = 405},
          new Resident {name = "Kalie Cropper", email = wt_email, unitNumber = 406},
          new Resident {name = "Corinne Garrison", email = wt_email, unitNumber = 407},
          new Resident {name = "Maybelle Pigne", email = wt_email, unitNumber = 408},
          new Resident {name = "Wald Kuddyhy", email = wt_email, unitNumber = 409},
          new Resident {name = "Blancha Amrosoni", email = wt_email, unitNumber = 410},
          new Resident {name = "Gussy Moiser", email = wt_email, unitNumber = 501},
          new Resident {name = "Margette Symcock", email = wt_email, unitNumber = 502},
          new Resident {name = "Cad Stearnes", email = wt_email, unitNumber = 503},
          new Resident {name = "Juliann Sumner", email = wt_email, unitNumber = 504},
          new Resident {name = "Esdras Bresland", email = wt_email, unitNumber = 505},
          new Resident {name = "Alisha Laspee", email = wt_email, unitNumber = 506},
          new Resident {name = "Yvon Jirusek", email = wt_email, unitNumber = 507},
          new Resident {name = "Parrnell Halbeard", email = wt_email, unitNumber = 508},
          new Resident {name = "Korrie Milesap", email = wt_email, unitNumber = 509},
          new Resident {name = "Vivyan Petzold", email = wt_email, unitNumber = 510}
        );

        context.SaveChanges();
    }
}