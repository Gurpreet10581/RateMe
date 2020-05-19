﻿using RateIt.Data;
using RateItData;
using RateItModels.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateItServices
{
    public class MusicService
    {
        public readonly Guid _userId;
        public MusicService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateMusic(MusicCreate model)
        {
            var entity =
                new Music()
                {
                    OwnerId = _userId,
                    ArtistName = model.ArtistName,
                    Duration = model.Duration,
                    DateRelease = model.DateRelease,
                    GenreOfMusic = model.GenreOfMusic,
                    TypeOfMusic = model.TypeOfMusic,
                    CreatedUtc = DateTimeOffset.Now
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Musics.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<MusicListItem> GetMusics()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Musics
                    .Where(e => e.OwnerId == _userId)
                    .Select(
                            e =>
                            new MusicListItem
                            {
                                MusicId = e.MusicId,
                                ArtistName = e.ArtistName,
                                Duration = e.Duration,
                                DateRelease = e.DateRelease,
                                GenreOfMusic = e.GenreOfMusic,
                                TypeOfMusic = e.TypeOfMusic,
                                CreatedUtc = e.CreatedUtc
                            }
                        );
                return query.ToArray();
            }
        }
        public MusicDetail GetMusicById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Musics
                    .Single(e => e.MusicId == id && e.OwnerId == _userId);
                return
                    new MusicDetail
                    {
                        MusicId = entity.MusicId,
                        ArtistName = entity.ArtistName,
                        Duration = entity.Duration,
                        DateRelease = entity.DateRelease,
                        GenreOfMusic = entity.GenreOfMusic,
                        TypeOfMusic = entity.TypeOfMusic,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }
        public bool UpdateMusic(MusicEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Musics
                    .Single(e => e.MusicId == model.MusicId && e.OwnerId == _userId);
                entity.ArtistName = model.ArtistName;
                entity.Duration = model.Duration;
                entity.GenreOfMusic = model.GenreOfMusic;
                entity.TypeOfMusic = model.TypeOfMusic;
                entity.DateRelease = model.DateRelease;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;
                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteMusic(int musicId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Musics
                        .Single(e => e.MusicId == musicId && e.OwnerId == _userId);

                ctx.Musics.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
