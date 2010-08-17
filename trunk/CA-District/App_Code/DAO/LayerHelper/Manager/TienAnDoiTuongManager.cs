
/*
'===============================================================================
'  LayerHelper.CAQ.BL.TienAnDoiTuongManager
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LayerHelper.CAQ.BLL;
using LayerHelper.CAQ.DAL;
using LayerHelper.CAQ.DAL.EntityClasses;
using LayerHelper.CAQ.DAL.FactoryClasses;
using LayerHelper.CAQ.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LayerHelper.CAQ.BLL
{
	public class TienAnDoiTuongManager : TienAnDoiTuongManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TienAnDoiTuongManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TienAnDoiTuongManager
		/// </summary>
		/// <returns>An instant of TienAnDoiTuongManager class</returns>
		public static TienAnDoiTuongManager CreateInstant()
		{
			return new TienAnDoiTuongManager();
		}
	}
}
