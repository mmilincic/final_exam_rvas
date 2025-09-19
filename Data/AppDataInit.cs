using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Formula.Models;
using Formula.Data;
using F1App.Data;

namespace Formula.Data
{
    public class AppDataInit
    {
        public static void Seed(DataContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Staze.Any())
            {
                context.Staze.AddRange(
                        new Staza { nazivStaze = "Circuit de Monaco", duzina = 3.34F },
                        new Staza { nazivStaze = "Silverstone Circuit", duzina = 5.89F },
                        new Staza { nazivStaze = "Suzuka International Racing Course", duzina = 5.81F },
                        new Staza { nazivStaze = "Monza (Autodromo Nazionale Monza)", duzina = 5.79F },
                        new Staza { nazivStaze = "Spa-Francorchamps", duzina = 7F },
                        new Staza { nazivStaze = "Marina Bay Street Circuit", duzina = 5.07F },
                        new Staza { nazivStaze = "Interlagos (Autódromo José Carlos Pace)", duzina = 4.31F },
                        new Staza { nazivStaze = "Red Bull Ring", duzina = 4.32F },
                        new Staza { nazivStaze = "Circuit of the Americas", duzina = 5.51F },
                        new Staza { nazivStaze = "Yas Marina Circuit", duzina = 5.28F },
                        new Staza { nazivStaze = "Bahrain International Circuit", duzina = 5.41F },
                        new Staza { nazivStaze = "Hungaroring", duzina = 4.38F },
                        new Staza { nazivStaze = "Circuit Gilles Villeneuve", duzina = 4.36F },
                        new Staza { nazivStaze = "Zandvoort (Circuit Zandvoort)", duzina = 4.26F },
                        new Staza { nazivStaze = "Baku City Circuit", duzina = 6F },
                        new Staza { nazivStaze = "Shanghai International Circuit", duzina = 5.45F },
                        new Staza { nazivStaze = "Circuit de Barcelona-Catalunya", duzina = 4.66F },
                        new Staza { nazivStaze = "Miami International Autodrome", duzina = 5.41F },
                        new Staza { nazivStaze = "Jeddah Street Circuit", duzina = 6.17F },
                        new Staza { nazivStaze = "Imola (Autodromo Enzo e Dino Ferrari)", duzina = 4.91F },
                        new Staza { nazivStaze = "Las Vegas Street Circuit", duzina = 6.12F },
                        new Staza { nazivStaze = "Hockenheimring", duzina = 4.57F },
                        new Staza { nazivStaze = "Nürburgring GP-Strecke", duzina = 5.15F },
                        new Staza { nazivStaze = "Istanbul Park", duzina = 5.34F },
                        new Staza { nazivStaze = "Sepang International Circuit", duzina = 5.54F },
                        new Staza { nazivStaze = "Kyalami Grand Prix Circuit", duzina = 4.52F },
                        new Staza { nazivStaze = "Magny-Cours (Circuit de Nevers Magny-Cours)", duzina = 4.41F },
                        new Staza { nazivStaze = "Fuji Speedway", duzina = 4.56F },
                        new Staza { nazivStaze = "Portimão (Algarve International Circuit)", duzina = 4.65F },
                        new Staza { nazivStaze = "Mugello Circuit", duzina = 5.25F }
                    );
            }
            if (!context.Timovi.Any())
            {
                context.Timovi.AddRange(
                    new Tim { nazivTima = "McLaren Mercedes" },
                    new Tim { nazivTima = "Mercedes" },
                    new Tim { nazivTima = "Red Bull Racing Honda RBPT" },
                    new Tim { nazivTima = "Ferrari" },
                    new Tim { nazivTima = "Williams Mercedes" },
                    new Tim { nazivTima = "Haas Ferrari" },
                    new Tim { nazivTima = "Aston Martin Aramco Mercedes" },
                    new Tim { nazivTima = "Racing Bulls Honda RBPT" },
                    new Tim { nazivTima = "Kick Sauber Ferrari" },
                    new Tim { nazivTima = "Alpine Renault" });
            }

            context.SaveChanges();

