///////////////////////////////////////////////////////////////////////////////
//      Author      : SM Habib Ullah -- Prince
//      Date        : 1/23/2022 1:28:48 AM     
//      File name   : PRE_TableInfoEntity.cs     
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using PRE.Entities;


namespace PRE.CONSOL.RND
{
	[Serializable]
	[DataContract(Name = "PRE_TableInfoEntity", Namespace = "http://www.meganetict.com/types")]
	public partial class PRE_TableInfoEntity : BaseEntity
	{

		#region public properties

		[DataMember]		
		public long ? tableKey { get; set;}		
		[DataMember]		
		public string  tableName { get; set;}		
		[DataMember]		
		public long ? parentTableKey { get; set;}		
		[DataMember]		
		public int ? status { get; set;}		
		[DataMember]		
		public int ? isIndoor { get; set;}		

		#endregion

		#region Master Details Lists

		[DataMember]
		public List<PRE_BillInfoEntity> PRE_BillInfoList { get; set; }

		[DataMember]
		public List<PRE_BillInfoEntity> PRE_BillInfoList2 { get; set; }

		[DataMember]
		public List<PRE_OrderInfoDetEntity> PRE_OrderInfoDetList { get; set; }

		#endregion

		#region Constructor

		public PRE_TableInfoEntity()
			: base()
		{
		}

		public PRE_TableInfoEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				this.BaseSecurityParam = new SecurityCapsule();
				if (!reader.IsDBNull(reader.GetOrdinal("TableKey"))) tableKey = reader.GetInt64(reader.GetOrdinal("TableKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("TableName"))) tableName = reader.GetString(reader.GetOrdinal("TableName"));
				if (!reader.IsDBNull(reader.GetOrdinal("ParentTableKey"))) parentTableKey = reader.GetInt64(reader.GetOrdinal("ParentTableKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("Status"))) status = reader.GetInt32(reader.GetOrdinal("Status"));
				if (!reader.IsDBNull(reader.GetOrdinal("IsIndoor"))) isIndoor = reader.GetInt32(reader.GetOrdinal("IsIndoor"));
				CurrentState = EntityState.Unchanged;
			}
		}

		#endregion

	}
}
