

/*
'===============================================================================
'  LayerHelper.CAQ.BL.SoDoToChucManager
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
	public class SoDoToChucBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SoDoToChucBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of SoDoToChucBus
		/// </summary>
		/// <returns>An instant of SoDoToChucBus class</returns>
		public static SoDoToChucBus CreateInstant()
		{
			return new SoDoToChucBus();
		}
	}
}
