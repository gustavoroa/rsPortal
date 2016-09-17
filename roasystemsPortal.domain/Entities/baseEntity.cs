using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roasystemsPortal.domain.Entities
{
    public class baseEntity
    {
        #region private variables...
        private Nullable<Int64> _id;
        private Nullable<Int64> _createdBy;
        private Nullable<DateTime> _creationDate;
        private Nullable<Int64> _lastUpdatedBy;
        private Nullable<DateTime> _lastUpdateDate;
        private Nullable<bool> _deleted;
        private Nullable<Int64> _deletedBy;
        private Nullable<DateTime> _deletedDate;
        #endregion
        #region Public properties...
        /// <summary>
        /// Gets or sets the property related with the ID for this object.
        /// </summary>
        public Nullable<Int64> ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        /// <summary>
        /// Gets or sets the ID of the user who created this record
        /// </summary>
        public Nullable<Int64> CREATED_BY
        {
            get
            {
                return _createdBy;
            }
            set
            {
                _createdBy = value;
            }
        }

        /// <summary>
        /// Gets or sets the date and time when the register was created
        /// </summary>
        public Nullable<DateTime> CREATION_DATE
        {
            get
            {
                return _creationDate;
            }
            set
            {
                _creationDate = value;
            }
        }

        /// <summary>
        /// Gets or sets the ID of the user who made the last update for this record
        /// </summary>
        public Nullable<Int64> LAST_UPDATED_BY
        {
            get
            {
                return _lastUpdatedBy;
            }
            set
            {
                _lastUpdatedBy = value;
            }
        }

        /// <summary>
        /// Gets or sets the date and time when the last update for this record was made.
        /// </summary>
        public Nullable<DateTime> LAST_UPDATE_DATE
        {
            get
            {
                return _lastUpdateDate;
            }
            set
            {
                _lastUpdateDate = value;
            }
        }

        /// <summary>
        /// Gets or sets the value which indicates if this record is active (0) or deleted (1)
        /// </summary>
        public Nullable<bool> DELETED
        {
            get
            {
                return _deleted;
            }
            set
            {
                _deleted = value;
            }
        }

        /// <summary>
        /// Gets or sets the ID of the user who marked this record as deleted
        /// </summary>
        public Nullable<Int64> DELETED_BY
        {
            get
            {
                return _deletedBy;
            }
            set
            {
                _deletedBy = value;
            }
        }

        /// <summary>
        /// Gets or sets the date and time when this record was marked as deleted.
        /// </summary>
        public Nullable<DateTime> DELETED_DATE
        {
            get
            {
                return _deletedDate;
            }
            set
            {
                _deletedDate = value;
            }
        }
        #endregion
    }
}
