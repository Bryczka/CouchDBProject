using CouchDB.Driver;
using CouchDB.Driver.Extensions;
using CouchDBClient.Model;
using System.Linq;

namespace CouchDBClient.CouchDB
{
    public static class CouchDBQuerry
    {
        public static int dataCount = 100000;
        public static object MostProfitableCinema(CouchDatabase<Ticket> database)
        {
            var firstQuery = database
                .AsQueryable().Take(dataCount)
                .GroupBy(x => x.FilmShow.Cinema.CinemaId)
                .Select(x => new
                {
                    Id = x.FirstOrDefault().FilmShow.Cinema.CinemaId,
                    Price = x.Sum(c => c.TicketPrice)
                })
                .OrderByDescending(x => x.Price)
                .ToList();

            return firstQuery;
        }

        public static object PersonMostCinemas(CouchDatabase<Ticket> database)
        {
            var secondQuery = database
                .AsQueryable().Take(dataCount)
                .GroupBy(x => x.Person.PersonId)
                .Select(x => new
                {
                    x.FirstOrDefault().Person,
                    Number = x.Count()
                })
                .OrderByDescending(x => x.Number)
                .ToList();

            return secondQuery;
        }

        public static object MostPopularFilm(CouchDatabase<Ticket> database)
        {
            var thirdQuery = database
                .AsQueryable().Take(dataCount)
                .GroupBy(x => x.FilmShow.Film.FilmId)
                .Select(x => new
                {
                    x.FirstOrDefault().FilmShow.Film,
                    Number = x.Count()
                })
                .OrderByDescending(x => x.Number)
                .ToList();
            return thirdQuery;
        }
    }
}
