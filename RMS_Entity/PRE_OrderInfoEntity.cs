using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PRE.CONSOL.RND
{
	[Serializable]
	[DataContract(Name = "PRE_OrderInfoEntity", Namespace = "http://www.meganetict.com/types")]
	public partial class PRE_OrderInfoEntity : BaseEntity
	{

		#region public properties

		[DataMember]
		public long? orderKey { get; set; }
		[DataMember]
		public string orderID { get; set; }
		[DataMember]
		public string firstName { get; set; }
		[DataMember]
		public string lastName { get; set; }
		[DataMember]
		public string phoneNo { get; set; }
		[DataMember]
		public string email { get; set; }
		[DataMember]
		public string address { get; set; }
		[DataMember]
		public string city { get; set; }
		[DataMember]
		public string state { get; set; }
		[DataMember]
		public int? noOfGuest { get; set; }
		[DataMember]
		public long? tableKey { get; set; }
		[DataMember]
		public DateTime? orderDate { get; set; }
		[DataMember]
		public decimal? totalPrice { get; set; }
		[DataMember]
		public int? orderStatus { get; set; }

		#endregion

		#region Master Details Lists

		[DataMember]
		public ObservableCollection<PRE_BillInfoDetEntity> PRE_BillInfoDetList { get; set; }

		[DataMember]
		public ObservableCollection<PRE_OrderInfoDetEntity_Ext> PRE_OrderInfoDetList { get; set; }

		#endregion

		#region Constructor

		public PRE_OrderInfoEntity()
			: base()
		{
		}

		public PRE_OrderInfoEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				this.BaseSecurityParam = new SecurityCapsule();
				if (!reader.IsDBNull(reader.GetOrdinal("OrderKey"))) orderKey = reader.GetInt64(reader.GetOrdinal("OrderKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("OrderID"))) orderID = reader.GetString(reader.GetOrdinal("OrderID"));
				if (!reader.IsDBNull(reader.GetOrdinal("FirstName"))) firstName = reader.GetString(reader.GetOrdinal("FirstName"));
				if (!reader.IsDBNull(reader.GetOrdinal("LastName"))) lastName = reader.GetString(reader.GetOrdinal("LastName"));
				if (!reader.IsDBNull(reader.GetOrdinal("PhoneNo"))) phoneNo = reader.GetString(reader.GetOrdinal("PhoneNo"));
				if (!reader.IsDBNull(reader.GetOrdinal("Email"))) email = reader.GetString(reader.GetOrdinal("Email"));
				if (!reader.IsDBNull(reader.GetOrdinal("Address"))) address = reader.GetString(reader.GetOrdinal("Address"));
				if (!reader.IsDBNull(reader.GetOrdinal("City"))) city = reader.GetString(reader.GetOrdinal("City"));
				if (!reader.IsDBNull(reader.GetOrdinal("State"))) state = reader.GetString(reader.GetOrdinal("State"));
				if (!reader.IsDBNull(reader.GetOrdinal("NoOfGuest"))) noOfGuest = reader.GetInt32(reader.GetOrdinal("NoOfGuest"));
				if (!reader.IsDBNull(reader.GetOrdinal("TableKey"))) tableKey = reader.GetInt64(reader.GetOrdinal("TableKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("OrderDate"))) orderDate = reader.GetDateTime(reader.GetOrdinal("OrderDate"));
				if (!reader.IsDBNull(reader.GetOrdinal("TotalPrice"))) totalPrice = reader.GetDecimal(reader.GetOrdinal("TotalPrice"));
				if (!reader.IsDBNull(reader.GetOrdinal("OrderStatus"))) orderStatus = reader.GetInt32(reader.GetOrdinal("OrderStatus"));
				CurrentState = EntityState.Unchanged;
			}
		}

		#endregion

	}
}
