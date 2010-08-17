
/*
'===============================================================================
'  LayerHelper.CAQ.BL.ChucNangNhomManager
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
	public class ChucNangNhomManager : ChucNangNhomManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ChucNangNhomManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ChucNangNhomManager
		/// </summary>
		/// <returns>An instant of ChucNangNhomManager class</returns>
		public static ChucNangNhomManager CreateInstant()
		{
			return new ChucNangNhomManager();
		}
	}
}
