using leave_management.Contracts;
using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeavehistoryRepository : ILeaveHistory
    {
        private readonly IdentityDataContext _db;

        public LeavehistoryRepository(IdentityDataContext db)
        {
            this._db = db;
        }
        public bool Create(Leavehistory entity)
        {
            _db.Leavehistories.Add(entity);
            return Save();
        }

        public bool Delete(Leavehistory entity)
        {
            _db.Leavehistories.Remove(entity);
            return Save();
        }

        public ICollection<Leavehistory> FindAll()
        {
            return _db.Leavehistories.ToList();
        }

        public Leavehistory FindById(int id)
        {
            return _db.Leavehistories.Find(id);
        }

        public bool IsExists(int id) => throw new NotImplementedException();

        public bool IsExists()
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            return _db.SaveChanges() > 1;
        }

        public bool Update(Leavehistory entity)
        {
            _db.Leavehistories.Update(entity);
            return Save();
        }
    }
}
