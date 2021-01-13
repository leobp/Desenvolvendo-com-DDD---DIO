﻿using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;

namespace Infra.Data.Repository
{
    public class WorkerRepository : BaseRepository<Worker, int>, IRepositoryWorker
    {
        public WorkerRepository(MySqlContext mySqlContext) : base(mySqlContext)
        {
        }

        public void Remove(int id) =>
            base.Delete(id);


        public void Save(Worker obj)
        {
            if (obj.Id == 0)
                base.Insert(obj);
            
        }

        public Worker GetById(int id) =>
            base.Select(id);

        public IList<Worker> GetAll() =>
            base.Select();

    }
}
