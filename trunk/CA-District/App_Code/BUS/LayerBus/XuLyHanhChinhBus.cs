

/*
'===============================================================================
'  LayerHelper.CAQ.BL.XuLyHanhChinhManager
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
	public class XuLyHanhChinhBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public XuLyHanhChinhBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of XuLyHanhChinhBus
		/// </summary>
		/// <returns>An instant of XuLyHanhChinhBus class</returns>
		public static XuLyHanhChinhBus CreateInstant()
		{
			return new XuLyHanhChinhBus();
		}
	}
}
