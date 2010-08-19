

/*
'===============================================================================
'  LayerHelper.CAQ.BL.ToDanPhoManager
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
	public class ToDanPhoBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ToDanPhoBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ToDanPhoBus
		/// </summary>
		/// <returns>An instant of ToDanPhoBus class</returns>
		public static ToDanPhoBus CreateInstant()
		{
			return new ToDanPhoBus();
		}
	}
}
