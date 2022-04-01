///////////////////////////////////////////////////////////////////////////////
//      Author      : SM Habib Ullah -- Prince
//      Date        : 1/23/2022 1:29:09 AM     
//      File name   : PRE_BillTipsDetEntity.cs     
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using PRE.Entities;


namespace PRE.CONSOL.RND
{
	[Serializable]
	[DataContract(Name = "PRE_BillTipsDetEntity", Namespace = "http://www.meganetict.com/types")]
	public partial class PRE_BillTipsDetEntity : BaseEntity
	{

		#region public properties

		[DataMember]		
		public long ? tipsKey { get; set;}		
		[DataMember]		
		public long ? billKey { get; set;}		
		[DataMember]		
		public decimal ? tipsAmount1 { get; set;}		
		[DataMember]		
		public long ? paymentKey1 { get; set;}		
		[DataMember]		
		public decimal ? tipsAmount2 { get; set;}		
		[DataMember]		
		public long ? paymentKey2 { get; set;}		

		#endregion

		#region Master Details Lists


		#endregion

		#region Constructor

		public PRE_BillTipsDetEntity()
			: base()
		{
		}

		public PRE_BillTipsDetEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				this.BaseSecurityParam = new SecurityCapsule();
				if (!reader.IsDBNull(reader.GetOrdinal("TipsKey"))) tipsKey = reader.GetInt64(reader.GetOrdinal("TipsKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("BillKey"))) billKey = reader.GetInt64(reader.GetOrdinal("BillKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("TipsAmount1"))) tipsAmount1 = reader.GetDecimal(reader.GetOrdinal("TipsAmount1"));
				if (!reader.IsDBNull(reader.GetOrdinal("PaymentKey1"))) paymentKey1 = reader.GetInt64(reader.GetOrdinal("PaymentKey1"));
				if (!reader.IsDBNull(reader.GetOrdinal("TipsAmount2"))) tipsAmount2 = reader.GetDecimal(reader.GetOrdinal("TipsAmount2"));
				if (!reader.IsDBNull(reader.GetOrdinal("PaymentKey2"))) paymentKey2 = reader.GetInt64(reader.GetOrdinal("PaymentKey2"));
				CurrentState = EntityState.Unchanged;
			}
		}

		#endregion

	}
}
