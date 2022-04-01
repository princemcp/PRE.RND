///////////////////////////////////////////////////////////////////////////////
//      Author      : SM Habib Ullah -- Prince
//      Date        : 1/23/2022 1:28:59 AM     
//      File name   : PRE_FoodInfoEntity_Ext.cs     
///////////////////////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Data;
using PRE.Entities;
using System.Runtime.Serialization;


namespace PRE.CONSOL.RND
{
	public partial class PRE_FoodInfoEntity_Ext : PRE_FoodInfoEntity
	{

		#region public properties

		/// <summary>
		/// WRITE EXTRA ATTRIBUTE HERE
		/// </summary>
		//Example:
		//public int? myproperty { get; set; }
		[DataMember]
		public string categoryName { get; set; }

		#endregion

		#region Constructor

		public PRE_FoodInfoEntity_Ext()
			: base()
		{
		}

		public PRE_FoodInfoEntity_Ext(IDataReader reader)
		{
			base.LoadFromReader(reader);
			this.LoadFromReader_Ext(reader);
		}

		protected void LoadFromReader_Ext(IDataReader reader)
		{
			/// <summary>
			/// WRITE EXTRA ATTRIBUTE HERE
			/// </summary>
			//Example:
			//if (!reader.IsDBNull(reader.GetOrdinal("myproperty"))) properties = reader.GetInt64(reader.GetOrdinal("myproperty"));
		}

		#endregion

	}
}
