

/*
'===============================================================================
'  LayerHelper.CAQ.BL.ToChucManager
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
	public class ToChucBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ToChucBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ToChucBus
		/// </summary>
		/// <returns>An instant of ToChucBus class</returns>
		public static ToChucBus CreateInstant()
		{
			return new ToChucBus();
		}
	}
}
