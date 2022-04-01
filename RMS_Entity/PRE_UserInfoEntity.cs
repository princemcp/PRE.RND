///////////////////////////////////////////////////////////////////////////////
//      Author      : SM Habib Ullah -- Prince
//      Date        : 1/23/2022 1:28:45 AM     
//      File name   : PRE_UserInfoEntity.cs     
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using PRE.Entities;


namespace PRE.CONSOL.RND
{
	[Serializable]
	[DataContract(Name = "PRE_UserInfoEntity", Namespace = "http://www.meganetict.com/types")]
	public partial class PRE_UserInfoEntity : BaseEntity
	{

		#region public properties

		[DataMember]		
		public long ? userKey { get; set;}		
		[DataMember]		
		public string  userName { get; set;}		
		[DataMember]		
		public string  userPass { get; set;}		
		[DataMember]		
		public string  firstName { get; set;}		
		[DataMember]		
		public string  lastName { get; set;}		
		[DataMember]		
		public string  phoneNo { get; set;}		
		[DataMember]		
		public string  empCode { get; set;}		
		[DataMember]		
		public int ? isTipsInclude { get; set;}		
		[DataMember]		
		public int ? isAdmin { get; set;}		
		[DataMember]		
		public int ? isActive { get; set;}		

		#endregion

		#region Master Details Lists


		#endregion

		#region Constructor

		public PRE_UserInfoEntity()
			: base()
		{
		}

		public PRE_UserInfoEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				this.BaseSecurityParam = new SecurityCapsule();
				if (!reader.IsDBNull(reader.GetOrdinal("UserKey"))) userKey = reader.GetInt64(reader.GetOrdinal("UserKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("UserName"))) userName = reader.GetString(reader.GetOrdinal("UserName"));
				if (!reader.IsDBNull(reader.GetOrdinal("UserPass"))) userPass = reader.GetString(reader.GetOrdinal("UserPass"));
				if (!reader.IsDBNull(reader.GetOrdinal("FirstName"))) firstName = reader.GetString(reader.GetOrdinal("FirstName"));
				if (!reader.IsDBNull(reader.GetOrdinal("LastName"))) lastName = reader.GetString(reader.GetOrdinal("LastName"));
				if (!reader.IsDBNull(reader.GetOrdinal("PhoneNo"))) phoneNo = reader.GetString(reader.GetOrdinal("PhoneNo"));
				if (!reader.IsDBNull(reader.GetOrdinal("EmpCode"))) empCode = reader.GetString(reader.GetOrdinal("EmpCode"));
				if (!reader.IsDBNull(reader.GetOrdinal("IsTipsInclude"))) isTipsInclude = reader.GetInt32(reader.GetOrdinal("IsTipsInclude"));
				if (!reader.IsDBNull(reader.GetOrdinal("IsAdmin"))) isAdmin = reader.GetInt32(reader.GetOrdinal("IsAdmin"));
				if (!reader.IsDBNull(reader.GetOrdinal("IsActive"))) isActive = reader.GetInt32(reader.GetOrdinal("IsActive"));
				CurrentState = EntityState.Unchanged;
			}
		}

		#endregion

	}
}
