




/*
'===============================================================================
'  LayerHelper.CAQ.BL.TablesCollectionManagerBase
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
	public class TablesCollectionManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TablesCollectionManagerBase()
		{
			// Nothing for now.
		}
		
		public TablesCollectionEntity Insert(TablesCollectionEntity _TablesCollectionEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_TablesCollectionEntity, true);
			}
			return _TablesCollectionEntity;
		}

		
		public TablesCollectionEntity Insert(Guid Id, string TableName, string TableTitle, bool Fk, bool IsMultiLevel)
		{
			TablesCollectionEntity _TablesCollectionEntity = new TablesCollectionEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TablesCollectionEntity.Id = Id;
				_TablesCollectionEntity.TableName = TableName;
				_TablesCollectionEntity.TableTitle = TableTitle;
				_TablesCollectionEntity.Fk = Fk;
				_TablesCollectionEntity.IsMultiLevel = IsMultiLevel;
				adapter.SaveEntity(_TablesCollectionEntity, true);
			}
			return _TablesCollectionEntity;
		}

		public TablesCollectionEntity Insert(string TableName, string TableTitle, bool Fk, bool IsMultiLevel)
		{
			TablesCollectionEntity _TablesCollectionEntity = new TablesCollectionEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TablesCollectionEntity.TableName = TableName;
				_TablesCollectionEntity.TableTitle = TableTitle;
				_TablesCollectionEntity.Fk = Fk;
				_TablesCollectionEntity.IsMultiLevel = IsMultiLevel;
				adapter.SaveEntity(_TablesCollectionEntity, true);
			}
			return _TablesCollectionEntity;
		}

		public bool Update(TablesCollectionEntity _TablesCollectionEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(TablesCollectionFields.Id == _TablesCollectionEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_TablesCollectionEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(TablesCollectionEntity _TablesCollectionEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_TablesCollectionEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TableName, string TableTitle, bool Fk, bool IsMultiLevel)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TablesCollectionEntity _TablesCollectionEntity = new TablesCollectionEntity(Id);
				if (adapter.FetchEntity(_TablesCollectionEntity))
				{
				
					_TablesCollectionEntity.TableName = TableName;
					_TablesCollectionEntity.TableTitle = TableTitle;
					_TablesCollectionEntity.Fk = Fk;
					_TablesCollectionEntity.IsMultiLevel = IsMultiLevel;
					adapter.SaveEntity(_TablesCollectionEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(Guid Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TablesCollectionEntity _TablesCollectionEntity = new TablesCollectionEntity(Id);
				if (adapter.FetchEntity(_TablesCollectionEntity))
				{
					adapter.DeleteEntity(_TablesCollectionEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("TablesCollectionEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TablesCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTableName(string TableName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.TableName == TableName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TablesCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTableTitle(string TableTitle)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.TableTitle == TableTitle);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TablesCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByFk(bool Fk)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.Fk == Fk);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TablesCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsMultiLevel(bool IsMultiLevel)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.IsMultiLevel == IsMultiLevel);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TablesCollectionEntity", filter);
			}
			return toReturn;
		}
		

		
		public TablesCollectionEntity SelectOne(Guid Id)
		{
			TablesCollectionEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TablesCollectionEntity _TablesCollectionEntity = new TablesCollectionEntity(Id);
				if (adapter.FetchEntity(_TablesCollectionEntity))
				{
					toReturn = _TablesCollectionEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TablesCollectionCollection = new EntityCollection(new TablesCollectionEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TablesCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<TablesCollectionEntity>
		public EntityCollection<TablesCollectionEntity> SelectAllLST()
		{
			EntityCollection<TablesCollectionEntity> _TablesCollectionCollection = new EntityCollection<TablesCollectionEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TablesCollectionCollection, null, 0, null);
			}
			return _TablesCollectionCollection;
		}
		
		// Return EntityCollection<TablesCollectionEntity>
		public EntityCollection<TablesCollectionEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<TablesCollectionEntity> _TablesCollectionCollection = new EntityCollection<TablesCollectionEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TablesCollectionCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _TablesCollectionCollection;
		}


		
		// Return EntityCollection<TablesCollectionEntity>
		public EntityCollection<TablesCollectionEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<TablesCollectionEntity> _TablesCollectionCollection = new EntityCollection<TablesCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TablesCollectionCollection, filter, 0, null);
			}
			return _TablesCollectionCollection;
		}
		
		// Return EntityCollection<TablesCollectionEntity>
		public EntityCollection<TablesCollectionEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<TablesCollectionEntity> _TablesCollectionCollection = new EntityCollection<TablesCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TablesCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TablesCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TablesCollectionCollection = new EntityCollection(new TablesCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TablesCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TablesCollectionCollection = new EntityCollection(new TablesCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TablesCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TablesCollectionEntity>
		public EntityCollection<TablesCollectionEntity> SelectByTableNameLST(string TableName)
		{
			EntityCollection<TablesCollectionEntity> _TablesCollectionCollection = new EntityCollection<TablesCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.TableName == TableName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TablesCollectionCollection, filter, 0, null);
			}
			return _TablesCollectionCollection;
		}
		
		// Return EntityCollection<TablesCollectionEntity>
		public EntityCollection<TablesCollectionEntity> SelectByTableNameLST_Paged(string TableName, int PageNumber, int PageSize)
		{
			EntityCollection<TablesCollectionEntity> _TablesCollectionCollection = new EntityCollection<TablesCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.TableName == TableName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TablesCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TablesCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTableNameRDT(string TableName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TablesCollectionCollection = new EntityCollection(new TablesCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.TableName == TableName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TablesCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTableNameRDT_Paged(string TableName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TablesCollectionCollection = new EntityCollection(new TablesCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.TableName == TableName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TablesCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TablesCollectionEntity>
		public EntityCollection<TablesCollectionEntity> SelectByTableTitleLST(string TableTitle)
		{
			EntityCollection<TablesCollectionEntity> _TablesCollectionCollection = new EntityCollection<TablesCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.TableTitle == TableTitle);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TablesCollectionCollection, filter, 0, null);
			}
			return _TablesCollectionCollection;
		}
		
		// Return EntityCollection<TablesCollectionEntity>
		public EntityCollection<TablesCollectionEntity> SelectByTableTitleLST_Paged(string TableTitle, int PageNumber, int PageSize)
		{
			EntityCollection<TablesCollectionEntity> _TablesCollectionCollection = new EntityCollection<TablesCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.TableTitle == TableTitle);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TablesCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TablesCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTableTitleRDT(string TableTitle)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TablesCollectionCollection = new EntityCollection(new TablesCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.TableTitle == TableTitle);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TablesCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTableTitleRDT_Paged(string TableTitle, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TablesCollectionCollection = new EntityCollection(new TablesCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.TableTitle == TableTitle);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TablesCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TablesCollectionEntity>
		public EntityCollection<TablesCollectionEntity> SelectByFkLST(bool Fk)
		{
			EntityCollection<TablesCollectionEntity> _TablesCollectionCollection = new EntityCollection<TablesCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.Fk == Fk);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TablesCollectionCollection, filter, 0, null);
			}
			return _TablesCollectionCollection;
		}
		
		// Return EntityCollection<TablesCollectionEntity>
		public EntityCollection<TablesCollectionEntity> SelectByFkLST_Paged(bool Fk, int PageNumber, int PageSize)
		{
			EntityCollection<TablesCollectionEntity> _TablesCollectionCollection = new EntityCollection<TablesCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.Fk == Fk);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TablesCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TablesCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByFkRDT(bool Fk)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TablesCollectionCollection = new EntityCollection(new TablesCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.Fk == Fk);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TablesCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByFkRDT_Paged(bool Fk, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TablesCollectionCollection = new EntityCollection(new TablesCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.Fk == Fk);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TablesCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TablesCollectionEntity>
		public EntityCollection<TablesCollectionEntity> SelectByIsMultiLevelLST(bool IsMultiLevel)
		{
			EntityCollection<TablesCollectionEntity> _TablesCollectionCollection = new EntityCollection<TablesCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.IsMultiLevel == IsMultiLevel);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TablesCollectionCollection, filter, 0, null);
			}
			return _TablesCollectionCollection;
		}
		
		// Return EntityCollection<TablesCollectionEntity>
		public EntityCollection<TablesCollectionEntity> SelectByIsMultiLevelLST_Paged(bool IsMultiLevel, int PageNumber, int PageSize)
		{
			EntityCollection<TablesCollectionEntity> _TablesCollectionCollection = new EntityCollection<TablesCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.IsMultiLevel == IsMultiLevel);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TablesCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TablesCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsMultiLevelRDT(bool IsMultiLevel)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TablesCollectionCollection = new EntityCollection(new TablesCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.IsMultiLevel == IsMultiLevel);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TablesCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsMultiLevelRDT_Paged(bool IsMultiLevel, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TablesCollectionCollection = new EntityCollection(new TablesCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TablesCollectionFields.IsMultiLevel == IsMultiLevel);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TablesCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
