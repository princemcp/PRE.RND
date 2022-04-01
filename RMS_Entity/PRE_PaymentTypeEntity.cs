///////////////////////////////////////////////////////////////////////////////
//      Author      : SM Habib Ullah -- Prince
//      Date        : 1/23/2022 1:28:51 AM     
//      File name   : PRE_PaymentTypeEntity.cs     
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using PRE.Entities;


namespace PRE.CONSOL.RND
{
	[Serializable]
	[DataContract(Name = "PRE_PaymentTypeEntity", Namespace = "http://www.meganetict.com/types")]
	public partial class PRE_PaymentTypeEntity : BaseEntity
	{

		#region public properties

		[DataMember]		
		public long ? paymentKey { get; set;}		
		[DataMember]		
		public string  paymentName { get; set;}		

		#endregion

		#region Master Details Lists

		[DataMember]
		public List<PRE_BillTipsDetEntity> PRE_BillTipsDetList { get; set; }

		[DataMember]
		public List<PRE_BillTipsDetEntity> PRE_BillTipsDetList2 { get; set; }

        #endregion

        #region Constructor

        public PRE_PaymentTypeEntity()
			: base()
		{
		}

		public PRE_PaymentTypeEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				this.BaseSecurityParam = new SecurityCapsule();
				if (!reader.IsDBNull(reader.GetOrdinal("PaymentKey"))) paymentKey = reader.GetInt64(reader.GetOrdinal("PaymentKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("PaymentName"))) paymentName = reader.GetString(reader.GetOrdinal("PaymentName"));
				CurrentState = EntityState.Unchanged;
			}
		}

		#endregion

	}
}
