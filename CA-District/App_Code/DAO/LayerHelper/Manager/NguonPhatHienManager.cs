
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

namespace LayerHelper.CAQ.BLL
{
	public class NguonPhatHienManager : NguonPhatHienManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NguonPhatHienManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of NguonPhatHienManager
		/// </summary>
		/// <returns>An instant of NguonPhatHienManager class</returns>
		public static NguonPhatHienManager CreateInstant()
		{
			return new NguonPhatHienManager();
		}
	}
}
