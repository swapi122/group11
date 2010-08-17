
/*
'===============================================================================
'  LayerHelper.CAQ.BL.VaiTroTrongVuAnManager
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
	public class VaiTroTrongVuAnManager : VaiTroTrongVuAnManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VaiTroTrongVuAnManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of VaiTroTrongVuAnManager
		/// </summary>
		/// <returns>An instant of VaiTroTrongVuAnManager class</returns>
		public static VaiTroTrongVuAnManager CreateInstant()
		{
			return new VaiTroTrongVuAnManager();
		}
	}
}
