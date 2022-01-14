﻿using MusicS.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicS.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Album = new AlbumRepository(_db);
        }
        public IAlbumRepository Album { get; private set; }

        void IUnitOfWork.Save()
        {
            _db.SaveChanges();
        }
    }
}
