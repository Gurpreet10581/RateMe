using RateIt.Data;
using RateItData;
using RateItModels.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateItServices
{
    public class MovieService
    {
        public readonly Guid _userId;
        public MovieService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateMovie(MovieCreate model)
        {
            var entity =
                new Movie()
                {
                    OwnerId = _userId,
                    MovieName = model.MovieName,
                    DirectorName = model.DirectorName,
                    Duration=model.Duration,
                    DateRelease=model.DateRelease,
                    GenreOfMovie=model.GenreOfMovie,
                    TypeOfMovie=model.TypeOfMovie,
                    CreatedUtc = DateTimeOffset.Now
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Movies.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<MovieListItem> GetMovies()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Movies
                    .Where(e => e.OwnerId == _userId)
                    .Select(
                            e =>
                            new MovieListItem
                            {
                                MovieId = e.MovieId,
                                MovieName = e.MovieName,
                                DirectorName = e.DirectorName,
                                Duration=e.Duration,
                                DateRelease=e.DateRelease,
                                GenreOfMovie=e.GenreOfMovie,
                                TypeOfMovie=e.TypeOfMovie,
                                CreatedUtc = e.CreatedUtc
                            }
                        );
                return query.ToArray();
            }
        }
        public MovieDetail GetMovieById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Movies
                    .Single(e => e.MovieId == id && e.OwnerId == _userId);
                return
                    new MovieDetail
                    {
                        MovieId = entity.MovieId,
                        MovieName = entity.MovieName,
                        DirectorName = entity.DirectorName,
                        Duration = entity.Duration,
                        DateRelease = entity.DateRelease,
                        GenreOfMovie = entity.GenreOfMovie,
                        TypeOfMovie = entity.TypeOfMovie,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }
        public bool UpdateMovie(MovieEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Movies
                    .Single(e => e.MovieId == model.MovieId && e.OwnerId == _userId);
                entity.MovieName = model.MovieName;
                entity.DirectorName = model.DirectorName;
                entity.DateRelease = model.DateRelease;
                entity.GenreOfMovie = model.GenreOfMovie;
                entity.TypeOfMovie = model.TypeOfMovie;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;
                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteMovie(int movieId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Movies
                        .Single(e => e.MovieId == movieId && e.OwnerId == _userId);

                ctx.Movies.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
