using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;



using MySql.Data.MySqlClient;

using System.Runtime.Caching;
using RoaSystems.Data.Transactional.Entities;
using RoaSystems.Data.Transactional.Persistence;

namespace RoaSystems.Server.Services
{
    public class AplicacionService : IAplicacionService
    {
        //private readonly ICacheManager _iCachemanager;
        private readonly IAplicacionRepository _repository;
        //public TopicService(ICacheManager iCacheManager)
        //{
        //    _iCachemanager = iCacheManager;
        //}

        public AplicacionService(IAplicacionRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Aplicacion> GetAll()
        {
            return (_repository.QuerySql(@"SELECT * FROM Topic")).ToList();
        }

        public IEnumerable<Aplicacion> GetAll(string topicNamee)
        {
            return new List<Aplicacion>();

            //throw new System.NotImplementedException();
        }

        public Aplicacion GetById(int pTopicId)
        {
            // run custom sql query with params, get back a collection of User entities.
            return (_repository.QuerySql(
                @"SELECT * FROM Topic WHERE TopicId = @pTopicID",
                new[] { new MySqlParameter("@pTopicID", pTopicId) })).ToList()[0];
        }

        public IEnumerable<Aplicacion> GetByName(string pTopicName)
        {
            return (_repository.QuerySql(
                @"SELECT * FROM Topic WHERE Name = @topicName", new List<MySqlParameter>
                {
                    new MySqlParameter("@topicName", pTopicName)
                }));
        }

        public void Save(Aplicacion pTopic)
        {
            throw new System.NotImplementedException();
        }
    }

    public interface ICacheManager
    {
        bool Exists(string topicNamee);
        void Add(string topicName);
    }

    public class CacheManager : ICacheManager
    {
        public bool Exists(string topicNamee)
        {
            throw new System.NotImplementedException();
        }

        public void Add(string topicName)
        {
            throw new System.NotImplementedException();
        }
    }
}


/*
 
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Caching;
using StevesBlinds.Data.Transactional.Entities;
using StevesBlinds.Data.Transactional.Persistence;

namespace StevesBlinds.Server.Services
{
    public class TopicService : ITopicService
    {
        //private readonly ICacheManager _iCachemanager;
        private readonly ITopicRepository _repository;


        //public TopicService(ICacheManager iCacheManager)
        //{
        //    _iCachemanager = iCacheManager;
        //}

        public TopicService(ITopicRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Topic> GetAll()
        {
           return (_repository.QuerySql(@"SELECT * FROM Topic")).ToList();     
        }

        public IEnumerable<Topic> GetAll(string topicNamee)
        {
           return new List<Topic>();

            //throw new System.NotImplementedException();
        }

        public Topic GetById(int pTopicId)
        {
            // run custom sql query with params, get back a collection of User entities.
            return (_repository.QuerySql(
                @"SELECT * FROM Topic WHERE TopicId = @pTopicID",
                new[] { new SqlParameter("@pTopicID", pTopicId) })).ToList()[0];
        }             
   
        public IEnumerable<Topic> GetByName(string pTopicName)
        {   
            return (_repository.QuerySql(
                @"SELECT * FROM Topic WHERE Name = @topicName", new List<SqlParameter>
                {
                    new SqlParameter("@topicName", pTopicName)
                }));
        }

        public void Save(Topic pTopic)
        {
            throw new System.NotImplementedException();
        }
    }

    public interface ICacheManager
    {
        bool Exists(string topicNamee);
        void Add(string topicName);
    }

    public class CacheManager : ICacheManager
    {
        public bool Exists(string topicNamee)
        {
            throw new System.NotImplementedException();
        }

        public void Add(string topicName)
        {
            throw new System.NotImplementedException();
        }
    }
}

 */
