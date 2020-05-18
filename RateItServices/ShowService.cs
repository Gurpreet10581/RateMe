using RateIt.Data;
using RateItData;
using RateItModels.Show;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateItServices
{
    public class ShowService
    {
        public readonly Guid _userId;
        public ShowService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateShow(ShowCreate model)
        {
            var entity =
                new Show()
                {
                    OwnerId = _userId,
                    ShowName = model.ShowName,
                    DirectorName = model.DirectorName,
                    Duration = model.Duration,
                    DateRelease = model.DateRelease,
                    GenreOfShow = model.GenreOfShow,
                    TypeOfShow = model.TypeOfShow,
                    CreatedUtc = DateTimeOffset.Now
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Shows.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<ShowListItem> GetShows()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Shows
                    .Where(e => e.OwnerId == _userId)
                    .Select(
                            e =>
                            new ShowListItem
                            {
                                ShowId = e.ShowId,
                                ShowName = e.ShowName,
                                DirectorName = e.DirectorName,
                                Duration = e.Duration,
                                DateRelease = e.DateRelease,
                                GenreOfShow = e.GenreOfShow,
                                TypeOfShow = e.TypeOfShow,
                                CreatedUtc = e.CreatedUtc
                            }
                        );
                return query.ToArray();
            }
        }
        public ShowDetail GetShowById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Shows
                    .Single(e => e.ShowId == id && e.OwnerId == _userId);
                return
                    new ShowDetail
                    {
                        ShowId = entity.ShowId,
                        ShowName = entity.ShowName,
                        DirectorName = entity.DirectorName,
                        Duration = entity.Duration,
                        DateRelease = entity.DateRelease,
                        GenreOfShow = entity.GenreOfShow,
                        TypeOfShow = entity.TypeOfShow,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }
        public bool UpdateShow(ShowEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Shows
                    .Single(e => e.ShowId == model.ShowId && e.OwnerId == _userId);
                entity.ShowName = model.ShowName;
                entity.DirectorName = model.DirectorName;
                entity.DateRelease = model.DateRelease;
                entity.GenreOfShow = model.GenreOfShow;
                entity.TypeOfShow = model.TypeOfShow;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;
                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteShow(int showId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Shows
                        .Single(e => e.ShowId == showId && e.OwnerId == _userId);

                ctx.Shows.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
