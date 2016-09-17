//using System;
using RoaSystems.Data.Transactional.Entities;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace RoaSystems.Server.Services
{
    public interface IAplicacionService
    {
        IEnumerable<Aplicacion> GetAll();
        IEnumerable<Aplicacion> GetByName(string pTopicName);
        void Save(Aplicacion pEntity);
        Aplicacion GetById(int pTopicId);
    }
}



//using StevesBlinds.Data.Transactional.Entities;
//using System.Collections.Generic;

//namespace StevesBlinds.Server.Services
//{
//    public interface ITopicService
//    {
//        IEnumerable<Topic> GetAll();
//        IEnumerable<Topic> GetByName(string pTopicName);
//        void Save(Topic pEntity);
//        Topic GetById(int pTopicId);
//    }
//}