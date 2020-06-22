using CouchDBClient.ModelEF;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CouchDBClient.MSSQL
{
    public static class MSSQLQuery
    {
        private static Model1 context = new Model1();

        public static object MostProfitableCinema()
        {
            var firstQuerry = context.Ticket
                .Include(x => x.FilmShow.Cinema)
                .GroupBy(x => x.FilmShow.Cinema.Id)
                .Select(x => new
                {
                    x.FirstOrDefault().FilmShow.Cinema.Id,
                    Price = x.Sum(c => c.TicketPrice)
                }).ToList();

            return firstQuerry;
        }

        public static object PersonMostCinemas()
        {
            var secondQuery = context.Ticket
                .Include(x =>x.Person)
            .GroupBy(x => x.Person.Id)
            .Select(x => new
            {
                x.FirstOrDefault().Person,
                Number = x.Count()
            })
            .OrderByDescending(x => x.Number)
            .ToList();

            return secondQuery;
        }

        public static object MostPopularFilm()
        {
            var thirdQuery = context.Ticket
                .Include(x => x.FilmShow)
                .GroupBy(x => x.FilmShow.Film.Id)
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