            if (!context.Vozaci.Any())
            {
                var mclarenmercedes = context.Timovi.First(t => t.nazivTima == "McLaren Mercedes");
                var mercedes = context.Timovi.First(t => t.nazivTima == "Mercedes");
                var redbullracinghondarbpt = context.Timovi.First(t => t.nazivTima == "Red Bull Racing Honda RBPT");
                var ferrari = context.Timovi.First(t => t.nazivTima == "Ferrari");
                var williamsmercedes = context.Timovi.First(t => t.nazivTima == "Williams Mercedes");
                var haasferrari = context.Timovi.First(t => t.nazivTima == "Haas Ferrari");
                var astonmartinaramcomercedes = context.Timovi.First(t => t.nazivTima == "Aston Martin Aramco Mercedes");
                var racingbullshondarbpt = context.Timovi.First(t => t.nazivTima == "Racing Bulls Honda RBPT");
                var kicksauberferrari = context.Timovi.First(t => t.nazivTima == "Kick Sauber Ferrari");
                var alpinerenault = context.Timovi.First(t => t.nazivTima == "Alpine Renault");

                context.Vozaci.AddRange(
                    new Vozac { ime = "Oscar", prezime = "Piastri", nacionalnost = "AUS", brojVozaca = 4, datumRodjenja = new DateOnly(2001, 04, 06), tim = mclarenmercedes.timId, Tim = mclarenmercedes },
                    new Vozac { ime = "Lando", prezime = "Norris", nacionalnost = "GBR", brojVozaca = 81, datumRodjenja = new DateOnly(1999, 11, 13), tim = mclarenmercedes.timId, Tim = mclarenmercedes },
                    new Vozac { ime = "Kimi", prezime = "Antonelli", nacionalnost = "ITA", brojVozaca = 12, datumRodjenja = new DateOnly(2006, 08, 25), tim = mercedes.timId, Tim = mercedes },
                    new Vozac { ime = "George", prezime = "Russel", nacionalnost = "GBR", brojVozaca = 63, datumRodjenja = new DateOnly(1998, 02, 15), tim = mercedes.timId , Tim = mercedes },
                    new Vozac { ime = "Max", prezime = "Verstappen", nacionalnost = "NED", brojVozaca = 1, datumRodjenja = new DateOnly(1997, 09, 30), tim = redbullracinghondarbpt.timId , Tim = redbullracinghondarbpt },
                    new Vozac { ime = "Yuki", prezime = "Tsunoda", nacionalnost = "JPN", brojVozaca = 22, datumRodjenja = new DateOnly(2000, 05, 11), tim = redbullracinghondarbpt.timId , Tim = redbullracinghondarbpt },
                    new Vozac { ime = "Lewis", prezime = "Hamilton", nacionalnost = "GBR", brojVozaca = 44, datumRodjenja = new DateOnly(1985, 01, 07), tim = ferrari.timId , Tim = ferrari },
                    new Vozac { ime = "Charles", prezime = "Leclerc", nacionalnost = "MON", brojVozaca = 16, datumRodjenja = new DateOnly(1997, 10, 16), tim = ferrari.timId , Tim = ferrari },
                    new Vozac { ime = "Carlos", prezime = "Sainz", nacionalnost = "ESP", brojVozaca = 55, datumRodjenja = new DateOnly(1994, 09, 01), tim = williamsmercedes.timId , Tim = williamsmercedes },
                    new Vozac { ime = "Alex", prezime = "Albon", nacionalnost = "THA", brojVozaca = 23, datumRodjenja = new DateOnly(1996, 03, 23), tim = williamsmercedes.timId , Tim = williamsmercedes },
                    new Vozac { ime = "Oliver", prezime = "Bearman", nacionalnost = "GBR", brojVozaca = 87, datumRodjenja = new DateOnly(2005, 05, 08), tim = haasferrari.timId , Tim = haasferrari },
                    new Vozac { ime = "Esteban", prezime = "Ocon", nacionalnost = "FRA", brojVozaca = 31, datumRodjenja = new DateOnly(1996, 09, 17), tim = haasferrari.timId , Tim = haasferrari },
                    new Vozac { ime = "Fernando", prezime = "Alonso", nacionalnost = "ESP", brojVozaca = 14, datumRodjenja = new DateOnly(1981, 07, 29), tim = astonmartinaramcomercedes.timId , Tim = astonmartinaramcomercedes },
                    new Vozac { ime = "Lance ", prezime = "Stroll", nacionalnost = "CAD", brojVozaca = 18, datumRodjenja = new DateOnly(1998, 10, 29), tim = astonmartinaramcomercedes.timId , Tim = astonmartinaramcomercedes },
                    new Vozac { ime = "Isack", prezime = "Hadjar", nacionalnost = "FRA", brojVozaca = 6, datumRodjenja = new DateOnly(2004, 09, 28), tim = racingbullshondarbpt.timId , Tim = racingbullshondarbpt },
                    new Vozac { ime = "Liam", prezime = "Lawson", nacionalnost = "NZL", brojVozaca = 30, datumRodjenja = new DateOnly(2002, 02, 11), tim = racingbullshondarbpt.timId , Tim = racingbullshondarbpt },
                    new Vozac { ime = "Gabriel", prezime = "Bortoleto", nacionalnost = "BRA", brojVozaca = 5, datumRodjenja = new DateOnly(2004, 10, 14), tim = kicksauberferrari.timId , Tim = kicksauberferrari },
                    new Vozac { ime = "Niko", prezime = "Hulkenberg", nacionalnost = "GER", brojVozaca = 27, datumRodjenja = new DateOnly(1987, 08, 19), tim = kicksauberferrari.timId , Tim = kicksauberferrari },
                    new Vozac { ime = "Pierre", prezime = "Gasly", nacionalnost = "FRA", brojVozaca = 10, datumRodjenja = new DateOnly(1996, 02, 07), tim = alpinerenault.timId , Tim = alpinerenault },
                    new Vozac { ime = "Jack", prezime = "Doohan", nacionalnost = "AUS", brojVozaca = 7, datumRodjenja = new DateOnly(2003, 01, 20), tim = alpinerenault.timId , Tim = alpinerenault }
                );
                context.SaveChanges();

            }
            //        public static async Task SeedAsync(DataContext context)
            //        {
            //            //await context.Database.MigrateAsync();
            //            context.Database.EnsureCreated();

