

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

namespace LayerHelper.CAQ.BUS
{
	public class VuViecXuLyBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VuViecXuLyBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of VuViecXuLyBus
		/// </summary>
		/// <returns>An instant of VuViecXuLyBus class</returns>
		public static VuViecXuLyBus CreateInstant()
		{
			return new VuViecXuLyBus();
		}
	}
}
