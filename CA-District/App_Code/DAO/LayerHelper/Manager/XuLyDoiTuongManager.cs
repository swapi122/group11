
/*
'===============================================================================
'  LayerHelper.CAQ.BL.XuLyDoiTuongManager
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
	public class XuLyDoiTuongManager : XuLyDoiTuongManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public XuLyDoiTuongManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of XuLyDoiTuongManager
		/// </summary>
		/// <returns>An instant of XuLyDoiTuongManager class</returns>
		public static XuLyDoiTuongManager CreateInstant()
		{
			return new XuLyDoiTuongManager();
		}
	}
}
