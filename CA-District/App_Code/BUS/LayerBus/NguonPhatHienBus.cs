

/*
'===============================================================================
'  LayerHelper.CAQ.BL.NguonPhatHienManager
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
	public class NguonPhatHienBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NguonPhatHienBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of NguonPhatHienBus
		/// </summary>
		/// <returns>An instant of NguonPhatHienBus class</returns>
		public static NguonPhatHienBus CreateInstant()
		{
			return new NguonPhatHienBus();
		}
	}
}
