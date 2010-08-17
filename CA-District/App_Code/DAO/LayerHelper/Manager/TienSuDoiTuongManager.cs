
/*
'===============================================================================
'  LayerHelper.CAQ.BL.TienSuDoiTuongManager
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
	public class TienSuDoiTuongManager : TienSuDoiTuongManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TienSuDoiTuongManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TienSuDoiTuongManager
		/// </summary>
		/// <returns>An instant of TienSuDoiTuongManager class</returns>
		public static TienSuDoiTuongManager CreateInstant()
		{
			return new TienSuDoiTuongManager();
		}
	}
}
