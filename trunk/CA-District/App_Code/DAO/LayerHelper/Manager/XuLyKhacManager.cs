
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

namespace LayerHelper.CAQ.BLL
{
	public class XuLyKhacManager : XuLyKhacManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public XuLyKhacManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of XuLyKhacManager
		/// </summary>
		/// <returns>An instant of XuLyKhacManager class</returns>
		public static XuLyKhacManager CreateInstant()
		{
			return new XuLyKhacManager();
		}
	}
}
