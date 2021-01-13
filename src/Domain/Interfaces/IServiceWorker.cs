using System.Collections.Generic;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IServiceWorker
    {
        WorkerModel Insert(CreateWorkerModel userModel);

        WorkerModel Update(int id, UpdateWorkerModel userModel);

        void Delete(int id);

        WorkerModel RecoverById(int id);

        IEnumerable<WorkerModel> RecoverAll();
    }
}
