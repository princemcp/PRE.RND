///////////////////////////////////////////////////////////////////////////////
//      Author      : SM Habib Ullah -- Prince
//      Date        : 1/23/2022 1:29:14 AM     
//      File name   : PRE_BillInfoDetEntity.cs     
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using PRE.Entities;


namespace PRE.CONSOL.RND
{
	[Serializable]
	[DataContract(Name = "PRE_BillInfoDetEntity", Namespace = "http://www.meganetict.com/types")]
	public partial class PRE_BillInfoDetEntity : BaseEntity
	{

		#region public properties

		[DataMember]		
		public long ? billDetKey { get; set;}		
		[DataMember]		
		public long ? orderKey { get; set;}		
		[DataMember]		
		public string  billNo { get; set;}		
		[DataMember]		
		public long ? foodKey { get; set;}		
		[DataMember]		
		public int ? quantity { get; set;}		
		[DataMember]		
		public decimal ? price { get; set;}		

		#endregion

		#region Master Details Lists

		[DataMember]
		public List<PRE_BillTipsDetEntity> PRE_BillTipsDetList { get; set; }

		#endregion

		#region Constructor

		public PRE_BillInfoDetEntity()
			: base()
		{
		}

		public PRE_BillInfoDetEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				this.BaseSecurityParam = new SecurityCapsule();
				if (!reader.IsDBNull(reader.GetOrdinal("BillDetKey"))) billDetKey = reader.GetInt64(reader.GetOrdinal("BillDetKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("OrderKey"))) orderKey = reader.GetInt64(reader.GetOrdinal("OrderKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("BillNo"))) billNo = reader.GetString(reader.GetOrdinal("BillNo"));
				if (!reader.IsDBNull(reader.GetOrdinal("FoodKey"))) foodKey = reader.GetInt64(reader.GetOrdinal("FoodKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("Quantity"))) quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
				if (!reader.IsDBNull(reader.GetOrdinal("Price"))) price = reader.GetDecimal(reader.GetOrdinal("Price"));
				CurrentState = EntityState.Unchanged;
			}
		}

		#endregion

	}
}
