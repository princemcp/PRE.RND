///////////////////////////////////////////////////////////////////////////////
//      Author      : SM Habib Ullah -- Prince
//      Date        : 1/23/2022 1:29:06 AM     
//      File name   : PRE_CatInfoEntity.cs     
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using PRE.Entities;


namespace PRE.CONSOL.RND
{
	[Serializable]
	[DataContract(Name = "PRE_CatInfoEntity", Namespace = "http://www.meganetict.com/types")]
	public partial class PRE_CatInfoEntity : BaseEntity
	{

		#region public properties

		[DataMember]		
		public long ? userCatKey { get; set;}		
		[DataMember]		
		public string  catagoryName { get; set;}		

		#endregion

		#region Master Details Lists


		#endregion

		#region Constructor

		public PRE_CatInfoEntity()
			: base()
		{
		}

		public PRE_CatInfoEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				this.BaseSecurityParam = new SecurityCapsule();
				if (!reader.IsDBNull(reader.GetOrdinal("UserCatKey"))) userCatKey = reader.GetInt64(reader.GetOrdinal("UserCatKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("CatagoryName"))) catagoryName = reader.GetString(reader.GetOrdinal("CatagoryName"));
				CurrentState = EntityState.Unchanged;
			}
		}

		#endregion

	}
}
