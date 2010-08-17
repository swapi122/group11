
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

namespace LayerHelper.CAQ.BLL
{
	public class ToDanPhoManager : ToDanPhoManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ToDanPhoManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ToDanPhoManager
		/// </summary>
		/// <returns>An instant of ToDanPhoManager class</returns>
		public static ToDanPhoManager CreateInstant()
		{
			return new ToDanPhoManager();
		}
	}
}
