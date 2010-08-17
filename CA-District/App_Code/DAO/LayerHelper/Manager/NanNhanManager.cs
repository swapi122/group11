
/*
'===============================================================================
'  LayerHelper.CAQ.BL.NanNhanManager
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
	public class NanNhanManager : NanNhanManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NanNhanManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of NanNhanManager
		/// </summary>
		/// <returns>An instant of NanNhanManager class</returns>
		public static NanNhanManager CreateInstant()
		{
			return new NanNhanManager();
		}
	}
}
