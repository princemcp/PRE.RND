///////////////////////////////////////////////////////////////////////////////
//      Author      : SM Habib Ullah -- Prince
//      Date        : 1/23/2022 1:29:17 AM     
//      File name   : PRE_BillInfoEntity.cs     
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using PRE.Entities;


namespace PRE.CONSOL.RND
{
	[Serializable]
	[DataContract(Name = "PRE_BillInfoEntity", Namespace = "http://www.meganetict.com/types")]
	public partial class PRE_BillInfoEntity : BaseEntity
	{

		#region public properties

		[DataMember]		
		public long ? billKey { get; set;}		
		[DataMember]		
		public long ? orderKey { get; set;}		
		[DataMember]		
		public long ? tableKey { get; set;}		
		[DataMember]		
		public long ? convertedTableKey { get; set;}		
		[DataMember]		
		public decimal ? totalBill { get; set;}		
		[DataMember]		
		public decimal ? storeDiscount { get; set;}		
		[DataMember]		
		public decimal ? gratuityAmount { get; set;}		
		[DataMember]		
		public decimal ? grouponAmount { get; set;}		
		[DataMember]		
		public decimal ? adjustAmount { get; set;}		
		[DataMember]		
		public string  adjustReason { get; set;}		
		[DataMember]		
		public decimal ? deliveryCharge { get; set;}		

		#endregion

		#region Master Details Lists

		[DataMember]
		public List<PRE_BillTipsDetEntity> PRE_BillTipsDetList { get; set; }

		#endregion

		#region Constructor

		public PRE_BillInfoEntity()
			: base()
		{
		}

		public PRE_BillInfoEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				this.BaseSecurityParam = new SecurityCapsule();
				if (!reader.IsDBNull(reader.GetOrdinal("BillKey"))) billKey = reader.GetInt64(reader.GetOrdinal("BillKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("OrderKey"))) orderKey = reader.GetInt64(reader.GetOrdinal("OrderKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("TableKey"))) tableKey = reader.GetInt64(reader.GetOrdinal("TableKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("ConvertedTableKey"))) convertedTableKey = reader.GetInt64(reader.GetOrdinal("ConvertedTableKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("TotalBill"))) totalBill = reader.GetDecimal(reader.GetOrdinal("TotalBill"));
				if (!reader.IsDBNull(reader.GetOrdinal("StoreDiscount"))) storeDiscount = reader.GetDecimal(reader.GetOrdinal("StoreDiscount"));
				if (!reader.IsDBNull(reader.GetOrdinal("GratuityAmount"))) gratuityAmount = reader.GetDecimal(reader.GetOrdinal("GratuityAmount"));
				if (!reader.IsDBNull(reader.GetOrdinal("GrouponAmount"))) grouponAmount = reader.GetDecimal(reader.GetOrdinal("GrouponAmount"));
				if (!reader.IsDBNull(reader.GetOrdinal("AdjustAmount"))) adjustAmount = reader.GetDecimal(reader.GetOrdinal("AdjustAmount"));
				if (!reader.IsDBNull(reader.GetOrdinal("AdjustReason"))) adjustReason = reader.GetString(reader.GetOrdinal("AdjustReason"));
				if (!reader.IsDBNull(reader.GetOrdinal("DeliveryCharge"))) deliveryCharge = reader.GetDecimal(reader.GetOrdinal("DeliveryCharge"));
				CurrentState = EntityState.Unchanged;
			}
		}

		#endregion

	}
}
