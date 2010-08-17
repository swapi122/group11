
/*
'===============================================================================
'  LayerHelper.CAQ.BL.VuViecXuLyManager
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
	public class VuViecXuLyManager : VuViecXuLyManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VuViecXuLyManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of VuViecXuLyManager
		/// </summary>
		/// <returns>An instant of VuViecXuLyManager class</returns>
		public static VuViecXuLyManager CreateInstant()
		{
			return new VuViecXuLyManager();
		}
	}
}
