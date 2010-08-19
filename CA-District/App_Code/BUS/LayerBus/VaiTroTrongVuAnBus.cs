

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

namespace LayerHelper.CAQ.BUS
{
	public class VaiTroTrongVuAnBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VaiTroTrongVuAnBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of VaiTroTrongVuAnBus
		/// </summary>
		/// <returns>An instant of VaiTroTrongVuAnBus class</returns>
		public static VaiTroTrongVuAnBus CreateInstant()
		{
			return new VaiTroTrongVuAnBus();
		}
	}
}
