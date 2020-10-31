using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using leave_management.Contracts;
using leave_management.Data;

namespace leave_management.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public ICollection<LeaveType> FindAll()
        {
            return _db.LeaveTypes.ToList();
        }

        public LeaveType FindById(int id)
        {
            var leaveType = _db.LeaveTypes.Find(id);
            //_db.LeaveTypes.FirstOrDefault();
            return leaveType;
        }

        public bool Create(LeaveType entity)
        {
            _db.LeaveTypes.Add(entity);
            return Save();
        }

        public bool Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _db.LeaveTypes.Remove(entity);
            return Save();
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public ICollection<LeaveType> GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }
    }
}