            //            if (!context.Timovi.Any()) {
            //                context.Timovi.AddRange(
            //                    new Tim { nazivTima = "McLaren Mercedes" },
            //                    new Tim { nazivTima = "Mercedes" },
            //                    new Tim { nazivTima = "Red Bull Racing Honda RBPT" },
            //                    new Tim { nazivTima = "Ferrari" },
            //                    new Tim { nazivTima = "Williams Mercedes" },
            //                    new Tim { nazivTima = "Haas Ferrari" },
            //                    new Tim { nazivTima = "Aston Martin Aramco Mercedes" },
            //                    new Tim { nazivTima = "Racing Bulls Honda RBPT" },
            //                    new Tim { nazivTima = "Kick Sauber Ferrari" },
            //                    new Tim { nazivTima = "Alpine Renault" }
            //                );
            //                await context.SaveChangesAsync();

            //            }

            //            if (!context.Sponzori.Any())
            //            {
            //                context.Sponzori.AddRange(
            //                    new Sponzori { naziv = "Red Bull" },
            //                    new Sponzori { naziv = "Shell" },
            //                    new Sponzori { naziv = "Petronas" },
            //                    new Sponzori { naziv = "Pirelli" },
            //                    new Sponzori { naziv = "Mobil 1" },
            //                    new Sponzori { naziv = "Mercedes AMG" },
            //                    new Sponzori { naziv = "Haas Automation" },
            //                    new Sponzori { naziv = "Alfa Romeo" },
            //                    new Sponzori { naziv = "Honda" },
            //                    new Sponzori { naziv = "Ferrari" }
            //);
            //                await context.SaveChangesAsync();
            //            }

