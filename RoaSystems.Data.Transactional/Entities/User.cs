using System;
using System.Security;
using RoaSystems.Data.Entities;

namespace RoaSystems.Data.Transactional.Entities
{
    /// <summary>
    /// Domain entity for the Users table for use by a repository
    /// </summary>
    public class User : EntityBase, ISaveable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int? UserStatusId { get; set; }
        public bool? Deleted { get; set; }
        public int? UserTypeID { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdateUserId { get; set; }
    }
}
