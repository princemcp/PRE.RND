using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PRE.CONSOL.RND
{
    [Serializable]
    [DataContract(Name = "BaseEntity", Namespace = "http://www.meganetict.com/types")]
    public class BaseEntity
    {
        protected SecurityCapsule _BaseSecurityParam;

        [DataMember]
        public SecurityCapsule BaseSecurityParam
        {
            get { return _BaseSecurityParam; }
            set { _BaseSecurityParam = value; }
        }


        public enum EntityState
        {
            /// <summary>
            /// Entity is unchanged
            /// </summary>
            //[EnumMember]
            Unchanged = 0,

            /// <summary>
            /// Entity is new
            /// </summary>
            //[EnumMember]
            Added = 1,

            /// <summary>
            /// Entity has been modified
            /// </summary>
            //[EnumMember]
            Changed = 2,

            /// <summary>
            /// Entity has been deleted
            /// </summary>
            //[EnumMember]
            Deleted = 3
        }

        private EntityState currentEntityState = EntityState.Unchanged;

        [DataMember]
        public EntityState CurrentState
        {
            get { return currentEntityState; }
            set { currentEntityState = value; }
        }

        [DataMember]
        public string SortExpression { get; set; }

        [DataMember]
        public long TotalRecord { get; set; }

        [DataMember]
        public int PageSize { get; set; }

        [DataMember]
        public int CurrentPage { get; set; }

        [DataMember]
        public long RowNumber { get; set; }

        [DataMember]
        public long ReturnKey { get; set; }




    }
}