            //            if (!context.Vozaci.Any())
            //            {
            //                var mclarenmercedes = context.Timovi.First(t => t.nazivTima == "McLaren Mercedes");
            //                var mercedes = context.Timovi.First(t => t.nazivTima == "Mercedes");
            //                var redbullracinghondarbpt = context.Timovi.First(t => t.nazivTima == "Red Bull Racing Honda RBPT");
            //                var ferrari = context.Timovi.First(t => t.nazivTima == "Ferrari");
            //                var williamsmercedes = context.Timovi.First(t => t.nazivTima == "Williams Mercedes");
            //                var haasferrari = context.Timovi.First(t => t.nazivTima == "Haas Ferrari");
            //                var astonmartinaramcomercedes = context.Timovi.First(t => t.nazivTima == "Aston Martin Aramco Mercedes");
            //                var racingbullshondarbpt = context.Timovi.First(t => t.nazivTima == "Racing Bulls Honda RBPT");
            //                var kicksauberferrari = context.Timovi.First(t => t.nazivTima == "Kick Sauber Ferrari");
            //                var alpinerenault = context.Timovi.First(t => t.nazivTima == "Alpine Renault");

            //                context.Vozaci.AddRange(
            //                    new Vozac { ime = "Oscar", prezime = "Piastri", nacionalnost = "AUS", brojVozaca = 4, datumRodjenja = new DateOnly(2001, 04, 06), tim = mclarenmercedes.timId },
            //                    new Vozac { ime = "Lando", prezime = "Norris", nacionalnost = "GBR", brojVozaca = 81, datumRodjenja = new DateOnly(1999, 11, 13), tim = mclarenmercedes.timId, sponzori = context.Sponzori.Where(s => s.naziv == "Shell").ToList() },
            //                    new Vozac { ime = "Kimi", prezime = "Antonelli", nacionalnost = "ITA", brojVozaca = 12, datumRodjenja = new DateOnly(2006, 08, 25), tim = mercedes.timId, sponzori = context.Sponzori.Where(s => s.naziv == "Mercedes AMG").ToList() },
            //                    new Vozac { ime = "George", prezime = "Russel", nacionalnost = "GBR", brojVozaca = 63, datumRodjenja = new DateOnly(1998, 02, 15), tim = mercedes.timId, sponzori = context.Sponzori.Where(s => s.naziv == "Petronas").ToList() },
            //                    new Vozac { ime = "Max", prezime = "Verstappen", nacionalnost = "NED", brojVozaca = 1, datumRodjenja = new DateOnly(1997, 09, 30), tim = redbullracinghondarbpt.timId, sponzori = context.Sponzori.Where(s => s.naziv == "Ferrari").ToList() },
            //                    new Vozac { ime = "Yuki", prezime = "Tsunoda", nacionalnost = "JPN", brojVozaca = 22, datumRodjenja = new DateOnly(2000, 05, 11), tim = redbullracinghondarbpt.timId, sponzori = context.Sponzori.Where(s => s.naziv == "Shell").ToList() },
            //                    new Vozac { ime = "Lewis", prezime = "Hamilton", nacionalnost = "GBR", brojVozaca = 44, datumRodjenja = new DateOnly(1985, 01, 07), tim = ferrari.timId, sponzori = context.Sponzori.Where(s => s.naziv == "Mercedes AMG").ToList() },
            //                    new Vozac { ime = "Charles", prezime = "Leclerc", nacionalnost = "MON", brojVozaca = 16, datumRodjenja = new DateOnly(1997, 10, 16), tim = ferrari.timId, sponzori = context.Sponzori.Where(s => s.naziv == "Haas Automation").ToList() },
            //                    new Vozac { ime = "Carlos", prezime = "Sainz", nacionalnost = "ESP", brojVozaca = 55, datumRodjenja = new DateOnly(1994, 09, 01), tim = williamsmercedes.timId, sponzori = context.Sponzori.Where(s => s.naziv == "Mobil 1").ToList() },
            //                    new Vozac { ime = "Alex", prezime = "Albon", nacionalnost = "THA", brojVozaca = 23, datumRodjenja = new DateOnly(1996, 03, 23), tim = williamsmercedes.timId, sponzori = context.Sponzori.Where(s => s.naziv == "Honda").ToList() },
            //                    new Vozac { ime = "Oliver", prezime = "Bearman", nacionalnost = "GBR", brojVozaca = 87, datumRodjenja = new DateOnly(2005, 05, 08), tim = haasferrari.timId, sponzori = context.Sponzori.Where(s => s.naziv == "Alfa Romeo").ToList() },
            //                    new Vozac { ime = "Esteban", prezime = "Ocon", nacionalnost = "FRA", brojVozaca = 31, datumRodjenja = new DateOnly(1996, 09, 17), tim = haasferrari.timId, sponzori = context.Sponzori.Where(s => s.naziv == "Red Bull").ToList() },
            //                    new Vozac { ime = "Fernando", prezime = "Alonso", nacionalnost = "ESP", brojVozaca = 14, datumRodjenja = new DateOnly(1981, 07, 29), tim = astonmartinaramcomercedes.timId, sponzori = context.Sponzori.Where(s => s.naziv == "Ferrari").ToList() },
            //                    new Vozac { ime = "Lance ", prezime = "Stroll", nacionalnost = "CAD", brojVozaca = 18, datumRodjenja = new DateOnly(1998, 10, 29), tim = astonmartinaramcomercedes.timId, sponzori = context.Sponzori.Where(s => s.naziv == "Pirelli").ToList() },
            //                    new Vozac { ime = "Isack", prezime = "Hadjar", nacionalnost = "FRA", brojVozaca = 6, datumRodjenja = new DateOnly(2004, 09, 28), tim = racingbullshondarbpt.timId, sponzori = context.Sponzori.Where(s => s.naziv == "Mercedes AMG").ToList() },
            //                    new Vozac { ime = "Liam", prezime = "Lawson", nacionalnost = "NZL", brojVozaca = 30, datumRodjenja = new DateOnly(2002, 02, 11), tim = racingbullshondarbpt.timId, sponzori = context.Sponzori.Where(s => s.naziv == "Red Bull").ToList() },
            //                    new Vozac { ime = "Gabriel", prezime = "Bortoleto", nacionalnost = "BRA", brojVozaca = 5, datumRodjenja = new DateOnly(2004, 10, 14), tim = kicksauberferrari.timId, sponzori = context.Sponzori.Where(s => s.naziv == "Alfa Romeo").ToList() },
            //                    new Vozac { ime = "Niko", prezime = "Hulkenberg", nacionalnost = "GER", brojVozaca = 27, datumRodjenja = new DateOnly(1987, 08, 19), tim = kicksauberferrari.timId, sponzori = context.Sponzori.Where(s => s.naziv == "Shell").ToList() },
            //                    new Vozac { ime = "Pierre", prezime = "Gasly", nacionalnost = "FRA", brojVozaca = 10, datumRodjenja = new DateOnly(1996, 02, 07), tim = alpinerenault.timId, sponzori = context.Sponzori.Where(s => s.naziv == "Shell").ToList() },
            //                    new Vozac { ime = "Jack", prezime = "Doohan", nacionalnost = "AUS", brojVozaca = 7, datumRodjenja = new DateOnly(2003, 01, 20), tim = alpinerenault.timId, sponzori = context.Sponzori.Where(s => s.naziv == "Red Bull").ToList() }
            //                );

