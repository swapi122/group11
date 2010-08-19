

/*
'===============================================================================
'  LayerHelper.CAQ.BL.XaManager
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
	public class XaBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public XaBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of XaBus
		/// </summary>
		/// <returns>An instant of XaBus class</returns>
		public static XaBus CreateInstant()
		{
			return new XaBus();
		}
	}
}
