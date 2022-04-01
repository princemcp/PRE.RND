///////////////////////////////////////////////////////////////////////////////
//      Author      : SM Habib Ullah -- Prince
//      Date        : 2/21/2022 1:38:04 AM     
//      File name   : PRE_OrderInfoDetEntity.cs     
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using PRE.Entities;


namespace PRE.CONSOL.RND
{
	[Serializable]
	[DataContract(Name = "PRE_OrderInfoDetEntity", Namespace = "http://www.meganetict.com/types")]
	public partial class PRE_OrderInfoDetEntity : BaseEntity
	{

		#region public properties

		[DataMember]		
		public long ? orderDetKey { get; set;}		
		[DataMember]		
		public long ? orderKey { get; set;}		
		[DataMember]		
		public long ? tableKey { get; set;}		
		[DataMember]		
		public long ? foodKey { get; set;}		
		[DataMember]		
		public string  description { get; set;}		
		[DataMember]		
		public int ? quantity { get; set;}		
		[DataMember]		
		public decimal ? price { get; set;}		
		[DataMember]		
		public int ? orderStatus { get; set;}		

		#endregion

		#region Master Details Lists


		#endregion

		#region Constructor

		public PRE_OrderInfoDetEntity()
			: base()
		{
		}

		public PRE_OrderInfoDetEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				this.BaseSecurityParam = new SecurityCapsule();
				if (!reader.IsDBNull(reader.GetOrdinal("OrderDetKey"))) orderDetKey = reader.GetInt64(reader.GetOrdinal("OrderDetKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("OrderKey"))) orderKey = reader.GetInt64(reader.GetOrdinal("OrderKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("TableKey"))) tableKey = reader.GetInt64(reader.GetOrdinal("TableKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("FoodKey"))) foodKey = reader.GetInt64(reader.GetOrdinal("FoodKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("Description"))) description = reader.GetString(reader.GetOrdinal("Description"));
				if (!reader.IsDBNull(reader.GetOrdinal("Quantity"))) quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
				if (!reader.IsDBNull(reader.GetOrdinal("Price"))) price = reader.GetDecimal(reader.GetOrdinal("Price"));
				if (!reader.IsDBNull(reader.GetOrdinal("OrderStatus"))) orderStatus = reader.GetInt32(reader.GetOrdinal("OrderStatus"));
				CurrentState = EntityState.Unchanged;
			}
		}

		#endregion

	}
}