            //                await context.SaveChangesAsync();
            //            }

            //            if (!context.Staze.Any())
            //            {
            //                context.Staze.AddRange(
            //                    new Staza { nazivStaze = "Circuit de Monaco", duzina = 3.34F },
            //                    new Staza { nazivStaze = "Silverstone Circuit", duzina = 5.89F },
            //                    new Staza { nazivStaze = "Suzuka International Racing Course", duzina = 5.81F },
            //                    new Staza { nazivStaze = "Monza (Autodromo Nazionale Monza)", duzina = 5.79F },
            //                    new Staza { nazivStaze = "Spa-Francorchamps", duzina = 7F },
            //                    new Staza { nazivStaze = "Marina Bay Street Circuit", duzina = 5.07F },
            //                    new Staza { nazivStaze = "Interlagos (Autódromo José Carlos Pace)", duzina = 4.31F },
            //                    new Staza { nazivStaze = "Red Bull Ring", duzina = 4.32F },
            //                    new Staza { nazivStaze = "Circuit of the Americas", duzina = 5.51F },
            //                    new Staza { nazivStaze = "Yas Marina Circuit", duzina = 5.28F },
            //                    new Staza { nazivStaze = "Bahrain International Circuit", duzina = 5.41F },
            //                    new Staza { nazivStaze = "Hungaroring", duzina = 4.38F },
            //                    new Staza { nazivStaze = "Circuit Gilles Villeneuve", duzina = 4.36F },
            //                    new Staza { nazivStaze = "Zandvoort (Circuit Zandvoort)", duzina = 4.26F },
            //                    new Staza { nazivStaze = "Baku City Circuit", duzina = 6F },
            //                    new Staza { nazivStaze = "Shanghai International Circuit", duzina = 5.45F },
            //                    new Staza { nazivStaze = "Circuit de Barcelona-Catalunya", duzina = 4.66F },
            //                    new Staza { nazivStaze = "Miami International Autodrome", duzina = 5.41F },
            //                    new Staza { nazivStaze = "Jeddah Street Circuit", duzina = 6.17F },
            //                    new Staza { nazivStaze = "Imola (Autodromo Enzo e Dino Ferrari)", duzina = 4.91F },
            //                    new Staza { nazivStaze = "Las Vegas Street Circuit", duzina = 6.12F },
            //                    new Staza { nazivStaze = "Hockenheimring", duzina = 4.57F },
            //                    new Staza { nazivStaze = "Nürburgring GP-Strecke", duzina = 5.15F },
            //                    new Staza { nazivStaze = "Istanbul Park", duzina = 5.34F },
            //                    new Staza { nazivStaze = "Sepang International Circuit", duzina = 5.54F },
            //                    new Staza { nazivStaze = "Kyalami Grand Prix Circuit", duzina = 4.52F },
            //                    new Staza { nazivStaze = "Magny-Cours (Circuit de Nevers Magny-Cours)", duzina = 4.41F },
            //                    new Staza { nazivStaze = "Fuji Speedway", duzina = 4.56F },
            //                    new Staza { nazivStaze = "Portimão (Algarve International Circuit)", duzina = 4.65F },
            //                    new Staza { nazivStaze = "Mugello Circuit", duzina = 5.25F }
            //                );
            //                await context.SaveChangesAsync();

