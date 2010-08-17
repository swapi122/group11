
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

namespace LayerHelper.CAQ.BLL
{
	public class ToChucManager : ToChucManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ToChucManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ToChucManager
		/// </summary>
		/// <returns>An instant of ToChucManager class</returns>
		public static ToChucManager CreateInstant()
		{
			return new ToChucManager();
		}
	}
}
