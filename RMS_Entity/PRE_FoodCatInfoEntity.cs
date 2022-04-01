///////////////////////////////////////////////////////////////////////////////
//      Author      : SM Habib Ullah -- Prince
//      Date        : 1/23/2022 1:29:03 AM     
//      File name   : PRE_FoodCatInfoEntity.cs     
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using PRE.Entities;


namespace PRE.CONSOL.RND
{
	[Serializable]
	[DataContract(Name = "PRE_FoodCatInfoEntity", Namespace = "http://www.meganetict.com/types")]
	public partial class PRE_FoodCatInfoEntity : BaseEntity
	{

		#region public properties

		[DataMember]		
		public long ? foodCatKey { get; set;}		
		[DataMember]		
		public string  categoryName { get; set;}		
		[DataMember]		
		public int ? isAvailable { get; set;}		
		[DataMember]		
		public string  lableColor { get; set;}		

		#endregion

		#region Master Details Lists

		[DataMember]
		public List<PRE_FoodInfoEntity> PRE_FoodInfoList { get; set; }

		#endregion

		#region Constructor

		public PRE_FoodCatInfoEntity()
			: base()
		{
		}

		public PRE_FoodCatInfoEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				this.BaseSecurityParam = new SecurityCapsule();
				if (!reader.IsDBNull(reader.GetOrdinal("FoodCatKey"))) foodCatKey = reader.GetInt64(reader.GetOrdinal("FoodCatKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("CategoryName"))) categoryName = reader.GetString(reader.GetOrdinal("CategoryName"));
				if (!reader.IsDBNull(reader.GetOrdinal("IsAvailable"))) isAvailable = reader.GetInt32(reader.GetOrdinal("IsAvailable"));
				if (!reader.IsDBNull(reader.GetOrdinal("LableColor"))) lableColor = reader.GetString(reader.GetOrdinal("LableColor"));
				CurrentState = EntityState.Unchanged;
			}
		}

		#endregion

	}
}
