///////////////////////////////////////////////////////////////////////////////
//      Author      : SM Habib Ullah -- Prince
//      Date        : 1/23/2022 1:28:59 AM     
//      File name   : PRE_FoodInfoEntity.cs     
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using PRE.Entities;


namespace PRE.CONSOL.RND
{
	[Serializable]
	[DataContract(Name = "PRE_FoodInfoEntity", Namespace = "http://www.meganetict.com/types")]
	public partial class PRE_FoodInfoEntity : BaseEntity
	{

		#region public properties

		[DataMember]		
		public long ? foodKey { get; set;}		
		[DataMember]		
		public long ? foodCatKey { get; set;}		
		[DataMember]		
		public string  foodName { get; set;}		
		[DataMember]		
		public decimal ? foodPrice { get; set;}		
		[DataMember]		
		public int ? isAvailable { get; set;}		

		#endregion

		#region Master Details Lists

		[DataMember]
		public List<PRE_OrderInfoDetEntity> PRE_OrderInfoDetList { get; set; }

		#endregion

		#region Constructor

		public PRE_FoodInfoEntity()
			: base()
		{
		}

		public PRE_FoodInfoEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				this.BaseSecurityParam = new SecurityCapsule();
				if (!reader.IsDBNull(reader.GetOrdinal("FoodKey"))) foodKey = reader.GetInt64(reader.GetOrdinal("FoodKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("FoodCatKey"))) foodCatKey = reader.GetInt64(reader.GetOrdinal("FoodCatKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("FoodName"))) foodName = reader.GetString(reader.GetOrdinal("FoodName"));
				if (!reader.IsDBNull(reader.GetOrdinal("FoodPrice"))) foodPrice = reader.GetDecimal(reader.GetOrdinal("FoodPrice"));
				if (!reader.IsDBNull(reader.GetOrdinal("IsAvailable"))) isAvailable = reader.GetInt32(reader.GetOrdinal("IsAvailable"));
				CurrentState = EntityState.Unchanged;
			}
		}

		#endregion

	}
}
