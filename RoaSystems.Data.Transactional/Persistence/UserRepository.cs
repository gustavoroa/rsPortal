using System;
using RoaSystems.Data.Transactional.Entities;
using RoaSystems.Data.Transactional.Mappings;

namespace RoaSystems.Data.Transactional.Persistence
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(IDataContext context) : base(context)
        {
        }

        public override bool Update(User entity)
        {
            entity.UpdatedOn = DateTime.Now;
            return base.Update(entity);
        }

        public override bool Delete(User entity)
        {
            entity.Deleted = true;
            entity.UpdatedOn = DateTime.Now;
            return base.Update(entity);
        }

    }
}