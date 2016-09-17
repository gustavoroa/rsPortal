using System;
using RoaSystems.Data.Transactional.Entities;
using RoaSystems.Data.Transactional.Mappings;

namespace RoaSystems.Data.Transactional.Persistence
{
    public class AplicacionRepository : Repository<Aplicacion>, IAplicacionRepository
    {
        public AplicacionRepository(IDataContext context) : base(context)
        {
        }

        public override bool Update(Aplicacion entity)
        {
            entity.LAST_UPDATED_BY = 1; // Change this with the UserID who changed this... 
            entity.LAST_UPDATE_DATE = DateTime.Now;
            //entity.UpdatedOn = DateTime.Now;
            return base.Update(entity);
        }

        public override bool Delete(Aplicacion entity)
        {
            entity.DELETED = true;
            entity.DELETED_DATE = DateTime.Now;
            entity.DELETED_BY = 1;
            return base.Update(entity);
        }

    }
}