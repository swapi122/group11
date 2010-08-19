

/*
'===============================================================================
'  LayerHelper.CAQ.BL.XuLyKhacManager
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
	public class XuLyKhacBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public XuLyKhacBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of XuLyKhacBus
		/// </summary>
		/// <returns>An instant of XuLyKhacBus class</returns>
		public static XuLyKhacBus CreateInstant()
		{
			return new XuLyKhacBus();
		}
	}
}
