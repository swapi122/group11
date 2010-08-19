

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

namespace LayerHelper.CAQ.BUS
{
	public class XuLyDoiTuongBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public XuLyDoiTuongBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of XuLyDoiTuongBus
		/// </summary>
		/// <returns>An instant of XuLyDoiTuongBus class</returns>
		public static XuLyDoiTuongBus CreateInstant()
		{
			return new XuLyDoiTuongBus();
		}
	}
}
