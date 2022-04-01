using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PRE.CONSOL.RND
{
    [Serializable]
    [DataContract(Name = "SecurityCapsule", Namespace = "http://www.meganetict.com/types")]
    public class SecurityCapsule
    {
        [DataMember]
        public DateTime? createdDate { get; set; }

        [DataMember]
        public long? createdBy { get; set; }

        [DataMember]
        public DateTime? updatedDate { get; set; }

        [DataMember]
        public long? updatedBy { get; set; }

        [DataMember]
        public long? tS { get; set; }

        [DataMember]
        public long? formID { get; set; }

        [DataMember]
        public long? userKey { get; set; }

        [DataMember]
        public long? orgKey { get; set; }

        [DataMember]
        public long? roleKey { get; set; }

        [DataMember]
        public long? perentMenuKey { get; set; }

        [DataMember]
        public long? pageKey { get; set; }

        [DataMember]
        protected string macAddress { get; set; }

        [DataMember]
        public string menuName { get; set; }

        [DataMember]
        public string pageName { get; set; }

        [DataMember]
        public string pageActionName { get; set; }

        [DataMember]
        protected string ipAddress { get; set; }

        [DataMember]
        protected string machiName { get; set; }

        [DataMember]
        protected string userName { get; set; }

        [DataMember]
        protected string className { get; set; }

        [DataMember]
        protected string pageURL { get; set; }

        [DataMember]
        protected string hitfrom { get; set; }

        [DataMember]
        public long? tagID { get; set; }

    }
}