            //            }

            //            if (!context.Trke.Any())
            //            {
            //                //var yasmarinacircuit = context.Staze.First(s => s.nazivStaze == "Yas Marina Circuit");
            //                //var suzukainternationalracingcourse = context.Staze.First(s => s.nazivStaze == "Suzuka International Racing Course");
            //                //var spafrancorchamps = context.Staze.First(s => s.nazivStaze == "Spa-Francorchamps");
            //                //var silverstonecircuit = context.Staze.First(s => s.nazivStaze == "Silverstone Circuit");
            //                //var shanghaiinternationalcircuit = context.Staze.First(s => s.nazivStaze == "Shanghai International Circuit");
            //                //context.Trke.AddRange(
            //                //    new Trke { stazas = yasmarinacircuit, datumTrke = new DateOnly(2025, 05, 14) },
            //                //    new Trke { stazas = suzukainternationalracingcourse, datumTrke = new DateOnly(2025, 06, 23) },
            //                //    new Trke { stazas = spafrancorchamps, datumTrke = new DateOnly(2025, 07, 18) },
            //                //    new Trke { stazas = silverstonecircuit, datumTrke = new DateOnly(2025, 03, 28) },
            //                //    new Trke { stazas = shanghaiinternationalcircuit, datumTrke = new DateOnly(2025, 02, 26) }
            //                //);
            //                await context.SaveChangesAsync();
            //            }

            //        }
        }
    }
}
