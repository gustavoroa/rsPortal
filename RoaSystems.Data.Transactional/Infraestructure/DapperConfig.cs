using Dapper;
using RoaSystems.Data.Transactional.Entities;
using RoaSystems.Data.Transactional.Mappings;

namespace RoaSystems.Data.Transactional.Infrastructure
{
    public static class DapperConfig
    {
        public static void Apply()
        {
            SqlMapper.SetTypeMap(typeof(User), new UserMapping());
            //SqlMapper.SetTypeMap(typeof(Topic), new TopicMapping());
        }
    }
}