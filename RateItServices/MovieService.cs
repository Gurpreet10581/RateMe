using RateIt.Data;
using RateItData;
using RateItModels;
using RateItModels.Movie;
using RateItModels.Review;
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
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }

        public IEnumerable<ReviewDetail> GetReveiwsByMovieId(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Reviews
                    .Where(e => e.MovieId == id && e.OwnerId == _userId)
                    .Select(
                                e=>
                                new ReviewDetail
                                {
                                    ReviewId=e.ReviewId,
                                    MovieId=e.MovieId,
                                    Content=e.Content,
                                    Rating=e.Rating,
                                    CreatedUtc=e.CreatedUtc,
                                    ModifiedUtc=e.ModifiedUtc
                                   
                                }
                        );
                return query.ToArray();
               
            }
        }


        //public IEnumerable<ReviewDetail> GetRatingsByMovieId()
        //{
        //    using (var ctx = new ApplicationDbContext())
        //    {
        //        var query =
        //            ctx
        //            .Reviews
        //            .GroupBy(e => 1)
        //            .Select(
        //                        e =>
        //                        new ReviewDetail
        //                        {
        //                            MovieId = e.MovieId,
        //                            Rating = e.Rating(e=>1),
        //                        }
        //                );
        //        return query.ToArray();

        //    }
        //}

        //public MovieRatingView GetMinMaxAvg(MovieRatingView model)
        //{


        //    string[,] MinMaxAvg = new string[3, 2] { { "Max", " " }, { "Min", " " }, { "Average", "" } };

        //    MinMaxAvg[0, 1] = model.Ratings.Max().ToString();  //Sets Max Value
        //    MinMaxAvg[1, 1] = model.Ratings.Min().ToString(); //Sets Min Value
        //    MinMaxAvg[2, 1] = model.Ratings.Average().ToString(); //Sets Average Value
        //    model.MinMaxAvg = MinMaxAvg;
        //    model.MovieId = _userId;
        //    return model;


        //}
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
                entity.Duration = model.Duration;
                entity.DateRelease = model.DateRelease;
                entity.GenreOfMovie = model.GenreOfMovie;
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
